using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using udemy_ASP.NET_MVC.Models;

namespace udemy_ASP.NET_MVC.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}