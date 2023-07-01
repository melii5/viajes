using Domain.Destinos;
using Domain.Paquetes;
using Domain.PaqueteDestinos;
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
        DbSet<Destino> Destinos { get; set; }
        DbSet<Paquete> Paquetes { get; set; }
        //DbSet<PaqueteDestinos> PaqueteDestinos { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken=default);
    }
}
