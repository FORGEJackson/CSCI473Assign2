using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI473Assign2
{
    public enum ItemType
    {
        Helmet, Neck, Shoulders, Back, Chest,
        Wrist, Gloves, Belt, Pants, Boots,
        Ring, Trinket
    };

    public enum Race { Orc, Troll, Tauren, Forsaken };

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
    }
}
