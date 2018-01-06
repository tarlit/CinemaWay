namespace CinemaWay.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class User : IdentityUser
    {
        [Required]
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        public string Username { get; set; }

        [Required]
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"\+\d{10,12}")]
        public string Phone { get; set; }

        public List<Projection> Lectures { get; set; } = new List<Projection>();

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
