using DAL.Models;
using DTO_Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ILogicAction
{
    public interface IEventToProviderBL
    {
        // שליפת רשימת אירועים לספק
        public List<EventToProviderDTO> GetAllEventToProvider();

        //שליפת אירוע לספק לפי הקוד של הספק
         public List<EventToProviderDTO> GetEventsToProviderID(int id);

        //הוספת אירועים לרשימת אירועים לספקים
        public List<EventToProviderDTO> AddNewEventToProvider(EventToProviderDTO e);

        // מחיקת אירוע לספק
        public List<EventToProviderDTO> DeleteEventToProvider(int id);

        // עדכון אירוע לספק
        public List<EventToProviderDTO> UpdateEventToProvider(int id, EventToProviderDTO e);
       
    }
}
