using NiVeTech.ExamEntity.Entity.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiVeTech.ExamRepository.Exam
{
    public interface IExamRepository
    {
        List<NiVeTech.ExamEntity.Entity.Exam.ExamEntity> GetExamList();
        int CreateExam(NiVeTech.ExamEntity.Entity.Exam.ExamEntity exam);
        NiVeTech.ExamEntity.Entity.Exam.ExamEntity GetExamById(int examId);
        NiVeTech.ExamEntity.Entity.Exam.ExamEntity UpdateExam(NiVeTech.ExamEntity.Entity.Exam.ExamEntity exam);
        void DeleteExamById(int examId);
    }
}
