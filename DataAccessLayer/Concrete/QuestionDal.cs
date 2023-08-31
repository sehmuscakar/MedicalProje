using CoreLayer.DataAccess.EntityFramwork;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class QuestionDal : BaseRepository<Question, ProjeContext>, IQuestionDal
    {
        public List<QuestionListDto> GetQuestionListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Questions.Select(question => new QuestionListDto()
                {
                    Id = question.Id,
                    TabIndex= question.TabIndex,
                    Title= question.Title,
                    Description= question.Description,
                    LastUpdatedAt = question.LastUpdatedAt,
                    CreatedFullName = question.AppUser.Name,
                    IsActive = question.IsActive,
                    RowOrder = question.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
