using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NiVeTech.ExamApi.Models.Question;
using NiVeTech.ExamApi.Services.Question;
using System.Reflection.Metadata.Ecma335;

namespace NiVeTech.ExamApi.Controllers.Question
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }
        [HttpPost]
        public ActionResult<int> CreateQuestion(CreateQuestionModel questionModel)
        {
            return _questionService.CreateQuestion(questionModel);
        }
        [HttpGet]
        public ActionResult<List<QuestionModel>> GetQuestionList()
        {
            return _questionService.GetQuestionList();
        }
        [HttpGet("{id:int}")]
        public ActionResult<QuestionModel> GetQuestionById(int questionId)
        {
            return _questionService.GetQuestionById(questionId);
        }
        [HttpPut("/question/update")]
        public ActionResult<QuestionModel> UpdateQuestion(QuestionModel questionModel)
        {
            return _questionService.UpdateQuestion(questionModel);
        }
        [HttpDelete("{id:int}")]
        public ActionResult<string> DeleteQuestionById(int questionId)
        {
            return _questionService.DeleteQuestionById(questionId);
        }
    }
}
