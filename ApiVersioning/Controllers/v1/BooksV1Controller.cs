using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.v1
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/Books")]
    public class BooksV1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var books = new[]
            {
                new { Id = 1, Title = "Book One V1" },
                new { Id = 2, Title = "Book Two V1" }
            };

            return Ok(books);
        }
    }
}
