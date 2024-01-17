using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Entities.Repository;

namespace BLL.ILogicAction
{
    public interface IOpinionToProviderBL
    {
        // שליפת כל חוות הדעת
        public List<OpinionToProviderDTO> GetAllOpinionsToProvider();
        
        // שליפת חוות דעת לספק מסוים לפי קוד הספק הרצוי
        public List<OpinionToProviderDTO> GetOpinionToProviderByProvId(int provId);

        // הוספת חוות דעת נוספת לרשימת חוות הדעת 
        public List<OpinionToProviderDTO> AddNewOpinionToProvider(OpinionToProviderDTO o);

        // מחיקת חוות דעת לפי קוד 
        public List<OpinionToProviderDTO> DeleteOpinionToProvider(int id);

        // עדכון חוות דעת מסוימת
        public List<OpinionToProviderDTO> UpdateOpinionToProvider(int id, OpinionToProviderDTO o);
        
    }
}
