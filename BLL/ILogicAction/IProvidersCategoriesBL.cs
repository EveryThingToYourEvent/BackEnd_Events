using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Entities.Repository;

namespace BLL.ILogicAction
{
    public interface IProvidersCategoriesBL
    {
        // שליפת כל הקטגוריות
        public List<ProvidersCategoriesDTO> GetAllProvidersCategories();

        // הוספת קטגוריה חדשה לרשימת הקטגוריות
        public List<ProvidersCategoriesDTO> AddNewProvidersCategory(ProvidersCategoriesDTO p);

        // מחיקת קטגוריה מרשימת הקטגוריות
        public List<ProvidersCategoriesDTO> DeleteProvidersCategory(int id);

        // עדכון קטגוריה מסוימת לפי קוד קטגוריה
        public List<ProvidersCategoriesDTO> UpdateProvidersCategory(int id, ProvidersCategoriesDTO p);
    }
}
