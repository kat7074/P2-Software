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
            this.nextTurnButton = new System.Windows.Forms.Button();
            this.addFaunaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitGameButton
            // 
            this.exitGameButton.Location = new System.Drawing.Point(878, 511);
            this.exitGameButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.Size = new System.Drawing.Size(85, 40);
            this.exitGameButton.TabIndex = 0;
            this.exitGameButton.Text = "Exit to Menu";
            this.exitGameButton.UseVisualStyleBackColor = true;
            this.exitGameButton.Click += new System.EventHandler(this.exitGame_Click);
            // 
            // devButton
            // 
            this.devButton.Location = new System.Drawing.Point(99, 96);
            this.devButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.devButton.Name = "devButton";
            this.devButton.Size = new System.Drawing.Size(302, 138);
            this.devButton.TabIndex = 1;
            this.devButton.Text = "DEV BUTTON";
            this.devButton.UseVisualStyleBackColor = true;
            this.devButton.Click += new System.EventHandler(this.devButton_Click);
            // 
            // nextTurnButton
            // 
            this.nextTurnButton.Location = new System.Drawing.Point(878, 18);
            this.nextTurnButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextTurnButton.Name = "nextTurnButton";
            this.nextTurnButton.Size = new System.Drawing.Size(85, 36);
            this.nextTurnButton.TabIndex = 3;
            this.nextTurnButton.Text = "Next Turn";
            this.nextTurnButton.UseVisualStyleBackColor = true;
            this.nextTurnButton.Click += new System.EventHandler(this.nextTurnButton_Click);
            // 
            // addFaunaButton
            // 
            this.addFaunaButton.Location = new System.Drawing.Point(877, 254);
            this.addFaunaButton.Name = "addFaunaButton";
            this.addFaunaButton.Size = new System.Drawing.Size(85, 36);
            this.addFaunaButton.TabIndex = 5;
            this.addFaunaButton.Text = "Add Fauna";
            this.addFaunaButton.UseVisualStyleBackColor = true;
            this.addFaunaButton.Click += new System.EventHandler(this.addFaunaButton_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(974, 558);
            this.Controls.Add(this.addFaunaButton);
            this.Controls.Add(this.nextTurnButton);
            this.Controls.Add(this.devButton);
            this.Controls.Add(this.exitGameButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitGameButton;
        private System.Windows.Forms.Button devButton;
        private System.Windows.Forms.Button nextTurnButton;
        private System.Windows.Forms.Button addFaunaButton;
    }
}