using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class WhyUsController : Controller
    {

        private readonly IWhyUsManager _whyUsManager;

        public WhyUsController(IWhyUsManager whyUsManager)
        {
            _whyUsManager = whyUsManager;
        }

        // GET: WhyUsController
        public async Task<IActionResult> Index()
        {
            // var listele = _whyUsManager.GetList();
            var listeledto = _whyUsManager.GetWhyUsListManager();
            return View(listeledto);
        }

        // GET: WhyUsController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: WhyUsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(WhyUs whyUs)
        {
            try
            {
                _whyUsManager.Add(whyUs);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: WhyUsController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var datagetir = _whyUsManager.GetByID(id);
            return View(datagetir);
        }

        // POST: WhyUsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, WhyUs whyUs)
        {
            try
            {
                _whyUsManager.Update(whyUs);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: WhyUsController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var datatut=_whyUsManager.GetByID(id);
            return View(datatut);
        }

        // POST: WhyUsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, WhyUs whyUs)
        {
            try
            {
                _whyUsManager.Remove(whyUs);
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
