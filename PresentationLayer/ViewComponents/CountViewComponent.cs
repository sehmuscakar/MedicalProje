using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class CountViewComponent:ViewComponent
    {
        private readonly ICountManager _countManager;

        public CountViewComponent(ICountManager countManager)
        {
            _countManager = countManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele =_countManager.GetList();
            return View(listele);
        }
    }
}
