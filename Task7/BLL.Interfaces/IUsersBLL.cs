using Entitiens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserBLL
    {
        bool SaveUser(Users user);
        bool DeleteUser(Guid id);
        IEnumerable<Users> AllUsers { get; }
        Users GetUserByID(Guid id);
        bool EditUser(Guid id, string name, DateTime data);
    }
}
