﻿using Entitiens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Interfaces
{
    public interface IUserPL
    {
        IEnumerable<Users> DisplayAllUsers();
        bool AddUser(string name, string data);
        bool DeleteUser(Guid id);
        Guid SelectedUser();
        Users GetUserByID(Guid id);
        bool EditUser(Guid id, string name, string data);
    }
}
