﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Processor
{
    public class Publisher
    {
        public int Publisher_Id { get; set; }
        public string Name {  get; set; }
        public string Location {  get; set; }
        public List<Book> Books { get; set; }
    }
}
