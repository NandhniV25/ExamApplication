using NiVeTech.ExamEntity.Data;
using NiVeTech.ExamEntity.Entity.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiVeTech.ExamRepository.Option
{
    public class OptionRepository : IOptionRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public OptionRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int CreateOption(OptionEntity option)
        {
            _dbContext.Options.Add(option);
            _dbContext.SaveChanges();
            return option.Id;
        }

        public void DeleteOptionById(int optionId)
        {
            _dbContext.Options.Remove(GetOptionById(optionId));
            _dbContext.SaveChanges();
        }

        public OptionEntity GetOptionById(int optionId)
        {
            return _dbContext.Options.FirstOrDefault(c => c.Id == optionId);
        }

        public List<OptionEntity> GetOptionList()
        {
            return _dbContext.Options.ToList();
        }

        public OptionEntity UpdateOption(OptionEntity option)
        {
            _dbContext.Options.Update(option);
            _dbContext.SaveChanges();
            return option;
        }
    }
}
