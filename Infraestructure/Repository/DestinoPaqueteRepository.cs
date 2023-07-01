using Domain.PaqueteDestinos;
using Domain.Paquetes;
using Infraestructure.Persistence;

namespace Infraestructure.Repository
{
    public class InfraestructureRepository : IPaqueteDestinoRepository
    {
        private readonly ApplicationDbContext _context;

        public InfraestructureRepository(ApplicationDbContext context){
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }
        
         public async Task<List<PaqueteDestinos>> listAsync(){
            throw new NotImplementedException();
         }

        public async Task<List<PaqueteDestinos>> listByDestinoAsync(int destinoId){
            throw new NotImplementedException();
        }
        public async Task<List<PaqueteDestinos>> listByPaqueteAsync(int paqueteId){
            throw new NotImplementedException();
        }
        //Task<PaqueteDestino?> GetByIdAsync(DestinoId id);
        

        public async Task Add(PaqueteDestinos entity){
            throw new NotImplementedException();
        }

        public async Task Update(PaqueteDestinos entity){
            throw new NotImplementedException();
        }
        public async Task Delete(int id){
            throw new NotImplementedException();
        }
      
    }
}