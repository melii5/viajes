using Domain.Destinos;
using Domain.Paquetes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Domain.Destinos.Destinos> Destinos { get; set; }
        DbSet<Paquetes> Paquetes { get; set; }
        DbSet<PaqueteDestinos> PaqueteDestinos { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken=default);
    }
}
