using NiVeTech.ExamEntity.Entity.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiVeTech.ExamRepository.Question
{
    public interface IQuestionRepository
    {
        int CreateQuestion(QuestionEntity question);
        List<QuestionEntity> GetQuestionList();
        QuestionEntity GetQuestionById(int questionId);
        QuestionEntity UpdateQuestion(QuestionEntity question);
        void DeleteQuestionById(int questionId);
    }
}
