using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI473Assign2
{
    class Guild
    {
        private uint id;
        private string name;
        private string location;

        public Guild()
        {
            this.id = 0;
            this.name = "";
            this.location = "";
        }

        public Guild(uint id, string nameServer)
        {
            this.id = id;
            string[] values = nameServer.Split('-');

            this.name = values[0];
            this.location = values[1];
        }
    }
}
