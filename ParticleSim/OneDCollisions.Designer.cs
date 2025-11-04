namespace ParticleSim
{
    partial class OneDCollisions
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
            this.panelDisplayArea = new System.Windows.Forms.Panel();
            this.panelParticleInitialiser = new System.Windows.Forms.Panel();
            this.checkBoxGrid = new System.Windows.Forms.CheckBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxMass = new System.Windows.Forms.TextBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelMass = new System.Windows.Forms.Label();
            this.buttonCreateParticle = new System.Windows.Forms.Button();
            this.buttonRunReset = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelParticleInitialiser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDisplayArea
            // 
            this.panelDisplayArea.BackColor = System.Drawing.SystemColors.Window;
            this.panelDisplayArea.Location = new System.Drawing.Point(12, 22);
            this.panelDisplayArea.Name = "panelDisplayArea";
            this.panelDisplayArea.Size = new System.Drawing.Size(776, 100);
            this.panelDisplayArea.TabIndex = 0;
            this.panelDisplayArea.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDisplayArea_Paint);
            // 
            // panelParticleInitialiser
            // 
            this.panelParticleInitialiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.panelParticleInitialiser.Controls.Add(this.checkBoxGrid);
            this.panelParticleInitialiser.Controls.Add(this.textBoxSpeed);
            this.panelParticleInitialiser.Controls.Add(this.textBoxMass);
            this.panelParticleInitialiser.Controls.Add(this.labelSpeed);
            this.panelParticleInitialiser.Controls.Add(this.labelMass);
            this.panelParticleInitialiser.Controls.Add(this.buttonCreateParticle);
            this.panelParticleInitialiser.Location = new System.Drawing.Point(461, 143);
            this.panelParticleInitialiser.Name = "panelParticleInitialiser";
            this.panelParticleInitialiser.Size = new System.Drawing.Size(327, 295);
            this.panelParticleInitialiser.TabIndex = 1;
            // 
            // checkBoxGrid
            // 
            this.checkBoxGrid.AutoSize = true;
            this.checkBoxGrid.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.checkBoxGrid.ForeColor = System.Drawing.Color.White;
            this.checkBoxGrid.Location = new System.Drawing.Point(42, 177);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(62, 25);
            this.checkBoxGrid.TabIndex = 4;
            this.checkBoxGrid.Text = "Grid";
            this.checkBoxGrid.UseVisualStyleBackColor = true;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(104, 67);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 22);
            this.textBoxSpeed.TabIndex = 3;
            this.textBoxSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSpeed_KeyPress);
            // 
            // textBoxMass
            // 
            this.textBoxMass.Location = new System.Drawing.Point(104, 27);
            this.textBoxMass.Name = "textBoxMass";
            this.textBoxMass.Size = new System.Drawing.Size(100, 22);
            this.textBoxMass.TabIndex = 2;
            this.textBoxMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMass_KeyPress);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.ForeColor = System.Drawing.Color.White;
            this.labelSpeed.Location = new System.Drawing.Point(38, 66);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(55, 21);
            this.labelSpeed.TabIndex = 1;
            this.labelSpeed.Text = "Speed";
            // 
            // labelMass
            // 
            this.labelMass.AutoSize = true;
            this.labelMass.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMass.ForeColor = System.Drawing.Color.White;
            this.labelMass.Location = new System.Drawing.Point(45, 26);
            this.labelMass.Name = "labelMass";
            this.labelMass.Size = new System.Drawing.Size(48, 21);
            this.labelMass.TabIndex = 0;
            this.labelMass.Text = "Mass";
            // 
            // buttonCreateParticle
            // 
            this.buttonCreateParticle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateParticle.Location = new System.Drawing.Point(112, 246);
            this.buttonCreateParticle.Name = "buttonCreateParticle";
            this.buttonCreateParticle.Size = new System.Drawing.Size(92, 31);
            this.buttonCreateParticle.TabIndex = 0;
            this.buttonCreateParticle.Text = "CREATE";
            this.buttonCreateParticle.UseVisualStyleBackColor = true;
            this.buttonCreateParticle.Click += new System.EventHandler(this.buttonCreateParticle_Click);
            // 
            // buttonRunReset
            // 
            this.buttonRunReset.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunReset.Location = new System.Drawing.Point(135, 152);
            this.buttonRunReset.Name = "buttonRunReset";
            this.buttonRunReset.Size = new System.Drawing.Size(79, 33);
            this.buttonRunReset.TabIndex = 3;
            this.buttonRunReset.Text = "RUN";
            this.buttonRunReset.UseVisualStyleBackColor = true;
            this.buttonRunReset.Click += new System.EventHandler(this.buttonRunReset_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(241, 152);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 33);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.panel1.Location = new System.Drawing.Point(28, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 229);
            this.panel1.TabIndex = 5;
            // 
            // OneDCollisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRunReset);
            this.Controls.Add(this.panelParticleInitialiser);
            this.Controls.Add(this.panelDisplayArea);
            this.Name = "OneDCollisions";
            this.Text = "OneDCollisions";
            this.panelParticleInitialiser.ResumeLayout(false);
            this.panelParticleInitialiser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDisplayArea;
        private System.Windows.Forms.Panel panelParticleInitialiser;
        private System.Windows.Forms.Button buttonRunReset;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCreateParticle;
        private System.Windows.Forms.TextBox textBoxMass;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelMass;
        private System.Windows.Forms.CheckBox checkBoxGrid;
        private System.Windows.Forms.TextBox textBoxSpeed;
    }
}