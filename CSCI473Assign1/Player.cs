/*  Authors:    Joshua Jackson z1855047
 *              Connor Whitten z1819460
 *      
 *      CSCI 473 Assignment 1
 *      Player.cs
 *      This file contains the implementation of the Player class and its methods
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CSCI473Assign1
{
    class Player : IComparable
    {
        readonly uint id;
        readonly string name;
        readonly Race race;
        uint level;
        uint exp;
        uint guildID;
        uint[] gear;
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
        bool usedLow1 = false;  //Booleans for rings & trinkets
        bool usedLow2 = false;

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
            set { exp += value; if (exp == this.level * 1000) { this.level++; exp = 0; } }
        }

        public uint GuildID { get => guildID; set => guildID = value; }

        //Equip and Unequip Methods
        public void EquipGear(uint newGearID)
        {
            if (Assign1.Items.ContainsKey(newGearID))   //Check that newGearID is a valid item
            {
                if (this.Level >= Assign1.Items[newGearID].Requirement) //Check level requirements
                {
                    if (Assign1.Items[newGearID].Type <= (ItemType)9)
                    {
                        if (this.gear[(int)Assign1.Items[newGearID].Type] != 0) //Check if slot is full and UnequipGear() if it is
                            UnequipGear((int)Assign1.Items[newGearID].Type);

                        this.gear[(int)Assign1.Items[newGearID].Type] = newGearID;  //Equip newGearID
                    }
                    else if (Assign1.Items[newGearID].Type == (ItemType)10) //Equip rules for rings
                    {
                        if (this.gear[10] == 0)
                            this.gear[10] = newGearID;
                        else if (this.gear[11] == 0)
                            this.gear[11] = newGearID;
                        else
                        {
                            if (usedLow1)
                            {
                                this.UnequipGear(10);
                                this.gear[10] = newGearID;
                                usedLow1 = true;
                            }
                            else
                            {
                                this.UnequipGear(11);
                                this.gear[11] = newGearID;
                                usedLow1 = false;
                            }
                        }
                    }
                    else if (Assign1.Items[newGearID].Type == (ItemType)11) //Equip rules for trinkets
                    {
                        if (this.gear[12] == 0)
                            this.gear[12] = newGearID;
                        else if (this.gear[13] == 0)
                            this.gear[13] = newGearID;
                        else
                        {
                            if (usedLow2)
                            {
                                this.UnequipGear(12);
                                this.gear[12] = newGearID;
                                usedLow2 = true;
                            }
                            else
                            {
                                this.UnequipGear(13);
                                this.gear[13] = newGearID;
                                usedLow2 = false;
                            }
                        }
                    }
                }
                else
                    throw new ArgumentException("Cannot equip-- Player level too low.");
            }
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
                    throw new ArgumentException("Cannot unequip item. Inventory is full.");
            }
            else
                throw new ArgumentException("You don't have any gear equipped here.");
        }
        //Method to implement IComparable
        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException(); //Check for null values

            Player rightOp = obj as Player;

            if (rightOp != null)
                return name.CompareTo(rightOp.name); //Sort using name
            else
                throw new ArgumentException("[Player]:CompareTo argument is not a Player");
        }
        //Printing methods
        public void PrintGearList()
        {
            ToString();
            System.Console.WriteLine("Equipped Gear:");
            foreach(uint curGear in gear)
            {
                if (curGear != 0)
                    System.Console.WriteLine(Assign1.Items[curGear]);
                else
                    System.Console.WriteLine("This item slot is empty.");
            }
        }
        public override string ToString()
        {
            string returnString = Name + " |" + Race + " |" + Level + " |" + GuildID;
            return returnString;
        }
    }
}
