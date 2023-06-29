using Domain.Destinos;
using Domain.Primitives;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Destinos.Created
{
    internal sealed class CreateDestinoCommandHandler : IRequestHandler<CreateDestinoCommand,Unit>
    {
        private readonly IDestinoRepository _destino;
        private readonly IUnitOfWork _unitOfWork;

        public CreateDestinoCommandHandler(IDestinoRepository destino, IUnitOfWork unitOfWork)
        {
            _destino = destino ?? throw new ArgumentNullException(nameof(destino));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<Unit> Handle(CreateDestinoCommand command, CancellationToken cancellationToken)
        {
            var destino = new Domain.Destinos.Destinos(
                new DestinoId(Guid.NewGuid()),
                command.Name,
                command.Description,
                command.Ubication,
                true
                );
            await _destino.Add(destino);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
