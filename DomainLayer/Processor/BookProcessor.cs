using DomainLayer.Interface;
using EFCore_DataAccess.Context;
using EFCore_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Processor
{
    public class BookProcessor: IBookProcessor
    {
        private readonly ApplicationDbContext _context;
        public BookProcessor(ApplicationDbContext context) 
        {
            _context = context;  
        }
        public List<Book> GetAllBooks()
        {
            return _context.Books
                    .Select(x => new Book
                    {
                        Title = x.Title,
                        Price = x.Price,
                    })
                    .ToList();
        }
    }
}
