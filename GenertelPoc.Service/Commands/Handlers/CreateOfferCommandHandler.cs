using AutoMapper;
using GenertelPoc.Common.ViewModels;
using GenertelPoc.Common.ViewModels.Home;
using GenertelPoc.Domain.BusinessObject;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GenertelPoc.Service.Commands.Handlers
{
    class CreateOfferCommandHandler : IRequestHandler<CreateOfferCommand>
    {
        private readonly IMapper mapper;

        public CreateOfferCommandHandler(IMapper mapper)
        {
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(CreateOfferCommand request, CancellationToken cancellationToken)
        {
            Person person = new Person();
            foreach (IPageViewModel page in request.Wizard.Pages)
            {

              mapper.Map(page,person, page.GetType(), typeof(Person));
            }

            return await Task.FromResult(Unit.Value);
        }
    }
}
