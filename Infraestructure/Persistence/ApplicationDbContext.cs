using Domain.Primitives;
using Application.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Destinos;
using Domain.Paquetes;

using MediatR;

namespace Infraestructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext, IUnitOfWork
    {
        private readonly IPublisher _publisher;

        public ApplicationDbContext(DbContextOptions options, IPublisher publisher) : base (options)
        {
        _publisher = publisher ?? throw new ArgumentNullException(nameof(publisher));
        }

       
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Paquete> Paquetes { get; set; }

    
        //public DbSet<PaqueteDestinos> PaqueteDestinos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
        //Task<int> SaveChangesAsync(CancellationToken cancellationToken=default){}
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var domaintEvents = ChangeTracker.Entries<AggregateRoot>()
                .Select(e => e.Entity)
                .Where(e => e.GetDomainEvents().Any())
                .SelectMany(e => e.GetDomainEvents());

            var result = await base.SaveChangesAsync(cancellationToken);
            foreach(var domaintEvent in domaintEvents)
            {
                await _publisher.Publish(domaintEvent,cancellationToken);
            }

            return result;
        }
    }
}
