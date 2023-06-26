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

        public ApplicationDbContext(IPublisher publisher, DbSet<Destinos> destinos, DbSet<Paquetes> paquetes)
        {
            _publisher = publisher;
            Destinos = destinos;
            Paquetes = paquetes;
        }

       
        public DbSet<Destinos> Destinos { get; set; }
        public DbSet<Paquetes> Paquetes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

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
