using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PresentationWebApp.Pages
{
    public class LoginModel : PageModel
    {
        private PL table;

        //public object Authentication { get; private set; }

        public void OnGet()
        {
        }

        //public ActionResult OnPost()

        public ActionResult SubmitForm() //Should be OnPostSubmit... removed parameter FormCollection Credentials
        {
            Console.WriteLine("Anyone There?");
            //return new RedirectToPageResult("/Error");
            //string str = ViewBag.;
            //var str2 = Request.Form["Username"];
            try
            {
                Console.WriteLine("Hello 1");
                //table = new PL(Credentials.Get, Credentials.Password, Credentials.Table);
                table = new PL(Request.Form["Username"], Request.Form["Password"], Request.Form["Table"]);
                return new RedirectToPageResult("View", table);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hello 2");
                return new RedirectToPageResult("Error");
            }
            
        }
    }
}
