using NiVeTech.ExamApi.Models.Question;

namespace NiVeTech.ExamApi.Services.Question
{
    public interface IQuestionService
    {
        int CreateQuestion(CreateQuestionModel questionModel);
        List<QuestionModel> GetQuestionList();
        QuestionModel GetQuestionById(int questionId);
        QuestionModel UpdateQuestion(QuestionModel questionModel);
        string DeleteQuestionById(int questionId);
    }
}
