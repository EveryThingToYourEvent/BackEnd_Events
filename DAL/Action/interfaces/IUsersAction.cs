using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Action.interfaces
{
    public interface IUsersAction
    {
        // שליפת כל המשתמשים
        public List<UsersTbl> GetAllUsers();

        // מחיקת משתמש מרשימת המשתמשים
        public void DeleteUser(string id);

        // הוספת משתמש חדש
        public void AddUser(UsersTbl user);

        // עדכון משתמש מסוים לפי קוד משתמש
        public void UpdateUser(string id, UsersTbl user);
    }
}
