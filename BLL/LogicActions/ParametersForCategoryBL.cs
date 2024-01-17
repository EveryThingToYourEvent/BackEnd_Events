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
    public class ParametersForCategoryBL:IParametersForCategoryBL
    {
        static IMapper _Mapper;
        IParametersForCategoryAction _parametersForCategoryAction;

        public ParametersForCategoryBL(IParametersForCategoryAction parametersForCategory)
        {
            _parametersForCategoryAction = parametersForCategory;
        }

        // שליפת רשימת הפרמטרים לקטגוריה
        public List<ParametersForCategoryDTO> GetAllParametersForCategory()
        {
            List<ParametersForCategoryDTO> listParametersForCategoryDTO = new List<ParametersForCategoryDTO>();
            List<ParametersForCategoryTbl> listParametersFotCategoryTbl = _parametersForCategoryAction.GetAllParametersForCategory();
            foreach (ParametersForCategoryTbl parametersTbl in listParametersFotCategoryTbl)
            {
                ParametersForCategoryDTO parametersDTO = _Mapper.Map<ParametersForCategoryTbl, ParametersForCategoryDTO>(parametersTbl);
                listParametersForCategoryDTO.Add(parametersDTO);
            }
            return listParametersForCategoryDTO;
        }

        // הוספת פרמטר לקטגוריה  
        public List<ParametersForCategoryDTO> AddNewParameterForCategory(ParametersForCategoryDTO p)
        {
            _parametersForCategoryAction.AddParametersForCategory(_Mapper.Map<ParametersForCategoryDTO, ParametersForCategoryTbl>(p));
            return GetAllParametersForCategory();
        }

        // מחיקת פרמטר לקטגוריה
        public List<ParametersForCategoryDTO> DeleteParameterForCategory(int id)
        {
            _parametersForCategoryAction.DeleteParametersForCategory(id);
            return GetAllParametersForCategory();
        }

        // עדכון פרמטר לקטגוריה
        public List<ParametersForCategoryDTO> UpdateParameterForCategory(int id, ParametersForCategoryDTO p)
        {
            _parametersForCategoryAction.UpdateParametersForCategory(id, _Mapper.Map<ParametersForCategoryDTO, ParametersForCategoryTbl>(p));
            return GetAllParametersForCategory();
        }

        static ParametersForCategoryBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMap>();

            });
            _Mapper = config.CreateMapper();
        }
    }
}
