namespace Checkers
{
    public partial class GameSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSettingsForm));
            this.BoardSize = new System.Windows.Forms.Label();
            this.smallDim = new System.Windows.Forms.RadioButton();
            this.mediumDim = new System.Windows.Forms.RadioButton();
            this.LargeDim = new System.Windows.Forms.RadioButton();
            this.Players = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player1TextBox = new System.Windows.Forms.TextBox();
            this.Player2CheckBox = new System.Windows.Forms.CheckBox();
            this.Player2TextBox = new System.Windows.Forms.TextBox();
            this.Done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoardSize
            // 
            this.BoardSize.AutoSize = true;
            this.BoardSize.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardSize.Location = new System.Drawing.Point(11, 11);
            this.BoardSize.Name = "BoardSize";
            this.BoardSize.Size = new System.Drawing.Size(93, 18);
            this.BoardSize.TabIndex = 0;
            this.BoardSize.Text = "Board Size:";
            // 
            // smallDim
            // 
            this.smallDim.AutoSize = true;
            this.smallDim.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallDim.Location = new System.Drawing.Point(27, 40);
            this.smallDim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.smallDim.Name = "smallDim";
            this.smallDim.Size = new System.Drawing.Size(61, 21);
            this.smallDim.TabIndex = 0;
            this.smallDim.TabStop = true;
            this.smallDim.Text = "6 x 6";
            this.smallDim.UseVisualStyleBackColor = true;
            // 
            // mediumDim
            // 
            this.mediumDim.AutoSize = true;
            this.mediumDim.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumDim.Location = new System.Drawing.Point(108, 40);
            this.mediumDim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mediumDim.Name = "mediumDim";
            this.mediumDim.Size = new System.Drawing.Size(61, 21);
            this.mediumDim.TabIndex = 1;
            this.mediumDim.TabStop = true;
            this.mediumDim.Text = "8 x 8";
            this.mediumDim.UseVisualStyleBackColor = true;
            this.mediumDim.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // LargeDim
            // 
            this.LargeDim.AutoSize = true;
            this.LargeDim.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LargeDim.Location = new System.Drawing.Point(187, 40);
            this.LargeDim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LargeDim.Name = "LargeDim";
            this.LargeDim.Size = new System.Drawing.Size(77, 21);
            this.LargeDim.TabIndex = 2;
            this.LargeDim.TabStop = true;
            this.LargeDim.Text = "10 x 10";
            this.LargeDim.UseVisualStyleBackColor = true;
            // 
            // Players
            // 
            this.Players.AutoSize = true;
            this.Players.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Players.Location = new System.Drawing.Point(32, 75);
            this.Players.Name = "Players";
            this.Players.Size = new System.Drawing.Size(70, 18);
            this.Players.TabIndex = 4;
            this.Players.Text = "Players:";
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Player1.Location = new System.Drawing.Point(55, 99);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(62, 17);
            this.Player1.TabIndex = 5;
            this.Player1.Text = "Player 1:";
            // 
            // Player1TextBox
            // 
            this.Player1TextBox.Location = new System.Drawing.Point(142, 97);
            this.Player1TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player1TextBox.Name = "Player1TextBox";
            this.Player1TextBox.Size = new System.Drawing.Size(123, 22);
            this.Player1TextBox.TabIndex = 3;
            this.Player1TextBox.TextChanged += new System.EventHandler(this.Player1TextBox_TextChanged_1);
            // 
            // Player2CheckBox
            // 
            this.Player2CheckBox.AutoSize = true;
            this.Player2CheckBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Player2CheckBox.Location = new System.Drawing.Point(53, 122);
            this.Player2CheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player2CheckBox.Name = "Player2CheckBox";
            this.Player2CheckBox.Size = new System.Drawing.Size(84, 21);
            this.Player2CheckBox.TabIndex = 4;
            this.Player2CheckBox.Text = "Player 2:";
            this.Player2CheckBox.UseVisualStyleBackColor = true;
            this.Player2CheckBox.CheckedChanged += new System.EventHandler(this.Player2CheckBox_CheckedChanged_1);
            // 
            // Player2TextBox
            // 
            this.Player2TextBox.Enabled = false;
            this.Player2TextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Player2TextBox.Location = new System.Drawing.Point(143, 122);
            this.Player2TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player2TextBox.Name = "Player2TextBox";
            this.Player2TextBox.Size = new System.Drawing.Size(122, 24);
            this.Player2TextBox.TabIndex = 5;
            this.Player2TextBox.Text = "[Computer]";
            this.Player2TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Done
            // 
            this.Done.AllowDrop = true;
            this.Done.BackColor = System.Drawing.Color.LightSalmon;
            this.Done.Enabled = false;
            this.Done.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Done.Location = new System.Drawing.Point(177, 158);
            this.Done.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(88, 24);
            this.Done.TabIndex = 9;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = false;
            this.Done.Click += new System.EventHandler(this.Done_Click_1);
            // 
            // GameSettingsForm
            // 
            this.AcceptButton = this.Done;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(288, 198);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Player2TextBox);
            this.Controls.Add(this.Player2CheckBox);
            this.Controls.Add(this.Player1TextBox);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Players);
            this.Controls.Add(this.LargeDim);
            this.Controls.Add(this.mediumDim);
            this.Controls.Add(this.smallDim);
            this.Controls.Add(this.BoardSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BoardSize;
        private System.Windows.Forms.RadioButton smallDim;
        private System.Windows.Forms.RadioButton mediumDim;
        private System.Windows.Forms.RadioButton LargeDim;
        private System.Windows.Forms.Label Players;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.TextBox Player1TextBox;
        private System.Windows.Forms.CheckBox Player2CheckBox;
        private System.Windows.Forms.TextBox Player2TextBox;
        private System.Windows.Forms.Button Done;
    }
}