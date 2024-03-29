﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor 
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name Is Required")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Bio Is Required")]
        public string Bio { get; set; }

        // relationships
        public List<Actor_Movie> Actor_Movies { get; set; }

    }
}
