using NiVeTech.ExamEntity.Data;
using NiVeTech.ExamEntity.Entity.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiVeTech.ExamRepository.Question
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public QuestionRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int CreateQuestion(QuestionEntity question)
        {
            _dbContext.Questions.Add(question);
            _dbContext.SaveChanges();
            return question.Id;
        }

        public void DeleteQuestionById(int questionId)
        {
            _dbContext.Questions.Remove(GetQuestionById(questionId));
            _dbContext.SaveChanges();
        }

        public QuestionEntity GetQuestionById(int questionId)
        {
            return _dbContext.Questions.FirstOrDefault(c => c.Id == questionId);
        }

        public List<QuestionEntity> GetQuestionList()
        {
            return _dbContext.Questions.ToList();
        }

        public QuestionEntity UpdateQuestion(QuestionEntity question)
        {
            var res = _dbContext.Questions.Update(question);
            _dbContext.SaveChanges();
            return res.Entity;
        }
    }
}
