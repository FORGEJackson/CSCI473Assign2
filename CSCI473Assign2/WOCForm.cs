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
            this.cbxRole.DataSource = Enum.GetValues(typeof(Role));
            this.cbxServer.DataSource = Enum.GetValues(typeof(Servers));
            this.cbxType.DataSource = Enum.GetValues(typeof(GuildType));

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

        }

        private void btnJoinGuild_Click(object sender, EventArgs e)
        {

        }

        private void btnLeaveGuild_Click(object sender, EventArgs e)
        {

        }

        private void btnApplySearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {

        }

        private void btnAddGuild_Click(object sender, EventArgs e)
        {

        }
    }
}
