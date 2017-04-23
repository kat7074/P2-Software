namespace EcosystemGame
{
    partial class GameWindowFaunaSelector
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
            this.addFishButton01 = new System.Windows.Forms.Button();
            this.addFishButton02 = new System.Windows.Forms.Button();
            this.addFishButton03 = new System.Windows.Forms.Button();
            this.addFishButton04 = new System.Windows.Forms.Button();
            this.faunaSelectorExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addFishButton01
            // 
            this.addFishButton01.Location = new System.Drawing.Point(12, 12);
            this.addFishButton01.Name = "addFishButton01";
            this.addFishButton01.Size = new System.Drawing.Size(142, 52);
            this.addFishButton01.TabIndex = 1;
            this.addFishButton01.Text = "Add one Eel";
            this.addFishButton01.UseVisualStyleBackColor = true;
            this.addFishButton01.Click += new System.EventHandler(this.addEelButton_Click);
            // 
            // addFishButton02
            // 
            this.addFishButton02.Enabled = false;
            this.addFishButton02.Location = new System.Drawing.Point(12, 70);
            this.addFishButton02.Name = "addFishButton02";
            this.addFishButton02.Size = new System.Drawing.Size(142, 52);
            this.addFishButton02.TabIndex = 2;
            this.addFishButton02.Text = "Add Fish 2";
            this.addFishButton02.UseVisualStyleBackColor = true;
            // 
            // addFishButton03
            // 
            this.addFishButton03.Enabled = false;
            this.addFishButton03.Location = new System.Drawing.Point(12, 128);
            this.addFishButton03.Name = "addFishButton03";
            this.addFishButton03.Size = new System.Drawing.Size(142, 52);
            this.addFishButton03.TabIndex = 3;
            this.addFishButton03.Text = "Add Fish 3";
            this.addFishButton03.UseVisualStyleBackColor = true;
            // 
            // addFishButton04
            // 
            this.addFishButton04.Enabled = false;
            this.addFishButton04.Location = new System.Drawing.Point(12, 186);
            this.addFishButton04.Name = "addFishButton04";
            this.addFishButton04.Size = new System.Drawing.Size(142, 52);
            this.addFishButton04.TabIndex = 4;
            this.addFishButton04.Text = "Add Fish 4";
            this.addFishButton04.UseVisualStyleBackColor = true;
            // 
            // faunaSelectorExitButton
            // 
            this.faunaSelectorExitButton.Location = new System.Drawing.Point(12, 247);
            this.faunaSelectorExitButton.Name = "faunaSelectorExitButton";
            this.faunaSelectorExitButton.Size = new System.Drawing.Size(142, 52);
            this.faunaSelectorExitButton.TabIndex = 5;
            this.faunaSelectorExitButton.Text = "Back";
            this.faunaSelectorExitButton.UseVisualStyleBackColor = true;
            this.faunaSelectorExitButton.Click += new System.EventHandler(this.faunaSelectorExitButton_Click);
            // 
            // GameWindowFaunaSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(164, 311);
            this.Controls.Add(this.faunaSelectorExitButton);
            this.Controls.Add(this.addFishButton04);
            this.Controls.Add(this.addFishButton03);
            this.Controls.Add(this.addFishButton02);
            this.Controls.Add(this.addFishButton01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameWindowFaunaSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GameWindowFaunaSelector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addFishButton01;
        private System.Windows.Forms.Button addFishButton02;
        private System.Windows.Forms.Button addFishButton03;
        private System.Windows.Forms.Button addFishButton04;
        private System.Windows.Forms.Button faunaSelectorExitButton;
    }
}