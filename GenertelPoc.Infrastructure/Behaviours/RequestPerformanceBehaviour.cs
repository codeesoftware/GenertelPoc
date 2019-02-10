using MediatR;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<TRequest> logger;
        private Stopwatch Timer { get; }

        public RequestPerformancePipelineBehaviour(ILogger<TRequest> logger)
        {
            this.Timer = new Stopwatch();
            this.logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            Timer.Start();
            TResponse response = await next();
            Timer.Stop();

            string name = typeof(TRequest).Name;
            logger.LogInformation($"{name} {Timer.ElapsedMilliseconds} ms");
            return response;
        }
    }
}
