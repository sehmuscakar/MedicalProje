using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class BranchViewComponent:ViewComponent
    {
        private readonly IBranchManager _branchManager;

        public BranchViewComponent(IBranchManager branchManager)
        {
            _branchManager = branchManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _branchManager.GetList();
            return View(listele);
        }
    }
}
