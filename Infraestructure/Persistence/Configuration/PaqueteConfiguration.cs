using Domain.Paquetes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Persistence.Configuration
{
    public class PaqueteConfiguration : IEntityTypeConfiguration<Paquetes>
    {
        public void Configure(EntityTypeBuilder<Paquetes> builder)
        {
            builder.ToTable("paquete");
            builder.HasKey(c=>c.Id);
            builder.Property(c => c.Id).HasConversion(paqueteId => paqueteId.value,
                value => new PaqueteId(value));
            builder.Property(c => c.nombre).HasMaxLength(150);
            builder.Property(c => c.descripcion).HasMaxLength(255);
            builder.Property(c => c.fecha).IsRequired(true);
            builder.Property(c => c.precio);
            builder.Property(c => c.activo);

        }
    }
}
