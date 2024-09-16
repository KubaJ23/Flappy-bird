
namespace Flappy_bird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.StartGamebtn = new System.Windows.Forms.Button();
            this.HighScorelbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Scorelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.BackColor = System.Drawing.Color.Transparent;
            this.Titlelbl.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Titlelbl.ForeColor = System.Drawing.Color.Gold;
            this.Titlelbl.Location = new System.Drawing.Point(264, 24);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(289, 64);
            this.Titlelbl.TabIndex = 0;
            this.Titlelbl.Text = "Flappy Burd";
            // 
            // StartGamebtn
            // 
            this.StartGamebtn.BackColor = System.Drawing.Color.Transparent;
            this.StartGamebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartGamebtn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartGamebtn.Location = new System.Drawing.Point(312, 130);
            this.StartGamebtn.Name = "StartGamebtn";
            this.StartGamebtn.Size = new System.Drawing.Size(189, 54);
            this.StartGamebtn.TabIndex = 1;
            this.StartGamebtn.Text = "Start Game";
            this.StartGamebtn.UseVisualStyleBackColor = false;
            this.StartGamebtn.Click += new System.EventHandler(this.StartGamebtn_Click);
            // 
            // HighScorelbl
            // 
            this.HighScorelbl.AutoSize = true;
            this.HighScorelbl.BackColor = System.Drawing.Color.Transparent;
            this.HighScorelbl.Font = new System.Drawing.Font("Segoe UI Emoji", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HighScorelbl.ForeColor = System.Drawing.Color.Gold;
            this.HighScorelbl.Location = new System.Drawing.Point(264, 211);
            this.HighScorelbl.Name = "HighScorelbl";
            this.HighScorelbl.Size = new System.Drawing.Size(205, 47);
            this.HighScorelbl.TabIndex = 2;
            this.HighScorelbl.Text = "High score:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Scorelbl
            // 
            this.Scorelbl.AutoSize = true;
            this.Scorelbl.BackColor = System.Drawing.Color.Transparent;
            this.Scorelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Scorelbl.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Scorelbl.ForeColor = System.Drawing.Color.Red;
            this.Scorelbl.Location = new System.Drawing.Point(12, 9);
            this.Scorelbl.Name = "Scorelbl";
            this.Scorelbl.Size = new System.Drawing.Size(56, 60);
            this.Scorelbl.TabIndex = 3;
            this.Scorelbl.Text = "0";
            this.Scorelbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Scorelbl);
            this.Controls.Add(this.HighScorelbl);
            this.Controls.Add(this.StartGamebtn);
            this.Controls.Add(this.Titlelbl);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Button StartGamebtn;
        private System.Windows.Forms.Label HighScorelbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Scorelbl;
    }
}

