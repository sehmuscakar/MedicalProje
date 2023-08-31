using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class WhyUsViewComponent:ViewComponent
    {
        private readonly IWhyUsManager _whyUsManager;

        public WhyUsViewComponent(IWhyUsManager whyUsManager)
        {
            _whyUsManager = whyUsManager;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _whyUsManager.GetList();
            return View(listele);
        }

    }
}
