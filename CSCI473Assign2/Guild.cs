/*  Authors:    Joshua Jackson z1855047
 *              Connor Whitten z1819460
 *      
 *      CSCI 473 Assignment 2
 *      Guild.cs
 *      This file contains implemenation of the Guild class
 */

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
        private GuildType type;
        private string name;
        private Servers location;

        /*
         * Guild - Default Constructor
         * Sets everything to 0, "", or null
        */
        public Guild()
        {
            this.id = 0;
            this.name = "";
            this.type = 0;
            this.location = 0;
        }

        /*
         * Guild - Constructor override
         * This constructor is designed to create guilds from guilds.txt
        */
        public Guild(uint id, string nameServer)
        {
            this.id = id;
            this.type = 0;
            string[] values = nameServer.Split('-');

            this.name = values[0];
            Servers.TryParse(values[1], out Servers server);
            this.location = server;
        }

        /*
         * Guild - Constructor override
         * This constructor allows manual input of all values
        */
        public Guild(uint id, string name, Servers server, GuildType type)
        {
            this.id = id;
            this.name = name;
            this.location = server;
            this.type = type;

        }

        //Getters and setters
        public uint Id { get => id; }
        public string Name { get => name; }
        public Servers Location { get => location; }
        public GuildType Type { get => type; set => type = value; }

        //Override for ToString - returns [GUILDNAME] [SERVER] with padding
        public override string ToString()
        {
            return String.Format("{0} [{1}]\r\n",this.Name.PadRight(24, ' '), this.Location.ToString());
        }

    }
}
