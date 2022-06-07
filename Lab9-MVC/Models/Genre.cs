using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab9_MVC.Models
{
    public class Genre
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Genre name is required!")]
        [StringLength(100, ErrorMessage = "Maximal length of the name of a genre is 100 characters!")]
        public string Name { get; set; }
        public ICollection<Song> SongsList { get; set; }
    }
}