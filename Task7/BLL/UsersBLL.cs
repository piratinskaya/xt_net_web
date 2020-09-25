﻿using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Dependencies;
using Entitiens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsersBLL : IUserBLL
    {
        private IUserDAL _usersDAL;
        public UsersBLL()
        {
            _usersDAL = DependenciesDAL.UserDAL;
        }
        public bool DeleteUser(Guid id)
        {
            try
            {
                _usersDAL.DeleteUser(id);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public IEnumerable<Users> AllUsers => _usersDAL.GetAllUsers();

        public Users GetUserByID(Guid id) => _usersDAL.GetUserByID(id);

        public bool SaveUser(Users user)
        {
            try
            {
                _usersDAL.SaveUser(user);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EditUser(Guid id, string name, DateTime data)
        {
            try
            {
                Users newUser = new Users(name, data)
                {
                    ID = id
                };
                _usersDAL.SaveUser(newUser);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
