﻿using Eapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eapp.ViewModels
{
    public class RamdomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}