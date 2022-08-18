using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace XWingPackingList.Pages
{
    public class ProcessModel : PageModel
    {
        public string XWSText { get; set; }
        public void OnGet()
        {
            XWSText = (string)TempData["XWS"];
        }
    }
}
