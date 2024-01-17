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
    public class EventTypeAndProvCategotyController : ControllerBase
    {
        private readonly IEventTypeAndProvCategoryBL _eventTypeAndProvCategoryBL;
        public EventTypeAndProvCategotyController(IEventTypeAndProvCategoryBL eventTypeAndProvCategoryBL)
        {
            _eventTypeAndProvCategoryBL = eventTypeAndProvCategoryBL;
        }

        // שליפת רשימת קשרי הגומלין המקשרת בין רשימת סוגי האירוע לקטגוריות ולהפך
        [HttpGet("GetAllEventTypeAndProvCategoty")]
        public IActionResult GetAllEventTypeAndProvCategoty()
        {
            return Ok(_eventTypeAndProvCategoryBL.GetAllEventTypeAndProvCategoty());
        }

        // הוספת עמודה חדשה המקשרת סוג אירוע לקטגוריה מסוימת ולהפך
        [HttpPost("AddNewEventToProvider")]
        public IActionResult AddNewEventTypeAndProvCategoty([FromBody] EventTypeAndProvCategotyDTO e)
        {
            return Ok(_eventTypeAndProvCategoryBL.AddNewEventTypeAndProvCategoty(e));
        }

        // מחיקת עמודה ע"פ קוד 
        [HttpDelete("DeleteEventTypeAndProvCategoty/{id}")]
        public IActionResult DeleteEventTypeAndProvCategoty(int id)
        {
            return Ok(_eventTypeAndProvCategoryBL.DeleteEventTypeAndProvCategoty(id));
        }

        // עדכון רשומה בטבלה המקשרת
        [HttpPut("UpdateEventTypeAndProvCategoty/{id}")]
        public IActionResult UpdateEventTypeAndProvCategoty(int id, [FromBody] EventTypeAndProvCategotyDTO e)
        {
            return Ok(_eventTypeAndProvCategoryBL.UpdateEventTypeAndProvCategoty(id, e));
        }
    }
}
