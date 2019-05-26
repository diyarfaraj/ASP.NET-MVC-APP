using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }
        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate { get; set; }

        
        public byte NumberInStock { get; set; }
    }
}