using Domain.Destinos;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class DestinoRepository : IDestinoRepository
    {
        private readonly ApplicationDbContext _context;

        public DestinoRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task Add(Destinos entity) => await _context.Destinos.AddAsync(entity);


        public async Task Delete(Destinos id) => _context.Destinos.Update(id);
        


        public async Task<Destinos?> GetByIdAsync(DestinoId id) => await _context.Destinos.SingleOrDefaultAsync(c => c.Id == id);

        public async Task<List<Destinos>> listAsync() => await _context.Destinos.Where(e=> e.activo == true).ToListAsync();
        

        public async Task Update(Destinos entity) => _context.Destinos.Update(entity);
     

    }
}
