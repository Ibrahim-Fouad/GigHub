using GigHub.CustomValidation;
using GigHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {
        [Required]
        public string Venue { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        public byte Genre { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public DateTime DataTime() => DateTime.Parse( $"{Date} {Time}" );
    }
}