using Domain.Primitives;
using Domain.Destinos;
using Domain.Paquetes;

namespace Domain.PaqueteDestinos
{
    public sealed class PaqueteDestinos : AggregateRoot
    {
        public PaqueteDestinos(PaqueteDestinosId id,int destinoId,int paqueteId,Destino destinos,Paquete paquetes,bool activo){
            this.Id = id;
            this.destinoId = destinoId;
            this.paqueteId = paqueteId;
            this.paquete = paquetes;
            this.destino = destinos;
            this.activo = activo;
        }

        public PaqueteDestinosId Id {get;private set;}
        public int paqueteId {get;private set;}
        public Paquete paquete {get;private set;}
        public int destinoId {get;private set;}
        public Destino destino {get;private set;}

        public bool activo {get; private set;} = true;
    }
}