using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Destinos
{
    public sealed class Destinos:AggregateRoot
    {
        public Destinos(DestinoId id, string nombre, string descripcion, string ubicacion, bool activo)
        {
            Id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.ubicacion = ubicacion;
            this.activo = activo;
        }

        private Destinos()
        {

        }

        public DestinoId Id { get; private set; }
        public string nombre { get; private set; } = string.Empty;
        public string descripcion { get; private set; } = string.Empty;
        public string ubicacion { get; private set; } = string.Empty;
        public bool activo { get; private set; } = true;

        public Domain.Paquetes.Paquetes paquete{ get; private set; }
    }
}
