namespace EcosystemGame
{
    partial class TestForm
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
            this.startgamebutton = new System.Windows.Forms.Button();
            this.exitgamebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startgamebutton
            // 
            this.startgamebutton.Location = new System.Drawing.Point(394, 158);
            this.startgamebutton.Name = "startgamebutton";
            this.startgamebutton.Size = new System.Drawing.Size(404, 122);
            this.startgamebutton.TabIndex = 0;
            this.startgamebutton.Text = "Start Game";
            this.startgamebutton.UseVisualStyleBackColor = true;
            // 
            // exitgamebutton
            // 
            this.exitgamebutton.Location = new System.Drawing.Point(394, 305);
            this.exitgamebutton.Name = "exitgamebutton";
            this.exitgamebutton.Size = new System.Drawing.Size(404, 122);
            this.exitgamebutton.TabIndex = 1;
            this.exitgamebutton.Text = "Exit Game";
            this.exitgamebutton.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1227, 787);
            this.Controls.Add(this.exitgamebutton);
            this.Controls.Add(this.startgamebutton);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startgamebutton;
        private System.Windows.Forms.Button exitgamebutton;
    }
}