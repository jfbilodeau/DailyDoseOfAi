using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DailyDoseOfAi.Core;

namespace DailyDoseOfAi.Web.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly TipManager _tipManager;

    public Tip? DailyTip { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        _tipManager = new TipManager();
    }

    public void OnGet()
    {
        DailyTip = _tipManager.GetDailyTip();
    }
}
