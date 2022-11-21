using System.Reflection;
using System.Runtime.CompilerServices;

namespace WebApiTest.Endpoints
{
    public static class IEndpointRouteBuilderExtensions
    {
        // SUMMARY: Searches assemblies for all classes that implement the IEndpointRouteBuilder interface.
        // Used to avoid having to explicitly call map method for each class in the program.cs file 
        public static void MapEndpoints(this IEndpointRouteBuilder app, Assembly assembly)
        {
            var endpointRouterHandlerInterfaceType = typeof(IEndpointRouteHandler);

            var endpointRouteHandlerTypes = assembly.GetTypes()
                .Where(t => 
                    t.IsClass && 
                    !t.IsAbstract && 
                    !t.IsGenericType && 
                    t.GetConstructor(Type.EmptyTypes) != null && 
                    endpointRouterHandlerInterfaceType.IsAssignableFrom(t));

            foreach (var endpintRouteHandlerType in endpointRouteHandlerTypes)
            {
                var instantiatedType = (IEndpointRouteHandler)Activator.CreateInstance(endpintRouteHandlerType)!;
                instantiatedType.MapEndpoints(app);
            }

        }
    }
}
