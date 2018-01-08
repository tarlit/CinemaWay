using CinemaWay.Common.Mapping;
using CinemaWay.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace CinemaWay.Services.Admin.Models.Movies
{
    public class AdminListMoviesModel : IMapFrom<Movie>, IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Director { get; set; }

        public string Genre { get; set; }

        public void ConfigureMapping(Profile mapper)
            => mapper
            .CreateMap<Movie, AdminListMoviesModel>()
            .ForMember(m => m.Genre, cfg => cfg.MapFrom(m => Enum.GetName(typeof(Genre), m.Genre)));
    }
}
