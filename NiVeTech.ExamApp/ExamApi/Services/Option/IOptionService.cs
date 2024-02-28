using NiVeTech.ExamApi.Models.Options;

namespace NiVeTech.ExamApi.Services.Option
{
    public interface IOptionService
    {
        int CreateOption(CreateOptionModel option);
        List<OptionModel> GetOptionList();
        OptionModel GetOptionById(int optionId);
        OptionModel updateOption(OptionModel option);
        string DeleteOptionById(int optionId);
    }
}
