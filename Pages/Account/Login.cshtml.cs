using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWeb.Models;

namespace SupermarketWeb.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Console.WriteLine("User: " + User.Email + "Password" + User.Password);
        }
    }
}
