using Domain.Paquetes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Destinos
{
    public interface IDestinoRepository
    {
        Task<List<Destinos>> listAsync();
        Task<Destinos?> GetByIdAsync(DestinoId id);
        Task Add(Destinos entity);

        Task Update(Destinos entity);
        Task Delete(Destinos id);
    }
}
