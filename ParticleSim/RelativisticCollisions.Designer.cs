namespace ParticleSim
{
    partial class RelativisticCollisions
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
            this.panelCM = new System.Windows.Forms.Panel();
            this.panelLab = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelCM
            // 
            this.panelCM.BackColor = System.Drawing.Color.White;
            this.panelCM.Location = new System.Drawing.Point(37, 42);
            this.panelCM.Name = "panelCM";
            this.panelCM.Size = new System.Drawing.Size(300, 300);
            this.panelCM.TabIndex = 0;
            // 
            // panelLab
            // 
            this.panelLab.BackColor = System.Drawing.Color.White;
            this.panelLab.Location = new System.Drawing.Point(389, 42);
            this.panelLab.Name = "panelLab";
            this.panelLab.Size = new System.Drawing.Size(300, 300);
            this.panelLab.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.panelMenu.Location = new System.Drawing.Point(37, 375);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(652, 252);
            this.panelMenu.TabIndex = 2;
            // 
            // RelativisticCollisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(742, 660);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelLab);
            this.Controls.Add(this.panelCM);
            this.Name = "RelativisticCollisions";
            this.Text = "RelativisticCollisions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCM;
        private System.Windows.Forms.Panel panelLab;
        private System.Windows.Forms.Panel panelMenu;
    }
}