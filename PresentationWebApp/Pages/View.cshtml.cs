using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PresentationWebApp.Pages
{
    public class ViewModel : PageModel
    {
        public List<string> tableRows;
        public int tableCount;

        public void OnGet(PL table)
        {
            tableRows = table.Results();
            tableCount = table.Count();
        }
    }
}
