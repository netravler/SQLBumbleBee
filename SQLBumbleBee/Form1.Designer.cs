namespace SQLBumbleBee
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Server = new System.Windows.Forms.TextBox();
            this.Database = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.TextBox();
            this.Pin = new System.Windows.Forms.TextBox();
            this.Col = new System.Windows.Forms.TextBox();
            this.ManualQuery = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Table = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Server
            // 
            this.Server.Location = new System.Drawing.Point(17, 34);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(100, 20);
            this.Server.TabIndex = 0;
            this.Server.Text = "Server";
            this.toolTip1.SetToolTip(this.Server, "Type in server name");
            // 
            // Database
            // 
            this.Database.Location = new System.Drawing.Point(17, 70);
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(100, 20);
            this.Database.TabIndex = 1;
            this.Database.Text = "Database";
            this.toolTip1.SetToolTip(this.Database, "Type in database name");
            // 
            // UserID
            // 
            this.UserID.Location = new System.Drawing.Point(17, 106);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(100, 20);
            this.UserID.TabIndex = 2;
            this.UserID.Text = "UserID";
            this.toolTip1.SetToolTip(this.UserID, "User with rights to the database");
            // 
            // Pin
            // 
            this.Pin.Location = new System.Drawing.Point(17, 142);
            this.Pin.Name = "Pin";
            this.Pin.Size = new System.Drawing.Size(100, 20);
            this.Pin.TabIndex = 3;
            this.Pin.Text = "Pin";
            // 
            // Col
            // 
            this.Col.AcceptsTab = true;
            this.Col.Location = new System.Drawing.Point(17, 214);
            this.Col.Multiline = true;
            this.Col.Name = "Col";
            this.Col.Size = new System.Drawing.Size(100, 20);
            this.Col.TabIndex = 5;
            this.Col.Text = "Col";
            this.toolTip1.SetToolTip(this.Col, "Initial column to examine");
            this.Col.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // ManualQuery
            // 
            this.ManualQuery.Location = new System.Drawing.Point(142, 215);
            this.ManualQuery.Name = "ManualQuery";
            this.ManualQuery.Size = new System.Drawing.Size(822, 20);
            this.ManualQuery.TabIndex = 6;
            this.ManualQuery.Text = "ManualQuery";
            this.toolTip1.SetToolTip(this.ManualQuery, "Enter Query then double click");
            this.ManualQuery.DoubleClick += new System.EventHandler(this.ManualQuery_DoubleClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(280, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(684, 160);
            this.listBox1.TabIndex = 7;
            this.toolTip1.SetToolTip(this.listBox1, "Double click to run");
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            this.listBox1.MouseHover += new System.EventHandler(this.listBox1_MouseHover);
            // 
            // Table
            // 
            this.Table.Location = new System.Drawing.Point(17, 178);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(100, 20);
            this.Table.TabIndex = 4;
            this.Table.Text = "Table";
            this.toolTip1.SetToolTip(this.Table, "Initial table to examine");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Click to exit application";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(142, 35);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 160);
            this.listBox2.TabIndex = 9;
            this.toolTip1.SetToolTip(this.listBox2, "Single click on a column");
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox2.MouseHover += new System.EventHandler(this.listBox2_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 240);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ManualQuery);
            this.Controls.Add(this.Col);
            this.Controls.Add(this.Pin);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.Database);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SQLBumbleBee";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Server;
        private System.Windows.Forms.TextBox Database;
        private System.Windows.Forms.TextBox UserID;
        private System.Windows.Forms.TextBox Pin;
        private System.Windows.Forms.TextBox Col;
        private System.Windows.Forms.TextBox ManualQuery;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox Table;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

