﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Processor
{
    public class AuthorBook
    {
        public int BookId {  get; set; }
        public int AuthorId {  get; set; }
        public Book Book {  get; set; }
        public Author Author {  get; set; }
    }
}
