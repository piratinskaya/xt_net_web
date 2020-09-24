using Entitiens;
using System.Collections.Generic;


namespace DAL.Interfaces
{
    public interface IRewardDAL
    {
        void SaveRaward(Rewards reward);
        IEnumerable<Rewards> GetAllRewards();
    }
}
