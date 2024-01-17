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
    public class EventTypeController : ControllerBase
    {
        private readonly IEventTypeBL _eventTypeBL;
        public EventTypeController(IEventTypeBL eventTypeBL)
        {
            _eventTypeBL = eventTypeBL;
        }

        // שליפת כל סוגי האירוע
        [HttpGet("GetAllEventType")]
        public IActionResult GetAllEventType()
        {
            return Ok(_eventTypeBL.GetAllEventType());
        }

        // הוספת סוג אירוע
        [HttpPost("AddNewEventType")]
        public IActionResult AddNewEventType([FromBody] EventTypeDTO e)
        {
            return Ok(_eventTypeBL.AddNewEventType(e));
        }

        // מחיקת סוג אירוע
        [HttpDelete("DeleteEventType/{id}")]
        public IActionResult DeleteEventType(int id)
        {
            return Ok(_eventTypeBL.DeleteEventType(id));
        }

        // עדכון סוג אירוע
        [HttpPut("UpdateEventType/{id}")]
        public IActionResult UpdateEventType(int id, [FromBody] EventTypeDTO e)
        {
            return Ok(_eventTypeBL.UpdateEventType(id, e));
        }
    }
}
