using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace WebApplication1.Pages.Shops
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        public string message { get; set; }

        //This page acts as the controller for the List.cshtml view

        public ListModel(IConfiguration config)
        {
            //This is how we grab data from the configuration files
            this.config = config;
        }

        public void OnGet()
        {
            message = config["MessageFromAppSettings"];
        }
    }
}