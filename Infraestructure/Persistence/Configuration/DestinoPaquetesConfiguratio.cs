using Domain.PaqueteDestinos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Persistence.Configuration
{
    public class DestinoPaquetesConfiguration : IEntityTypeConfiguration<PaqueteDestino>
    {
        public void Configure(EntityTypeBuilder<Paquetes> builder)
        {
            builder.ToTable("paquete_destino");
            builder.HasKey(c=>c.Id);
            
            builder.Property(c => c.Id).HasConversion(c => c.value,
                value => new PaqueteDestinosId(value));
            
            builder.entity<PaqueteDestinos>()
            .HasKey(c => new {c.paqueteId,c.destinoId});
            builder.Property(c => c.activo);
            
            builder.entity<PaqueteDestinos>()
            .HasOne(pd=>pd.paquete)
            .WithMany(pd=>pd.PaqueteDestinos)
            .HasForeignKey(pd=>pd.paqueteId);

            builder.entity<PaqueteDestinos>()
            .HasOne(pd=>pd.destino)
            .WithMany(pd=>pd.PaqueteDestinos)
            .HasForeignKey(pd=>pd.destinoId);

            builder.Property(c => c.activo).IsRequired(true);


        }
    }
}
