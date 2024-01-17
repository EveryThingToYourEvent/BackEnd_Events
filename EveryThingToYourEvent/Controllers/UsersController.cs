using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL.LogicActions;
using BLL.ILogicAction;
using DTO_Entities.Repository;

namespace EveryThingToYourEvent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersBL _userBL;

        public UsersController(IUsersBL userBL)
        {
            _userBL = userBL;
        }

        // שליפת רשימת המשתמשים
        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            return Ok(_userBL.GetAllUsers());
        }

        // הוספה לרשימת המשתמשים
        [HttpPost("AddNewUser")]
        public IActionResult AddNewUser([FromBody] UsersDTO user)
        {
            return Ok(_userBL.AddNewUser(user));
        }

        // מחיקת משתמש לפי קוד משתמש
        [HttpDelete("DeleteUser/{id}")]
        public IActionResult DeleteUser(string id)
        {
            return Ok(_userBL.DeleteUser(id));
        }

        // עדכון משתמש לפי קוד משתמש
        [HttpPut("UpdateUser/{id}")]
        public IActionResult UpdateUser(string id, [FromBody] UsersDTO user)
        {
            return Ok(_userBL.UpdateUser(id, user));
        }
    }
}
