using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> OnGet()
    {
        var time = new Random().Next(1, 3);
        _logger.LogInformation("Req delay : {Time}", time);
        await Task.Delay(TimeSpan.FromSeconds(time));
        return Page();

    }
}
