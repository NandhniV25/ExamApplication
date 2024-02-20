using NiVeTech.ExamEntity.Entity.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamRepository.Quiz
{
    public interface IExamRepository
    {
        List<NiVeTech.ExamEntity.Entity.Exam.ExamEntity> GetAll();
        int CreateQuiz(NiVeTech.ExamEntity.Entity.Exam.ExamEntity quiz);
        NiVeTech.ExamEntity.Entity.Exam.ExamEntity GetQuizById(int id);
    }
}
