using AutoMapper;
using NiVeTech.ExamApi.Models.Options;
using NiVeTech.ExamEntity.Entity.Option;
using NiVeTech.ExamEntity.Migrations;
using NiVeTech.ExamRepository.Option;

namespace NiVeTech.ExamApi.Services.Option
{
    public class OptionService : IOptionService
    {
        public IOptionRepository _optionRepository { get; set; }
        public IMapper _mapper { get; set; }
        public OptionService(IOptionRepository optionRepository, IMapper mapper)
        {
            _optionRepository = optionRepository;
            _mapper = mapper;
        }
        public int CreateOption(CreateOptionModel option)
        {
            return _optionRepository.CreateOption(_mapper.Map<OptionEntity>(option));
        }

        public string DeleteOptionById(int optionId)
        {
            try
            {
                _optionRepository.DeleteOptionById(optionId);
                return "Deleted Successfully";
            }
            catch (Exception ex)
            {
                return "Error while deleting...";
            }
        }

        public OptionModel GetOptionById(int optionId)
        {
            return _mapper.Map<OptionModel>(_optionRepository.GetOptionById(optionId));
        }

        public List<OptionModel> GetOptionList()
        {
            return _mapper.Map<List<OptionModel>>(_optionRepository.GetOptionList());
        }

        public OptionModel updateOption(OptionModel option)
        {
            var inputOptionEntity = _mapper.Map<OptionEntity>(option);
            var optionEntity = _optionRepository.UpdateOption(inputOptionEntity);
            var updatedOptionModel = _mapper.Map<OptionModel>(optionEntity);
            return updatedOptionModel;
        }
    }
}
