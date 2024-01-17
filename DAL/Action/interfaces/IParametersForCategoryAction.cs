using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Action.interfaces
{
    public interface IParametersForCategoryAction
    {
        // שליפת רשימת פרמטרים לקטגוריה
        public List<ParametersForCategoryTbl> GetAllParametersForCategory();
        
        // מחיקת פרמטר לקטגוריה לפי קוד הפרמטר
        public void DeleteParametersForCategory(int id);

        // הוספת פרמטר לקטגוריה
        public void AddParametersForCategory(ParametersForCategoryTbl parametersForCategory);

        // עדכון פרמטר לקטגוריה לפי קוד הפרמטר
        public void UpdateParametersForCategory(int id, ParametersForCategoryTbl parametersForCategory);
    }
}
