using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class BranchController : Controller
    {
        private readonly IBranchManager _branchManager;

        public BranchController(IBranchManager branchManager)
        {
            _branchManager = branchManager;
        }

        // GET: BranchController
        public async Task<IActionResult> Index()
        {
            // var listele=  _branchManager.GetList();
            var listeledto = _branchManager.GetBranchListManager();
            return View(listeledto);
        }

        // GET: BranchController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: BranchController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Branch branch,IFormFile? ImageUrl)
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
                        branch.ImageUrl = ImageUrl.FileName;
                    }

                    _branchManager.Add(branch);
                }
                    return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: BranchController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var verigetir=_branchManager.GetByID(id);
            return View(verigetir);
        }

        // POST: BranchController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Branch branch, IFormFile? ImageUrl)
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
                        branch.ImageUrl = ImageUrl.FileName;
                    }

                    _branchManager.Update(branch);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: BranchController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var verigetir = _branchManager.GetByID(id);
            return View(verigetir);
        }

        // POST: BranchController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Branch branch)
        {
            try
            {
                _branchManager.Remove(branch);
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
