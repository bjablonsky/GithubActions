using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace GithubActionsTest.Pages
{
    public class APIModel : PageModel
    {
        private readonly ILogger<APIModel> _logger;

        public APIModel(ILogger<APIModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
