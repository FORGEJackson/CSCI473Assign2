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
        public uint Id { get => id; }
        public string Name { get => name; }
        public string Location { get => location; }

        public override string ToString()
        {
            return String.Format("{0} [{1}]\r\n",this.Name.PadRight(24, ' '), this.Location);
        }

    }
}
