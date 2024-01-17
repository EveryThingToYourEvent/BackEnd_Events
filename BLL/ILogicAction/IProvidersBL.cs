using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Entities.Repository;

namespace BLL.ILogicAction
{
    public interface IProvidersBL
    {
        // שליפת כל רשמת הספקים
        public List<ProvidersDTO> GetAllProviders();

        // שליפת כל הספקים שאושרו ע"י המנהל
        public List<ProvidersDTO> GetAllProvidersConfirm();

        // שליפת כל הספקים שלא אושרו ע"י המנהל
        public List<ProvidersDTO> GetAllProviderNotConfirm();

        // שליפת ספק לפי קוד
        public ProvidersDTO GetProviderById(int id);

        // הוספת ספק חדש
        public List<ProvidersDTO> AddNewProvider(ProvidersDTO p);

        //מחיקת ספק 
        public List<ProvidersDTO> DeleteProvider(int id);

        //עדכון ספק מסוים לפי קוד
        public List<ProvidersDTO> UpdateProvider(int id, ProvidersDTO p);

        // עדכון ספק מסוים שקשור לקטגוריה שעדיין לא נמצאת במערכת 
        // לאחר הוספת הקטגוריה החדשה שספק זה קשור אליה
        // עדכון הספק לכך שיהיה מקושר לקטגוריה החדשה שנוספה
        public bool UpdatePCcode(int provCode, short PCcode);
    }
}
