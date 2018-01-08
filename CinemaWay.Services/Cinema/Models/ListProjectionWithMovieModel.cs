using CinemaWay.Common.Mapping;
using CinemaWay.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace CinemaWay.Services.Cinema.Models
{
    public class ListProjectionWithMovieModel : IMapFrom<Projection>, IHaveCustomMapping
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int StartTime { get; set; }

        public string Movie { get; set; }

        public string MovieImage { get; set; }

        public void ConfigureMapping(Profile mapper)
            => mapper
            .CreateMap<Projection, ListProjectionWithMovieModel>()
            .ForMember(p => p.Movie, cfg => cfg.MapFrom(p => p.Movie.Name))
            .ForMember(p => p.MovieImage, cfg => cfg.MapFrom(p => p.Movie.ImageUrl));
    }
}
