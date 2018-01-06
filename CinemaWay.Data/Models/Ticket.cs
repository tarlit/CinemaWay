namespace CinemaWay.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        public int ProjectionId { get; set; }

        public Projection Projection { get; set; }

        [Required]
        [Range(5, 30)]
        public decimal Price { get; set; }
    }
}
