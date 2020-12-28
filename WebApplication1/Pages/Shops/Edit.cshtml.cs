using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OdeToFood.Core;
using OdeToFood.Data;

namespace WebApplication1.Pages.Shops
{
    public class EditModel : PageModel
    {
        public EditModel(IShopData shopData, IHtmlHelper htmlHelper)
        {
            ShopData = shopData;
            HtmlHelper = htmlHelper;
        }

        public IShopData ShopData { get; }
        public IHtmlHelper HtmlHelper { get; }

        [BindProperty]
        public OdeToFood.Core.Shops Shop { get; set; }
        public IEnumerable<SelectListItem> Specialties { get; set; }

        public IActionResult OnGet(int? shopId)
        {
            Specialties = HtmlHelper.GetEnumSelectList<ShopSpecialty>();

            if (shopId.HasValue)
            {
                Shop = ShopData.GetShopById(shopId.Value);
            }
            else
            {
                Shop = new OdeToFood.Core.Shops();
            }

            
            if (Shop == null)
            {
                return RedirectToPage("./NotFound");
            } 
            return Page();
        } 

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Specialties = HtmlHelper.GetEnumSelectList<ShopSpecialty>();
                return Page();
            }

            if (Shop.Id > 0)
            {
                Shop = ShopData.Update(Shop);
                TempData["Message"] = "Shop Updated!";
            }
            else
            {
                Shop = ShopData.Add(Shop);
                TempData["Message"] = "Shop Added!";
            }
            ShopData.Commit();

            //Post Get Redirect pattern, after a successful post, a users shouldn't be redirected to the same page. This could end up in duplicated posts
            return RedirectToPage("./Detail", new { ShopId = Shop.Id });
        }




    }
}