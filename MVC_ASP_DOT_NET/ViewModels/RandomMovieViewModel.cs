using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_ASP_DOT_NET.Models;

namespace MVC_ASP_DOT_NET.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; } // property
        public List<Customer> Customers{ get; set; } // property
    }
}