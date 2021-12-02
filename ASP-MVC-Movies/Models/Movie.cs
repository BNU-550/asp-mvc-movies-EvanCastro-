using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MVC_Movies.Models
{
    public enum Genres
    {
        Comedy,
        Drama,
        Action,
        Romance,
        Thriller,
        Horror,
        Fantasy


    }
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30), Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public Genres Genre { get; set; }

        [Range(5.99, 10.99), Required]
        public decimal Price { get; set; }
    }
}
