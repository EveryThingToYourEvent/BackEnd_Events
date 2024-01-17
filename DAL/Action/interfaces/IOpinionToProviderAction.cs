using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Action.interfaces
{
    public interface IOpinionToProviderAction
    {
        //שליפת כל החוות דעת
        public List<OpinionToProviderTbl> GetAllOpinionToProvider();

        // שליפת חוות דעת שנרשמו לספק מסוים
        public List<OpinionToProviderTbl> GetOpinionToProviderByProvId(int provId);

        // מחיקת חוות דעת לפי קוד 
        public void DeleteOpinionToProvider(int id); 
        
        // הוספת חוות דעת לרשימת חוות הדעת
        public void AddNewOpinionToProvider(OpinionToProviderTbl opinionToProvider);

        // עדכון חוות דעת מסוימת לפי קוד חוות הדעת
        public void UpdateOpinionToProvider(int id, OpinionToProviderTbl opinionToProvider);
    }
}
