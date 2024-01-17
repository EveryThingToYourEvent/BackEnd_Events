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
    public class ProviderController : ControllerBase
{
        private readonly IProvidersBL _providerBL;

        public ProviderController(IProvidersBL providerBL)
        {
            _providerBL = providerBL;
        }

        // שליפת רשימת הספקים
        [HttpGet("GetAllProviders")]
        public IActionResult GetAllProviders()
        {
            return Ok(_providerBL.GetAllProviders());
        }

        // שליפת כל הספקים המאושרים ע"י המנהל
        [HttpGet("GetAllProvidersConfirm")]
        public IActionResult GetAllProvidersConfirm()
        {
            return Ok(_providerBL.GetAllProvidersConfirm());
        }

        // שליפת הספקים שלא אושרו עדיין ע"י המנהל
        [HttpGet("GetAllProviderNotConfirm")]
        public IActionResult GetAllProviderNotConfirm()
        {
            return Ok(_providerBL.GetAllProviderNotConfirm());
        }

        // שליפת ספק מסוים לפי קוד ספק
        [HttpGet("GetProviderByCode/{code}")]
        public IActionResult GetProviderById(int code)
        {
            return Ok(_providerBL.GetProviderById(code));
        }

        // הוספת ספק חדש לרשימת הספקים
        [HttpPost("AddNewProvider")]
        public IActionResult AddNewProvider([FromBody] ProvidersDTO p)
        {
            return Ok(_providerBL.AddNewProvider(p));
        }

        // מחיקת ספק מרשימת הספקים לפי קוד ספק
        [HttpDelete("DeleteProvider/{id}")]
        public IActionResult DeleteProvider(int id)
        {
            return Ok(_providerBL.DeleteProvider(id));
        }

        // עדכון ספק מסוים לפי קוד הספק
        [HttpPut("UpdateProvider/{id}")]
        public IActionResult UpdateProvider(int id, [FromBody] ProvidersDTO p)
        {
            return Ok(_providerBL.UpdateProvider(id, p));
        }


        // עדכון ספק מסוים שקשור לקטגוריה שעדיין לא נמצאת במערכת 
        // לאחר הוספת הקטגוריה החדשה שספק זה קשור אליה
        // עדכון הספק לכך שיהיה מקושר לקטגוריה החדשה שנוספה
        [HttpGet("UpdatePCcode/{provCode}/{PCcode}")]
        public IActionResult UpdatePCcode(int provCode, int PCcode)
        {
            return Ok(_providerBL.UpdatePCcode(provCode, (short)PCcode));
        }
    }



}
