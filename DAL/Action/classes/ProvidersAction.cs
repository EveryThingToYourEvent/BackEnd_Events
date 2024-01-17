using DAL.Action.interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Action.classes
{
    public class ProvidersAction:IProvidersAction
    {
        EverythingToYourEventContext _dbEveryThingToYourEvent;

        public ProvidersAction(EverythingToYourEventContext dbEveryThingToYourEvent)
        {
            _dbEveryThingToYourEvent = dbEveryThingToYourEvent;
        }

        // שליפת כל רשימת הספקים
        public List<ProvidersTbl> GetAllProviders()
        {
            return _dbEveryThingToYourEvent.ProvidersTbls.Where(p => !p.ProvIsDelete).ToList();
        }

        // שליפת כל הספקים שאושרו ע"י המנהל
        public List<ProvidersTbl> GetAllProvidersConfirm()
        {
            return _dbEveryThingToYourEvent.ProvidersTbls.Where(p => !p.ProvIsDelete && p.ProvStatus == "אושר").ToList();
        }

        // שליפת כל הספקים שלא אושרו ע"י המנהל
        public List<ProvidersTbl> GetAllProviderNotConfirm()
        {
            return _dbEveryThingToYourEvent.ProvidersTbls.Where(p => !p.ProvIsDelete && p.ProvStatus == "לא אושר").ToList();
        }

        // שליפת ספק לפי קוד
        public ProvidersTbl GetProviderById(int id)
        {
            return GetAllProviders().Find(x => x.ProvCode == id);
        }

        // הוספת ספק חדש
        public void AddProviders(ProvidersTbl provider)
        {
            _dbEveryThingToYourEvent.ProvidersTbls.Add(provider);//

            _dbEveryThingToYourEvent.SaveChanges();
        }

        //מחיקת ספק 
        public void DeleteProviders(int id)
        {
            var providerToDelete = _dbEveryThingToYourEvent.ProvidersTbls.FirstOrDefault(x=>x.ProvCode == id);
            if (providerToDelete != null)
                providerToDelete.ProvIsDelete = true;
            _dbEveryThingToYourEvent.SaveChanges();
        }

        //עדכון ספק מסוים לפי קוד

        public void UpdateProviders(int id, ProvidersTbl provider)
        {
            var providerToUpdate = _dbEveryThingToYourEvent.ProvidersTbls.FirstOrDefault(x=>x.ProvCode==id);
            if(providerToUpdate != null)
            {
                providerToUpdate.ProvLogo = provider.ProvLogo;
                providerToUpdate.ProvTitle = provider.ProvTitle;
                providerToUpdate.ProvAdvertisementText = provider.ProvAdvertisementText;
                providerToUpdate.ProvPic1 = provider.ProvPic1;
                providerToUpdate.ProvPic2 = provider.ProvPic2;
                providerToUpdate.ProvPic3 = provider.ProvPic3;
                providerToUpdate.ProvPic4 = provider.ProvPic4;
                providerToUpdate.ProvPic5 = provider.ProvPic5;
                providerToUpdate.ProvPic6 = provider.ProvPic6;
                providerToUpdate.ProvPic7 = provider.ProvPic7;
                providerToUpdate.ProvPic8 = provider.ProvPic8;
                providerToUpdate.ProvEmail = provider.ProvEmail;
                providerToUpdate.ProvPhone = provider.ProvPhone;
                providerToUpdate.ProvCity = provider.ProvCity;
                providerToUpdate.ProvAddress = provider.ProvAddress;
                providerToUpdate.ProvClip = provider.ProvClip;
                providerToUpdate.ProvStatus = provider.ProvStatus;
                providerToUpdate.ProvIsDelete = false;
                providerToUpdate.OtherCategory = provider.OtherCategory;
                _dbEveryThingToYourEvent.SaveChanges();

            }
        }

         // עדכון ספק מסוים שקשור לקטגוריה שעדיין לא נמצאת במערכת 
        // לאחר הוספת הקטגוריה החדשה שספק זה קשור אליה
        // עדכון הספק לכך שיהיה מקושר לקטגוריה החדשה שנוספה
        public bool UpdatePCcode(int provCode, short PCcode)
        {
            try
            {
                ProvidersTbl p = GetAllProviderNotConfirm().FirstOrDefault(x => x.ProvCode == provCode);
                p.Pccode = PCcode;
                p.ProvStatus = "אושר";
                _dbEveryThingToYourEvent.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
