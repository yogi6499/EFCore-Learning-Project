﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Models.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public int DiplayOrder { get; set; }
    }
}
