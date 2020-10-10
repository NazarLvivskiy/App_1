using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_1.Models
{
    public class AuthorBook
    {
        public int AuthotId { get; set; }

        public Author Author { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; }
    }
}
