namespace EcosystemGame
{
    partial class GameWindow
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
            this.exitGameButton = new System.Windows.Forms.Button();
            this.devButton = new System.Windows.Forms.Button();
            this.devText = new System.Windows.Forms.TextBox();
            this.nextTurnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitGameButton
            // 
            this.exitGameButton.Location = new System.Drawing.Point(1317, 786);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.Size = new System.Drawing.Size(127, 61);
            this.exitGameButton.TabIndex = 0;
            this.exitGameButton.Text = "Exit to Menu";
            this.exitGameButton.UseVisualStyleBackColor = true;
            this.exitGameButton.Click += new System.EventHandler(this.exitGame_Click);
            // 
            // devButton
            // 
            this.devButton.Location = new System.Drawing.Point(149, 148);
            this.devButton.Name = "devButton";
            this.devButton.Size = new System.Drawing.Size(453, 213);
            this.devButton.TabIndex = 1;
            this.devButton.Text = "DEV BUTTON";
            this.devButton.UseVisualStyleBackColor = true;
            this.devButton.Click += new System.EventHandler(this.devButton_Click);
            // 
            // devText
            // 
            this.devText.Location = new System.Drawing.Point(182, 367);
            this.devText.Name = "devText";
            this.devText.Size = new System.Drawing.Size(388, 26);
            this.devText.TabIndex = 2;
            // 
            // nextTurnButton
            // 
            this.nextTurnButton.Location = new System.Drawing.Point(1317, 27);
            this.nextTurnButton.Name = "nextTurnButton";
            this.nextTurnButton.Size = new System.Drawing.Size(127, 56);
            this.nextTurnButton.TabIndex = 3;
            this.nextTurnButton.Text = "Next Turn";
            this.nextTurnButton.UseVisualStyleBackColor = true;
            this.nextTurnButton.Click += new System.EventHandler(this.nextTurnButton_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1456, 859);
            this.Controls.Add(this.nextTurnButton);
            this.Controls.Add(this.devText);
            this.Controls.Add(this.devButton);
            this.Controls.Add(this.exitGameButton);
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitGameButton;
        private System.Windows.Forms.Button devButton;
        private System.Windows.Forms.TextBox devText;
        private System.Windows.Forms.Button nextTurnButton;
    }
}