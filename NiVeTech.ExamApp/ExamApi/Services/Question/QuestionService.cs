using AutoMapper;
using NiVeTech.ExamApi.Models.Question;
using NiVeTech.ExamEntity.Entity.Question;
using NiVeTech.ExamRepository.Question;

namespace NiVeTech.ExamApi.Services.Question
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;
        public QuestionService(IQuestionRepository questionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public int CreateQuestion(CreateQuestionModel questionModel)
        {
            return _questionRepository.CreateQuestion(_mapper.Map<QuestionEntity>(questionModel));
        }

        public string DeleteQuestionById(int questionId)
        {
            try
            {
                _questionRepository.DeleteQuestionById(questionId);
                return "Deleted Successfully";
            }
            catch(Exception ex)
            {
                return "Error while deleting...";
            }
        }

        public QuestionModel GetQuestionById(int questionId)
        {
            var questionEntity = _questionRepository.GetQuestionById(questionId); 
            var questionModel = _mapper.Map<QuestionModel>(questionEntity);
            if (questionModel == null) 
            {
                throw new Exception("Question Not Found");
            }
            return questionModel;
        }

        public List<QuestionModel> GetQuestionList()
        {
            var questionEntity = _questionRepository.GetQuestionList();
            var questionList = _mapper.Map<List<QuestionModel>>(questionEntity);
            return questionList;
        }

        public QuestionModel UpdateQuestion(QuestionModel questionModel)
        {
            var inputQuestionEntity = _mapper.Map<QuestionEntity>(questionModel);
            var questionEntity = _questionRepository.UpdateQuestion(inputQuestionEntity);
            var updatedQuestionModel = _mapper.Map<QuestionModel>(questionEntity);
            return updatedQuestionModel;
        }
    }
}
