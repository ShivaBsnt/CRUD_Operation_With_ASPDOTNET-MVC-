using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;

namespace New.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Release date is required.")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Genre is required.")]
        public string Genre { get; set; }
        [Required(ErrorMessage = "price date is required.")]
        public decimal Price { get; set; }
    }


  
}