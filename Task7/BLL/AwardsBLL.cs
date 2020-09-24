﻿using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Dependencies;
using Entitiens;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class AwardsBLL : IAwardBLL
    {
        private IAwardDAL _awardDAL;
        public AwardsBLL()
        {
            _awardDAL = DependenciesDAL.AwardDAL;
        }

        public bool DeleteAward(Guid id)
        {
            try
            {
                _awardDAL.DeleteAward(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Awards> GetAllAwards()
        {
            return _awardDAL.GetAllAwards();
        }

        public Awards GetAwardByID(Guid id)
        {
            return _awardDAL.GetAwardByID(id);
        }

        public bool SaveAward(Awards award)
        {
            try
            {
                _awardDAL.SaveAward(award);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
