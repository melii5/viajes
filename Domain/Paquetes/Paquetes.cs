using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Paquetes
{
    public sealed class Paquetes:AggregateRoot
    {
        public PaqueteId Id { get; private set; }
        public string nombre { get; private set; } = string.Empty;

        public string descripcion { get; private set; } = string.Empty;

        public DateTime fecha { get; private set; } = DateTime.Now;
        public decimal precio { get; private set; } = decimal.Zero;
        public bool activo { get; private set; } = true;

        public ICollection<Domain.Destinos.Destinos> Destinos { get; private set; } 


    }
}
