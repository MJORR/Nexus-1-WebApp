using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Nexus_1_WebApp.Pages;

public class CookieModel : PageModel
{
    private readonly ILogger<CookieModel> _logger;

    public PrivacyModel(ILogger<CookieModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

