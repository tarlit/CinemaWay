using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWay.Services.Html
{
    public interface IHtmlService
    {
        string Sanitize(string htmlContent);
    }
}
