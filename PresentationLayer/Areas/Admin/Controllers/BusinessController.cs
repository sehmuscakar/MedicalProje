using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class BusinessController : Controller
    {
        private readonly IBusinessManager _businessManager;

        public BusinessController(IBusinessManager businessManager)
        {
            _businessManager = businessManager;
        }

        // GET: BusinessController
        public async Task<IActionResult> Index()
        {
            //  var listele = _businessManager.GetList();
            var listeledto = _businessManager.GetBusinessListManager();
            return View(listeledto);
        }

        // GET: BusinessController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: BusinessController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Business business, IFormFile? ImageUrl)
        {
            try
            {
                if (!ModelState.IsValid)
                {

                    if (ImageUrl is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + ImageUrl.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create);
                        ImageUrl.CopyTo(stream1);
                        business.ImageUrl = ImageUrl.FileName;
                    }
                    _businessManager.Add(business);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: BusinessController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var verigetir=_businessManager.GetByID(id);
            return View(verigetir);
        }

        // POST: BusinessController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Business business, IFormFile? ImageUrl)
        {
            try
            {
                if (!ModelState.IsValid)
                {

                    if (ImageUrl is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + ImageUrl.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create);
                        ImageUrl.CopyTo(stream1);
                        business.ImageUrl = ImageUrl.FileName;
                    }
                    _businessManager.Update(business);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: BusinessController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var verigetir = _businessManager.GetByID(id);
            return View(verigetir);
        }

        // POST: BusinessController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Business business)
        {
            try
            {
                _businessManager.Remove(business);  
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }
    }
}
