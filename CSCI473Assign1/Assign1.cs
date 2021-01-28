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
        public static Dictionary<uint, Item> Items = new Dictionary<uint, Item>();
        public static Dictionary<uint, Player> Players = new Dictionary<uint, Player>();
        public static Dictionary<uint, string> Guilds = new Dictionary<uint, string>();

        //Inverse Dictionaries of the ones above for converting a name to an id
        static Dictionary<string, uint> invItems = new Dictionary<string, uint>();
        static Dictionary<string, uint> invPlayers = new Dictionary<string, uint>();
        static Dictionary<string, uint> invGuilds = new Dictionary<string, uint>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the World of ConflictCraft: Testing Environment!\n");

            Setup();

            while (Menu()) ;
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
                invItems.Add(values[1], id);
                curLine = inFile.ReadLine();
            }

            //Load in all Players
            stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("CSCI473Assign1.players.txt");
            inFile = new StreamReader(stream);

            curLine = inFile.ReadLine();
            while (curLine != null)
            {
                string[] values = curLine.Split("\t");
                uint[] gear = new uint[14];

                UInt32.TryParse(values[0], out uint id);
                Int32.TryParse(values[2], out int race);
                UInt32.TryParse(values[3], out uint level);
                UInt32.TryParse(values[4], out uint exp);
                UInt32.TryParse(values[5], out uint guildID);

                for (int i = 0; i < 14; i++)
                    UInt32.TryParse(values[6 + i], out gear[i]);

                Players.Add(id, new Player(id, values[1], (Race)race, level, exp, guildID, gear));
                invPlayers.Add(values[1], id);
                curLine = inFile.ReadLine();
            }

            //Load in all guilds
            stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("CSCI473Assign1.guilds.txt");
            inFile = new StreamReader(stream);

            curLine = inFile.ReadLine();
            while (curLine != null)
            {
                string[] values = curLine.Split("\t");

                UInt32.TryParse(values[0], out uint id);

                Guilds.Add(id, values[1]);
                invGuilds.Add(values[1], id);
                curLine = inFile.ReadLine();
            }
        }

        static bool Menu()
        {
            try
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

                while (input < 1 || input > 11) //Get an integer corresponding with one of the menu options
                {
                    string strInput = Console.ReadLine();

                    if (strInput == "q" || strInput == "Q" || strInput == "quit" || strInput == "Quit" || strInput == "exit" || strInput == "Exit")
                    {
                        input = 10;
                    }
                    else if (strInput == "T")
                    {
                        input = 11;
                    }
                    else
                    {
                        int.TryParse(strInput, out input);
                        if (input < 1 || input > 10)
                            Console.WriteLine("Please enter the digit corresponding with your choice");
                    }
                }

                string player;

                switch (input)
                {
                    case 1: //Print all players
                        foreach (KeyValuePair<uint, Player> cur in Players)
                            Console.WriteLine(cur.Value);

                        Console.WriteLine();
                        break;
                    case 2: //Print all guilds
                        foreach (KeyValuePair<uint, string> cur in Guilds)
                            Console.WriteLine(cur.Value);

                        Console.WriteLine();
                        break;
                    case 3: //Print all gear
                        foreach (KeyValuePair<uint, Item> cur in Items)
                            Console.WriteLine(cur.Value);

                        Console.WriteLine();
                        break;
                    case 4: //Print gear list for a player
                        Console.Write("Enter the player name: ");

                        player = Console.ReadLine();

                        if (invPlayers.ContainsKey(player))
                        {
                            Console.WriteLine(Players[invPlayers[player]]);
                            Players[invPlayers[player]].PrintGearList();
                            Console.WriteLine();
                        }
                        else
                        {
                            throw new ArgumentException("Player does not exist");
                        }

                        break;
                    case 5: //Leave guild
                        Console.Write("Enter the player name: ");

                        player = Console.ReadLine();

                        if (invPlayers.ContainsKey(player))
                        {
                            if (Players[invPlayers[player]].GuildID != 0)
                            {
                                Players[invPlayers[player]].GuildID = 0;
                                Console.WriteLine(player + " has left their Guild");
                            }
                            else
                            {
                                Console.WriteLine(player + " is not in a Guild");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Player does not exist");
                        }

                        break;
                    case 6: //Join Guild
                        Console.Write("Enter the player name: ");

                        player = Console.ReadLine();

                        if (invPlayers.ContainsKey(player))
                        {
                            Console.Write("Enter the Guild they will join: ");

                            string guild = Console.ReadLine();

                            if (Guilds.ContainsValue(guild))
                            {
                                Players[invPlayers[player]].GuildID = invGuilds[guild];
                                Console.WriteLine(player + " has joined " + guild);
                            }
                            else
                            {
                                throw new ArgumentException("Guild does not exist");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Player does not exist");
                        }

                        break;
                    case 7: //Equip gear
                        Console.Write("Enter the player name: ");

                        player = Console.ReadLine();

                        if (invPlayers.ContainsKey(player))
                        {
                            Console.Write("Enter the item name they will equip: ");

                            string item = Console.ReadLine();

                            if (invItems.ContainsKey(item))
                            {
                                Players[invPlayers[player]].EquipGear(invItems[item]);
                                Console.WriteLine(player + " successfully equipped " + item);
                            }
                            else
                            {
                                throw new ArgumentException("Item does not exist");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Player does not exist");
                        }

                        break;
                    case 8: //Unequip gear
                        Console.Write("Enter the player name: ");

                        player = Console.ReadLine();

                        if (invPlayers.ContainsKey(player))
                        {
                            Console.Write("Enter the Item Slot number they will unequip:\n" +
                                "\t0 = Helmet\n" +
                                "\t1 = Neck\n" +
                                "\t2 = Shoulders\n" +
                                "\t3 = Back\n" +
                                "\t4 = Chest\n" +
                                "\t5 = Wrist\n" +
                                "\t6 = Gloves\n" +
                                "\t7 = Belt\n" +
                                "\t8 = Pants\n" +
                                "\t9 = Boots\n" +
                                "\t10 = Ring\n" +
                                "\t11 = Trinket\n");

                            input = -1;
                            while (input < 0 || input > 11) //Get an integer corresponding with one of the menu options
                            {
                                int.TryParse(Console.ReadLine(), out input);
                                if (input < 0 || input > 11)
                                    Console.WriteLine("Please enter the digit corresponding with your choice");
                            }

                            Players[invPlayers[player]].UnequipGear(input);
                        }
                        else
                        {
                            throw new ArgumentException("Player does not exist");
                        }

                        break;
                    case 9: //Award experience
                        Console.Write("Enter the player name: ");

                        player = Console.ReadLine();

                        if (invPlayers.ContainsKey(player))
                        {
                            Console.Write("Enter the amount of experience to award: ");

                            UInt32.TryParse(Console.ReadLine(), out uint exp);

                            Players[invPlayers[player]].Exp = exp;
                        }
                        else
                        {
                            throw new ArgumentException("Player does not exist");
                        }

                        break;
                    case 10:    //Quit
                        return false;
                    case 11:    //Hidden option for testing IComparable
                        SortedSet<Item> sortItems = new SortedSet<Item>();
                        SortedSet<Player> sortPlayers = new SortedSet<Player>();

                        foreach(KeyValuePair<uint, Item> cur in Items)
                        {
                            sortItems.Add(cur.Value);
                        }
                        foreach (KeyValuePair<uint, Player> cur in Players)
                        {
                            sortPlayers.Add(cur.Value);
                        }

                        foreach (Item cur in sortItems)
                        {
                            Console.WriteLine(cur);
                        }
                        foreach (Player cur in sortPlayers)
                        {
                            Console.WriteLine(cur);
                        }

                        break;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }
    }
}
