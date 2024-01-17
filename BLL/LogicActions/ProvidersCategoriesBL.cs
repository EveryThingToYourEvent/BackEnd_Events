using AutoMapper;
using DTO_Entities;
using DTO_Entities.Repository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Action.classes;
using BLL.ILogicAction;
using DAL.Action.interfaces;

namespace BLL.LogicActions
{
    public class ProvidersCategoriesBL:IProvidersCategoriesBL
    {
        static IMapper _Mapper;
        IProvidersCategoriesAction _providersCategoryAction;
        public ProvidersCategoriesBL(IProvidersCategoriesAction providersCategoryAction)
        {
            _providersCategoryAction = providersCategoryAction;
        }

        // שליפת רשימת הקטגוריות
        public List<ProvidersCategoriesDTO> GetAllProvidersCategories()
        {
            List<ProvidersCategoriesDTO> listProvidersCategoriesDTO = new List<ProvidersCategoriesDTO>();
            List<ProvidersCategoriesTbl> listProvidersCategoriesTbl = _providersCategoryAction.GetAllProvidersCategories();
            foreach (ProvidersCategoriesTbl providerCategoryTbl in listProvidersCategoriesTbl)
            {
                ProvidersCategoriesDTO providerCategoriesDTO = _Mapper.Map<ProvidersCategoriesTbl, ProvidersCategoriesDTO>(providerCategoryTbl);
                listProvidersCategoriesDTO.Add(providerCategoriesDTO);
            }
            return listProvidersCategoriesDTO;
        }

        // הוספה לרשימת הקטגוריות
        public List<ProvidersCategoriesDTO> AddNewProvidersCategory(ProvidersCategoriesDTO p)
        {
            _providersCategoryAction.AddProvidersCategory(_Mapper.Map<ProvidersCategoriesDTO, ProvidersCategoriesTbl>(p));
            return GetAllProvidersCategories();
        }

        // מחיקה מרשימת הקטגוריות
        public List<ProvidersCategoriesDTO> DeleteProvidersCategory(int id)
        {
            _providersCategoryAction.DeleteProvidersCategory(id);
            return GetAllProvidersCategories();
        }

        // עדכון קטגוריה מסוימת לפי קוד קטגוריה
        public List<ProvidersCategoriesDTO> UpdateProvidersCategory(int id, ProvidersCategoriesDTO p)
        {
            _providersCategoryAction.UpdateProvidersCategory(id, _Mapper.Map<ProvidersCategoriesDTO, ProvidersCategoriesTbl>(p));
            return GetAllProvidersCategories();
        }
        static ProvidersCategoriesBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMap>();

            });
            _Mapper = config.CreateMapper();
        }
    }
}
