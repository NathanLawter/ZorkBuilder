namespace ZorkBuilderForm.WinForms
{
    partial class MainForm
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
            this.zorkMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zorkTabControl = new System.Windows.Forms.TabControl();
            this.roomsTab = new System.Windows.Forms.TabPage();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.eastRoomLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.westRoomLabel = new System.Windows.Forms.Label();
            this.southRoomTextBox = new System.Windows.Forms.TextBox();
            this.southRoomLabel = new System.Windows.Forms.Label();
            this.northRoomTextBox = new System.Windows.Forms.TextBox();
            this.northRoomLabel = new System.Windows.Forms.Label();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gameDetailsTab = new System.Windows.Forms.TabPage();
            this.startingLocationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.welcomeMessageTextBox = new System.Windows.Forms.TextBox();
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.createNewDialog = new System.Windows.Forms.SaveFileDialog();
            this.zorkMenuStrip.SuspendLayout();
            this.zorkTabControl.SuspendLayout();
            this.roomsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.gameDetailsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // zorkMenuStrip
            // 
            this.zorkMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.zorkMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.zorkMenuStrip.Name = "zorkMenuStrip";
            this.zorkMenuStrip.Size = new System.Drawing.Size(627, 24);
            this.zorkMenuStrip.TabIndex = 0;
            this.zorkMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewGameToolStripMenuItem,
            this.openWorldToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // createNewGameToolStripMenuItem
            // 
            this.createNewGameToolStripMenuItem.Name = "createNewGameToolStripMenuItem";
            this.createNewGameToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.createNewGameToolStripMenuItem.Text = "&Create New Game...";
            this.createNewGameToolStripMenuItem.Click += new System.EventHandler(this.CreateNewGameToolStripMenuItem_Click);
            // 
            // openWorldToolStripMenuItem
            // 
            this.openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.openWorldToolStripMenuItem.Text = "&Open Game...";
            this.openWorldToolStripMenuItem.Click += new System.EventHandler(this.openWorldToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // zorkTabControl
            // 
            this.zorkTabControl.Controls.Add(this.roomsTab);
            this.zorkTabControl.Controls.Add(this.gameDetailsTab);
            this.zorkTabControl.Location = new System.Drawing.Point(12, 27);
            this.zorkTabControl.Name = "zorkTabControl";
            this.zorkTabControl.SelectedIndex = 0;
            this.zorkTabControl.Size = new System.Drawing.Size(603, 399);
            this.zorkTabControl.TabIndex = 1;
            // 
            // roomsTab
            // 
            this.roomsTab.Controls.Add(this.descriptionTextBox);
            this.roomsTab.Controls.Add(this.descriptionLabel);
            this.roomsTab.Controls.Add(this.textBox2);
            this.roomsTab.Controls.Add(this.eastRoomLabel);
            this.roomsTab.Controls.Add(this.textBox1);
            this.roomsTab.Controls.Add(this.westRoomLabel);
            this.roomsTab.Controls.Add(this.southRoomTextBox);
            this.roomsTab.Controls.Add(this.southRoomLabel);
            this.roomsTab.Controls.Add(this.northRoomTextBox);
            this.roomsTab.Controls.Add(this.northRoomLabel);
            this.roomsTab.Controls.Add(this.roomNameTextBox);
            this.roomsTab.Controls.Add(this.roomNameLabel);
            this.roomsTab.Controls.Add(this.deleteRoomButton);
            this.roomsTab.Controls.Add(this.addRoomButton);
            this.roomsTab.Controls.Add(this.roomsListBox);
            this.roomsTab.Controls.Add(this.listView1);
            this.roomsTab.Location = new System.Drawing.Point(4, 22);
            this.roomsTab.Name = "roomsTab";
            this.roomsTab.Padding = new System.Windows.Forms.Padding(3);
            this.roomsTab.Size = new System.Drawing.Size(595, 373);
            this.roomsTab.TabIndex = 0;
            this.roomsTab.Text = "Rooms";
            this.roomsTab.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(201, 75);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(343, 90);
            this.descriptionTextBox.TabIndex = 15;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(ZorkBuilderForm.WinForms.ViewModels.WorldViewModel);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(198, 58);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 14;
            this.descriptionLabel.Text = "Description:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Neighbors.East", true));
            this.textBox2.Location = new System.Drawing.Point(199, 335);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 13;
            // 
            // eastRoomLabel
            // 
            this.eastRoomLabel.AutoSize = true;
            this.eastRoomLabel.Location = new System.Drawing.Point(196, 318);
            this.eastRoomLabel.Name = "eastRoomLabel";
            this.eastRoomLabel.Size = new System.Drawing.Size(31, 13);
            this.eastRoomLabel.TabIndex = 12;
            this.eastRoomLabel.Text = "East:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Neighbors.West", true));
            this.textBox1.Location = new System.Drawing.Point(199, 288);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 11;
            // 
            // westRoomLabel
            // 
            this.westRoomLabel.AutoSize = true;
            this.westRoomLabel.Location = new System.Drawing.Point(196, 271);
            this.westRoomLabel.Name = "westRoomLabel";
            this.westRoomLabel.Size = new System.Drawing.Size(35, 13);
            this.westRoomLabel.TabIndex = 10;
            this.westRoomLabel.Text = "West:";
            // 
            // southRoomTextBox
            // 
            this.southRoomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Neighbors.South", true));
            this.southRoomTextBox.Location = new System.Drawing.Point(199, 243);
            this.southRoomTextBox.Name = "southRoomTextBox";
            this.southRoomTextBox.Size = new System.Drawing.Size(167, 20);
            this.southRoomTextBox.TabIndex = 9;
            // 
            // southRoomLabel
            // 
            this.southRoomLabel.AutoSize = true;
            this.southRoomLabel.Location = new System.Drawing.Point(196, 226);
            this.southRoomLabel.Name = "southRoomLabel";
            this.southRoomLabel.Size = new System.Drawing.Size(38, 13);
            this.southRoomLabel.TabIndex = 8;
            this.southRoomLabel.Text = "South:";
            // 
            // northRoomTextBox
            // 
            this.northRoomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Neighbors.North", true));
            this.northRoomTextBox.Location = new System.Drawing.Point(199, 197);
            this.northRoomTextBox.Name = "northRoomTextBox";
            this.northRoomTextBox.Size = new System.Drawing.Size(167, 20);
            this.northRoomTextBox.TabIndex = 7;
            // 
            // northRoomLabel
            // 
            this.northRoomLabel.AutoSize = true;
            this.northRoomLabel.Location = new System.Drawing.Point(196, 180);
            this.northRoomLabel.Name = "northRoomLabel";
            this.northRoomLabel.Size = new System.Drawing.Size(36, 13);
            this.northRoomLabel.TabIndex = 6;
            this.northRoomLabel.Text = "North:";
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true));
            this.roomNameTextBox.Location = new System.Drawing.Point(199, 24);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(167, 20);
            this.roomNameTextBox.TabIndex = 5;
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(196, 7);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(38, 13);
            this.roomNameLabel.TabIndex = 4;
            this.roomNameLabel.Text = "Name:";
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Location = new System.Drawing.Point(104, 345);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRoomButton.TabIndex = 3;
            this.deleteRoomButton.Text = "&Delete";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            this.deleteRoomButton.Click += new System.EventHandler(this.DeleteRoomButton_Click);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(6, 345);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomButton.TabIndex = 2;
            this.addRoomButton.Text = "&Add...";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.AddRoomButton_Click);
            // 
            // roomsListBox
            // 
            this.roomsListBox.DataSource = this.roomsBindingSource;
            this.roomsListBox.DisplayMember = "Name";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(0, 0);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(189, 342);
            this.roomsListBox.TabIndex = 1;
            this.roomsListBox.ValueMember = "Description";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(189, 373);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // gameDetailsTab
            // 
            this.gameDetailsTab.Controls.Add(this.startingLocationTextBox);
            this.gameDetailsTab.Controls.Add(this.label1);
            this.gameDetailsTab.Controls.Add(this.welcomeMessageTextBox);
            this.gameDetailsTab.Controls.Add(this.welcomeMessageLabel);
            this.gameDetailsTab.Location = new System.Drawing.Point(4, 22);
            this.gameDetailsTab.Name = "gameDetailsTab";
            this.gameDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.gameDetailsTab.Size = new System.Drawing.Size(595, 373);
            this.gameDetailsTab.TabIndex = 1;
            this.gameDetailsTab.Text = "Game Details";
            this.gameDetailsTab.UseVisualStyleBackColor = true;
            // 
            // startingLocationTextBox
            // 
            this.startingLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worldViewModelBindingSource, "World.StartingLocation", true));
            this.startingLocationTextBox.Location = new System.Drawing.Point(10, 125);
            this.startingLocationTextBox.Name = "startingLocationTextBox";
            this.startingLocationTextBox.Size = new System.Drawing.Size(246, 20);
            this.startingLocationTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Starting Location:";
            // 
            // welcomeMessageTextBox
            // 
            this.welcomeMessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worldViewModelBindingSource, "WelcomeMessage", true));
            this.welcomeMessageTextBox.Location = new System.Drawing.Point(10, 24);
            this.welcomeMessageTextBox.Multiline = true;
            this.welcomeMessageTextBox.Name = "welcomeMessageTextBox";
            this.welcomeMessageTextBox.Size = new System.Drawing.Size(444, 64);
            this.welcomeMessageTextBox.TabIndex = 1;
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.AutoSize = true;
            this.welcomeMessageLabel.Location = new System.Drawing.Point(7, 7);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(101, 13);
            this.welcomeMessageLabel.TabIndex = 0;
            this.welcomeMessageLabel.Text = "Welcome Message:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Game Files (*json)|*.json";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Game Files (*json)|*.json";
            this.saveFileDialog.Title = "Save game file";
            // 
            // createNewDialog
            // 
            this.createNewDialog.Filter = "Game Files (*json)|*.json";
            this.createNewDialog.Title = "Create game file";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 431);
            this.Controls.Add(this.zorkTabControl);
            this.Controls.Add(this.zorkMenuStrip);
            this.MainMenuStrip = this.zorkMenuStrip;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            this.zorkMenuStrip.ResumeLayout(false);
            this.zorkMenuStrip.PerformLayout();
            this.zorkTabControl.ResumeLayout(false);
            this.roomsTab.ResumeLayout(false);
            this.roomsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.gameDetailsTab.ResumeLayout(false);
            this.gameDetailsTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip zorkMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl zorkTabControl;
        private System.Windows.Forms.TabPage roomsTab;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label eastRoomLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label westRoomLabel;
        private System.Windows.Forms.TextBox southRoomTextBox;
        private System.Windows.Forms.Label southRoomLabel;
        private System.Windows.Forms.TextBox northRoomTextBox;
        private System.Windows.Forms.Label northRoomLabel;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabPage gameDetailsTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox welcomeMessageTextBox;
        private System.Windows.Forms.Label welcomeMessageLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.SaveFileDialog createNewDialog;
        private System.Windows.Forms.ToolStripMenuItem createNewGameToolStripMenuItem;
        private System.Windows.Forms.TextBox startingLocationTextBox;
    }
}

