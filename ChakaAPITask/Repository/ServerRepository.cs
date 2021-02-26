using ChakaAPITask.Data;
using ChakaAPITask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChakaAPITask.Repository
{
    public class ServerRepository : IServerRepository
    {
        private ChakaDBContext _context;

        public ServerRepository(ChakaDBContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Fetches the number of days it would take to update all servers.
        /// </summary>
        /// <param name="server">Server Object</param>
        public string NumberOfDaysToUpdateServers(Server server)
        {
            var serverOne = ServerOneUpdated(server.ServerOne);
            var serverTwo = ServerTwoUpdated(server.ServerTwo);
            var serverThree = ServerThreeUpdated(server.ServerThree);

            var result = (serverOne + serverTwo + serverThree) / 3;

            return result.ToString() + " " + "days";
        }


        /// <summary>
        /// Fetches the number of databases in a server to be updated.
        /// </summary>
        /// <param name="serverOne">ServerOne String</param>
        public double ServerOneUpdated(string serverOne)
        {
            string[] server = serverOne.Split(' ');
            int i = 0;

            foreach (var database in server)
            {
                
                if (database == "0")
                {
                    server[i] = "1";
                }

                i++;
            }

            return server.Count();
        }


        /// <summary>
        /// Fetches the number of databases in a server to be updated.
        /// </summary>
        /// <param name="serverTwo">ServerTwo String</param>
        public double ServerTwoUpdated(string serverTwo)
        {
            string[] server = serverTwo.Split(' ');
            int i = 0;

            foreach (var database in server)
            {

                if (database == "0")
                {
                    server[i] = "1";
                }

                i++;
            }

            return server.Count();
        }


        /// <summary>
        /// Fetches the number of databases in a server to be updated.
        /// </summary>
        /// <param name="serverThree">ServerThree String</param>
        public double ServerThreeUpdated(string serverThree)
        {
            string[] server = serverThree.Split(' ');
            int i = 0;

            foreach (var database in server)
            {

                if (database == "0")
                {
                    server[i] = "1";
                }

                i++;
            }

            return server.Count();
        }

        
    }
}
