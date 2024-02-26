using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ApiVersioning.Filters
{
    public class SwaggerDefaultValues : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {

            var apiVersionDescription = context.ApiDescription.ActionDescriptor.GetApiVersionMetadata();

            foreach (var parameter in operation.Parameters)
            {
                if (parameter.Name == "api-version")
                {
                    parameter.Description = "API version";
                }
            }
        }
    }
}
