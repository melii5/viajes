using Domain.PaquetesDestinos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.PaqueteDestinos
{
    public interface IPaqueteDestinoRepository
    {
        Task<List<PaqueteDestinos>> listAsync();

        Task<List<PaqueteDestinos>> listByDestinoAsync(int destinoId);
        Task<List<PaqueteDestinos>> listByPaqueteAsync(int paqueteId);
        //Task<PaqueteDestino?> GetByIdAsync(DestinoId id);
        Task Add(PaqueteDestinos entity);

        Task Update(PaqueteDestinos entity);
        Task Delete(int id);
    }
}
