using DomainLayer.Interface;
using DomainLayer.Processor;
using EFCore_DataAccess.Context;
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
        private readonly ApplicationDbContext _context;
        public BooksController(IBookProcessor bookProcessor, ApplicationDbContext context)
        {
            _bookProcessor = bookProcessor;
            _context = context;
        }
        [HttpGet("GetAllBooks")]
        public IActionResult GetAllBooks()
        {
            var result = _bookProcessor.GetAllBooks();
            return Ok(result);
        }

        [HttpPost("CreateBook")]
        public IActionResult CreateBook(EFCore_Models.Models.Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return Ok(book);
        }

        [HttpPost("CreateAuthor")]
        public IActionResult CreateAuthor(AuthorBookVm vm)
        {
            var author = new EFCore_Models.Models.Author()
            {
                FirstName = vm.FirstName,
                LastName = vm.LastName,
                BirthDate = vm.BirthDate,
                Location = vm.Location,
            };
            foreach(var id in vm.BookIds)
            {
                author.AuthorBookMap.Add(new EFCore_Models.Models.AuthorBook
                {
                    BookId = id,
                    //Author = author
                });
            }
            _context.Authors.Add(author);
            _context.SaveChanges();
            return Ok();
        }
    }
}
