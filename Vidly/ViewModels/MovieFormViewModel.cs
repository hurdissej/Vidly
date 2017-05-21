using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using Vidly.Migrations;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genres> Genres { get; set; }

        public string NewOrEdit
        {
            get
            {
                if (Movie != null && Movie.ID != 0)
                    return "Edit Movie";

                return "New Movie!";
            }
        }


    }
}