﻿using Domain.Destinos;
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
        DbSet<Destinos> Destinos { get; set; }
        DbSet<Paquetes> Paquetes { get; set; }

        Task<int> SaveChangeAsync(CancellationToken cancellationToken=default);
    }
}