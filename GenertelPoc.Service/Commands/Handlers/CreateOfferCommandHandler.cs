using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GenertelPoc.Service.Commands.Handlers
{
    class CreateOfferCommandHandler : IRequestHandler<CreateOfferCommand>
    {
        public async  Task<Unit> Handle(CreateOfferCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult( Unit.Value);
        }
    }
}
