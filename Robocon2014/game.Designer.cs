namespace Robocon2014
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.txtRedTeam = new System.Windows.Forms.Label();
            this.txtBlueTeam = new System.Windows.Forms.Label();
            this.RedTeamImage = new System.Windows.Forms.PictureBox();
            this.BlueTeamImage = new System.Windows.Forms.PictureBox();
            this.lblRedScore = new System.Windows.Forms.Label();
            this.lblBlueScore = new System.Windows.Forms.Label();
            this.txtRedScore = new System.Windows.Forms.TextBox();
            this.txtBlueScore = new System.Windows.Forms.TextBox();
            this.Score = new System.Windows.Forms.Button();
            this.RedSh = new System.Windows.Forms.Button();
            this.BlueSh = new System.Windows.Forms.Button();
            this.butRedWin = new System.Windows.Forms.Button();
            this.butBlueWin = new System.Windows.Forms.Button();
            this.gameStatus = new System.Windows.Forms.Label();
            this.lblshared = new System.Windows.Forms.Label();
            this.lblshablue = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.matchno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RedTeamImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTeamImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRedTeam
            // 
            this.txtRedTeam.BackColor = System.Drawing.Color.Transparent;
            this.txtRedTeam.Font = new System.Drawing.Font("Klavika Rg", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRedTeam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRedTeam.Location = new System.Drawing.Point(31, 185);
            this.txtRedTeam.Name = "txtRedTeam";
            this.txtRedTeam.Size = new System.Drawing.Size(407, 43);
            this.txtRedTeam.TabIndex = 0;
            this.txtRedTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBlueTeam
            // 
            this.txtBlueTeam.BackColor = System.Drawing.Color.Transparent;
            this.txtBlueTeam.Font = new System.Drawing.Font("Klavika Rg", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlueTeam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBlueTeam.Location = new System.Drawing.Point(588, 185);
            this.txtBlueTeam.Name = "txtBlueTeam";
            this.txtBlueTeam.Size = new System.Drawing.Size(407, 43);
            this.txtBlueTeam.TabIndex = 1;
            this.txtBlueTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RedTeamImage
            // 
            this.RedTeamImage.Location = new System.Drawing.Point(133, 284);
            this.RedTeamImage.Name = "RedTeamImage";
            this.RedTeamImage.Size = new System.Drawing.Size(233, 144);
            this.RedTeamImage.TabIndex = 2;
            this.RedTeamImage.TabStop = false;
            // 
            // BlueTeamImage
            // 
            this.BlueTeamImage.Location = new System.Drawing.Point(685, 281);
            this.BlueTeamImage.Name = "BlueTeamImage";
            this.BlueTeamImage.Size = new System.Drawing.Size(233, 144);
            this.BlueTeamImage.TabIndex = 3;
            this.BlueTeamImage.TabStop = false;
            // 
            // lblRedScore
            // 
            this.lblRedScore.BackColor = System.Drawing.Color.Transparent;
            this.lblRedScore.Font = new System.Drawing.Font("Digital dream Fat", 99.74999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblRedScore.Location = new System.Drawing.Point(61, 431);
            this.lblRedScore.Name = "lblRedScore";
            this.lblRedScore.Size = new System.Drawing.Size(377, 312);
            this.lblRedScore.TabIndex = 4;
            this.lblRedScore.Text = "0";
            this.lblRedScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlueScore
            // 
            this.lblBlueScore.AutoEllipsis = true;
            this.lblBlueScore.BackColor = System.Drawing.Color.Transparent;
            this.lblBlueScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBlueScore.Font = new System.Drawing.Font("Digital dream Fat", 99.74999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblBlueScore.Location = new System.Drawing.Point(610, 431);
            this.lblBlueScore.Name = "lblBlueScore";
            this.lblBlueScore.Size = new System.Drawing.Size(385, 312);
            this.lblBlueScore.TabIndex = 5;
            this.lblBlueScore.Text = "0";
            this.lblBlueScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRedScore
            // 
            this.txtRedScore.BackColor = System.Drawing.SystemColors.Info;
            this.txtRedScore.Location = new System.Drawing.Point(232, 746);
            this.txtRedScore.Name = "txtRedScore";
            this.txtRedScore.Size = new System.Drawing.Size(23, 20);
            this.txtRedScore.TabIndex = 6;
            // 
            // txtBlueScore
            // 
            this.txtBlueScore.Location = new System.Drawing.Point(780, 746);
            this.txtBlueScore.Name = "txtBlueScore";
            this.txtBlueScore.Size = new System.Drawing.Size(21, 20);
            this.txtBlueScore.TabIndex = 7;
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Score.Location = new System.Drawing.Point(498, 745);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(53, 23);
            this.Score.TabIndex = 8;
            this.Score.Text = "S";
            this.Score.UseVisualStyleBackColor = false;
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // RedSh
            // 
            this.RedSh.BackColor = System.Drawing.Color.Transparent;
            this.RedSh.Location = new System.Drawing.Point(-3, 743);
            this.RedSh.Name = "RedSh";
            this.RedSh.Size = new System.Drawing.Size(33, 26);
            this.RedSh.TabIndex = 9;
            this.RedSh.Text = "SH";
            this.RedSh.UseVisualStyleBackColor = false;
            this.RedSh.Click += new System.EventHandler(this.RedSh_Click);
            // 
            // BlueSh
            // 
            this.BlueSh.BackColor = System.Drawing.Color.Transparent;
            this.BlueSh.Location = new System.Drawing.Point(992, 743);
            this.BlueSh.Name = "BlueSh";
            this.BlueSh.Size = new System.Drawing.Size(33, 23);
            this.BlueSh.TabIndex = 11;
            this.BlueSh.Text = "SH";
            this.BlueSh.UseVisualStyleBackColor = false;
            this.BlueSh.Click += new System.EventHandler(this.BlueSh_Click);
            // 
            // butRedWin
            // 
            this.butRedWin.BackColor = System.Drawing.Color.Transparent;
            this.butRedWin.Location = new System.Drawing.Point(27, 746);
            this.butRedWin.Name = "butRedWin";
            this.butRedWin.Size = new System.Drawing.Size(21, 23);
            this.butRedWin.TabIndex = 12;
            this.butRedWin.Text = "W";
            this.butRedWin.UseVisualStyleBackColor = false;
            this.butRedWin.Click += new System.EventHandler(this.butRedWin_Click);
            // 
            // butBlueWin
            // 
            this.butBlueWin.BackColor = System.Drawing.Color.Transparent;
            this.butBlueWin.Location = new System.Drawing.Point(970, 743);
            this.butBlueWin.Name = "butBlueWin";
            this.butBlueWin.Size = new System.Drawing.Size(25, 23);
            this.butBlueWin.TabIndex = 13;
            this.butBlueWin.Text = "W";
            this.butBlueWin.UseVisualStyleBackColor = false;
            this.butBlueWin.Click += new System.EventHandler(this.butBlueWin_Click);
            // 
            // gameStatus
            // 
            this.gameStatus.BackColor = System.Drawing.Color.Transparent;
            this.gameStatus.Font = new System.Drawing.Font("Klavika Rg", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStatus.ForeColor = System.Drawing.Color.Yellow;
            this.gameStatus.Location = new System.Drawing.Point(381, 308);
            this.gameStatus.Name = "gameStatus";
            this.gameStatus.Size = new System.Drawing.Size(298, 120);
            this.gameStatus.TabIndex = 14;
            this.gameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblshared
            // 
            this.lblshared.BackColor = System.Drawing.Color.Transparent;
            this.lblshared.Font = new System.Drawing.Font("Homestead Inline", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshared.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblshared.Location = new System.Drawing.Point(-7, 482);
            this.lblshared.Name = "lblshared";
            this.lblshared.Size = new System.Drawing.Size(505, 170);
            this.lblshared.TabIndex = 15;
            this.lblshared.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblshared.Visible = false;
            // 
            // lblshablue
            // 
            this.lblshablue.BackColor = System.Drawing.Color.Transparent;
            this.lblshablue.Font = new System.Drawing.Font("Homestead Inline", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshablue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblshablue.Location = new System.Drawing.Point(544, 482);
            this.lblshablue.Name = "lblshablue";
            this.lblshablue.Size = new System.Drawing.Size(505, 170);
            this.lblshablue.TabIndex = 16;
            this.lblshablue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblshablue.Visible = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(994, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(31, 23);
            this.Close.TabIndex = 17;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // matchno
            // 
            this.matchno.BackColor = System.Drawing.Color.Transparent;
            this.matchno.Font = new System.Drawing.Font("Klavika Bd", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchno.ForeColor = System.Drawing.Color.Yellow;
            this.matchno.Location = new System.Drawing.Point(415, 431);
            this.matchno.Name = "matchno";
            this.matchno.Size = new System.Drawing.Size(204, 51);
            this.matchno.TabIndex = 18;
            this.matchno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.matchno);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.lblshablue);
            this.Controls.Add(this.lblshared);
            this.Controls.Add(this.gameStatus);
            this.Controls.Add(this.butBlueWin);
            this.Controls.Add(this.butRedWin);
            this.Controls.Add(this.BlueSh);
            this.Controls.Add(this.RedSh);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.txtBlueScore);
            this.Controls.Add(this.txtRedScore);
            this.Controls.Add(this.lblBlueScore);
            this.Controls.Add(this.lblRedScore);
            this.Controls.Add(this.BlueTeamImage);
            this.Controls.Add(this.RedTeamImage);
            this.Controls.Add(this.txtBlueTeam);
            this.Controls.Add(this.txtRedTeam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RedTeamImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTeamImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtRedTeam;
        private System.Windows.Forms.Label txtBlueTeam;
        private System.Windows.Forms.PictureBox RedTeamImage;
        private System.Windows.Forms.PictureBox BlueTeamImage;
        private System.Windows.Forms.Label lblRedScore;
        private System.Windows.Forms.Label lblBlueScore;
        private System.Windows.Forms.TextBox txtRedScore;
        private System.Windows.Forms.TextBox txtBlueScore;
        private System.Windows.Forms.Button Score;
        private System.Windows.Forms.Button RedSh;
        private System.Windows.Forms.Button BlueSh;
        private System.Windows.Forms.Button butRedWin;
        private System.Windows.Forms.Button butBlueWin;
        private System.Windows.Forms.Label gameStatus;
        private System.Windows.Forms.Label lblshared;
        private System.Windows.Forms.Label lblshablue;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label matchno;
    }
}