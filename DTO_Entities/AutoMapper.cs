using AutoMapper;
using DAL.Models;
using DTO_Entities.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Entities
{
    public class AutoMap : AutoMapper.Profile
    {
        public AutoMap()
        {
            EverythingToYourEventContext everythingToYourEventContextDB = new EverythingToYourEventContext();

            CreateMap<EventToProviderTbl, EventToProviderDTO>()
                .ForMember(dest => dest.backgroundColor, opt => opt.MapFrom(src =>
                 src.Epstatus == "נקבע" ? "red" : src.Epstatus == "אושר" ? "green" : "yellow"))
                .ForMember(dest => dest.title, opt => opt.MapFrom(src => src.Epname))
                .ForMember(dest => dest.start, opt => opt.MapFrom(src =>src.Epdate))
                .ForMember(dest => dest.allDay, opt => opt.MapFrom(src =>
                 src.EpwholeDay == "כן"?true: src.EpwholeDay=="לא"?false:true));

            CreateMap<EventToProviderDTO, EventToProviderTbl>();

            CreateMap<EventTypeAndProvCategotyTbl, EventTypeAndProvCategotyDTO>();
            CreateMap<EventTypeAndProvCategotyDTO, EventTypeAndProvCategotyTbl>();

            CreateMap<EventTypeTbl, EventTypeDTO>();
            CreateMap<EventTypeDTO, EventTypeTbl>();

            CreateMap<OpinionToProviderTbl, OpinionToProviderDTO>();
            CreateMap<OpinionToProviderDTO, OpinionToProviderTbl>();

            CreateMap<ParametersForCategoryTbl, ParametersForCategoryDTO>();
            CreateMap<ParametersForCategoryDTO, ParametersForCategoryTbl>();

            CreateMap<ProvidersCategoriesTbl, ProvidersCategoriesDTO>();
            CreateMap<ProvidersCategoriesDTO, ProvidersCategoriesTbl>();

            CreateMap<ProvidersTbl, ProvidersDTO>();
            CreateMap<ProvidersDTO, ProvidersTbl>();

            CreateMap<UsersTbl, UsersDTO>();
            CreateMap<UsersDTO, UsersTbl>();
        }
    }
}
