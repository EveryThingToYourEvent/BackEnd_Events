using DAL.Action.interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Action.classes
{
    public class EventToProviderAction: IEventToProviderAction
    {
        EverythingToYourEventContext _dbEveryThingToYourEvent;

        public EventToProviderAction(EverythingToYourEventContext dbEveryThingToYourEvent)
        {
          _dbEveryThingToYourEvent = dbEveryThingToYourEvent;
        }

        // שליפת רשימת אירועים לספק
        public List<EventToProviderTbl> GetAllEventToProvider()
        {
            return _dbEveryThingToYourEvent.EventToProviderTbls.Where(ep=>!ep.EpisDelete).ToList();
        }

        //שליפת אירוע לספק לפי הקוד של הספק
        public List<EventToProviderTbl> GetEventsToProviderID(int id)
        {
            var a= _dbEveryThingToYourEvent.EventToProviderTbls.Where(ep => !ep.EpisDelete && ep.ProvCode == id).ToList();
            return a;
        
        }

        //הוספת אירועים לרשימת אירועים לספקים
        public void AddNewEventToProvider(EventToProviderTbl e)
        {
            _dbEveryThingToYourEvent.EventToProviderTbls.Add(e);
            _dbEveryThingToYourEvent.SaveChanges();
        }

        // מחיקת אירוע לספק
        public void DeleteEventToProvider(int id)
        {
            var eventToProviderDelete=_dbEveryThingToYourEvent.EventToProviderTbls.FirstOrDefault(e=>e.Epcode == id);
            if (eventToProviderDelete != null)
            {
                eventToProviderDelete.EpisDelete=true;
                _dbEveryThingToYourEvent.SaveChanges();
            }

        }

        // עדכון אירוע לספק לפי קוד אירוע לספק
        public void UpdateEventToProvider(int id, EventToProviderTbl e)
        {
            var eventToProviderUpdate=_dbEveryThingToYourEvent.EventToProviderTbls.FirstOrDefault(e =>e.Epcode == id);
            if (eventToProviderUpdate != null)
            {
                eventToProviderUpdate.Epdate = e.Epdate;
                eventToProviderUpdate.Epname=e.Epname;  
                eventToProviderUpdate.Epstatus= e.Epstatus;
                eventToProviderUpdate.Epnotes= e.Epnotes;   
                eventToProviderUpdate.EpisDelete=e.EpisDelete;
                eventToProviderUpdate.EpwholeDay= e.EpwholeDay;
                eventToProviderUpdate.ProvCode = e.ProvCode;
                eventToProviderUpdate.UserId= e.UserId;
                _dbEveryThingToYourEvent.SaveChanges() ;
            }
        }

        
    }
}
