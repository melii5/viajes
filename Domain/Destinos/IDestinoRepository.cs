using Domain.Paquetes;
using Domain.Destinos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Destinos
{
    public interface IDestinoRepository
    {
        Task<List<Destino>> listAsync();
        Task<Destino?> GetByIdAsync(DestinoId id);
        Task Add(Destino entity);

        Task Update(Destino entity);
        Task Delete(Destino id);
    }
}
