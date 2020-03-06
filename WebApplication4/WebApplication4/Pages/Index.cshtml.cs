using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace WebApplication4.Pages
{
    public class ArrayModel
    {
        public List<SelectListItem> ArrayOfStrings { get; set; } = new List<SelectListItem>();
    }
    public class IndexModel : PageModel
    {
        [BindProperty]
        public ArrayModel Model { get; set; }

        public void OnGet()
        {
            Model = new ArrayModel();
        }

        public void OnPost()
        {
            System.Diagnostics.Debugger.Break();
        }
    }
}
