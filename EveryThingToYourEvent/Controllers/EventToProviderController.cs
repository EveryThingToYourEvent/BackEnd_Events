using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL.LogicActions;
using BLL.ILogicAction;
using DTO_Entities.Repository;

namespace EveryThingToYourEvent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventToProviderController : ControllerBase
    {
        private readonly IEventToProviderBL _eventToProviderBL;
        public EventToProviderController(IEventToProviderBL eventToProviderBL)
        {
            _eventToProviderBL = eventToProviderBL;
        }

        // שליפת רשימת אירועים לספק
        [HttpGet("GetAllEventToProvider")]
        public IActionResult GetAllEventToProvider()
        {
            return Ok(_eventToProviderBL.GetAllEventToProvider());
        }

        //שליפת אירוע לספק לפי הקוד של הספק
        [HttpGet("GetEventsToProviderById/{id}")]
        public IActionResult GetEventsToProviderById(int id)
        {
            
            return Ok(_eventToProviderBL.GetEventsToProviderID(id));
        }

        //הוספת אירועים לרשימת אירועים לספקים
        [HttpPost("AddNewEventToProvider")]
        public IActionResult AddNewEventToProvider([FromBody] EventToProviderDTO e)
        {
            return Ok(_eventToProviderBL.AddNewEventToProvider(e)); 
        }

        // מחיקת אירוע לספק
        [HttpDelete("DeleteEventToProvider/{id}")]
        public IActionResult DeleteEventToProvider(int id)
        {
            return Ok(_eventToProviderBL.DeleteEventToProvider(id));
        }

        // עדכון אירוע לספק
        [HttpPut("UpdateEventToProvider/{id}")]
        public IActionResult UpdateEventToProvider(int id, [FromBody] EventToProviderDTO e) 
        {
            return Ok(_eventToProviderBL.UpdateEventToProvider(id, e));
        } 
    }
}
