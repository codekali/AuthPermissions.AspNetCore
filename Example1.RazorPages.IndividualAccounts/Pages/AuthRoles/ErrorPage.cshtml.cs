using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace Example1.RazorPages.IndividualAccounts.Pages.AuthRoles
{
    public class ErrorPageModel : PageModel
    {

        public IEnumerable<string> Data { get; private set; }

        public void OnGet(string allErrors)
        {
            Data = allErrors.Split(Environment.NewLine);
        }
    }
}
