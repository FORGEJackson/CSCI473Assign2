
namespace CSCI473Assign2
{
    partial class WOCForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxManagement = new System.Windows.Forms.GroupBox();
            this.txtSearchGuild = new System.Windows.Forms.TextBox();
            this.lblSearchGuild = new System.Windows.Forms.Label();
            this.txtSearchPlayer = new System.Windows.Forms.TextBox();
            this.lblSearchPlayer = new System.Windows.Forms.Label();
            this.btnApplySearch = new System.Windows.Forms.Button();
            this.btnLeaveGuild = new System.Windows.Forms.Button();
            this.btnJoinGuild = new System.Windows.Forms.Button();
            this.btnDisbandGuild = new System.Windows.Forms.Button();
            this.btnPrintGuild = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxCreatePlayer = new System.Windows.Forms.GroupBox();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.cbxRace = new System.Windows.Forms.ComboBox();
            this.lblRace = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.gbxCreateGuild = new System.Windows.Forms.GroupBox();
            this.btnAddGuild = new System.Windows.Forms.Button();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.cbxServer = new System.Windows.Forms.ComboBox();
            this.txtGuildName = new System.Windows.Forms.TextBox();
            this.lblGuildName = new System.Windows.Forms.Label();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.lblGuilds = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lbxPlayers = new System.Windows.Forms.ListBox();
            this.lbxGuilds = new System.Windows.Forms.ListBox();
            this.gbxManagement.SuspendLayout();
            this.gbxCreatePlayer.SuspendLayout();
            this.gbxCreateGuild.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxManagement
            // 
            this.gbxManagement.Controls.Add(this.txtSearchGuild);
            this.gbxManagement.Controls.Add(this.lblSearchGuild);
            this.gbxManagement.Controls.Add(this.txtSearchPlayer);
            this.gbxManagement.Controls.Add(this.lblSearchPlayer);
            this.gbxManagement.Controls.Add(this.btnApplySearch);
            this.gbxManagement.Controls.Add(this.btnLeaveGuild);
            this.gbxManagement.Controls.Add(this.btnJoinGuild);
            this.gbxManagement.Controls.Add(this.btnDisbandGuild);
            this.gbxManagement.Controls.Add(this.btnPrintGuild);
            this.gbxManagement.Location = new System.Drawing.Point(12, 49);
            this.gbxManagement.Name = "gbxManagement";
            this.gbxManagement.Size = new System.Drawing.Size(356, 172);
            this.gbxManagement.TabIndex = 0;
            this.gbxManagement.TabStop = false;
            this.gbxManagement.Text = "Management Functions";
            // 
            // txtSearchGuild
            // 
            this.txtSearchGuild.Location = new System.Drawing.Point(142, 110);
            this.txtSearchGuild.Name = "txtSearchGuild";
            this.txtSearchGuild.Size = new System.Drawing.Size(121, 20);
            this.txtSearchGuild.TabIndex = 9;
            // 
            // lblSearchGuild
            // 
            this.lblSearchGuild.AutoSize = true;
            this.lblSearchGuild.Location = new System.Drawing.Point(139, 94);
            this.lblSearchGuild.Name = "lblSearchGuild";
            this.lblSearchGuild.Size = new System.Drawing.Size(122, 13);
            this.lblSearchGuild.TabIndex = 8;
            this.lblSearchGuild.Text = "Search Guild (by Server)";
            // 
            // txtSearchPlayer
            // 
            this.txtSearchPlayer.Location = new System.Drawing.Point(142, 51);
            this.txtSearchPlayer.Name = "txtSearchPlayer";
            this.txtSearchPlayer.Size = new System.Drawing.Size(121, 20);
            this.txtSearchPlayer.TabIndex = 7;
            // 
            // lblSearchPlayer
            // 
            this.lblSearchPlayer.AutoSize = true;
            this.lblSearchPlayer.Location = new System.Drawing.Point(139, 35);
            this.lblSearchPlayer.Name = "lblSearchPlayer";
            this.lblSearchPlayer.Size = new System.Drawing.Size(124, 13);
            this.lblSearchPlayer.TabIndex = 6;
            this.lblSearchPlayer.Text = "Search Player (by Name)";
            // 
            // btnApplySearch
            // 
            this.btnApplySearch.Location = new System.Drawing.Point(7, 138);
            this.btnApplySearch.Name = "btnApplySearch";
            this.btnApplySearch.Size = new System.Drawing.Size(113, 23);
            this.btnApplySearch.TabIndex = 4;
            this.btnApplySearch.Text = "Apply Search Criteria";
            this.btnApplySearch.UseVisualStyleBackColor = true;
            this.btnApplySearch.Click += new System.EventHandler(this.btnApplySearch_Click);
            // 
            // btnLeaveGuild
            // 
            this.btnLeaveGuild.Location = new System.Drawing.Point(7, 108);
            this.btnLeaveGuild.Name = "btnLeaveGuild";
            this.btnLeaveGuild.Size = new System.Drawing.Size(113, 23);
            this.btnLeaveGuild.TabIndex = 3;
            this.btnLeaveGuild.Text = "Leave Guild";
            this.btnLeaveGuild.UseVisualStyleBackColor = true;
            this.btnLeaveGuild.Click += new System.EventHandler(this.btnLeaveGuild_Click);
            // 
            // btnJoinGuild
            // 
            this.btnJoinGuild.Location = new System.Drawing.Point(7, 78);
            this.btnJoinGuild.Name = "btnJoinGuild";
            this.btnJoinGuild.Size = new System.Drawing.Size(113, 23);
            this.btnJoinGuild.TabIndex = 2;
            this.btnJoinGuild.Text = "Join Guild";
            this.btnJoinGuild.UseVisualStyleBackColor = true;
            this.btnJoinGuild.Click += new System.EventHandler(this.btnJoinGuild_Click);
            // 
            // btnDisbandGuild
            // 
            this.btnDisbandGuild.Location = new System.Drawing.Point(6, 48);
            this.btnDisbandGuild.Name = "btnDisbandGuild";
            this.btnDisbandGuild.Size = new System.Drawing.Size(114, 23);
            this.btnDisbandGuild.TabIndex = 1;
            this.btnDisbandGuild.Text = "Disband Guild";
            this.btnDisbandGuild.UseVisualStyleBackColor = true;
            this.btnDisbandGuild.Click += new System.EventHandler(this.btnDisbandGuild_Click);
            // 
            // btnPrintGuild
            // 
            this.btnPrintGuild.Location = new System.Drawing.Point(6, 19);
            this.btnPrintGuild.Name = "btnPrintGuild";
            this.btnPrintGuild.Size = new System.Drawing.Size(114, 23);
            this.btnPrintGuild.TabIndex = 0;
            this.btnPrintGuild.Text = "Print Guild Roster";
            this.btnPrintGuild.UseVisualStyleBackColor = true;
            this.btnPrintGuild.Click += new System.EventHandler(this.btnPrintGuild_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player/Guild Management System";
            // 
            // gbxCreatePlayer
            // 
            this.gbxCreatePlayer.Controls.Add(this.cbxRole);
            this.gbxCreatePlayer.Controls.Add(this.lblRole);
            this.gbxCreatePlayer.Controls.Add(this.cbxClass);
            this.gbxCreatePlayer.Controls.Add(this.lblClass);
            this.gbxCreatePlayer.Controls.Add(this.btnAddPlayer);
            this.gbxCreatePlayer.Controls.Add(this.cbxRace);
            this.gbxCreatePlayer.Controls.Add(this.lblRace);
            this.gbxCreatePlayer.Controls.Add(this.txtPlayerName);
            this.gbxCreatePlayer.Controls.Add(this.lblPlayerName);
            this.gbxCreatePlayer.Location = new System.Drawing.Point(12, 228);
            this.gbxCreatePlayer.Name = "gbxCreatePlayer";
            this.gbxCreatePlayer.Size = new System.Drawing.Size(356, 112);
            this.gbxCreatePlayer.TabIndex = 2;
            this.gbxCreatePlayer.TabStop = false;
            this.gbxCreatePlayer.Text = "Create New Player";
            // 
            // cbxRole
            // 
            this.cbxRole.Enabled = false;
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(142, 75);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(121, 21);
            this.cbxRole.TabIndex = 8;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(139, 60);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 13);
            this.lblRole.TabIndex = 7;
            this.lblRole.Text = "Role";
            // 
            // cbxClass
            // 
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(6, 75);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(121, 21);
            this.cbxClass.TabIndex = 6;
            this.cbxClass.SelectedIndexChanged += new System.EventHandler(this.cbxClass_SelectedIndexChanged);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(7, 59);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 5;
            this.lblClass.Text = "Class";
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(275, 36);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(75, 20);
            this.btnAddPlayer.TabIndex = 4;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // cbxRace
            // 
            this.cbxRace.FormattingEnabled = true;
            this.cbxRace.Location = new System.Drawing.Point(142, 36);
            this.cbxRace.Name = "cbxRace";
            this.cbxRace.Size = new System.Drawing.Size(121, 21);
            this.cbxRace.TabIndex = 3;
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(139, 20);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(33, 13);
            this.lblRace.TabIndex = 2;
            this.lblRace.Text = "Race";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(7, 36);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(120, 20);
            this.txtPlayerName.TabIndex = 1;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(7, 20);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(67, 13);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player Name";
            // 
            // gbxCreateGuild
            // 
            this.gbxCreateGuild.Controls.Add(this.btnAddGuild);
            this.gbxCreateGuild.Controls.Add(this.cbxType);
            this.gbxCreateGuild.Controls.Add(this.lblType);
            this.gbxCreateGuild.Controls.Add(this.lblServer);
            this.gbxCreateGuild.Controls.Add(this.cbxServer);
            this.gbxCreateGuild.Controls.Add(this.txtGuildName);
            this.gbxCreateGuild.Controls.Add(this.lblGuildName);
            this.gbxCreateGuild.Location = new System.Drawing.Point(12, 346);
            this.gbxCreateGuild.Name = "gbxCreateGuild";
            this.gbxCreateGuild.Size = new System.Drawing.Size(356, 113);
            this.gbxCreateGuild.TabIndex = 3;
            this.gbxCreateGuild.TabStop = false;
            this.gbxCreateGuild.Text = "Create New Guild";
            // 
            // btnAddGuild
            // 
            this.btnAddGuild.Location = new System.Drawing.Point(275, 35);
            this.btnAddGuild.Name = "btnAddGuild";
            this.btnAddGuild.Size = new System.Drawing.Size(75, 21);
            this.btnAddGuild.TabIndex = 6;
            this.btnAddGuild.Text = "Add Guild";
            this.btnAddGuild.UseVisualStyleBackColor = true;
            this.btnAddGuild.Click += new System.EventHandler(this.btnAddGuild_Click);
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(142, 80);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 21);
            this.cbxType.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(142, 63);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(142, 19);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(38, 13);
            this.lblServer.TabIndex = 3;
            this.lblServer.Text = "Server";
            // 
            // cbxServer
            // 
            this.cbxServer.FormattingEnabled = true;
            this.cbxServer.Location = new System.Drawing.Point(142, 35);
            this.cbxServer.Name = "cbxServer";
            this.cbxServer.Size = new System.Drawing.Size(121, 21);
            this.cbxServer.TabIndex = 2;
            // 
            // txtGuildName
            // 
            this.txtGuildName.Location = new System.Drawing.Point(7, 37);
            this.txtGuildName.Name = "txtGuildName";
            this.txtGuildName.Size = new System.Drawing.Size(120, 20);
            this.txtGuildName.TabIndex = 1;
            // 
            // lblGuildName
            // 
            this.lblGuildName.AutoSize = true;
            this.lblGuildName.Location = new System.Drawing.Point(7, 20);
            this.lblGuildName.Name = "lblGuildName";
            this.lblGuildName.Size = new System.Drawing.Size(62, 13);
            this.lblGuildName.TabIndex = 0;
            this.lblGuildName.Text = "Guild Name";
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPlayers.Location = new System.Drawing.Point(390, 57);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(71, 24);
            this.lblPlayers.TabIndex = 5;
            this.lblPlayers.Text = "Players";
            // 
            // lblGuilds
            // 
            this.lblGuilds.AutoSize = true;
            this.lblGuilds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblGuilds.Location = new System.Drawing.Point(673, 57);
            this.lblGuilds.Name = "lblGuilds";
            this.lblGuilds.Size = new System.Drawing.Size(63, 24);
            this.lblGuilds.TabIndex = 7;
            this.lblGuilds.Text = "Guilds";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblOutput.Location = new System.Drawing.Point(12, 466);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(66, 24);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(12, 494);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(986, 142);
            this.txtOutput.TabIndex = 9;
            // 
            // lbxPlayers
            // 
            this.lbxPlayers.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPlayers.FormattingEnabled = true;
            this.lbxPlayers.ItemHeight = 14;
            this.lbxPlayers.Location = new System.Drawing.Point(394, 84);
            this.lbxPlayers.Name = "lbxPlayers";
            this.lbxPlayers.Size = new System.Drawing.Size(263, 368);
            this.lbxPlayers.TabIndex = 10;
            // 
            // lbxGuilds
            // 
            this.lbxGuilds.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxGuilds.FormattingEnabled = true;
            this.lbxGuilds.ItemHeight = 14;
            this.lbxGuilds.Location = new System.Drawing.Point(677, 84);
            this.lbxGuilds.Name = "lbxGuilds";
            this.lbxGuilds.Size = new System.Drawing.Size(306, 368);
            this.lbxGuilds.TabIndex = 11;
            // 
            // WOCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1020, 648);
            this.Controls.Add(this.lbxGuilds);
            this.Controls.Add(this.lbxPlayers);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblGuilds);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.gbxCreateGuild);
            this.Controls.Add(this.gbxCreatePlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxManagement);
            this.Name = "WOCForm";
            this.Text = "World of ConflictCraft: Player/Guild Management System";
            this.Load += new System.EventHandler(this.WOCForm_Load);
            this.gbxManagement.ResumeLayout(false);
            this.gbxManagement.PerformLayout();
            this.gbxCreatePlayer.ResumeLayout(false);
            this.gbxCreatePlayer.PerformLayout();
            this.gbxCreateGuild.ResumeLayout(false);
            this.gbxCreateGuild.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxManagement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintGuild;
        private System.Windows.Forms.Button btnApplySearch;
        private System.Windows.Forms.Button btnLeaveGuild;
        private System.Windows.Forms.Button btnJoinGuild;
        private System.Windows.Forms.Button btnDisbandGuild;
        private System.Windows.Forms.Label lblSearchPlayer;
        private System.Windows.Forms.TextBox txtSearchGuild;
        private System.Windows.Forms.Label lblSearchGuild;
        private System.Windows.Forms.TextBox txtSearchPlayer;
        private System.Windows.Forms.GroupBox gbxCreatePlayer;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.ComboBox cbxRace;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.GroupBox gbxCreateGuild;
        private System.Windows.Forms.Button btnAddGuild;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ComboBox cbxServer;
        private System.Windows.Forms.TextBox txtGuildName;
        private System.Windows.Forms.Label lblGuildName;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Label lblGuilds;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ListBox lbxPlayers;
        private System.Windows.Forms.ListBox lbxGuilds;
    }
}

