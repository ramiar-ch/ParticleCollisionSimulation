namespace ParticleSim
{
    partial class _2DCollisions
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
            this.panelModifer = new System.Windows.Forms.Panel();
            this.buttonRunReset = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.checkBoxArrows = new System.Windows.Forms.CheckBox();
            this.labelElasticity = new System.Windows.Forms.Label();
            this.trackBarElasticity = new System.Windows.Forms.TrackBar();
            this.checkBoxGrid = new System.Windows.Forms.CheckBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxMass = new System.Windows.Forms.TextBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelMass = new System.Windows.Forms.Label();
            this.buttonCreateParticle = new System.Windows.Forms.Button();
            this.panelParticleInitialiser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarElasticity)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDisplayArea
            // 
            this.panelDisplayArea.BackColor = System.Drawing.Color.White;
            this.panelDisplayArea.Location = new System.Drawing.Point(32, 27);
            this.panelDisplayArea.Name = "panelDisplayArea";
            this.panelDisplayArea.Size = new System.Drawing.Size(740, 370);
            this.panelDisplayArea.TabIndex = 0;
            this.panelDisplayArea.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDisplayArea_Paint);
            // 
            // panelParticleInitialiser
            // 
            this.panelParticleInitialiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.panelParticleInitialiser.Controls.Add(this.buttonCreateParticle);
            this.panelParticleInitialiser.Location = new System.Drawing.Point(432, 420);
            this.panelParticleInitialiser.Name = "panelParticleInitialiser";
            this.panelParticleInitialiser.Size = new System.Drawing.Size(342, 222);
            this.panelParticleInitialiser.TabIndex = 1;
            // 
            // panelModifer
            // 
            this.panelModifer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.panelModifer.Location = new System.Drawing.Point(32, 475);
            this.panelModifer.Name = "panelModifer";
            this.panelModifer.Size = new System.Drawing.Size(375, 167);
            this.panelModifer.TabIndex = 2;
            // 
            // buttonRunReset
            // 
            this.buttonRunReset.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunReset.Location = new System.Drawing.Point(122, 420);
            this.buttonRunReset.Name = "buttonRunReset";
            this.buttonRunReset.Size = new System.Drawing.Size(79, 33);
            this.buttonRunReset.TabIndex = 4;
            this.buttonRunReset.Text = "RUN";
            this.buttonRunReset.UseVisualStyleBackColor = true;
            this.buttonRunReset.Click += new System.EventHandler(this.buttonRunReset_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(229, 420);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 33);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // checkBoxArrows
            // 
            this.checkBoxArrows.AutoSize = true;
            this.checkBoxArrows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.checkBoxArrows.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.checkBoxArrows.ForeColor = System.Drawing.Color.White;
            this.checkBoxArrows.Location = new System.Drawing.Point(594, 562);
            this.checkBoxArrows.Name = "checkBoxArrows";
            this.checkBoxArrows.Size = new System.Drawing.Size(85, 25);
            this.checkBoxArrows.TabIndex = 16;
            this.checkBoxArrows.Text = "Arrows";
            this.checkBoxArrows.UseVisualStyleBackColor = false;
            // 
            // labelElasticity
            // 
            this.labelElasticity.AutoSize = true;
            this.labelElasticity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelElasticity.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElasticity.ForeColor = System.Drawing.Color.White;
            this.labelElasticity.Location = new System.Drawing.Point(465, 518);
            this.labelElasticity.Name = "labelElasticity";
            this.labelElasticity.Size = new System.Drawing.Size(77, 21);
            this.labelElasticity.TabIndex = 15;
            this.labelElasticity.Text = "Elasticity";
            // 
            // trackBarElasticity
            // 
            this.trackBarElasticity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.trackBarElasticity.Location = new System.Drawing.Point(542, 511);
            this.trackBarElasticity.Name = "trackBarElasticity";
            this.trackBarElasticity.Size = new System.Drawing.Size(162, 56);
            this.trackBarElasticity.TabIndex = 14;
            // 
            // checkBoxGrid
            // 
            this.checkBoxGrid.AutoSize = true;
            this.checkBoxGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.checkBoxGrid.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.checkBoxGrid.ForeColor = System.Drawing.Color.White;
            this.checkBoxGrid.Location = new System.Drawing.Point(507, 563);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(62, 25);
            this.checkBoxGrid.TabIndex = 13;
            this.checkBoxGrid.Text = "Grid";
            this.checkBoxGrid.UseVisualStyleBackColor = false;
            this.checkBoxGrid.CheckedChanged += new System.EventHandler(this.checkBoxGrid_CheckedChanged);
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(542, 478);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(162, 22);
            this.textBoxSpeed.TabIndex = 12;
            // 
            // textBoxMass
            // 
            this.textBoxMass.Location = new System.Drawing.Point(542, 438);
            this.textBoxMass.Name = "textBoxMass";
            this.textBoxMass.Size = new System.Drawing.Size(162, 22);
            this.textBoxMass.TabIndex = 11;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelSpeed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.ForeColor = System.Drawing.Color.White;
            this.labelSpeed.Location = new System.Drawing.Point(476, 477);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(55, 21);
            this.labelSpeed.TabIndex = 10;
            this.labelSpeed.Text = "Speed";
            // 
            // labelMass
            // 
            this.labelMass.AutoSize = true;
            this.labelMass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelMass.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMass.ForeColor = System.Drawing.Color.White;
            this.labelMass.Location = new System.Drawing.Point(483, 437);
            this.labelMass.Name = "labelMass";
            this.labelMass.Size = new System.Drawing.Size(48, 21);
            this.labelMass.TabIndex = 8;
            this.labelMass.Text = "Mass";
            // 
            // buttonCreateParticle
            // 
            this.buttonCreateParticle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateParticle.Location = new System.Drawing.Point(117, 178);
            this.buttonCreateParticle.Name = "buttonCreateParticle";
            this.buttonCreateParticle.Size = new System.Drawing.Size(92, 31);
            this.buttonCreateParticle.TabIndex = 9;
            this.buttonCreateParticle.Text = "CREATE";
            this.buttonCreateParticle.UseVisualStyleBackColor = true;
            // 
            // _2DCollisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(800, 663);
            this.Controls.Add(this.checkBoxArrows);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.trackBarElasticity);
            this.Controls.Add(this.buttonRunReset);
            this.Controls.Add(this.labelElasticity);
            this.Controls.Add(this.panelModifer);
            this.Controls.Add(this.labelMass);
            this.Controls.Add(this.checkBoxGrid);
            this.Controls.Add(this.panelDisplayArea);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.textBoxMass);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.panelParticleInitialiser);
            this.Name = "_2DCollisions";
            this.Text = "_2DCollisions";
            this.panelParticleInitialiser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarElasticity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDisplayArea;
        private System.Windows.Forms.Panel panelParticleInitialiser;
        private System.Windows.Forms.Panel panelModifer;
        private System.Windows.Forms.Button buttonRunReset;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCreateParticle;
        private System.Windows.Forms.CheckBox checkBoxArrows;
        private System.Windows.Forms.Label labelElasticity;
        private System.Windows.Forms.TrackBar trackBarElasticity;
        private System.Windows.Forms.CheckBox checkBoxGrid;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxMass;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelMass;
    }
}