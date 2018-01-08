using CinemaWay.Common.Mapping;
using CinemaWay.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace CinemaWay.Services.Storyteller.Models
{
    public class ListStoriesModel : IMapFrom<Story>, IHaveCustomMapping
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public DateTime PublishDate { get; set; }

        public string Author { get; set; }

        public void ConfigureMapping(Profile mapper)
            => mapper
            .CreateMap<Story, ListStoriesModel>()
            .ForMember(s => s.Author, cfg => cfg.MapFrom(s => s.Author.UserName));
    }
}
