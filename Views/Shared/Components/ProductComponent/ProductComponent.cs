
using Microsoft.AspNetCore.Mvc;
namespace AvaKids_188269.Components
{
    // [ViewComponent]
    public class ProductComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("ToyComponent");
        }
        
    }
}