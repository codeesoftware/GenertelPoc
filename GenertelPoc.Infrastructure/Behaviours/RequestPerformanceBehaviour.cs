using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GenertelPoc.Infrastructure.Behaviours
{
    class RequestPerformancePipelineBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>

    {

        public Stopwatch Timer { get; }

        public RequestPerformancePipelineBehaviour()
        {
            this.Timer = new Stopwatch();
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            Timer.Start();
            TResponse response = await next();
            Timer.Stop();

            string name = typeof(TRequest).Name;

            return response;
        }
    }
}
