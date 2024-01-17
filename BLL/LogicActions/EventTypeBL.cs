using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Models;
using DTO_Entities.Repository;
using DTO_Entities;
using DAL.Action.classes;
using BLL.ILogicAction;
using DAL.Action.interfaces;

namespace BLL.LogicActions
{
    public class EventTypeBL: IEventTypeBL
    {
        static IMapper _Mapper;
        IEventTypeAction _eventTypeAction;

        public EventTypeBL(IEventTypeAction eventTypeAction)
        {
            _eventTypeAction = eventTypeAction;
        }

        // שליפת כל סוגי האירוע
        public List<EventTypeDTO> GetAllEventType()
        {
            List<EventTypeDTO> listEventTypeDTO = new List<EventTypeDTO>();

            List<EventTypeTbl> listEventTypeTbl = _eventTypeAction.GetAllEventType();
            foreach (EventTypeTbl eventTypeTbl in listEventTypeTbl)
            {
                EventTypeDTO eventTypeDTO = _Mapper.Map<EventTypeTbl, EventTypeDTO>(eventTypeTbl);
                listEventTypeDTO.Add(eventTypeDTO);
            }
            return listEventTypeDTO;
        }

        // הוספת סוג אירוע
        public List<EventTypeDTO> AddNewEventType(EventTypeDTO eventTypeDTO)
        {
            _eventTypeAction.AddNewEventType(_Mapper.Map<EventTypeDTO,EventTypeTbl>(eventTypeDTO));
            return GetAllEventType();
        }

        // מחיקת סוג אירוע
        public List<EventTypeDTO> DeleteEventType(int id)
        {
            _eventTypeAction.DeleteEventType(id);
            return GetAllEventType();
        }

        // עדכון סוג אירוע
        public List<EventTypeDTO> UpdateEventType(int id, EventTypeDTO eventTypeDTO)
        {
            _eventTypeAction.UpdateEventType(id,_Mapper.Map<EventTypeDTO,EventTypeTbl>(eventTypeDTO));
            return GetAllEventType();
        }

        static EventTypeBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMap>();

            });
            _Mapper = config.CreateMapper();
        }
    }
}
