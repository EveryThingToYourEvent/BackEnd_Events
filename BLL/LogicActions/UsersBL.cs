using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Entities;
using AutoMapper;
using DAL.Models;
using DTO_Entities.Repository;
using DAL.Action.classes;
using DAL.Action.interfaces;
using BLL.ILogicAction;

namespace BLL.LogicActions
{
    public class UsersBL:IUsersBL
    {
        static IMapper _Mapper;
        IUsersAction _usersAction;

        public UsersBL(IUsersAction usersAction)
        {
            _usersAction = usersAction;
        }

        // שליפת כל המשתמשים
        public List<UsersDTO> GetAllUsers()
        {
            List<UsersDTO> listUsersDTO = new List<UsersDTO>();

            List<UsersTbl> listUsersTbl = _usersAction.GetAllUsers();

            foreach (UsersTbl usersTbl in listUsersTbl)
            {

                UsersDTO usersDTO = _Mapper.Map<UsersTbl, UsersDTO>(usersTbl);
                listUsersDTO.Add(usersDTO);
            }
            return listUsersDTO;
        }

        // הוספת משתמש חדש
        public List<UsersDTO> AddNewUser(UsersDTO u)
        {
            _usersAction.AddUser(_Mapper.Map<UsersDTO, UsersTbl>(u));
            return GetAllUsers();
        }

        // מחיקת משתמש מרשימת המשתמשים
        public List<UsersDTO> DeleteUser(string id)
        {
            _usersAction.DeleteUser(id);
            return GetAllUsers();
        }

        // עדכון משתמש מסוים לפי קוד משתמש
        public List<UsersDTO> UpdateUser(string id, UsersDTO u)
        {
            _usersAction.UpdateUser(id, _Mapper.Map<UsersDTO, UsersTbl>(u));
            return GetAllUsers();
        }

        static UsersBL()
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
