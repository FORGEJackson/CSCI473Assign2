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
            this.cbxRace.DataSource = Enum.GetValues(typeof(Race));
            this.cbxClass.DataSource = Enum.GetValues(typeof(Class));
            this.cbxRole.DataSource = Enum.GetValues(typeof(Role));
            this.cbxServer.DataSource = Enum.GetValues(typeof(Servers));
            this.cbxType.DataSource = Enum.GetValues(typeof(GuildType));
        }

        private void btnPrintGuild_Click(object sender, EventArgs e)
        {

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
