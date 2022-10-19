using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Course
    {
        public Guid Id { get; set; }
        
        [Required]
        public string? Title { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Creator { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public string? Category { get; set; }
    }
}