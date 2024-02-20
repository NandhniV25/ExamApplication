using NiVeTech.ExamEntity.Entity.Exam;
using NiVeTech.ExamEntity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiVeTech.ExamRepository.Exam;
using Microsoft.EntityFrameworkCore;

namespace NiVeTec.ExamRepository.Exam
{
    public class ExamRepository : IExamRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ExamRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateExam(NiVeTech.ExamEntity.Entity.Exam.ExamEntity exam)
        {
            _dbContext.Exams.Add(exam);
            _dbContext.SaveChanges();
            return exam.Id;
        }

        public List<NiVeTech.ExamEntity.Entity.Exam.ExamEntity> GetExamList()
        {
            return _dbContext.Exams.ToList();
        }

        public NiVeTech.ExamEntity.Entity.Exam.ExamEntity GetExamById(int examId)
        {
            return _dbContext.Exams.FirstOrDefault(c => c.Id == examId);
        }

        public NiVeTech.ExamEntity.Entity.Exam.ExamEntity UpdateExam(NiVeTech.ExamEntity.Entity.Exam.ExamEntity exam)
        {
            var res = _dbContext.Exams.Update(exam);
            _dbContext.SaveChanges();
            return res.Entity;
        }

        public void DeleteExamById(int examId)
        {
            _dbContext.Exams.Remove(GetExamById(examId));
            _dbContext.SaveChanges();
        }
    }
}
