using Autofac;
using GenertelPoc.Infrastructure.Behaviours;
using MediatR;

namespace GenertelPoc.Infrastructure.Infrastructure
{
    class ContainerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(ExceptionBehaviour<,>)).As(typeof(IPipelineBehavior<,>));
            builder.RegisterGeneric(typeof(RequestValidationBehavior<,>)).As(typeof(IPipelineBehavior<,>));
            builder.RegisterGeneric(typeof(RequestPerformancePipelineBehaviour<,>)).As(typeof(IPipelineBehavior<,>));
            builder.RegisterGeneric(typeof(CacheBehaviour<,>)).As(typeof(IPipelineBehavior<,>)); 

        }
    }
}
