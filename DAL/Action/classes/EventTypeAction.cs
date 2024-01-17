using DAL.Action.interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Action.classes
{
    public class EventTypeAction: IEventTypeAction
    {
        EverythingToYourEventContext _everyThingToYourEventContext;
        public EventTypeAction(EverythingToYourEventContext everyThingToYourEventContext)
        {
            _everyThingToYourEventContext = everyThingToYourEventContext;
        }

        // שליפת כל סוגי האירוע
        public List<EventTypeTbl> GetAllEventType()
        {
            return _everyThingToYourEventContext.EventTypeTbls.Where(e => !e.EventTypeIsDelete).ToList();
        }

        // הוספת סוג אירוע
        public void AddNewEventType(EventTypeTbl eventType)
        {
            _everyThingToYourEventContext.EventTypeTbls.Add(eventType);
            _everyThingToYourEventContext.SaveChanges();
        }

        // מחיקת סוג אירוע
        public void DeleteEventType(int id)
        {
            var eventTypeToDelete = _everyThingToYourEventContext.EventTypeTbls.FirstOrDefault(e=>e.EventTypeCode == id);
            if(eventTypeToDelete != null)
            {
                eventTypeToDelete.EventTypeIsDelete = true;
                _everyThingToYourEventContext.SaveChanges();
            }
        }

        // עדכון סוג אירוע
        public void UpdateEventType(int id, EventTypeTbl eventType)
        {
            var eventTpyeToEdit = _everyThingToYourEventContext.EventTypeTbls.FirstOrDefault(e=>e.EventTypeCode==id);
            if(eventTpyeToEdit != null)
            {
                eventTpyeToEdit.EventTypeName = eventType.EventTypeName;
                eventTpyeToEdit.EventTypeLogo = eventType.EventTypeLogo;
                eventTpyeToEdit.EventTypeIsDelete=eventType.EventTypeIsDelete;
                _everyThingToYourEventContext.SaveChanges();
            }
        }
}
}
