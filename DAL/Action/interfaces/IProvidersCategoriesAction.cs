using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Action.interfaces
{
    public interface IProvidersCategoriesAction
    {
        // שליפת רשימת הקטגוריות
        public List<ProvidersCategoriesTbl> GetAllProvidersCategories();

        // מחיקה מרשימת הקטגוריות
        public void DeleteProvidersCategory(int id);

        // הוספה לרשימת הקטגוריות
        public void AddProvidersCategory(ProvidersCategoriesTbl providersCategory);

        // עדכון קטגוריה מסוימת לפי קוד קטגוריה
        public void UpdateProvidersCategory(int id, ProvidersCategoriesTbl providersCategory);

    }
}
