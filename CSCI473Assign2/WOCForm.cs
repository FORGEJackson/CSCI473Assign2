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
        public WOCForm()
        {
            InitializeComponent();
        }

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

        private void btnPrintGuild_Click(object sender, EventArgs e)
        {
            Guild curGuild = (Guild)lbxGuilds.SelectedItem;
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

        private void btnDisbandGuild_Click(object sender, EventArgs e)
        {
            Guild curGuild = (Guild)lbxGuilds.SelectedItem;
            foreach (KeyValuePair<uint, Player> cur in Assign2.Players)
            {
                if (cur.Value.GuildID == curGuild.Id)
                    cur.Value.GuildID = 0; //Error message of "too many characters in character literal, so just make it '0'??
            }
            lbxGuilds.Items.Remove(curGuild);
        }

        private void btnJoinGuild_Click(object sender, EventArgs e)
        {
            Player curPlayer = (Player)lbxPlayers.SelectedItem;
            Guild curGuild = (Guild)lbxGuilds.SelectedItem;
            if (lbxPlayers.SelectedIndex == -1 || lbxGuilds.SelectedIndex == -1)
            {
                //print error message in RichTextBox
            }
            //else add Player to selected Guild
        }

        private void btnLeaveGuild_Click(object sender, EventArgs e)
        {

        }

        private void btnApplySearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            uint id = (uint)rand.Next(0, 99999999);
            Player newPlayer = new Player(id, txtPlayerName.Text, (Race)cbxRace.SelectedItem, (Class)cbxClass.SelectedItem, (Role)cbxRole.SelectedItem, 0, 0, 0);
            Assign2.Players.Add(id, newPlayer);
            UpdateLists();            
        }

        private void btnAddGuild_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            uint id = (uint)rand.Next(0, 999999);
            Guild newGuild = new Guild(id, txtGuildName.Text, (Servers)cbxServer.SelectedItem, (GuildType)cbxType.SelectedItem);
            Assign2.Guilds.Add(id, newGuild);
            UpdateLists();
        }

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

        private void cbxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddPlayer.Enabled = true;
        }
    }
}