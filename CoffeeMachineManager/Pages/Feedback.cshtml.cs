using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoffeeMachineManager.Pages
{
    [Authorize]
    public class FeedbackModel : PageModel
    {
        public void OnGet()
        {
            // Logic to fetch and display feedback
        }
    }
}
