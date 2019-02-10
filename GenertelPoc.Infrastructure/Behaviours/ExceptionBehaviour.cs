using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GenertelPoc.Infrastructure.Behaviours
{
    class ExceptionBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>

    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            try
            {

                TResponse response = await next();
                return response;
            }
            catch (Exception )
            {
                throw;

            }
        }
    }
}
