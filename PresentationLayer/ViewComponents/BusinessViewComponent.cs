using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class BusinessViewComponent:ViewComponent
    {
        private readonly IBusinessManager _businessManager;

        public BusinessViewComponent(IBusinessManager businessManager)
        {
            _businessManager = businessManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _businessManager.GetList();
            return View(listele);
        }
    }
}
