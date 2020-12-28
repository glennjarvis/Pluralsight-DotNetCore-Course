using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace WebApplication1.Pages.Shops
{
    public class DetailModel : PageModel
    {
        public OdeToFood.Core.Shops shop{ get; set; }
        public IShopData Shopdata { get; }


        //Binding to a successful edit, we create temp data (disappears after post) to show the user
        [TempData]
        public string Message { get; set; }

        public DetailModel(IShopData shopdata)
        {
            Shopdata = shopdata;
        }

        //OnGet is a Action, we'll use ActionResult instead of void to handle bad requests
        public IActionResult OnGet(int shopId)
        {
            shop = Shopdata.GetShopById(shopId);
            if (shop == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}