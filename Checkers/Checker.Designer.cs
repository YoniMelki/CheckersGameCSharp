namespace Checkers
{
    public partial class Checker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checker));
            this.m_Player1 = new System.Windows.Forms.Label();
            this.m_Player2 = new System.Windows.Forms.Label();
            this.Player1Score = new System.Windows.Forms.Label();
            this.Player2Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_Player1
            // 
            this.m_Player1.AutoSize = true;
            this.m_Player1.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Player1.Location = new System.Drawing.Point(45, 26);
            this.m_Player1.Name = "m_Player1";
            this.m_Player1.Size = new System.Drawing.Size(53, 21);
            this.m_Player1.TabIndex = 0;
            this.m_Player1.Text = "label1";
            this.m_Player1.Click += new System.EventHandler(this.Player1_Click);
            // 
            // m_Player2
            // 
            this.m_Player2.AutoSize = true;
            this.m_Player2.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Player2.Location = new System.Drawing.Point(205, 26);
            this.m_Player2.Name = "m_Player2";
            this.m_Player2.Size = new System.Drawing.Size(56, 21);
            this.m_Player2.TabIndex = 1;
            this.m_Player2.Text = "label2";
            this.m_Player2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Player1Score
            // 
            this.Player1Score.AutoSize = true;
            this.Player1Score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Player1Score.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Score.Location = new System.Drawing.Point(147, 26);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(21, 23);
            this.Player1Score.TabIndex = 2;
            this.Player1Score.Text = "0";
            // 
            // Player2Score
            // 
            this.Player2Score.AutoSize = true;
            this.Player2Score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Player2Score.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Score.Location = new System.Drawing.Point(305, 26);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(21, 23);
            this.Player2Score.TabIndex = 3;
            this.Player2Score.Text = "0";
            this.Player2Score.Click += new System.EventHandler(this.label4_Click);
            // 
            // Checker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(428, 240);
            this.Controls.Add(this.Player2Score);
            this.Controls.Add(this.Player1Score);
            this.Controls.Add(this.m_Player2);
            this.Controls.Add(this.m_Player1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Checker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checker";
            this.Load += new System.EventHandler(this.Checker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Player1Score;
        private System.Windows.Forms.Label Player2Score;
    }
}