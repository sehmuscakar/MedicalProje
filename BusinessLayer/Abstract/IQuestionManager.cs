using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IQuestionManager
    {
        List<QuestionListDto> GetQuestionListManager();
        List<Question> GetList();
        void Add(Question question);
        void Update(Question question);
        void Remove(Question question);
        Question GetByID(int id);

    }
}
