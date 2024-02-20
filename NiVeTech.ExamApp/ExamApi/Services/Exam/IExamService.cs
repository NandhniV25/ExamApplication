using NiVeTech.ExamApi.Models.Exam;

namespace NiVeTech.ExamApi.Services.Exam
{
    public interface IExamService
    {
        List<ExamModel> GetExamList();
        int CreateExam(CreateExamModel examModel);
        ExamModel GetExamById(int examId);
        ExamModel UpdateExam(ExamModel examModel);
        string DeleteExamById(int examId);
    }
}
