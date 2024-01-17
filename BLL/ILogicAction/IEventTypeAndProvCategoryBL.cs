using DTO_Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.ILogicAction
{
    public interface IEventTypeAndProvCategoryBL
    {
        // שליפת רשימת קשרי הגומלין המקשרת בין רשימת סוגי האירוע לקטגוריות ולהפך
        public List<EventTypeAndProvCategotyDTO> GetAllEventTypeAndProvCategoty(); 

        // הוספת עמודה חדשה המקשרת סוג אירוע לקטגוריה מסוימת ולהפך
        public List<EventTypeAndProvCategotyDTO> AddNewEventTypeAndProvCategoty(EventTypeAndProvCategotyDTO e);

        // מחיקת עמודה ע"פ קוד 
        public List<EventTypeAndProvCategotyDTO> DeleteEventTypeAndProvCategoty(int id);
        
        // עדכון רשומה בטבלה המקשרת
        public List<EventTypeAndProvCategotyDTO> UpdateEventTypeAndProvCategoty(int id, EventTypeAndProvCategotyDTO e);
    }
}
