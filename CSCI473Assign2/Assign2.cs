using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace CSCI473Assign2
{
    public enum ItemType
    {
        Helmet, Neck, Shoulders, Back, Chest,
        Wrist, Gloves, Belt, Pants, Boots,
        Ring, Trinket
    };

    public enum Race { Orc, Troll, Tauren, Forsaken };

    public enum Class 
    { 
        Warrior, Mage, Druid, Priest, Warlock,
        Rogue, Paladin, Hunter, Shaman
    };

    public enum Role { Tank, Healer, DPS };

    public enum Servers { Beta4Azeroth, TKWasASetback, ZappyBoi };

    public enum GuildType { Casual, Questing, Mythic, Raiding, PVP };

    static class Assign2
    {
        public static Dictionary<uint, Item> Items = new Dictionary<uint, Item>();
        public static Dictionary<uint, Player> Players = new Dictionary<uint, Player>();
        public static Dictionary<uint, string> Guilds = new Dictionary<uint, string>();

        //Inverse Dictionaries of the ones above for converting a name to an id
        static Dictionary<string, uint> invItems = new Dictionary<string, uint>();
        static Dictionary<string, uint> invPlayers = new Dictionary<string, uint>();
        static Dictionary<string, uint> invGuilds = new Dictionary<string, uint>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WOCForm());
        }

        static void setup()
        {
            //Load in all Items
            string curLine;


            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("CSCI473Assign2.equipment.txt");
            StreamReader inFile = new StreamReader(stream);

            curLine = inFile.ReadLine();
            while (curLine != null)
            {
                string[] values = curLine.Split('\t');

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
            stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("CSCI473Assign2.players.txt");
            inFile = new StreamReader(stream);

            curLine = inFile.ReadLine();
            while (curLine != null)
            {
                string[] values = curLine.Split('\t');
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
            stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("CSCI473Assign2.guilds.txt");
            inFile = new StreamReader(stream);

            curLine = inFile.ReadLine();
            while (curLine != null)
            {
                string[] values = curLine.Split('\t');

                UInt32.TryParse(values[0], out uint id);

                Guilds.Add(id, values[1]);
                invGuilds.Add(values[1], id);
                curLine = inFile.ReadLine();
            }
        }
    }
}
