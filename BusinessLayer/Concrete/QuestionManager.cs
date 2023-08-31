using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class QuestionManager : IQuestionManager
    {
        private readonly IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }
        public void Add(Question question)
        {
           question.AppUserId = 3;
           question.IsActive = true;
           var roworder = _questionDal.GetAll().Count();
           question.RowOrder = roworder + 1;
          _questionDal.Add(question);
        }

        public Question GetByID(int id)
        {
          return  _questionDal.Get(id);
        }

        public List<Question> GetList()
        {
           return _questionDal.GetAll();
        }

        public List<QuestionListDto> GetQuestionListManager()
        {
            return _questionDal.GetQuestionListDal();
        }

        public void Remove(Question question)
        {
            _questionDal.Delete(question);
        }

        public void Update(Question question)
        {
           question.AppUserId = 3;
           question.IsActive = true;
           var roworder = _questionDal.GetAll().Count();
           question.RowOrder = roworder;
           question.LastUpdatedAt = DateTime.Now;
            _questionDal.Update(question);
        }
    }
}
