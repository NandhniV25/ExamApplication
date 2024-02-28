using NiVeTech.ExamEntity.Entity.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiVeTech.ExamRepository.Option
{
    public interface IOptionRepository
    {
        int CreateOption(OptionEntity option);
        List<OptionEntity> GetOptionList();
        OptionEntity GetOptionById(int optionId);
        OptionEntity UpdateOption(OptionEntity option);
        void DeleteOptionById(int optionId);
    }
}
