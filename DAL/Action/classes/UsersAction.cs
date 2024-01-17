using DAL.Action.interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Action.classes
{
    public class UsersAction:IUsersAction
    {
        EverythingToYourEventContext _everythingToYourEventContext;

        public UsersAction(EverythingToYourEventContext everythingToYourEventContext)
        {
            _everythingToYourEventContext = everythingToYourEventContext;
        }

        // שליפת כל המשתמשים
        public List<UsersTbl> GetAllUsers()
        {
            return _everythingToYourEventContext.UsersTbls.Where(u => !u.UserIsDelete).ToList();
        }

        // הוספת משתמש חדש
        public void AddUser(UsersTbl user)
        {
            _everythingToYourEventContext.UsersTbls.Add(user);
            _everythingToYourEventContext.SaveChanges();
        }

        // מחיקת משתמש מרשימת המשתמשים
        public void DeleteUser(string id)
        {
            var userToDelete = _everythingToYourEventContext.UsersTbls.FirstOrDefault(x => x.UserId == id);
            if (userToDelete != null)
                userToDelete.UserIsDelete = true;
            _everythingToYourEventContext.SaveChanges();
        }

        // עדכון משתמש מסוים לפי קוד משתמש
        public void UpdateUser(string id, UsersTbl user)
        {
            var userToUpdate = _everythingToYourEventContext.UsersTbls.FirstOrDefault(x => x.UserId.Equals(id));
            if (userToUpdate != null)
            {
                userToUpdate.UserFname = user.UserFname;
                userToUpdate.UserLname = user.UserLname;
                userToUpdate.UserPassword = user.UserPassword;
                userToUpdate.UserEmail = user.UserEmail;
                userToUpdate.UserPic = user.UserPic;
                userToUpdate.UserGender = user.UserGender;
            }
            _everythingToYourEventContext.SaveChanges();
        }
    }
}
