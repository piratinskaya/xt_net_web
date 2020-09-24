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
        void DisplayAllUsers();
        bool AddUser();
        bool DeleteUser();
        Guid SelectedUser();
    }
}
