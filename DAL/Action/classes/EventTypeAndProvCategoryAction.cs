using DAL.Action.interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Action.classes
{
    public class EventTypeAndProvCategoryAction : IEventTypeAndProvCategoryAction
    {
        EverythingToYourEventContext _dbEveryThingToYourEvent;

        public EventTypeAndProvCategoryAction(EverythingToYourEventContext dbEveryThingToYourEvent)
        {
            _dbEveryThingToYourEvent = dbEveryThingToYourEvent;
        }


        // שליפת רשימת קשרי הגומלין המקשרת בין רשימת סוגי האירוע לקטגוריות ולהפך
        public List<EventTypeAndProvCategotyTbl> GetAllEventTypeAndProvCategoty()
        {
            return _dbEveryThingToYourEvent.EventTypeAndProvCategotyTbls.ToList();
        }

        // עדכון רשומה בטבלה המקשרת
        public void UpdateEventTypeAndProvCategoty(int id, EventTypeAndProvCategotyTbl eventTypeAndProvCategoty)
        {
            var eventToEdit = _dbEveryThingToYourEvent.EventTypeAndProvCategotyTbls.FirstOrDefault(x => x.EventTypeProvcode == id);
            if (eventToEdit != null)
            {
                eventToEdit.EventTypeProvcode = eventTypeAndProvCategoty.EventTypeProvcode;
                eventToEdit.EventTypeCode = eventTypeAndProvCategoty.EventTypeCode;
                eventToEdit.Pccode = eventTypeAndProvCategoty.Pccode;
                _dbEveryThingToYourEvent.SaveChanges();
            }
        }

        // הוספת עמודה חדשה המקשרת סוג אירוע לקטגוריה מסוימת ולהפך
        public void AddEventTypeAndProvCategoty(EventTypeAndProvCategotyTbl eventTypeAndProvCategoty)
        {
            _dbEveryThingToYourEvent.EventTypeAndProvCategotyTbls.Add(eventTypeAndProvCategoty);
            _dbEveryThingToYourEvent.SaveChanges();
        }

        // מחיקת עמודה ע"פ קוד 
        public void DeleteEventTypeAndProvCategoty(int id)
        {
            var eventToDelete = _dbEveryThingToYourEvent.EventTypeAndProvCategotyTbls.FirstOrDefault(x => x.EventTypeProvcode == id);
            if (eventToDelete != null)
            {
                _dbEveryThingToYourEvent.EventTypeAndProvCategotyTbls.Remove(eventToDelete);
                _dbEveryThingToYourEvent.SaveChanges();
            }
        }

    }
}
