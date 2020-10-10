using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_1.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public int Year { get; set; }

        public List<AuthorBook> AuthorBooks { get; set; }

        public Author()
        {
            AuthorBooks = new List<AuthorBook>();
        }
    }
}
