using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NiVeTech.ExamApi.Models.Options;
using NiVeTech.ExamApi.Services.Option;

namespace NiVeTech.ExamApi.Controllers.Option
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionController : ControllerBase
    {
        public IOptionService _optionService { get; set; }
        public OptionController(IOptionService optionService)
        {
            _optionService = optionService;
        }
        [HttpPost]
        public ActionResult<int> CreateOption(CreateOptionModel option)
        {
            return _optionService.CreateOption(option);
        }
        [HttpGet]
        public ActionResult<List<OptionModel>> GetOptionList()
        {
            return _optionService.GetOptionList();
        }
        //[HttpGet("{id:int}")]
        //public ActionResult<OptionModel> GetOptionById(int id)
        //{
        //    return _optionService.GetOptionById(id);
        //}
        //[HttpPut]
        //public ActionResult<OptionModel> UpdateOption(OptionModel option)
        //{
        //    return _optionService.updateOption(option);
        //}
        [HttpDelete("{id:int}")]
        public ActionResult<string> DeleteOptionById(int id)
        {
            return _optionService.DeleteOptionById(id);
        }
    }
}
