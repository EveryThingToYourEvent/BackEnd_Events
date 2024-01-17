using DTO_Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ILogicAction
{
    public interface IEventTypeBL
    {
        // שליפת כל סוגי האירוע
        public List<EventTypeDTO> GetAllEventType();

        // הוספת סוג אירוע
        public List<EventTypeDTO> AddNewEventType(EventTypeDTO eventTypeDTO);

        // מחיקת סוג אירוע
        public List<EventTypeDTO> DeleteEventType(int id);

        // עדכון סוג אירוע
        public List<EventTypeDTO> UpdateEventType(int id, EventTypeDTO eventTypeDTO);
    }
}
