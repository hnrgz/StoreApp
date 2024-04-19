using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StoreApp.Pages
{
    public class DemoModel : PageModel
    {
        public String? UserName => HttpContext?.Session?.GetString("name") ?? "";

        
        public void OnGet()
        {

        }

        public void OnPost([FromForm] string name)
        {
            //UserName = name;
            HttpContext.Session.SetString("name", name);
        }
    }
} 