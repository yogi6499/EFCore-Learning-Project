using DomainLayer.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCore_Learning_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookProcessor _bookProcessor;
        public BooksController(IBookProcessor bookProcessor)
        {
            _bookProcessor = bookProcessor;
        }
        [HttpGet("GetAllBooks")]
        public IActionResult GetAllBooks()
        {
            var result = _bookProcessor.GetAllBooks();
            return Ok(result);
        }
    }
}
