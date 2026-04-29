using Microsoft.AspNetCore.Mvc;

namespace UmbracoBlockGrid.Site.Controllers;

public class CairoGovernmentController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        SetPageMeta("اكتشف القاهرة", "home");
        return View();
    }

    [HttpGet("ads")]
    public IActionResult Ads()
    {
        SetPageMeta("الإعلانات", "ads");
        return View();
    }

    [HttpGet("digital-transformation")]
    public IActionResult DigitalTransformation()
    {
        SetPageMeta("التحول الرقمي", "digital-transformation");
        return View();
    }

    [HttpGet("governor")]
    public IActionResult Governor()
    {
        SetPageMeta("المحافظ", "governor");
        return View();
    }

    [HttpGet("hayah-karima")]
    public IActionResult HayahKarima()
    {
        SetPageMeta("حياة كريمة", "hayah-karima");
        return View();
    }

    [HttpGet("org-chart")]
    public IActionResult OrgChart()
    {
        SetPageMeta("الهيكل التنظيمي", "org-chart");
        return View();
    }

    private void SetPageMeta(string title, string currentPage)
    {
        ViewData["Title"] = title;
        ViewData["CurrentPage"] = currentPage;
    }
}
