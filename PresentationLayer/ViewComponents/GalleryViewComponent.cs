using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class GalleryViewComponent:ViewComponent
    {
        private readonly IGalleryManager _galleryManager;

        public GalleryViewComponent(IGalleryManager galleryManager)
        {
            _galleryManager = galleryManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _galleryManager.GetList();
            return View(listele);
        }

    }
}
