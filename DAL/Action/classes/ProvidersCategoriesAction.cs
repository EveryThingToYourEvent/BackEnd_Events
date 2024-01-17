using DAL.Action.interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Action.classes
{
    public class ProvidersCategoriesAction:IProvidersCategoriesAction
    {

        EverythingToYourEventContext _everythingToYourEventContext;

        public ProvidersCategoriesAction(EverythingToYourEventContext everythingToYourEventContext)
        {
            _everythingToYourEventContext = everythingToYourEventContext;
        }

        // שליפת רשימת הקטגוריות
        public List<ProvidersCategoriesTbl> GetAllProvidersCategories()
        {
            return _everythingToYourEventContext.ProvidersCategoriesTbls.Where(pc=>!pc.PcisDelete).ToList();
        }

        // הוספה לרשימת הקטגוריות
        public void AddProvidersCategory(ProvidersCategoriesTbl providersCategory)
        {
            _everythingToYourEventContext.ProvidersCategoriesTbls.Add(providersCategory);
            _everythingToYourEventContext.SaveChanges();
        }

        // מחיקה מרשימת הקטגוריות
        public void DeleteProvidersCategory(int id)
        {
            var provCatToDelete = _everythingToYourEventContext.ProvidersCategoriesTbls.FirstOrDefault(x => x.Pccode == id);
            if(provCatToDelete != null)
                provCatToDelete.PcisDelete = true;
            _everythingToYourEventContext.SaveChanges();
        }

        // עדכון קטגוריה מסוימת לפי קוד קטגוריה
        public void UpdateProvidersCategory(int id, ProvidersCategoriesTbl providersCategory)
        {
            var provCatToDelete = _everythingToYourEventContext.ProvidersCategoriesTbls.FirstOrDefault(x => x.Pccode == id);
            if (provCatToDelete != null)
            {
                provCatToDelete.Pcname = providersCategory.Pcname;
            }
                
            _everythingToYourEventContext.SaveChanges();
        }
    }
}
