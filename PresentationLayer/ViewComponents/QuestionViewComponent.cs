using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
    public class QuestionViewComponent:ViewComponent
    {
        private readonly IQuestionManager _questionMangager;

        public QuestionViewComponent(IQuestionManager questionMangager)
        {
            _questionMangager = questionMangager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _questionMangager.GetList();
            return View(listele);
        }
    }
}
