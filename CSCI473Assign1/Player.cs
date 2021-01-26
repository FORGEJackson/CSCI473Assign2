using System;
using System.Collections.Generic;
using System.Text;

namespace CSCI473Assign1
{
    class Player
    {
        readonly uint id;
        readonly string name;
        readonly Race race;
        uint level;
        uint exp;
        uint guildID;
        uint[] gear; //Change from an array to whichever collection is easiest
        List<uint> inventory;

        //Constructors
        public Player()
        {
            this.id = 0;
            this.name = "";
            this.race = 0;
            this.level = 0;
            this.exp = 0;
            this.guildID = 0;
            this.gear = null;
            this.inventory = null;
        }

        public Player(uint id, string name, Race race, uint level, uint exp, uint guildID, uint[] gear)
        {
            this.id = id;
            this.name = name;
            this.race = race;
            this.level = level;
            this.exp = exp;
            this.guildID = guildID;
            this.gear = gear;
            this.inventory = new List<uint>();
        }

        //Get and Set Methods
        public uint Id { get => id; }
        public string Name { get => name; }
        public Race Race { get => race; }
        public uint Level 
        {
            get => level;
            set { if (value >= 0 && value <= Constants.MAX_LEVEL) level = value; }
        }
        public uint Exp
        {
            get => exp;
            set { exp += value; }   //Add more code to increment level
        }
        public uint GuildID { get => guildID; set => guildID = value; }

        //Methods
        public void EquipGear(uint newGearID)
        {
            
        }
        public void UnequipGear(int gearSlot)
        {

        }
    }
}
