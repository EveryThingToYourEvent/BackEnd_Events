using AutoMapper;
using DAL.Models;
using DTO_Entities;
using DTO_Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Action.classes;
using DAL.Action.interfaces;
using BLL.ILogicAction;

namespace BLL.LogicActions
{
    public class EventTypeAndProvCategotyBL : IEventTypeAndProvCategoryBL
    {
        static IMapper _Mapper;

        IEventTypeAndProvCategoryAction _eventTypeAndProvCategoryAction;
        public EventTypeAndProvCategotyBL(IEventTypeAndProvCategoryAction eventTypeAndProvCategory)
        {
            _eventTypeAndProvCategoryAction = eventTypeAndProvCategory;
        }

        // שליפת רשימת קשרי הגומלין המקשרת בין רשימת סוגי האירוע לקטגוריות ולהפך
        public List<EventTypeAndProvCategotyDTO> GetAllEventTypeAndProvCategoty()
        {
            List<EventTypeAndProvCategotyDTO> listEventAndProvDTO = new List<EventTypeAndProvCategotyDTO>();
            List<EventTypeAndProvCategotyTbl> listEventAndProvTbl = _eventTypeAndProvCategoryAction.GetAllEventTypeAndProvCategoty();
            foreach (EventTypeAndProvCategotyTbl eventAndProvTbl in listEventAndProvTbl)
            {
                EventTypeAndProvCategotyDTO eventAndProvDTO = _Mapper.Map<EventTypeAndProvCategotyTbl, EventTypeAndProvCategotyDTO>(eventAndProvTbl);
                listEventAndProvDTO.Add(eventAndProvDTO);
            }
            return listEventAndProvDTO;
        }

        // הוספת עמודה חדשה המקשרת סוג אירוע לקטגוריה מסוימת ולהפך
        public List<EventTypeAndProvCategotyDTO> AddNewEventTypeAndProvCategoty(EventTypeAndProvCategotyDTO e)
        {
            _eventTypeAndProvCategoryAction.AddEventTypeAndProvCategoty(_Mapper.Map<EventTypeAndProvCategotyDTO, EventTypeAndProvCategotyTbl>(e));
            return GetAllEventTypeAndProvCategoty();
        }

        // מחיקת עמודה ע"פ קוד 
        public List<EventTypeAndProvCategotyDTO> DeleteEventTypeAndProvCategoty(int id)
        {
            _eventTypeAndProvCategoryAction.DeleteEventTypeAndProvCategoty(id);
            return GetAllEventTypeAndProvCategoty();
        }

        // עדכון רשומה בטבלה המקשרת
        public List<EventTypeAndProvCategotyDTO> UpdateEventTypeAndProvCategoty(int id, EventTypeAndProvCategotyDTO e)
        {
            _eventTypeAndProvCategoryAction.UpdateEventTypeAndProvCategoty(id, _Mapper.Map<EventTypeAndProvCategotyDTO, EventTypeAndProvCategotyTbl>(e));
            return GetAllEventTypeAndProvCategoty();
        }

        static EventTypeAndProvCategotyBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMap>();
            });
            _Mapper = config.CreateMapper();
        }
    }
}
