namespace Presentations.Giao_dien_chinh
{
    partial class GiaoDienChinh1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tmFootball = new System.Windows.Forms.ToolStripMenuItem();
            this.tmReferee = new System.Windows.Forms.ToolStripMenuItem();
            this.tmSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.tmCompetitionResults = new System.Windows.Forms.ToolStripMenuItem();
            this.mSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.pContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuManagement,
            this.mSearch,
            this.mHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuManagement
            // 
            this.MenuManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmFootball,
            this.tmReferee,
            this.tmSchedule,
            this.tmCompetitionResults});
            this.MenuManagement.Name = "MenuManagement";
            this.MenuManagement.Size = new System.Drawing.Size(90, 20);
            this.MenuManagement.Text = "Management";
            // 
            // tmFootball
            // 
            this.tmFootball.Name = "tmFootball";
            this.tmFootball.Size = new System.Drawing.Size(184, 22);
            this.tmFootball.Text = "Football";
            this.tmFootball.Click += new System.EventHandler(this.tmFootball_Click);
            // 
            // tmReferee
            // 
            this.tmReferee.Name = "tmReferee";
            this.tmReferee.Size = new System.Drawing.Size(184, 22);
            this.tmReferee.Text = "Referee";
            this.tmReferee.Click += new System.EventHandler(this.tmReferee_Click);
            // 
            // tmSchedule
            // 
            this.tmSchedule.Name = "tmSchedule";
            this.tmSchedule.Size = new System.Drawing.Size(184, 22);
            this.tmSchedule.Text = "Schedule";
            this.tmSchedule.Click += new System.EventHandler(this.tmSchedule_Click);
            // 
            // tmCompetitionResults
            // 
            this.tmCompetitionResults.Name = "tmCompetitionResults";
            this.tmCompetitionResults.Size = new System.Drawing.Size(184, 22);
            this.tmCompetitionResults.Text = "Competition Results ";
            this.tmCompetitionResults.Click += new System.EventHandler(this.tmCompetitionResults_Click);
            // 
            // mSearch
            // 
            this.mSearch.Name = "mSearch";
            this.mSearch.Size = new System.Drawing.Size(54, 20);
            this.mSearch.Text = "Search";
            this.mSearch.Click += new System.EventHandler(this.mSearch_Click);
            // 
            // mHelp
            // 
            this.mHelp.Name = "mHelp";
            this.mHelp.Size = new System.Drawing.Size(44, 20);
            this.mHelp.Text = "Help";
            this.mHelp.Visible = false;
            this.mHelp.Click += new System.EventHandler(this.mHelp_Click);
            // 
            // pContent
            // 
            this.pContent.BackColor = System.Drawing.Color.Transparent;
            this.pContent.CausesValidation = false;
            this.pContent.Location = new System.Drawing.Point(0, 27);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(981, 496);
            this.pContent.TabIndex = 1;
            // 
            // GiaoDienChinh1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentations.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(987, 564);
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GiaoDienChinh1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiaoDienChinh1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuManagement;
        private System.Windows.Forms.ToolStripMenuItem tmFootball;
        private System.Windows.Forms.ToolStripMenuItem tmReferee;
        private System.Windows.Forms.ToolStripMenuItem tmSchedule;
        private System.Windows.Forms.ToolStripMenuItem tmCompetitionResults;
        private System.Windows.Forms.ToolStripMenuItem mSearch;
        private System.Windows.Forms.ToolStripMenuItem mHelp;
        private System.Windows.Forms.Panel pContent;
    }
}