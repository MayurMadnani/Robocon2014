namespace Robocon2014
{
    partial class shabaash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shabaash));
            this.button1 = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblShabaash = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(65, 746);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Winner";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Finish
            // 
            this.Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Finish.Location = new System.Drawing.Point(949, 746);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(75, 23);
            this.Finish.TabIndex = 3;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Transparent;
            this.textBox2.Font = new System.Drawing.Font("Klavika Bd", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Yellow;
            this.textBox2.Location = new System.Drawing.Point(-19, 275);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1086, 361);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textBox2.Click += new System.EventHandler(this.txtShabaash_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(-1, 746);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Game";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblShabaash
            // 
            this.lblShabaash.BackColor = System.Drawing.Color.Transparent;
            this.lblShabaash.Font = new System.Drawing.Font("Homestead Inline", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShabaash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblShabaash.Location = new System.Drawing.Point(32, 106);
            this.lblShabaash.Name = "lblShabaash";
            this.lblShabaash.Size = new System.Drawing.Size(992, 154);
            this.lblShabaash.TabIndex = 5;
            this.lblShabaash.Text = "SHABAASH";
            this.lblShabaash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // shabaash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.lblShabaash);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "shabaash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "shabaash";
            this.Load += new System.EventHandler(this.shabaash_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Label textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblShabaash;
        private System.Windows.Forms.Timer timer1;
    }
}