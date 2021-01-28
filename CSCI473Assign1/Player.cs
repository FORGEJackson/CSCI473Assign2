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
        /*  0 Helmet
         *  1 Neck
         *  2 Shoulders
         *  3 Back
         *  4 Chest
         *  5 Wrist
         *  6 Gloves
         *  7 Belt
         *  8 Pants
         *  9 Boots
         *  10 + 11 Ring
         *  12 + 13 Trinket
         */
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
            if (Assign1.Items.ContainsKey(newGearID))   //Check that newGearID is a valid item
            {
                if (this.Level >= Assign1.Items[newGearID].Requirement) //Check level requirements
                    //Do we need to first check array index is empty before the line below this?
//                   gear[Item[Type]] = newGearID; //not sure how to give the right array index

                    if (Assign1.Items[newGearID].Type <= (ItemType)9)
                    {
                        if (this.gear[(int)Assign1.Items[newGearID].Type] != 0) //Check if slot is full and UnequipGear() if it is
                            UnequipGear((int)Assign1.Items[newGearID].Type);

                        this.gear[(int)Assign1.Items[newGearID].Type] = newGearID;  //Equip newGearID
                    }
                    else if (Assign1.Items[newGearID].Type == (ItemType)10) //Equip rules for rings
                    {

                    }
                    else if (Assign1.Items[newGearID].Type == (ItemType)11) //Equip rules for trinkets
                    {

                    }
                else
                    throw new ArgumentException("Cannot equip-- Player level too low.");
            }    //still need the Booleans for rings & trinkets
            else
                throw new ArgumentException("Not a valid piece of gear");
        }
        public void UnequipGear(int gearSlot)
        {
            if (gear[gearSlot] != 0)
            {
                if (inventory.Count < Constants.MAX_INVENTORY_SIZE)
                {
                    inventory.Add(gear[gearSlot]);
                    gear[gearSlot] = 0;
                }
                else
                    throw new ArgumentException("Failed to unequip item. Inventory is full.");
            }
            else
                throw new ArgumentException("You don't have any gear equipped here.");
        }
    }
}
