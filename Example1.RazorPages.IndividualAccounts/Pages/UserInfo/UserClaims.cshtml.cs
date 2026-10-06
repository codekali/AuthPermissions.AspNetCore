using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Example1.RazorPages.IndividualAccounts.Pages.UserInfo
{
    public class UserClaimsModel : PageModel
    {
        public ClaimsPrincipal ThisUser { get; set; }

        public void OnGet()
        {
            ThisUser = User;
        }
    }
}
