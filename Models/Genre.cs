﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_1.Models
{
    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Book> Books { get; set; }

        public Genre()
        {
            Books = new List<Book>();
        }
    }
}
