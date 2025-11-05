namespace ParticleSim
{
    partial class _1DCollisions
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
            this.checkBoxArrows = new System.Windows.Forms.CheckBox();
            this.labelRestitution = new System.Windows.Forms.Label();
            this.trackBarElasticity = new System.Windows.Forms.TrackBar();
            this.checkBoxGrid = new System.Windows.Forms.CheckBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxMass = new System.Windows.Forms.TextBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelMass = new System.Windows.Forms.Label();
            this.buttonCreateParticle = new System.Windows.Forms.Button();
            this.buttonRunReset = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelParticleCustomiser = new System.Windows.Forms.Panel();
            this.panelParticleInitialiser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarElasticity)).BeginInit();
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
            this.panelParticleInitialiser.Controls.Add(this.checkBoxArrows);
            this.panelParticleInitialiser.Controls.Add(this.labelRestitution);
            this.panelParticleInitialiser.Controls.Add(this.trackBarElasticity);
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
            // checkBoxArrows
            // 
            this.checkBoxArrows.AutoSize = true;
            this.checkBoxArrows.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.checkBoxArrows.ForeColor = System.Drawing.Color.White;
            this.checkBoxArrows.Location = new System.Drawing.Point(165, 178);
            this.checkBoxArrows.Name = "checkBoxArrows";
            this.checkBoxArrows.Size = new System.Drawing.Size(85, 25);
            this.checkBoxArrows.TabIndex = 7;
            this.checkBoxArrows.Text = "Arrows";
            this.checkBoxArrows.UseVisualStyleBackColor = true;
            // 
            // labelRestitution
            // 
            this.labelRestitution.AutoSize = true;
            this.labelRestitution.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestitution.ForeColor = System.Drawing.Color.White;
            this.labelRestitution.Location = new System.Drawing.Point(27, 116);
            this.labelRestitution.Name = "labelRestitution";
            this.labelRestitution.Size = new System.Drawing.Size(77, 21);
            this.labelRestitution.TabIndex = 6;
            this.labelRestitution.Text = "Elasticity";
            // 
            // trackBarElasticity
            // 
            this.trackBarElasticity.Location = new System.Drawing.Point(104, 109);
            this.trackBarElasticity.Name = "trackBarElasticity";
            this.trackBarElasticity.Size = new System.Drawing.Size(162, 56);
            this.trackBarElasticity.TabIndex = 5;
            this.trackBarElasticity.Scroll += new System.EventHandler(this.trackBarElasticity_Scroll);
            // 
            // checkBoxGrid
            // 
            this.checkBoxGrid.AutoSize = true;
            this.checkBoxGrid.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.checkBoxGrid.ForeColor = System.Drawing.Color.White;
            this.checkBoxGrid.Location = new System.Drawing.Point(78, 178);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(62, 25);
            this.checkBoxGrid.TabIndex = 4;
            this.checkBoxGrid.Text = "Grid";
            this.checkBoxGrid.UseVisualStyleBackColor = true;
            this.checkBoxGrid.CheckedChanged += new System.EventHandler(this.checkBoxGrid_CheckedChanged);
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(104, 76);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(162, 22);
            this.textBoxSpeed.TabIndex = 3;
            this.textBoxSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSpeed_KeyPress);
            // 
            // textBoxMass
            // 
            this.textBoxMass.Location = new System.Drawing.Point(104, 36);
            this.textBoxMass.Name = "textBoxMass";
            this.textBoxMass.Size = new System.Drawing.Size(162, 22);
            this.textBoxMass.TabIndex = 2;
            this.textBoxMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMass_KeyPress);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.ForeColor = System.Drawing.Color.White;
            this.labelSpeed.Location = new System.Drawing.Point(38, 75);
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
            this.labelMass.Location = new System.Drawing.Point(45, 35);
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
            // panelParticleCustomiser
            // 
            this.panelParticleCustomiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.panelParticleCustomiser.Location = new System.Drawing.Point(28, 209);
            this.panelParticleCustomiser.Name = "panelParticleCustomiser";
            this.panelParticleCustomiser.Size = new System.Drawing.Size(412, 229);
            this.panelParticleCustomiser.TabIndex = 5;
            // 
            // _1DCollisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelParticleCustomiser);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRunReset);
            this.Controls.Add(this.panelParticleInitialiser);
            this.Controls.Add(this.panelDisplayArea);
            this.Name = "_1DCollisions";
            this.Text = "Collisions in One Dimension";
            this.panelParticleInitialiser.ResumeLayout(false);
            this.panelParticleInitialiser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarElasticity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDisplayArea;
        private System.Windows.Forms.Panel panelParticleInitialiser;
        private System.Windows.Forms.Button buttonRunReset;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panelParticleCustomiser;
        private System.Windows.Forms.Button buttonCreateParticle;
        private System.Windows.Forms.TextBox textBoxMass;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelMass;
        private System.Windows.Forms.CheckBox checkBoxGrid;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.CheckBox checkBoxArrows;
        private System.Windows.Forms.Label labelRestitution;
        private System.Windows.Forms.TrackBar trackBarElasticity;
    }
}