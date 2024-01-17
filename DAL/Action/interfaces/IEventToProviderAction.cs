using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Action.interfaces
{
    public interface IEventToProviderAction
    {
        // שליפת רשימת אירועים לספק
        public List<EventToProviderTbl> GetAllEventToProvider();

        //שליפת אירוע לספק לפי הקוד של הספק
        public List<EventToProviderTbl> GetEventsToProviderID(int id);

        //הוספת אירועים לרשימת אירועים לספקים
        public void AddNewEventToProvider(EventToProviderTbl e);

        // מחיקת אירוע לספק
        public void DeleteEventToProvider(int id);

        // עדכון אירוע לספק
        public void UpdateEventToProvider(int id, EventToProviderTbl e);
        
    }
}
