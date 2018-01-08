namespace CinemaWay.Services.Admin.Models.Movies
{
    using CinemaWay.Common.Mapping;
    using CinemaWay.Data.Models;

    public class ShortMovieModel : IMapFrom<Movie>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
