using DTO_Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ILogicAction
{
    public interface IParametersForCategoryBL
    {
        // שליפת רשימת הפרמטרים לקטגוריה
        public List<ParametersForCategoryDTO> GetAllParametersForCategory();

        // הוספת פרמטר לקטגוריה  
        public List<ParametersForCategoryDTO> AddNewParameterForCategory(ParametersForCategoryDTO p);

        // מחיקת פרמטר לקטגוריה
        public List<ParametersForCategoryDTO> DeleteParameterForCategory(int id);

        // עדכון פרמטר לקטגוריה
        public List<ParametersForCategoryDTO> UpdateParameterForCategory(int id, ParametersForCategoryDTO p);
    }
}
