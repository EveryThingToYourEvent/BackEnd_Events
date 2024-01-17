using DAL.Action.interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Action.classes
{
    public class OpinionToProviderAction: IOpinionToProviderAction
    {
        EverythingToYourEventContext _everyThingToYourEvent;
        public OpinionToProviderAction(EverythingToYourEventContext everyThingToYourEvent)
        {
            _everyThingToYourEvent = everyThingToYourEvent;
        }

        //שליפת כל החוות דעת
        public List<OpinionToProviderTbl> GetAllOpinionToProvider()
        {
            return _everyThingToYourEvent.OpinionToProviderTbls.Where(o=>!o.OpisDelete).ToList();
        }

        // שליפת חוות דעת של ספק מסוים לפי קוד ספק
        public List<OpinionToProviderTbl> GetOpinionToProviderByProvId(int provId)
        {
            return GetAllOpinionToProvider().Where(x => x.ProvCode == provId).ToList();
        }

        // הוספת חוות דעת נוספת לרשימת חוות הדעת
        public void AddNewOpinionToProvider(OpinionToProviderTbl o)
        {
            _everyThingToYourEvent.OpinionToProviderTbls.Add(o);
            _everyThingToYourEvent.SaveChanges();
        }

        // מחיקת חוות דעת לפי קוד 
        public void DeleteOpinionToProvider(int id)
        {
            var opinionProviderToDelete=_everyThingToYourEvent.OpinionToProviderTbls.FirstOrDefault(o=>o.Opcode == id);
            if(opinionProviderToDelete != null)
            {
                opinionProviderToDelete.OpisDelete = true;
                _everyThingToYourEvent.SaveChanges();
            }
        }

        // עדכון חוות דעת מסוימת
        public void UpdateOpinionToProvider(int id, OpinionToProviderTbl opinionToProvider)
        {
            var opinionToEdit = _everyThingToYourEvent.OpinionToProviderTbls.FirstOrDefault(x => x.Opcode == id);
            if (opinionToEdit != null)
            {
                opinionToEdit.Opdate = opinionToProvider.Opdate;
                opinionToEdit.Optext = opinionToProvider.Optext;
                opinionToEdit.ProvCode = opinionToProvider.ProvCode;
                opinionToEdit.UserId = opinionToProvider.UserId;
                opinionToEdit.Oppic = opinionToProvider.Oppic;
                opinionToEdit.OpisShow = opinionToProvider.OpisShow;
                opinionToEdit.OpisDelete = opinionToProvider.OpisDelete;

                _everyThingToYourEvent.SaveChanges();
            }
        }
    }
}
