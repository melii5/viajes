using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Destinos
{
    public sealed class Destino:AggregateRoot
    {
        public Destino(DestinoId id, string nombre, string descripcion, string ubicacion, bool activo)
        {
            Id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.ubicacion = ubicacion;
            this.activo = activo;
        }

        private Destino()
        {

        }

        public DestinoId Id { get; private set; }
        public string nombre { get; private set; } = string.Empty;
        public string descripcion { get; private set; } = string.Empty;
        public string ubicacion { get; private set; } = string.Empty;
        public bool activo { get; private set; } = true;

        public Domain.Paquetes.Paquete paquete{ get; private set; }
    }
}
