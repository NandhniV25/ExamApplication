using AutoMapper;
using NiVeTech.ExamApi.Models.Exam;

namespace NiVeTech.ExamApi.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        { 
            // Exam
            CreateMap<ExamModel, NiVeTech.ExamEntity.Entity.Exam.ExamEntity>().ReverseMap();
            CreateMap<CreateExamModel, NiVeTech.ExamEntity.Entity.Exam.ExamEntity>().ReverseMap();
        }
    }
}
