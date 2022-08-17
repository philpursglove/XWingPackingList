using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace XWingPackingList.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        [Required]
        public string XWSText { get; set; }

        public string ErrorMessage { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (!string.IsNullOrWhiteSpace(XWSText))
            {
                try
                {
                    object testJson = JObject.Parse(XWSText);
                }
                catch (JsonReaderException)
                {
                    ErrorMessage = "Bad XWS";
                }
            }
        }
    }
}