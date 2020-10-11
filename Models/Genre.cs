using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App_1.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Book> Books { get; set; }

        public Genre()
        {
            Books = new List<Book>();
        }
    }
}
