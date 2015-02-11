namespace Robocon2014
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerTeamToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Start = new System.Windows.Forms.Button();
            this.roboconDBDataSet = new Robocon2014.RoboconDBDataSet();
            this.roboconTeamTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roboconTeamTableTableAdapter = new Robocon2014.RoboconDBDataSetTableAdapters.RoboconTeamTableTableAdapter();
            this.RedTeam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BlueTeam = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.quaterfin = new System.Windows.Forms.Button();
            this.txtAred = new System.Windows.Forms.TextBox();
            this.txtAblue = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roboconDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roboconTeamTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerTeamToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 744);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // registerTeamToolStripMenuItem
            // 
            this.registerTeamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerTeamToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.registerTeamToolStripMenuItem.Name = "registerTeamToolStripMenuItem";
            this.registerTeamToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.registerTeamToolStripMenuItem.Text = "System";
            this.registerTeamToolStripMenuItem.Click += new System.EventHandler(this.registerTeamToolStripMenuItem_Click);
            // 
            // registerTeamToolStripMenuItem1
            // 
            this.registerTeamToolStripMenuItem1.Name = "registerTeamToolStripMenuItem1";
            this.registerTeamToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.registerTeamToolStripMenuItem1.Text = "Register Team";
            this.registerTeamToolStripMenuItem1.Click += new System.EventHandler(this.registerTeamToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Start
            // 
            this.Start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start.Location = new System.Drawing.Point(918, 744);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(106, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start Game";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // roboconDBDataSet
            // 
            this.roboconDBDataSet.DataSetName = "RoboconDBDataSet";
            this.roboconDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roboconTeamTableBindingSource
            // 
            this.roboconTeamTableBindingSource.DataMember = "RoboconTeamTable";
            this.roboconTeamTableBindingSource.DataSource = this.roboconDBDataSet;
            // 
            // roboconTeamTableTableAdapter
            // 
            this.roboconTeamTableTableAdapter.ClearBeforeFill = true;
            // 
            // RedTeam
            // 
            this.RedTeam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.RedTeam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RedTeam.FormattingEnabled = true;
            this.RedTeam.Location = new System.Drawing.Point(298, 746);
            this.RedTeam.Name = "RedTeam";
            this.RedTeam.Size = new System.Drawing.Size(224, 21);
            this.RedTeam.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 716);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 716);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            this.label2.Visible = false;
            // 
            // BlueTeam
            // 
            this.BlueTeam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BlueTeam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BlueTeam.FormattingEnabled = true;
            this.BlueTeam.Location = new System.Drawing.Point(583, 747);
            this.BlueTeam.Name = "BlueTeam";
            this.BlueTeam.Size = new System.Drawing.Size(254, 21);
            this.BlueTeam.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(119, 744);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "P";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(215, 744);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "S";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(262, 744);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "F";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // quaterfin
            // 
            this.quaterfin.Location = new System.Drawing.Point(167, 744);
            this.quaterfin.Name = "quaterfin";
            this.quaterfin.Size = new System.Drawing.Size(21, 23);
            this.quaterfin.TabIndex = 9;
            this.quaterfin.Text = "Q";
            this.quaterfin.UseVisualStyleBackColor = true;
            this.quaterfin.Click += new System.EventHandler(this.quaterfin_Click);
            // 
            // txtAred
            // 
            this.txtAred.Location = new System.Drawing.Point(536, 746);
            this.txtAred.Name = "txtAred";
            this.txtAred.Size = new System.Drawing.Size(26, 20);
            this.txtAred.TabIndex = 10;
            // 
            // txtAblue
            // 
            this.txtAblue.Location = new System.Drawing.Point(852, 746);
            this.txtAblue.Name = "txtAblue";
            this.txtAblue.Size = new System.Drawing.Size(29, 20);
            this.txtAblue.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.txtAblue);
            this.Controls.Add(this.txtAred);
            this.Controls.Add(this.quaterfin);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BlueTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RedTeam);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roboconDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roboconTeamTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerTeamToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button Start;
        private RoboconDBDataSet roboconDBDataSet;
        private System.Windows.Forms.BindingSource roboconTeamTableBindingSource;
        private RoboconDBDataSetTableAdapters.RoboconTeamTableTableAdapter roboconTeamTableTableAdapter;
        private System.Windows.Forms.ComboBox RedTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BlueTeam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button quaterfin;
        private System.Windows.Forms.TextBox txtAred;
        private System.Windows.Forms.TextBox txtAblue;
    }
}

