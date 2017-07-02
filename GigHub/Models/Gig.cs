using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigHub.Models
{
    public class Gig
    {
        public int Id { get; set; }


        [ForeignKey( "ArtistId" )]
        public ApplicationUser Artist { get; set; }

        [Required]
        public string ArtistId { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength( 255 )]
        public string Venue { get; set; }


        [ForeignKey( "GenreId" )]
        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }


    }
}