namespace Robocon2014
{
    partial class winner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winner));
            this.txtwinner = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblwinner = new System.Windows.Forms.Label();
            this.txtwinner2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtwinner
            // 
            this.txtwinner.BackColor = System.Drawing.Color.Transparent;
            this.txtwinner.Font = new System.Drawing.Font("Klavika Bd", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwinner.ForeColor = System.Drawing.Color.White;
            this.txtwinner.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.txtwinner.Location = new System.Drawing.Point(12, 402);
            this.txtwinner.Name = "txtwinner";
            this.txtwinner.Size = new System.Drawing.Size(985, 337);
            this.txtwinner.TabIndex = 0;
            this.txtwinner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtwinner.Click += new System.EventHandler(this.txtwinner_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(937, 744);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(244, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblwinner
            // 
            this.lblwinner.BackColor = System.Drawing.Color.Transparent;
            this.lblwinner.Font = new System.Drawing.Font("Klavika Bd", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwinner.ForeColor = System.Drawing.Color.Yellow;
            this.lblwinner.Location = new System.Drawing.Point(12, 76);
            this.lblwinner.Name = "lblwinner";
            this.lblwinner.Size = new System.Drawing.Size(1010, 326);
            this.lblwinner.TabIndex = 4;
            this.lblwinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtwinner2
            // 
            this.txtwinner2.BackColor = System.Drawing.Color.Transparent;
            this.txtwinner2.Font = new System.Drawing.Font("Klavika Bd", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwinner2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtwinner2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.txtwinner2.Location = new System.Drawing.Point(15, 405);
            this.txtwinner2.Name = "txtwinner2";
            this.txtwinner2.Size = new System.Drawing.Size(985, 337);
            this.txtwinner2.TabIndex = 5;
            this.txtwinner2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.txtwinner2);
            this.Controls.Add(this.lblwinner);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtwinner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "winner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.winner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtwinner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblwinner;
        private System.Windows.Forms.Label txtwinner2;
        private System.Windows.Forms.Timer timer1;
    }
}