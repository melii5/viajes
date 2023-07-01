using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Paquetes;

namespace Domain.Paquetes
{
    public interface IPaquetesRepository
    {   
        Task<Paquete?> GetByIdAsync(PaqueteId id);
        Task Add(Paquete entity);

        Task Update(Paquete entity);
        Task Delete(PaqueteId id);  


    }
}
