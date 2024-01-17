using DTO_Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ILogicAction
{
    public interface IUsersBL
    {
        // שליפת כל המשתמשים
        public List<UsersDTO> GetAllUsers();

        // הוספת משתמש חדש
        public List<UsersDTO> AddNewUser(UsersDTO u);

        // מחיקת משתמש לפי קוד משתמש
        public List<UsersDTO> DeleteUser(string id);

        // עדכון משתמש לפי קוד משתמש
        public List<UsersDTO> UpdateUser(string id, UsersDTO u);
    }
}
