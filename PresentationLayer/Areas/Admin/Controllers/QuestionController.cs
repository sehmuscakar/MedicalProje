using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class QuestionController : Controller
    {
        private readonly IQuestionManager _questionManager;

        public QuestionController(IQuestionManager questionManager)
        {
            _questionManager = questionManager;
        }

        // GET: QuestionController
        public async Task<IActionResult> Index()
        {
            // var listele = _questionManager.GetList();
            var listeledto = _questionManager.GetQuestionListManager();
            return View(listeledto);
        }

        // GET: QuestionController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: QuestionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Question question)
        {
            try
            {
                _questionManager.Add(question);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: QuestionController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var datagetir = _questionManager.GetByID(id);
            return View(datagetir);
        }

        // POST: QuestionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Question question)
        {
            try
            {
                _questionManager.Update(question);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: QuestionController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var datagetir = _questionManager.GetByID(id);
            return View(datagetir);
        }

        // POST: QuestionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Question question)
        {
            try
            {
                _questionManager.Remove(question);
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
