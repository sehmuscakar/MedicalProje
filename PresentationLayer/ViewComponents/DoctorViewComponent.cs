using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class DoctorViewComponent:ViewComponent
    {
        private readonly IDoctorManager _doctorManager;

        public DoctorViewComponent(IDoctorManager doctorManager)
        {
            _doctorManager = doctorManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _doctorManager.GetList();
            return View(listele);
        }

    }
}
