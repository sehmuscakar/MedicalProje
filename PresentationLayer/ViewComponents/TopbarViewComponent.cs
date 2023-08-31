using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class TopbarViewComponent:ViewComponent
    {
        private readonly ITopbarManager _topbarManager;

        public TopbarViewComponent(ITopbarManager topbarManager)
        {
            _topbarManager = topbarManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _topbarManager.GetList();
            return View(listele);
        }


    }
}
