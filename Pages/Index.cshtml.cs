using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab1app.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    public IActionResult OnPost(string operation, double value1, double value2)
    {
        double result = 0;

        if (operation == "add")
        {
            result = value1 + value2;
        }
        else if (operation == "subtract")
        {
            result = value1 - value2;
        }
        else if (operation == "multiply")
        {
            result = value1 * value2;
        }
        else if (operation == "power")
        {
            result = Math.Pow(value1, value2);
        }
        else if(operation == "AC"){
            result = 0;
            ViewData["display"] = "";
            return Page();
        }
        else if(operation == "cube"){
            result = value1*value1*value1;
        }
        else if(operation =="square"){
            result = value1*value1;
        }
        else
        {
            ViewData["display"] = "Invalid operation";
            return Page();
        }

        ViewData["display"] = result.ToString();

        return Page();
    }
    
}