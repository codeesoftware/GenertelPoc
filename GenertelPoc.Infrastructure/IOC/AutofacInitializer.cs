using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using MediatR.Extensions.Autofac.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GenertelPoc.Infrastructure.IOC
{
    public static class AutofacInitializer
    {
        private const string ApplicationName = "genertelpoc";

        public static IServiceProvider Initialize(IServiceCollection services)
        {
            var builder = new ContainerBuilder();
            Assembly[] assemblies = GetAssemblies();
            services.AddAutoMapper(assemblies.First(a => a.GetName().Name.ToLower().Contains("common")));
            builder.Populate(services);
            Assembly medatrAssembly = assemblies.First(a => a.GetName().Name.ToLower().Contains("service"));
            builder.AddMediatR(medatrAssembly);
            builder.RegisterAssemblyModules(assemblies);
            return new AutofacServiceProvider(builder.Build());
        }

        internal static Assembly[] GetAssemblies()
        {

            HashSet<Assembly> assemblies = new HashSet<Assembly>();

            IReadOnlyList<CompilationLibrary> dependencies = DependencyContext.Default.CompileLibraries;
            foreach (CompilationLibrary library in dependencies)
            {
                if (library.Name.ToLower().Contains(ApplicationName))
                {
                    var assembly = Assembly.Load(new AssemblyName(library.Name));
                    assemblies.Add(assembly);
                }
            }

            return assemblies.ToArray();
        }
    }
}
