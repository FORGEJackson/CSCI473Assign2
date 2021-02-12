/*  Authors:    Joshua Jackson z1855047
 *              Connor Whitten z1819460
 *      
 *      CSCI 473 Assignment 2
 *      WOCForm.cs
 *      This file contains the event handling for WOCForm
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI473Assign2
{
    public partial class WOCForm : Form
    {
        /*
         * WOCForm
         * Initializes components
        */
        public WOCForm()
        {
            InitializeComponent();
        }

        /*
         * WOCForm_Load
         * Connects Data sources for the comboboxes and calls UpdateLists() to populate the lists
         * 
         * Arguments:   Default event handler arguments
        */
        private void WOCForm_Load(object sender, EventArgs e)
        {
            //Populate Combo boxes
            this.cbxRace.DataSource = Enum.GetValues(typeof(Race));
            this.cbxClass.DataSource = Enum.GetValues(typeof(Class));
            //this.cbxRole.DataSource = Enum.GetValues(typeof(Role));
            this.cbxServer.DataSource = Enum.GetValues(typeof(Servers));
            this.cbxType.DataSource = Enum.GetValues(typeof(GuildType));

            UpdateLists();
        }

        /*
         * UpdateLists
         * Creates lists from the Dictionaries in Assign2.cs to act as a DataSource for lbxPlayers and lbxGuilds
        */
        private void UpdateLists()
        {
            //Populate Players listbox
            List<Player> playerList = new List<Player>();
            foreach (KeyValuePair<uint, Player> cur in Assign2.Players)
            {
                playerList.Add(cur.Value);
            }
            lbxPlayers.DataSource = playerList;

            //Populate Guilds listbox
            List<Guild> guildList = new List<Guild>();
            foreach (KeyValuePair<uint, Guild> cur in Assign2.Guilds)
            {
                guildList.Add(cur.Value);
            }
            lbxGuilds.DataSource = guildList;
        }

        /*
         * btnPrintGuild_Click
         * Prints a list of all members belonging to the Currently Selected Guild
         * 
         * Arguments:   Default event handler arguments
        */
        private void btnPrintGuild_Click(object sender, EventArgs e)
        {
            Guild curGuild = (Guild)lbxGuilds.SelectedItem;
            curGuild.ToString();
            string outputHeader = String.Format("Guild listing for {0}\r{1}\r\n", curGuild, String.Empty.PadRight(64, '-'));
            txtOutput.AppendText(outputHeader);
            foreach (KeyValuePair<uint, Player> cur in Assign2.Players)
            {
                if (cur.Value.GuildID == curGuild.Id)
                {
                    string playerOutput = String.Format("Name: {0} Race: {1} Level: {2} Guild: {3}\r", cur.Value.Name.PadRight(16, ' '), cur.Value.Race.ToString().PadRight(8, ' '), cur.Value.Level.ToString().PadRight(8, ' '), Assign2.Guilds[cur.Value.GuildID].ToString());
                    txtOutput.AppendText(playerOutput);
                }

            }
        }

        /*
         * btnDisbandGuild_Click
         * Removes all Players from the selected Guild and then deletes it from Assign2.Guilds
         * 
         * Arguments:   Default event handler arguments
        */
        private void btnDisbandGuild_Click(object sender, EventArgs e)
        {
            Guild curGuild = (Guild)lbxGuilds.SelectedItem;
            curGuild.ToString();
            foreach (KeyValuePair<uint, Player> cur in Assign2.Players)
            {
                if (cur.Value.GuildID == curGuild.Id)
                    cur.Value.GuildID = 0;
            }
            Assign2.Guilds.Remove(curGuild.Id);
            UpdateLists();
        }

        /*
         * btnJoinGuild_Click
         * Sets the currently selected player's guildId to the currently selected guild
         * 
         * Arguments:   Default event handler arguments
        */
        private void btnJoinGuild_Click(object sender, EventArgs e)
        {
            Player curPlayer = (Player)lbxPlayers.SelectedItem;
            curPlayer.ToString();
            Guild curGuild = (Guild)lbxGuilds.SelectedItem;
            curGuild.ToString();
            if (lbxPlayers.SelectedIndex == -1 || lbxGuilds.SelectedIndex == -1)
            {
                txtOutput.AppendText("You must select both a Player and a Guild.");
            }
            else curPlayer.GuildID = curGuild.Id;
        }

        /*
         * btnLeaveGuild_Click
         * Sets the currently selected Player's guild id to 0
         * 
         * Arguments:   Default event handler arguments
        */
        private void btnLeaveGuild_Click(object sender, EventArgs e)
        {
            Player curPlayer = (Player)lbxPlayers.SelectedItem;
            curPlayer.ToString();
            Guild curGuild = (Guild)lbxGuilds.SelectedItem;
            curGuild.ToString();
            if (lbxPlayers.SelectedIndex == -1 || lbxGuilds.SelectedIndex == -1)
            {
                txtOutput.AppendText("You must select both a Player and a Guild.");
            }
            else curPlayer.GuildID = '0';
        }

        /*
         * btnApplySearch_Click
         * Applies search filters to their respective lists
         * 
         * Arguments:   Default event handler arguments
        */
        private void btnApplySearch_Click(object sender, EventArgs e)
        {
            Dictionary<uint, Player> copy1 = new Dictionary<uint, Player>(Assign2.Players);
            Dictionary<uint, Guild> copy2 = new Dictionary<uint, Guild>(Assign2.Guilds);
            if(txtSearchPlayer.Text == "" && txtSearchGuild.Text == "")
            {
                txtOutput.AppendText("No filter criteria was chosen.");
            }
            else if(txtSearchPlayer.Text != "")
            {
                foreach (KeyValuePair<uint, Player> cur in Assign2.Players)
                {
                    if (!cur.Value.Name.StartsWith(txtSearchPlayer.Text))
                            copy1.Remove(cur.Key);
                }
                int length1 = copy1.Count;
                if(length1 == 0)
                    txtOutput.AppendText("Nothing was a match for your Player filtering criteria.\r");
                else lbxPlayers.DataSource = copy1;
            }
            else if(txtSearchGuild.Text != "")
            {
                Servers.TryParse(txtSearchGuild.Text, out Servers server);
                foreach (KeyValuePair<uint, Guild> cur in Assign2.Guilds)
                {
                    if (cur.Value.Location != server)
                        copy2.Remove(cur.Key);
                }
                int length2 = copy2.Count;
                if (length2 == 0)
                    txtOutput.AppendText("Nothing was a match for your Guild filtering criteria.\r");
                else lbxGuilds.DataSource = copy2;
            }
        }

        /*
         * btnAddPlayer_Click
         * Creates a new Player from the parameters in the group box and adds them to Assign2.Players
         * 
         * Arguments:   Default event handler arguments
        */
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            uint id = (uint)rand.Next(0, 99999999);
            Player newPlayer = new Player(id, txtPlayerName.Text, (Race)cbxRace.SelectedItem, (Class)cbxClass.SelectedItem, (Role)cbxRole.SelectedItem, 0, 0, 0);
            Assign2.Players.Add(id, newPlayer);
            UpdateLists();            
        }

        /*
         * btnAddGuild_Click
         * Creates a new Guild from the parameters in the group box and adds it to Assign2.Guilds
         * 
         * Arguments:   Default event handler arguments
        */
        private void btnAddGuild_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            uint id = (uint)rand.Next(0, 999999);
            Guild newGuild = new Guild(id, txtGuildName.Text, (Servers)cbxServer.SelectedItem, (GuildType)cbxType.SelectedItem);
            Assign2.Guilds.Add(id, newGuild);
            UpdateLists();
        }

        /*
         * cbxClass_SelectedIndexChanged
         * Enables cbxRole and adds the available roles to the box
         * 
         * Arguments:   Default event handler arguments
        */
        private void cbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxRole.Enabled = true;

            cbxRole.Items.Clear();

            switch(cbxClass.SelectedIndex)
            {
                case 0:
                    this.cbxRole.Items.Add((Role)0);
                    this.cbxRole.Items.Add((Role)2);
                    break;
                case 1:
                    this.cbxRole.Items.Add((Role)2);
                    break;
                case 2:
                    this.cbxRole.Items.Add((Role)0);
                    this.cbxRole.Items.Add((Role)1);
                    this.cbxRole.Items.Add((Role)2);
                    break;
                case 3:
                    this.cbxRole.Items.Add((Role)1);
                    this.cbxRole.Items.Add((Role)2);
                    break;
                case 4:
                    this.cbxRole.Items.Add((Role)2);
                    break;
                case 5:
                    this.cbxRole.Items.Add((Role)2);
                    break;
                case 6:
                    this.cbxRole.Items.Add((Role)0);
                    this.cbxRole.Items.Add((Role)1);
                    this.cbxRole.Items.Add((Role)2);
                    break;
                case 7:
                    this.cbxRole.Items.Add((Role)2);
                    break;
                case 8:
                    this.cbxRole.Items.Add((Role)1);
                    this.cbxRole.Items.Add((Role)2);
                    break;
            }
        }

        /*
         * cbxRole_SelectdIndexChanged
         * Enables the AddPlayer button once all the options have been filled
         * 
         * Arguments:   Default event handler arguments
        */
        private void cbxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddPlayer.Enabled = true;
        }

        /*
         * lbxPlayers_SelectdIndexChanged
         * Outputs the currently selectd Player's ToString method to txtOutput
         * 
         * Arguments:   Default event handler arguments
        */
        private void lbxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtOutput.AppendText(lbxPlayers.SelectedItem.ToString() + "\r");
        }

        /*
         * lbxGuilds_SelectdIndexChanged
         * Outputs the currently selectd Guild's ToString method to txtOutput
         * 
         * Arguments:   Default event handler arguments
        */
        private void lbxGuilds_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtOutput.AppendText(lbxGuilds.SelectedItem.ToString() + "\r");
        } 
    }
}