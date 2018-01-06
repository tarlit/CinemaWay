using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWay.Data.Models
{
    public class Projection
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [Range(0, 23)]
        public int StartTime { get; set; }

        [Range(100, 180)]
        public int Duration { get; set; }

        [Required]
        public int MovieId { get; set; }

        public Movie Movie { get; set; }

        public int ThemeId { get; set; }

        public Theme Theme { get; set; }

        public string LecturerId { get; set; }

        public User Lecturer { get; set; }

        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
