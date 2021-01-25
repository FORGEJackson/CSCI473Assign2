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
        static void Main(string[] args)
        {
            string curLine;
            List<Item> Items = new List<Item>();

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

                Items.Add(new Item(id, values[1], (ItemType)type, ilvl, primary, stamina, requirement, values[7]));
                curLine = inFile.ReadLine();
            }

            foreach (Item cur in Items)
            {
                System.Console.WriteLine(cur);
            }

        }
    }
}
