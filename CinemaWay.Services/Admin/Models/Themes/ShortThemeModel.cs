namespace CinemaWay.Services.Admin.Models.Themes
{
    using CinemaWay.Common.Mapping;
    using CinemaWay.Data.Models;

    public class ShortThemeModel : IMapFrom<Theme>
    {
        public int Id { get; set; }

        public string Title { get; set; }
    }
}
