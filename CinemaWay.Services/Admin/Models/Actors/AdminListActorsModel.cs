namespace CinemaWay.Services.Admin.Models.Actors
{
    using CinemaWay.Common.Mapping;
    using CinemaWay.Data.Models;

    public class AdminListActorsModel : IMapFrom<Actor>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ImageUrl { get; set; }
    }
}
