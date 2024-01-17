using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Action.interfaces
{
    public interface IEventTypeAction
    {
        // שליפת כל סוגי האירוע
        public List<EventTypeTbl> GetAllEventType();

        // הוספת סוג אירוע
        public void AddNewEventType(EventTypeTbl eventType);

        // מחיקת סוג אירוע
        public void DeleteEventType(int id);

        // עדכון סוג אירוע
        public void UpdateEventType(int id, EventTypeTbl eventType);
    }
}
