namespace CinemaWay.Services.Admin.Models.Projections
{
    using AutoMapper;
    using CinemaWay.Common.Mapping;
    using CinemaWay.Data.Models;
    using System;

    public class AdminListProjectionsModel : IMapFrom<Projection>, IHaveCustomMapping
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int StartTime { get; set; }

        public int Duration { get; set; }

        public string Movie { get; set; }

        public string Theme { get; set; }

        public string Lecturer { get; set; }

        public void ConfigureMapping(Profile mapper)
            => mapper
            .CreateMap<Projection, AdminListProjectionsModel>()
            .ForMember(p => p.Movie, cfg => cfg.MapFrom(p => p.Movie.Name))
            .ForMember(p => p.Theme, cfg => cfg.MapFrom(p => p.Theme.Title))
            .ForMember(p => p.Lecturer, cfg => cfg.MapFrom(p => p.Lecturer.UserName));
    }
}
