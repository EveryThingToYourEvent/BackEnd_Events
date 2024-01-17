using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Action.interfaces
{
    public interface IProvidersAction
    {
        // שליפת כל רשימת הספקים
        public List<ProvidersTbl> GetAllProviders();

        // שליפת כל הספקים שאושרו ע"י המנהל
        public List<ProvidersTbl> GetAllProvidersConfirm();

        // שליפת כל הספקים שלא אושרו ע"י המנהל
        public List<ProvidersTbl> GetAllProviderNotConfirm();

        // שליפת ספק לפי קוד
        public ProvidersTbl GetProviderById(int id);

        //מחיקת ספק 
        public void DeleteProviders(int id);

        // הוספת ספק חדש
        public void AddProviders(ProvidersTbl providers);

        //עדכון ספק מסוים לפי קוד
        public void UpdateProviders(int id, ProvidersTbl providers);

        // עדכון ספק מסוים שקשור לקטגוריה שעדיין לא נמצאת במערכת 
        // לאחר הוספת הקטגוריה החדשה שספק זה קשור אליה
        // עדכון הספק לכך שיהיה מקושר לקטגוריה החדשה שנוספה
        public bool UpdatePCcode(int provCode, short PCcode);
    }
}
