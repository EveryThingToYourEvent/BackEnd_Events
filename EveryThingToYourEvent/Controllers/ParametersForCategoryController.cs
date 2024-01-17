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
    public class ParametersForCategoryController : ControllerBase
    {
        private readonly IParametersForCategoryBL _parametersBl;
        public ParametersForCategoryController(IParametersForCategoryBL parametersBl)
        {
            _parametersBl = parametersBl;
        }

        // שליפת רשימת פרמטרים לקטגוריה   
        [HttpGet("GetAllParametersForCategory")]
        public IActionResult GetAllParametersForCategory()
        {
            return Ok(_parametersBl.GetAllParametersForCategory());
        }

        // הוספת פרמטר לקטגוריה מסוימת
        [HttpPost("AddNewParameterForCategory")]
        public IActionResult AddNewParameterForCategory([FromBody] ParametersForCategoryDTO p)
        {
            return Ok(_parametersBl.AddNewParameterForCategory(p));
        }

        // מחיקת פרמטר מקטגוריה מסוימת
        [HttpDelete("DeleteParameterForCategory/{id}")]
        public IActionResult DeleteParameterForCategory(int id)
        {
            return Ok(_parametersBl.DeleteParameterForCategory(id));
        }

        // עדכון פרמטר לקטגוריה לפי קוד הפרמטר
        [HttpPut("UpdateParameterForCategory/{id}")]
        public IActionResult UpdateParameterForCategory(int id, [FromBody] ParametersForCategoryDTO p)
        {
            return Ok(_parametersBl.UpdateParameterForCategory(id, p));
        }
    } 
}
