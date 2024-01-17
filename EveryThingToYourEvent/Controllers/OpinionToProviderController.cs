using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL.LogicActions;
using BLL.ILogicAction;
using DAL.Models;
using DTO_Entities.Repository;

namespace EveryThingToYourEvent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpinionToProviderController : ControllerBase
    {
        private readonly IOpinionToProviderBL _opinionBl;

        public OpinionToProviderController (IOpinionToProviderBL opinionBl)
        {
            _opinionBl = opinionBl;
        }

        // שליפת כל חוות הדעת
        [HttpGet("GetAllOpinionToProvider")]
        public IActionResult GetAllOpinionToProvider()
        {
            return Ok(_opinionBl.GetAllOpinionsToProvider());
        }

        // שליפת חוות דעת של ספק מסוים לפי קוד ספק
        [HttpGet("GetOpinionToProviderByProvCode/{provCode}")]
        public IActionResult GetOpinionToProviderByProvCode(int provCode)
        {
            return Ok(_opinionBl.GetOpinionToProviderByProvId(provCode));
        }

        // הוספת חוות דעת חדשה
        [HttpPost("AddNewOpinionToProvider")]
        public IActionResult AddNewOpinionToProvider([FromBody] OpinionToProviderDTO e)
        {
            return Ok(_opinionBl.AddNewOpinionToProvider(e));
        }

        //מחיקת חוות דעת לפי קוד חוות הדעת
        [HttpDelete("DeleteOpinionToProvider/{id}")]
        public IActionResult DeleteOpinionToProvider(int id)
        {
            return Ok(_opinionBl.DeleteOpinionToProvider(id));
        }

        // עדכון חוות דעת מסוימת
        [HttpPut("UpdateOpinionToProvider/{id}")]
        public IActionResult UpdateOpinionToProvider(int id, [FromBody] OpinionToProviderDTO e)
        {
            return Ok(_opinionBl.UpdateOpinionToProvider(id, e));
        }
    }


}
