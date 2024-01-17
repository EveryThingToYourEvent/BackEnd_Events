using AutoMapper;
using DTO_Entities;
using DTO_Entities.Repository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Action.classes;
using BLL.ILogicAction;
using DAL.Action.interfaces;

namespace BLL.LogicActions
{
    public class EventToProviderBL: IEventToProviderBL
    {
        static IMapper _Mapper;

        IEventToProviderAction _eventToProviderAction;
        public EventToProviderBL(IEventToProviderAction eventToProvider)
        {
            _eventToProviderAction = eventToProvider;
        }

        // שליפת רשימת אירועים לספק
        public List<EventToProviderDTO> GetAllEventToProvider()
        {
            List<EventToProviderDTO> listEventToProviderDTO = new List<EventToProviderDTO>();
            List<EventToProviderTbl> listEventToProviderTbls = _eventToProviderAction.GetAllEventToProvider();
            foreach (EventToProviderTbl eventToProviderTbl in listEventToProviderTbls)
            {
                EventToProviderDTO eventToProviderDTO = _Mapper.Map<EventToProviderTbl, EventToProviderDTO>(eventToProviderTbl);
                listEventToProviderDTO.Add(eventToProviderDTO);
            }
            return listEventToProviderDTO;
        }

        //שליפת אירוע לספק לפי הקוד של הספק
        public List<EventToProviderDTO> GetEventsToProviderID(int id)
        {
            List<EventToProviderDTO> listEventsToProviderDTOID = new List<EventToProviderDTO>();
            List<EventToProviderTbl> listEventToProviderTblsID = _eventToProviderAction.GetEventsToProviderID(id);
            foreach (EventToProviderTbl eventToProviderTbl in listEventToProviderTblsID)
            {
                EventToProviderDTO eventToProviderDTO = _Mapper.Map<EventToProviderTbl, EventToProviderDTO>(eventToProviderTbl);
                listEventsToProviderDTOID.Add(eventToProviderDTO);
            }
            return listEventsToProviderDTOID;
        }

        //הוספת אירועים לרשימת אירועים לספקים
        public List<EventToProviderDTO> AddNewEventToProvider(EventToProviderDTO e)
        {
            _eventToProviderAction.AddNewEventToProvider(_Mapper.Map<EventToProviderDTO,EventToProviderTbl>(e));
            return GetAllEventToProvider();
        }

        // מחיקת אירוע לספק
        public List<EventToProviderDTO> DeleteEventToProvider(int id)
        {
            _eventToProviderAction.DeleteEventToProvider(id); 
            return GetAllEventToProvider();
        }

        // עדכון אירוע לספק
        public List<EventToProviderDTO> UpdateEventToProvider(int id, EventToProviderDTO e)
        {
            _eventToProviderAction.UpdateEventToProvider(id, _Mapper.Map<EventToProviderDTO, EventToProviderTbl>(e));
            return GetAllEventToProvider();
        }
        static EventToProviderBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMap>();

            });
            _Mapper = config.CreateMapper();
        }
    }
}
