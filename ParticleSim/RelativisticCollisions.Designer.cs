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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelativisticCollisions));
            this.panelCM = new System.Windows.Forms.Panel();
            this.labelClockCM = new System.Windows.Forms.Label();
            this.panelLab = new System.Windows.Forms.Panel();
            this.labelClockLab = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.textBoxVelocityB = new System.Windows.Forms.TextBox();
            this.textBoxVelocityA = new System.Windows.Forms.TextBox();
            this.buttonCreateParticle = new System.Windows.Forms.Button();
            this.comboBoxColorB = new System.Windows.Forms.ComboBox();
            this.labelColorB = new System.Windows.Forms.Label();
            this.comboBoxColorA = new System.Windows.Forms.ComboBox();
            this.labelColorA = new System.Windows.Forms.Label();
            this.labelVelocityB = new System.Windows.Forms.Label();
            this.labelVelocityA = new System.Windows.Forms.Label();
            this.labelParticleB = new System.Windows.Forms.Label();
            this.labelMassB = new System.Windows.Forms.Label();
            this.textBoxMassB = new System.Windows.Forms.TextBox();
            this.labelParticleA = new System.Windows.Forms.Label();
            this.labelMassA = new System.Windows.Forms.Label();
            this.textBoxMassA = new System.Windows.Forms.TextBox();
            this.trackBarVelocityA = new System.Windows.Forms.TrackBar();
            this.trackBarVelocityB = new System.Windows.Forms.TrackBar();
            this.buttonArrowBack = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.panelUIOptions = new System.Windows.Forms.Panel();
            this.checkBoxArrows = new System.Windows.Forms.CheckBox();
            this.checkBoxGrid = new System.Windows.Forms.CheckBox();
            this.panelCM.SuspendLayout();
            this.panelLab.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocityA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocityB)).BeginInit();
            this.panelUIOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCM
            // 
            this.panelCM.BackColor = System.Drawing.Color.White;
            this.panelCM.Controls.Add(this.labelClockCM);
            this.panelCM.Location = new System.Drawing.Point(37, 37);
            this.panelCM.Name = "panelCM";
            this.panelCM.Size = new System.Drawing.Size(652, 127);
            this.panelCM.TabIndex = 0;
            this.panelCM.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCM_Paint);
            // 
            // labelClockCM
            // 
            this.labelClockCM.AutoSize = true;
            this.labelClockCM.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClockCM.Location = new System.Drawing.Point(1, 1);
            this.labelClockCM.Name = "labelClockCM";
            this.labelClockCM.Size = new System.Drawing.Size(93, 32);
            this.labelClockCM.TabIndex = 0;
            this.labelClockCM.Text = "CM Frame \r\nTime Elapsed: ";
            // 
            // panelLab
            // 
            this.panelLab.BackColor = System.Drawing.Color.White;
            this.panelLab.Controls.Add(this.labelClockLab);
            this.panelLab.Location = new System.Drawing.Point(37, 209);
            this.panelLab.Name = "panelLab";
            this.panelLab.Size = new System.Drawing.Size(652, 128);
            this.panelLab.TabIndex = 1;
            this.panelLab.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLab_Paint);
            // 
            // labelClockLab
            // 
            this.labelClockLab.AutoSize = true;
            this.labelClockLab.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClockLab.Location = new System.Drawing.Point(2, 2);
            this.labelClockLab.Name = "labelClockLab";
            this.labelClockLab.Size = new System.Drawing.Size(93, 32);
            this.labelClockLab.TabIndex = 21;
            this.labelClockLab.Text = "Lab Frame \r\nTime Elapsed: ";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.panelMenu.Controls.Add(this.textBoxVelocityB);
            this.panelMenu.Controls.Add(this.textBoxVelocityA);
            this.panelMenu.Controls.Add(this.buttonCreateParticle);
            this.panelMenu.Controls.Add(this.comboBoxColorB);
            this.panelMenu.Controls.Add(this.labelColorB);
            this.panelMenu.Controls.Add(this.comboBoxColorA);
            this.panelMenu.Controls.Add(this.labelColorA);
            this.panelMenu.Controls.Add(this.labelVelocityB);
            this.panelMenu.Controls.Add(this.labelVelocityA);
            this.panelMenu.Controls.Add(this.labelParticleB);
            this.panelMenu.Controls.Add(this.labelMassB);
            this.panelMenu.Controls.Add(this.textBoxMassB);
            this.panelMenu.Controls.Add(this.labelParticleA);
            this.panelMenu.Controls.Add(this.labelMassA);
            this.panelMenu.Controls.Add(this.textBoxMassA);
            this.panelMenu.Controls.Add(this.trackBarVelocityA);
            this.panelMenu.Controls.Add(this.trackBarVelocityB);
            this.panelMenu.Location = new System.Drawing.Point(37, 375);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(491, 226);
            this.panelMenu.TabIndex = 2;
            // 
            // textBoxVelocityB
            // 
            this.textBoxVelocityB.Location = new System.Drawing.Point(435, 95);
            this.textBoxVelocityB.Name = "textBoxVelocityB";
            this.textBoxVelocityB.Size = new System.Drawing.Size(49, 22);
            this.textBoxVelocityB.TabIndex = 36;
            this.textBoxVelocityB.TextChanged += new System.EventHandler(this.textBoxVelocityB_TextChanged);
            // 
            // textBoxVelocityA
            // 
            this.textBoxVelocityA.Location = new System.Drawing.Point(190, 95);
            this.textBoxVelocityA.Name = "textBoxVelocityA";
            this.textBoxVelocityA.Size = new System.Drawing.Size(47, 22);
            this.textBoxVelocityA.TabIndex = 35;
            this.textBoxVelocityA.TextChanged += new System.EventHandler(this.textBoxVelocityA_TextChanged);
            // 
            // buttonCreateParticle
            // 
            this.buttonCreateParticle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateParticle.Location = new System.Drawing.Point(190, 175);
            this.buttonCreateParticle.Name = "buttonCreateParticle";
            this.buttonCreateParticle.Size = new System.Drawing.Size(92, 31);
            this.buttonCreateParticle.TabIndex = 21;
            this.buttonCreateParticle.Text = "CREATE";
            this.buttonCreateParticle.UseVisualStyleBackColor = true;
            this.buttonCreateParticle.Click += new System.EventHandler(this.buttonCreateParticle_Click);
            // 
            // comboBoxColorB
            // 
            this.comboBoxColorB.FormattingEnabled = true;
            this.comboBoxColorB.Location = new System.Drawing.Point(331, 138);
            this.comboBoxColorB.Name = "comboBoxColorB";
            this.comboBoxColorB.Size = new System.Drawing.Size(135, 24);
            this.comboBoxColorB.TabIndex = 28;
            // 
            // labelColorB
            // 
            this.labelColorB.AutoSize = true;
            this.labelColorB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelColorB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColorB.ForeColor = System.Drawing.Color.White;
            this.labelColorB.Location = new System.Drawing.Point(258, 136);
            this.labelColorB.Name = "labelColorB";
            this.labelColorB.Size = new System.Drawing.Size(57, 21);
            this.labelColorB.TabIndex = 34;
            this.labelColorB.Text = "Colour";
            // 
            // comboBoxColorA
            // 
            this.comboBoxColorA.FormattingEnabled = true;
            this.comboBoxColorA.Location = new System.Drawing.Point(88, 136);
            this.comboBoxColorA.Name = "comboBoxColorA";
            this.comboBoxColorA.Size = new System.Drawing.Size(135, 24);
            this.comboBoxColorA.TabIndex = 24;
            // 
            // labelColorA
            // 
            this.labelColorA.AutoSize = true;
            this.labelColorA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelColorA.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColorA.ForeColor = System.Drawing.Color.White;
            this.labelColorA.Location = new System.Drawing.Point(15, 134);
            this.labelColorA.Name = "labelColorA";
            this.labelColorA.Size = new System.Drawing.Size(57, 21);
            this.labelColorA.TabIndex = 21;
            this.labelColorA.Text = "Colour";
            // 
            // labelVelocityB
            // 
            this.labelVelocityB.AutoSize = true;
            this.labelVelocityB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelVelocityB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelocityB.ForeColor = System.Drawing.Color.White;
            this.labelVelocityB.Location = new System.Drawing.Point(243, 94);
            this.labelVelocityB.Name = "labelVelocityB";
            this.labelVelocityB.Size = new System.Drawing.Size(68, 21);
            this.labelVelocityB.TabIndex = 28;
            this.labelVelocityB.Text = "Velocity";
            // 
            // labelVelocityA
            // 
            this.labelVelocityA.AutoSize = true;
            this.labelVelocityA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelVelocityA.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelocityA.ForeColor = System.Drawing.Color.White;
            this.labelVelocityA.Location = new System.Drawing.Point(2, 94);
            this.labelVelocityA.Name = "labelVelocityA";
            this.labelVelocityA.Size = new System.Drawing.Size(68, 21);
            this.labelVelocityA.TabIndex = 26;
            this.labelVelocityA.Text = "Velocity";
            // 
            // labelParticleB
            // 
            this.labelParticleB.AutoSize = true;
            this.labelParticleB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelParticleB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParticleB.ForeColor = System.Drawing.Color.White;
            this.labelParticleB.Location = new System.Drawing.Point(327, 12);
            this.labelParticleB.Name = "labelParticleB";
            this.labelParticleB.Size = new System.Drawing.Size(80, 21);
            this.labelParticleB.TabIndex = 25;
            this.labelParticleB.Text = "Particle B";
            // 
            // labelMassB
            // 
            this.labelMassB.AutoSize = true;
            this.labelMassB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelMassB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMassB.ForeColor = System.Drawing.Color.White;
            this.labelMassB.Location = new System.Drawing.Point(258, 54);
            this.labelMassB.Name = "labelMassB";
            this.labelMassB.Size = new System.Drawing.Size(48, 21);
            this.labelMassB.TabIndex = 23;
            this.labelMassB.Text = "Mass";
            // 
            // textBoxMassB
            // 
            this.textBoxMassB.Location = new System.Drawing.Point(331, 53);
            this.textBoxMassB.Name = "textBoxMassB";
            this.textBoxMassB.Size = new System.Drawing.Size(135, 22);
            this.textBoxMassB.TabIndex = 25;
            // 
            // labelParticleA
            // 
            this.labelParticleA.AutoSize = true;
            this.labelParticleA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelParticleA.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParticleA.ForeColor = System.Drawing.Color.White;
            this.labelParticleA.Location = new System.Drawing.Point(84, 12);
            this.labelParticleA.Name = "labelParticleA";
            this.labelParticleA.Size = new System.Drawing.Size(81, 21);
            this.labelParticleA.TabIndex = 22;
            this.labelParticleA.Text = "Particle A";
            // 
            // labelMassA
            // 
            this.labelMassA.AutoSize = true;
            this.labelMassA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelMassA.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMassA.ForeColor = System.Drawing.Color.White;
            this.labelMassA.Location = new System.Drawing.Point(15, 54);
            this.labelMassA.Name = "labelMassA";
            this.labelMassA.Size = new System.Drawing.Size(48, 21);
            this.labelMassA.TabIndex = 20;
            this.labelMassA.Text = "Mass";
            // 
            // textBoxMassA
            // 
            this.textBoxMassA.Location = new System.Drawing.Point(88, 53);
            this.textBoxMassA.Name = "textBoxMassA";
            this.textBoxMassA.Size = new System.Drawing.Size(135, 22);
            this.textBoxMassA.TabIndex = 21;
            // 
            // trackBarVelocityA
            // 
            this.trackBarVelocityA.Location = new System.Drawing.Point(78, 93);
            this.trackBarVelocityA.Maximum = 100;
            this.trackBarVelocityA.Name = "trackBarVelocityA";
            this.trackBarVelocityA.Size = new System.Drawing.Size(115, 56);
            this.trackBarVelocityA.SmallChange = 2;
            this.trackBarVelocityA.TabIndex = 22;
            this.trackBarVelocityA.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVelocityA.Scroll += new System.EventHandler(this.trackBarVelocityA_Scroll);
            // 
            // trackBarVelocityB
            // 
            this.trackBarVelocityB.Location = new System.Drawing.Point(324, 93);
            this.trackBarVelocityB.Maximum = 100;
            this.trackBarVelocityB.Name = "trackBarVelocityB";
            this.trackBarVelocityB.Size = new System.Drawing.Size(113, 56);
            this.trackBarVelocityB.SmallChange = 2;
            this.trackBarVelocityB.TabIndex = 26;
            this.trackBarVelocityB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVelocityB.Scroll += new System.EventHandler(this.trackBarVelocityB_Scroll);
            // 
            // buttonArrowBack
            // 
            this.buttonArrowBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.buttonArrowBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonArrowBack.FlatAppearance.BorderSize = 0;
            this.buttonArrowBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArrowBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonArrowBack.Image")));
            this.buttonArrowBack.Location = new System.Drawing.Point(37, -1);
            this.buttonArrowBack.Margin = new System.Windows.Forms.Padding(0);
            this.buttonArrowBack.Name = "buttonArrowBack";
            this.buttonArrowBack.Size = new System.Drawing.Size(35, 35);
            this.buttonArrowBack.TabIndex = 19;
            this.buttonArrowBack.UseVisualStyleBackColor = false;
            this.buttonArrowBack.Click += new System.EventHandler(this.buttonArrowBack_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(574, 550);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(111, 31);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.Location = new System.Drawing.Point(574, 501);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(113, 29);
            this.buttonRun.TabIndex = 8;
            this.buttonRun.Text = "RUN";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // panelUIOptions
            // 
            this.panelUIOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.panelUIOptions.Controls.Add(this.checkBoxArrows);
            this.panelUIOptions.Controls.Add(this.checkBoxGrid);
            this.panelUIOptions.Location = new System.Drawing.Point(550, 375);
            this.panelUIOptions.Name = "panelUIOptions";
            this.panelUIOptions.Size = new System.Drawing.Size(156, 106);
            this.panelUIOptions.TabIndex = 20;
            // 
            // checkBoxArrows
            // 
            this.checkBoxArrows.AutoSize = true;
            this.checkBoxArrows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.checkBoxArrows.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.checkBoxArrows.ForeColor = System.Drawing.Color.White;
            this.checkBoxArrows.Location = new System.Drawing.Point(38, 59);
            this.checkBoxArrows.Name = "checkBoxArrows";
            this.checkBoxArrows.Size = new System.Drawing.Size(85, 25);
            this.checkBoxArrows.TabIndex = 19;
            this.checkBoxArrows.Text = "Arrows";
            this.checkBoxArrows.UseVisualStyleBackColor = false;
            this.checkBoxArrows.CheckedChanged += new System.EventHandler(this.checkBoxArrows_CheckedChanged);
            // 
            // checkBoxGrid
            // 
            this.checkBoxGrid.AutoSize = true;
            this.checkBoxGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.checkBoxGrid.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.checkBoxGrid.ForeColor = System.Drawing.Color.White;
            this.checkBoxGrid.Location = new System.Drawing.Point(38, 28);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(62, 25);
            this.checkBoxGrid.TabIndex = 18;
            this.checkBoxGrid.Text = "Grid";
            this.checkBoxGrid.UseVisualStyleBackColor = false;
            this.checkBoxGrid.CheckedChanged += new System.EventHandler(this.checkBoxGrid_CheckedChanged);
            // 
            // RelativisticCollisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(742, 629);
            this.Controls.Add(this.panelUIOptions);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonArrowBack);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelLab);
            this.Controls.Add(this.panelCM);
            this.Name = "RelativisticCollisions";
            this.Text = "RelativisticCollisions";
            this.panelCM.ResumeLayout(false);
            this.panelCM.PerformLayout();
            this.panelLab.ResumeLayout(false);
            this.panelLab.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocityA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocityB)).EndInit();
            this.panelUIOptions.ResumeLayout(false);
            this.panelUIOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCM;
        private System.Windows.Forms.Panel panelLab;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonArrowBack;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelMassA;
        private System.Windows.Forms.TextBox textBoxMassA;
        private System.Windows.Forms.Label labelVelocityB;
        private System.Windows.Forms.Label labelVelocityA;
        private System.Windows.Forms.Label labelParticleB;
        private System.Windows.Forms.Label labelMassB;
        private System.Windows.Forms.TextBox textBoxMassB;
        private System.Windows.Forms.Label labelParticleA;
        private System.Windows.Forms.ComboBox comboBoxColorB;
        private System.Windows.Forms.Label labelColorB;
        private System.Windows.Forms.ComboBox comboBoxColorA;
        private System.Windows.Forms.Label labelColorA;
        private System.Windows.Forms.Panel panelUIOptions;
        private System.Windows.Forms.CheckBox checkBoxArrows;
        private System.Windows.Forms.CheckBox checkBoxGrid;
        private System.Windows.Forms.Button buttonCreateParticle;
        private System.Windows.Forms.TrackBar trackBarVelocityA;
        private System.Windows.Forms.TrackBar trackBarVelocityB;
        private System.Windows.Forms.Label labelClockCM;
        private System.Windows.Forms.Label labelClockLab;
        private System.Windows.Forms.TextBox textBoxVelocityA;
        private System.Windows.Forms.TextBox textBoxVelocityB;
    }
}