using System;
using System.ComponentModel.DataAnnotations;

namespace siteSuggestionApp.Models
{
    public class SiteSuggestion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SiteName { get; set; }

        [Required, Url]
        public string SiteUrl { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime DateSubmitted { get; set; } = DateTime.Now;
    }
}
