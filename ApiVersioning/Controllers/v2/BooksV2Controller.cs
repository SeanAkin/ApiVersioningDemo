using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.v2
{
    [ApiVersion("2.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/Books")]
    public class BooksV2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var books = new[]
            {
                new { Id = 1, Title = "Book One V2", Author = "Author A" },
                new { Id = 2, Title = "Book Two V2", Author = "Author B" }
            };

            return Ok(books);
        }
    }
}
