namespace ParticleSim
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.btn1D = new System.Windows.Forms.Button();
            this.btn2D = new System.Windows.Forms.Button();
            this.btnRelativistic = new System.Windows.Forms.Button();
            this.btnGaseous = new System.Windows.Forms.Button();
            this.titleMenu = new System.Windows.Forms.TextBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHelpGuide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1D
            // 
            this.btn1D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn1D.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn1D.FlatAppearance.BorderSize = 0;
            this.btn1D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1D.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1D.ForeColor = System.Drawing.Color.White;
            this.btn1D.Location = new System.Drawing.Point(76, 181);
            this.btn1D.Name = "btn1D";
            this.btn1D.Size = new System.Drawing.Size(242, 92);
            this.btn1D.TabIndex = 0;
            this.btn1D.Text = "1D Collisions";
            this.btn1D.UseVisualStyleBackColor = false;
            this.btn1D.Click += new System.EventHandler(this.Navigate);
            // 
            // btn2D
            // 
            this.btn2D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn2D.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn2D.FlatAppearance.BorderSize = 0;
            this.btn2D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2D.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2D.ForeColor = System.Drawing.Color.White;
            this.btn2D.Location = new System.Drawing.Point(348, 181);
            this.btn2D.Name = "btn2D";
            this.btn2D.Size = new System.Drawing.Size(242, 92);
            this.btn2D.TabIndex = 1;
            this.btn2D.Text = "2D Collisions";
            this.btn2D.UseVisualStyleBackColor = false;
            this.btn2D.Click += new System.EventHandler(this.Navigate);
            // 
            // btnRelativistic
            // 
            this.btnRelativistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnRelativistic.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRelativistic.FlatAppearance.BorderSize = 0;
            this.btnRelativistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelativistic.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelativistic.ForeColor = System.Drawing.Color.White;
            this.btnRelativistic.Location = new System.Drawing.Point(76, 295);
            this.btnRelativistic.Name = "btnRelativistic";
            this.btnRelativistic.Size = new System.Drawing.Size(242, 92);
            this.btnRelativistic.TabIndex = 2;
            this.btnRelativistic.Text = "Relativistic Collisions";
            this.btnRelativistic.UseVisualStyleBackColor = false;
            this.btnRelativistic.Click += new System.EventHandler(this.Navigate);
            // 
            // btnGaseous
            // 
            this.btnGaseous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnGaseous.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGaseous.FlatAppearance.BorderSize = 0;
            this.btnGaseous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGaseous.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGaseous.ForeColor = System.Drawing.Color.White;
            this.btnGaseous.Location = new System.Drawing.Point(348, 295);
            this.btnGaseous.Name = "btnGaseous";
            this.btnGaseous.Size = new System.Drawing.Size(242, 92);
            this.btnGaseous.TabIndex = 3;
            this.btnGaseous.Text = "Gaseous Collisions";
            this.btnGaseous.UseVisualStyleBackColor = false;
            this.btnGaseous.Click += new System.EventHandler(this.Navigate);
            // 
            // titleMenu
            // 
            this.titleMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.titleMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleMenu.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleMenu.ForeColor = System.Drawing.Color.White;
            this.titleMenu.Location = new System.Drawing.Point(76, 100);
            this.titleMenu.Name = "titleMenu";
            this.titleMenu.Size = new System.Drawing.Size(606, 45);
            this.titleMenu.TabIndex = 4;
            this.titleMenu.Text = "Particle Collision Simulator";
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(583, 33);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(58, 43);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.Navigate);
            // 
            // btnHelpGuide
            // 
            this.btnHelpGuide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnHelpGuide.FlatAppearance.BorderSize = 0;
            this.btnHelpGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpGuide.Image = ((System.Drawing.Image)(resources.GetObject("btnHelpGuide.Image")));
            this.btnHelpGuide.Location = new System.Drawing.Point(536, 34);
            this.btnHelpGuide.Name = "btnHelpGuide";
            this.btnHelpGuide.Size = new System.Drawing.Size(42, 40);
            this.btnHelpGuide.TabIndex = 7;
            this.btnHelpGuide.UseVisualStyleBackColor = false;
            this.btnHelpGuide.Click += new System.EventHandler(this.Navigate);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(662, 453);
            this.Controls.Add(this.btnHelpGuide);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.titleMenu);
            this.Controls.Add(this.btnGaseous);
            this.Controls.Add(this.btnRelativistic);
            this.Controls.Add(this.btn2D);
            this.Controls.Add(this.btn1D);
            this.Name = "StartMenu";
            this.Text = "Start Menu";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1D;
        private System.Windows.Forms.Button btn2D;
        private System.Windows.Forms.Button btnRelativistic;
        private System.Windows.Forms.Button btnGaseous;
        private System.Windows.Forms.TextBox titleMenu;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnHelpGuide;
    }
}

