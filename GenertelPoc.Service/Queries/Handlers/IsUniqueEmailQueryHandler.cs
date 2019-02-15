using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GenertelPoc.Service.Queries.Handlers
{
    class IsUniqueEmailQueryHandler : IRequestHandler<IsUniqueEmailQuery, bool>
    {
        public async Task<bool> Handle(IsUniqueEmailQuery request, CancellationToken cancellationToken)
        {

            string[] emails = { "sorstenson@gmail.com", "sandor@citromail.hu" };

            return !emails.Contains(request.Email);

        }
    }
}
