namespace EcosystemGame
{
    partial class GameMenu
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
            this.titleText = new System.Windows.Forms.TextBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.exitGameButton = new System.Windows.Forms.Button();
            this.subTitleText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.titleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleText.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleText.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleText.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.ForeColor = System.Drawing.Color.White;
            this.titleText.Location = new System.Drawing.Point(0, 0);
            this.titleText.Name = "titleText";
            this.titleText.ReadOnly = true;
            this.titleText.Size = new System.Drawing.Size(1439, 65);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "Lake Simulator";
            this.titleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.White;
            this.startGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startGameButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.ForeColor = System.Drawing.Color.Black;
            this.startGameButton.Location = new System.Drawing.Point(609, 276);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(262, 79);
            this.startGameButton.TabIndex = 1;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // exitGameButton
            // 
            this.exitGameButton.BackColor = System.Drawing.Color.White;
            this.exitGameButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitGameButton.ForeColor = System.Drawing.Color.Black;
            this.exitGameButton.Location = new System.Drawing.Point(609, 397);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.Size = new System.Drawing.Size(262, 79);
            this.exitGameButton.TabIndex = 2;
            this.exitGameButton.Text = "Exit Game";
            this.exitGameButton.UseVisualStyleBackColor = false;
            this.exitGameButton.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // subTitleText
            // 
            this.subTitleText.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.subTitleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subTitleText.Cursor = System.Windows.Forms.Cursors.Default;
            this.subTitleText.Dock = System.Windows.Forms.DockStyle.Top;
            this.subTitleText.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleText.ForeColor = System.Drawing.Color.White;
            this.subTitleText.Location = new System.Drawing.Point(0, 65);
            this.subTitleText.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.subTitleText.Name = "subTitleText";
            this.subTitleText.ReadOnly = true;
            this.subTitleText.Size = new System.Drawing.Size(1439, 33);
            this.subTitleText.TabIndex = 3;
            this.subTitleText.Text = "An exciting game of mistrust, intrigue, and the struggle for survival";
            this.subTitleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1439, 887);
            this.Controls.Add(this.subTitleText);
            this.Controls.Add(this.exitGameButton);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.titleText);
            this.Name = "GameMenu";
            this.Text = "GameMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button exitGameButton;
        private System.Windows.Forms.TextBox subTitleText;
    }
}