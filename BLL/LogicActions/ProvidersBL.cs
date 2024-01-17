using AutoMapper;
using DAL.Action.classes;
using DAL.Models;
using DTO_Entities;
using DTO_Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.ILogicAction;
using DAL.Action.interfaces;

namespace BLL.LogicActions
{
    public class ProvidersBL:IProvidersBL
    {
        static IMapper _Mapper;
        IProvidersAction _providerAction;

        public ProvidersBL(IProvidersAction providerAction)
        {
            _providerAction = providerAction;
        }

        // שליפת כל רשימת הספקים
        public List<ProvidersDTO> GetAllProviders()
        {
            List<ProvidersDTO> listProvidersDTO = new List<ProvidersDTO>();
            List<ProvidersTbl> listProvidersTbl = _providerAction.GetAllProviders();
            foreach (ProvidersTbl providersTbl in listProvidersTbl)
            {
                ProvidersDTO providersDTO = _Mapper.Map<ProvidersTbl, ProvidersDTO>(providersTbl);
                listProvidersDTO.Add(providersDTO);
            }
            return listProvidersDTO;
        }

        // שליפת כל הספקים שאושרו ע"י המנהל
        public List<ProvidersDTO> GetAllProvidersConfirm()
        {
            List<ProvidersDTO> listProvidersDTO = new List<ProvidersDTO>();
            List<ProvidersTbl> listProvidersTbl = _providerAction.GetAllProvidersConfirm();
            foreach (ProvidersTbl providersTbl in listProvidersTbl)
            {
                ProvidersDTO providersDTO = _Mapper.Map<ProvidersTbl, ProvidersDTO>(providersTbl);
                listProvidersDTO.Add(providersDTO);
            }
            return listProvidersDTO;
        }

        // שליפת כל הספקים שלא אושרו ע"י המנהל
        public List<ProvidersDTO> GetAllProviderNotConfirm()
        {
            List<ProvidersDTO> listProvidersDTO = new List<ProvidersDTO>();
            List<ProvidersTbl> listProvidersTbl = _providerAction.GetAllProviderNotConfirm();
            foreach (ProvidersTbl providersTbl in listProvidersTbl)
            {
                ProvidersDTO providersDTO = _Mapper.Map<ProvidersTbl, ProvidersDTO>(providersTbl);
                listProvidersDTO.Add(providersDTO);
            }
            return listProvidersDTO;
        }

        // שליפת ספק לפי קוד
        public ProvidersDTO GetProviderById(int id)
        {
            return _Mapper.Map<ProvidersTbl, ProvidersDTO>(_providerAction.GetProviderById(id));
        }

        // הוספת ספק חדש
        public List<ProvidersDTO> AddNewProvider(ProvidersDTO p)
        {
            _providerAction.AddProviders(_Mapper.Map<ProvidersDTO, ProvidersTbl>(p));
            return GetAllProviders();
        }

        //מחיקת ספק 
        public List<ProvidersDTO> DeleteProvider(int id)
        {
            _providerAction.DeleteProviders(id);
            return GetAllProviders();
        }

        //עדכון ספק מסוים לפי קוד
        public List<ProvidersDTO> UpdateProvider(int id, ProvidersDTO p)
        {
            _providerAction.UpdateProviders(id, _Mapper.Map<ProvidersDTO, ProvidersTbl>(p));
            return GetAllProviders();
        }

        // עדכון ספק מסוים שקשור לקטגוריה שעדיין לא נמצאת במערכת 
        // לאחר הוספת הקטגוריה החדשה שספק זה קשור אליה
        // עדכון הספק לכך שיהיה מקושר לקטגוריה החדשה שנוספה
        public bool UpdatePCcode(int provCode, short PCcode)
        {
            return _providerAction.UpdatePCcode(provCode, PCcode);
        }

        static ProvidersBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMap>();

            });
            _Mapper = config.CreateMapper();
        }
    }
}
