using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GigHub.Models;
using Microsoft.Owin.Security.Notifications;

namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}