using Domain.Destinos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Persistence.Configuration
{
    public class DestinoConfiguration : IEntityTypeConfiguration<Destinos>
    {
        public void Configure(EntityTypeBuilder<Destinos> builder)
        {
            builder.ToTable("destino");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasConversion( destinoId=>destinoId.value,
                value=> new DestinoId(value));
            builder.Property(c => c.nombre).HasMaxLength(255);
            builder.Property(c => c.descripcion).HasMaxLength(255); 
            builder.Property(c=> c.ubicacion).HasMaxLength(255);
            builder.Property(c => c.activo).IsRequired(true);
        }
    }
}
