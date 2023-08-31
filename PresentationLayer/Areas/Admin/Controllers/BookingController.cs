using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class BookingController : Controller
    {
        private readonly IBookingManager _bookingManager;

     
        public BookingController(IBookingManager bookingManager)
        {
            _bookingManager = bookingManager;
        }

        // GET: BookingController
        public async Task<IActionResult> Index()
        {
             var listele = _bookingManager.GetList();  
            return View(listele);
        }

        // GET: BookingController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var verigetir = _bookingManager.GetByID(id);
            return View(verigetir);
        }


        // POST: BookingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Booking booking)
        {
            try
            {
                _bookingManager.Remove(booking);
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
