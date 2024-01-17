using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Action.interfaces
{
    public interface IEventTypeAndProvCategoryAction
    {
        // שליפת רשימת קשרי הגומלין המקשרת בין רשימת סוגי האירוע לקטגוריות ולהפך
        public List<EventTypeAndProvCategotyTbl> GetAllEventTypeAndProvCategoty();

        // מחיקת עמודה ע"פ קוד 
        public void DeleteEventTypeAndProvCategoty(int id);

        // הוספת עמודה חדשה המקשרת סוג אירוע לקטגוריה מסוימת ולהפך
        public void AddEventTypeAndProvCategoty(EventTypeAndProvCategotyTbl eventTypeAndProvCategoty);

        // עדכון רשומה בטבלה המקשרת
        public void UpdateEventTypeAndProvCategoty(int id, EventTypeAndProvCategotyTbl eventTypeAndProvCategoty);
    }
}
