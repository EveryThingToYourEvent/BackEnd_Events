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
    public class OpinionToProviderBL: IOpinionToProviderBL
    {
        static IMapper _Mapper;
        IOpinionToProviderAction _opinionToProviderAction;
        public OpinionToProviderBL(IOpinionToProviderAction opinionToProvider)
        {
            _opinionToProviderAction = opinionToProvider;
        }

        // שליפת כל חוות הדעת
        public List<OpinionToProviderDTO> GetAllOpinionsToProvider()
        {
            List<OpinionToProviderDTO> listOpinionToProviderDTO = new List<OpinionToProviderDTO>();
            List<OpinionToProviderTbl> listOpinionToProviderTbl = _opinionToProviderAction.GetAllOpinionToProvider();
            foreach (OpinionToProviderTbl opinionTbl in listOpinionToProviderTbl)
            {
                OpinionToProviderDTO opinionDTO = _Mapper.Map<OpinionToProviderTbl, OpinionToProviderDTO>(opinionTbl);
                listOpinionToProviderDTO.Add(opinionDTO);
            }
            return listOpinionToProviderDTO;
        }

        // שליפת חוות דעת לספק מסוים לפי קוד הספק הרצוי
        public List<OpinionToProviderDTO> GetOpinionToProviderByProvId(int provId)
        {
            List<OpinionToProviderDTO> listOpinionToProviderDTO = new List<OpinionToProviderDTO>();
            List<OpinionToProviderTbl> listOpinionToProviderTbl = _opinionToProviderAction.GetOpinionToProviderByProvId(provId);
            foreach (OpinionToProviderTbl opinionTbl in listOpinionToProviderTbl)
            {
                OpinionToProviderDTO opinionDTO = _Mapper.Map<OpinionToProviderTbl, OpinionToProviderDTO>(opinionTbl);
                listOpinionToProviderDTO.Add(opinionDTO);
            }
            return listOpinionToProviderDTO;
        }

        // הוספת חוות דעת נוספת לרשימת חוות הדעת
        public List<OpinionToProviderDTO> AddNewOpinionToProvider(OpinionToProviderDTO o)
        {
            _opinionToProviderAction.AddNewOpinionToProvider(_Mapper.Map<OpinionToProviderDTO, OpinionToProviderTbl>(o));
            return GetAllOpinionsToProvider();
        }

        // מחיקת חוות דעת לפי קוד 
        public List<OpinionToProviderDTO> DeleteOpinionToProvider(int id)
        {
            _opinionToProviderAction.DeleteOpinionToProvider(id);
            return GetAllOpinionsToProvider();
        }

        // עדכון חוות דעת מסוימת
        public List<OpinionToProviderDTO> UpdateOpinionToProvider(int id, OpinionToProviderDTO o)
        {
            _opinionToProviderAction.UpdateOpinionToProvider(id, _Mapper.Map<OpinionToProviderDTO, OpinionToProviderTbl>(o));
            return GetAllOpinionsToProvider();
        }

        static OpinionToProviderBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<EventGuestsTbl,EventGuestsDTO>();
                cfg.AddProfile<AutoMap>();

            });
            _Mapper = config.CreateMapper();
        }
    }
}
