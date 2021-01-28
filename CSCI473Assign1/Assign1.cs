using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace CSCI473Assign1
{
    public enum ItemType
    {
        Helmet, Neck, Shoulders, Back, Chest,
        Wrist, Gloves, Belt, Pants, Boots,
        Ring, Trinket
    };

    public enum Race { Orc, Troll, Tauren, Forsaken };    

    class Assign1
    {
        static Dictionary<uint, Item> Items = new Dictionary<uint, Item>();
        static Dictionary<uint, Player> Players = new Dictionary<uint, Player>();
        static Dictionary<uint, string> Guilds = new Dictionary<uint, string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the World of ConflictCraft: Testing Environment!\n");

            Setup();

            Item test = Assign1.Items[0];
        }

        static void Setup()
        {
            //Load in all Items
            string curLine;
            

            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("CSCI473Assign1.equipment.txt");
            StreamReader inFile = new StreamReader(stream);

            curLine = inFile.ReadLine();
            while (curLine != null)
            {
                string[] values = curLine.Split("\t");

                UInt32.TryParse(values[0], out uint id);
                Int32.TryParse(values[2], out int type);
                UInt32.TryParse(values[3], out uint ilvl);
                UInt32.TryParse(values[4], out uint primary);
                UInt32.TryParse(values[5], out uint stamina);
                UInt32.TryParse(values[6], out uint requirement);

                Items.Add(id, new Item(id, values[1], (ItemType)type, ilvl, primary, stamina, requirement, values[7]));
                curLine = inFile.ReadLine();
            }
        }

        static bool Menu()
        {
            int input = 0;

            Console.WriteLine("Welcome to the World of ConflictCraft: Testing Environment. Please select an option from the list below:\n\t" +
                "1.) Print All Players\n\t" +
                "2.) Print All Guilds\n\t" +
                "3.) List All Gear\n\t" +
                "4.) Print Gear List for Player\n\t" +
                "5.) Leave Guild\n\t" +
                "6.) Join Guild\n\t" +
                "7.) Equip Gear\n\t" +
                "8.) Unequip Gear\n\t" +
                "9.) Award Experience\n\t" +
                "10.) Quit\n");

            while ((input < 1 || input > 10) && input != 'T') 
            {
                input = Console.Read();
                if ((input < 1 || input > 10) && input != 'T')
                    Console.WriteLine("Please enter the digit corresponding with your choice");
            }

            return true;
        }
    }
}
