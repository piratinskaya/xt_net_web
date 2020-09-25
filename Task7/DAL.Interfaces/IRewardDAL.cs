using Entitiens;
using System;
using System.Collections.Generic;


namespace DAL.Interfaces
{
    public interface IRewardDAL
    {
        void SaveRaward(Rewards reward);
        IEnumerable<Rewards> GetAllRewards();
        List<Users> GetUsersWithCurrentReward(Guid idAward);
        void DeleteUserReward(Guid IDUser);

        void DeleteAwardReward(Guid IDAward);
        void DeleteReward(Guid idUser, Guid idAward);
        void EditAward(Awards newAward);
    }
}
