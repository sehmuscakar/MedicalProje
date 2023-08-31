using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly IFooterManager _footerManager;

        public FooterViewComponent(IFooterManager footerManager)
        {
            _footerManager = footerManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _footerManager.GetList();
            return View(listele);
        }

    }
}
