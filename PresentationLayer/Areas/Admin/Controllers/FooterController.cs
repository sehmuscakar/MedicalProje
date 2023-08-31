using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class FooterController : Controller
    {
        private readonly IFooterManager _footerManager;

        public FooterController(IFooterManager footerManager)
        {
            _footerManager = footerManager;
        }

        // GET: FooterController
        public async Task<IActionResult> Index()
        {
            // var listele = _footerManager.GetList();
            var listdto = _footerManager.GetFooterListManager();
            return View(listdto);
        }

        // GET: FooterController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: FooterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Footer footer)
        {
            try
            {
                _footerManager.Add(footer);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: FooterController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var verigetir = _footerManager.GetByID(id);
            return View(verigetir);
        }

        // POST: FooterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Footer footer)
        {
            try
            {
                _footerManager.Update(footer);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: FooterController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var verigetir = _footerManager.GetByID(id);
            return View(verigetir);
        }

        // POST: FooterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Footer footer)
        {
            try
            {
                _footerManager.Remove(footer);
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
