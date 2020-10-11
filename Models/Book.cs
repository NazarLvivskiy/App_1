using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App_1.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        public List<AuthorBook> AuthorBooks { get; set; }

        public bool IsAvailable { get; set; }

        public decimal Price { get; set; }

        public int Amount { get; set; }

        public Book()
        {
            AuthorBooks = new List<AuthorBook>();
        }
    }
}
