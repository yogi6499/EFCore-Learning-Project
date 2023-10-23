using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Models.Models
{
    public class Author
    {
        [Key]
        public int Authoe_Id {  get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Location {  get; set; }
        public List<AuthorBook> AuthorBookMap { get; set; }
        [NotMapped]
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
