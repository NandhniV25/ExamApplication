using AutoMapper;
using NiVeTech.ExamApi.Models.Exam;
using NiVeTech.ExamApi.Models.Question;
using NiVeTech.ExamEntity.Entity.Question;

namespace NiVeTech.ExamApi.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        { 
            // Exam
            CreateMap<ExamModel, NiVeTech.ExamEntity.Entity.Exam.ExamEntity>().ReverseMap();
            CreateMap<CreateExamModel, NiVeTech.ExamEntity.Entity.Exam.ExamEntity>().ReverseMap();

            // Question
            CreateMap<QuestionModel, QuestionEntity>().ReverseMap();
            CreateMap<CreateQuestionModel, QuestionEntity>().ReverseMap();
        }
    }
}
