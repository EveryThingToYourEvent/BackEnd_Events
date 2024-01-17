using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Entities.Repository
{
    public class UsersDTO
    {
        public string UserId { get; set; } = null!;

        public string? UserFname { get; set; }

        public string? UserLname { get; set; }

        public string UserPassword { get; set; } = null!;

        public string UserEmail { get; set; } = null!;

        public string? UserPic { get; set; }

        public string? UserGender { get; set; }
        public bool? UserIsDelete { get; set; }
    }
}
