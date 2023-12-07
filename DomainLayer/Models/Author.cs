using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Processor
{
    public class Author
    {
        public int Authoe_Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Location {  get; set; }
        public List<AuthorBook> AuthorBookMap { get; set; }
        public string FullName
        {
            get
            {
                return FullName ?? string.Empty;
            } 
            set
            {
                FullName = FirstName + LastName;
            }
        }
    }
}
