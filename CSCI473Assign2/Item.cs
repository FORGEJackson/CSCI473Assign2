/*  Authors:    Joshua Jackson z1855047
 *              Connor Whitten z1819460
 *      
 *      CSCI 473 Assignment 1
 *      Item.cs
 *      This file contains the implementation of the Item class and its methods
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace CSCI473Assign2
{
    class Item : IComparable
    {
        readonly uint id;
        string name;
        ItemType type;
        uint ilvl;
        uint primary;
        uint stamina;
        uint requirement;
        string flavor;

        //Constructors
        public Item()
        {
            this.id = 0;
            this.Name = "";
            this.Type = 0;
            this.Ilvl = 0;
            this.Primary = 0;
            this.Stamina = 0;
            this.Requirement = 0;
            this.Flavor = "";
        }

        public Item(uint id, string name, ItemType type, uint ilvl, uint primary, uint stamina, uint requirement, string flavor)
        {
            this.id = id;
            this.Name = name;
            this.Type = type;
            this.Ilvl = ilvl;
            this.Primary = primary;
            this.Stamina = stamina;
            this.Requirement = requirement;
            this.Flavor = flavor;
        }

        //Get and Set methods
        public uint Id { get => id; }
        public string Name { get => name; set => name = value; }
        public ItemType Type
        {
            get => type;
            set { if ((int)value >= 0 && (int)value <= 12) type = value; } //Verify value is a valid ItemType
        }
        public uint Ilvl 
        { 
            get => ilvl;
            set { if (value >= 0 && value <= Constants.MAX_ILVL) ilvl = value; }
        }
        public uint Primary 
        { 
            get => primary;
            set { if (value >= 0 && value <= Constants.MAX_PRIMARY) primary = value; } 
        }
        public uint Stamina 
        { 
            get => stamina; 
            set { if (value >= 0 && value <= Constants.MAX_STAMINA) stamina = value; }
        }
        public uint Requirement
        {
            get => requirement;
            set { if (value >= 0 && value <= Constants.MAX_LEVEL) requirement = value; }
        }
        public string Flavor { get => flavor; set => flavor = value; }

        //Methods
        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException(); //Check for null values

            Item rightOp = obj as Item;

            if (rightOp != null)
                return name.CompareTo(rightOp.name);    //Sort using name
            else
                throw new ArgumentException("[Item]:CompareTo argument is not an Item");
        }

        public override string ToString()
        {
            string returnString = "(" + Type + ") " + Name + " |" + Ilvl + "| --" + Requirement + "--\n\t\"" + Flavor + "\"";
            return returnString;
        }
    }
}
