using AutoMapper;
using NiVeTech.ExamApi.Models.Exam;
using NiVeTech.ExamRepository.Exam;

namespace NiVeTech.ExamApi.Services.Exam
{
    public class ExamService : IExamService
    {
        private readonly IMapper _mapper;
        private readonly IExamRepository _examRepository;
        public ExamService(IMapper mapper, IExamRepository examRepository)
        {
            _mapper = mapper;
            _examRepository = examRepository;
        }
        public int CreateExam(CreateExamModel examModel)
        {
            return _examRepository.CreateExam(_mapper.Map<NiVeTech.ExamEntity.Entity.Exam.ExamEntity>(examModel));
        }

        public ExamModel GetExamById(int examId)
        {
            var examEntity = _examRepository.GetExamById(examId);
            var examModel = _mapper.Map<ExamModel>(examEntity);
            if (examModel == null)
            {
                throw new Exception("The ExamId does not valid. Please enter valid ExamId.");
            }
            return examModel;
        }

        public List<ExamModel> GetExamList()
        {
            return _mapper.Map<List<ExamModel>>(_examRepository.GetExamList());
        }

        public ExamModel UpdateExam(ExamModel examModel)
        {
            var inputExamEntity = _mapper.Map<NiVeTech.ExamEntity.Entity.Exam.ExamEntity>(examModel);
            var examEntity = _examRepository.UpdateExam(inputExamEntity);
            var updatedExamModel = _mapper.Map<ExamModel>(examEntity);
            return updatedExamModel;
        }

        public string DeleteExamById(int examId)
        {
            try
            {
                _examRepository.DeleteExamById(examId);
                return "Deleted Successfully";
            }
            catch(Exception ex)
            {
                return "Error while deleting....";
            }
        }
    }
}
