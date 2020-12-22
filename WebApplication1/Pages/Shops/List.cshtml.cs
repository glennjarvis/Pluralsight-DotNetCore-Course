using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Data;
using OdeToFood.Core;

namespace WebApplication1.Pages.Shops
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        public string message { get; set; }
        public IShopData ShopData { get; }
        public List<OdeToFood.Core.Shops> Shops { get; set; }

        //This bind property attribute specifies that this property should receive information from the request
        //By default, this is populated using a post request, so we'll add the support for a get request
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        //This page acts as the controller for the List.cshtml view


        //We're able to get the Shop Data from the startup page since we configured it as a service
        public ListModel(IConfiguration config, IShopData shopData)
        {
            //This is how we grab data from the configuration files
            this.config = config;
            ShopData = shopData;
        }

        /// <summary>
        /// The Request sent when the application navigates to this page.
        /// </summary>
        public void OnGet()
        {
            message = config["MessageFromAppSettings"];
            if (string.IsNullOrEmpty(SearchTerm))
            {
                Shops = ShopData.GetAllShops().ToList();
            }
            else
            {
                Shops = ShopData.GetShopsByName(SearchTerm).ToList();
            }
        }
    }
}