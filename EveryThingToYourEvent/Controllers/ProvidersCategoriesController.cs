using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL.LogicActions;
using BLL.ILogicAction;
using DTO_Entities.Repository;

namespace EveryThingToYourEvent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvidersCategoriesController : ControllerBase
    {
        private readonly IProvidersCategoriesBL _providersCategoriesBL;

        public ProvidersCategoriesController(IProvidersCategoriesBL providersCategoriesBL)
        {
            _providersCategoriesBL = providersCategoriesBL;
        }

        // שליפת כל קטגוריות בעלי המקצוע
        [HttpGet("GetAllProvidersCategories")]
        public IActionResult GetAllProvidersCategories()
        {
            return Ok(_providersCategoriesBL.GetAllProvidersCategories());
        }

        // הוספת קטגוריה חדשה
        [HttpPost("AddNewProvidersCategory")]
        public IActionResult AddNewProvidersCategory([FromBody] ProvidersCategoriesDTO p)
        {
            return Ok(_providersCategoriesBL.AddNewProvidersCategory(p));
        }

        // מחיקת קטגוריה לפי קוד קטגוריה
        [HttpDelete("DeleteProviderCategory/{id}")]
        public IActionResult DeleteProviderCategory(int id)
        {
            return Ok(_providersCategoriesBL.DeleteProvidersCategory(id));
        }

        // עדכון קטגוריה לפי קוג קטגוריה 
        [HttpPut("UpdateProviderCategory/{id}")]
        public IActionResult UpdateProviderCategory(int id, [FromBody] ProvidersCategoriesDTO p)
        {
            return Ok(_providersCategoriesBL.UpdateProvidersCategory(id, p));
        }
    }
}
