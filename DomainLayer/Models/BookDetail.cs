using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Processor
{
    public class BookDetail
    {
        public int BookDetailId {  get; set; }
        public int NumberOfChapters {  get; set; }
        public int NumberOfPages { get; set;}
        public string Weight {  get; set; }
        public int BookId {  get; set; }
        public Book Book { get; set; }
    }
}
