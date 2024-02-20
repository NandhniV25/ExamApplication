using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NiVeTech.ExamApi.Models.Exam;
using NiVeTech.ExamApi.Services.Exam;

namespace NiVeTech.ExamApi.Controllers.Exam
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IExamService _examService;
        public ExamController(IExamService examService)
        {
            _examService = examService;
        }
        [HttpPost]
        public ActionResult<int> CreateExam(CreateExamModel examModel)
        {
            return _examService.CreateExam(examModel);
        }
        [HttpGet]
        public ActionResult<List<ExamModel>> GetExamList()
        {
            return _examService.GetExamList();
        }
        [HttpGet("{id:int}")]
        public ActionResult<ExamModel> GetExamById(int id)
        {
            return _examService.GetExamById(id);
        }
        [HttpPut("/update")]
        public ActionResult<ExamModel> UpdateExam(ExamModel examModel)
        {
            return _examService.UpdateExam(examModel);
        }
        [HttpDelete("{id:int}")]
        public ActionResult<string> DeleteExamById(int id) 
        {
            return _examService.DeleteExamById(id);
        }
    }
}
