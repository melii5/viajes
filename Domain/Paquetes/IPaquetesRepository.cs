using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Paquetes
{
    public interface IPaquetesRepository
    {   
        Task<Paquetes?> GetByIdAsync(PaqueteId id);
        Task Add(Paquetes entity);

        Task Update(Paquetes entity);
        Task Delete(PaqueteId id);  


    }
}
