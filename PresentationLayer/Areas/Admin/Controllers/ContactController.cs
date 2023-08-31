using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    //NETCore.MailKit bu kütüphane 
    // ve bu kütüphaneyi eklemen lazım  MimeKit 
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class ContactController : Controller
    {
        private readonly IContactManager _contactManager;

        public ContactController(IContactManager contactManager)
        {
            _contactManager = contactManager;
        }

        // GET: ContactController
        public ActionResult Index()
        {
            var listele = _contactManager.GetList();
            return View(listele);
        }

        public ActionResult Delete(int id)
        {
            var verigetir = _contactManager.GetByID(id);
            return View(verigetir);
        }

        // POST: ContactController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Contact contact)
        {
            try
            {
                _contactManager.Remove(contact);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
