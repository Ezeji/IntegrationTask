using ChakaAPITask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChakaAPITask.Repository
{
    public interface IServerRepository
    {
        string NumberOfDaysToUpdateServers(Server server);
        double ServerOneUpdated(string serverOne);
        double ServerTwoUpdated(string serverTwo);
        double ServerThreeUpdated(string serverThree);

    }
}
