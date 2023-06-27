using Domain.PaqueteDestinos;

namespace Infraestructure.Repository
{
    public class InfraestructureRepository : IPaqueteDestinoRepository
    {
        private readonly ApplicationDbContext _context;

        public InfraestructureRepository(ApplicationDbContext context){
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }
        
        
    }
}