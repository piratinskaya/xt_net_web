using Entitiens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IRewardBLL
    {
        bool RewardUser(Guid userID, Guid awardID);
        IEnumerable<Rewards> GetAllRewards();
    }
}
