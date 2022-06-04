using Microsoft.AspNetCore.Mvc;
namespace AvaKids_188269.Components
{
    // [ViewComponent]
    public class SearchFocus : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("SearchFocus");
        }

    }
}