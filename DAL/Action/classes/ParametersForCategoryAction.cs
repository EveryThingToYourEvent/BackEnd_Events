using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Action.interfaces;

namespace DAL.Action.classes
{
    public class ParametersForCategoryAction : IParametersForCategoryAction
    {
        EverythingToYourEventContext _dbEveryThingToYourEvent;
        public ParametersForCategoryAction(EverythingToYourEventContext everyThingToYourEvent)
        {
            _dbEveryThingToYourEvent = everyThingToYourEvent;
        }

        // שליפת רשימת הפרמטרים לקטגוריה
        public List<ParametersForCategoryTbl> GetAllParametersForCategory()
        {
            return _dbEveryThingToYourEvent.ParametersForCategoryTbls.Where(p=>!p.ParamCisDelete).ToList();
        }

        // הוספת פרמטר לקטגוריה  
        public void AddParametersForCategory(ParametersForCategoryTbl parametersForCategory)
        {
            _dbEveryThingToYourEvent.ParametersForCategoryTbls.Add(parametersForCategory);
            _dbEveryThingToYourEvent.SaveChanges();
        }

        // מחיקת פרמטר לקטגוריה
        public void DeleteParametersForCategory(int id)
        {
            var parameterToDelete = _dbEveryThingToYourEvent.ParametersForCategoryTbls.FirstOrDefault(x => x.ParamCcode == id);
            if (parameterToDelete != null)
            {
                parameterToDelete.ParamCisDelete = true ;
                _dbEveryThingToYourEvent.SaveChanges();
            }
        }

        // עדכון פרמטר לקטגוריה
        public void UpdateParametersForCategory(int id, ParametersForCategoryTbl parametersForCategory)
        {
            var parameterToEdit = _dbEveryThingToYourEvent.ParametersForCategoryTbls.FirstOrDefault(x => x.ParamCcode == id);
            if (parameterToEdit != null)
            {
                parameterToEdit.ParamCcode = parametersForCategory.ParamCcode;
                parameterToEdit.Pccode = parametersForCategory.Pccode;
                parameterToEdit.ParamCname = parametersForCategory.ParamCname;
                parameterToEdit.ParamCtype = parametersForCategory.ParamCtype;

                _dbEveryThingToYourEvent.SaveChanges();
            }
        }
    }
}
