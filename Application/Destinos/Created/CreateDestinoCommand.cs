using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Destinos.Created
{
    public record CreateDestinoCommand(string Name,string Ubication,string Description):IRequest<Unit>;

}
