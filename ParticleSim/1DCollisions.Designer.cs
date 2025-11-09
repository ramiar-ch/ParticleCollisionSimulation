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
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.checkBoxArrows = new System.Windows.Forms.CheckBox();
            this.labelColor = new System.Windows.Forms.Label();
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
            this.buttonModifyParticle = new System.Windows.Forms.Button();
            this.comboBoxColorModifier = new System.Windows.Forms.ComboBox();
            this.labelMassModifier = new System.Windows.Forms.Label();
            this.textBoxSpeedModifier = new System.Windows.Forms.TextBox();
            this.labelSpeedModifier = new System.Windows.Forms.Label();
            this.textBoxMassModifier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelParticleInitialiser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarElasticity)).BeginInit();
            this.panelParticleCustomiser.SuspendLayout();
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
            this.panelDisplayArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDisplayArea_MouseDown);
            this.panelDisplayArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDisplayArea_MouseMove);
            this.panelDisplayArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDisplayArea_MouseUp);
            // 
            // panelParticleInitialiser
            // 
            this.panelParticleInitialiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.panelParticleInitialiser.Controls.Add(this.comboBoxColor);
            this.panelParticleInitialiser.Controls.Add(this.checkBoxArrows);
            this.panelParticleInitialiser.Controls.Add(this.labelColor);
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
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(104, 102);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(162, 24);
            this.comboBoxColor.TabIndex = 20;
            // 
            // checkBoxArrows
            // 
            this.checkBoxArrows.AutoSize = true;
            this.checkBoxArrows.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.checkBoxArrows.ForeColor = System.Drawing.Color.White;
            this.checkBoxArrows.Location = new System.Drawing.Point(165, 194);
            this.checkBoxArrows.Name = "checkBoxArrows";
            this.checkBoxArrows.Size = new System.Drawing.Size(85, 25);
            this.checkBoxArrows.TabIndex = 7;
            this.checkBoxArrows.Text = "Arrows";
            this.checkBoxArrows.UseVisualStyleBackColor = true;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelColor.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.ForeColor = System.Drawing.Color.White;
            this.labelColor.Location = new System.Drawing.Point(38, 100);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(57, 21);
            this.labelColor.TabIndex = 19;
            this.labelColor.Text = "Colour";
            // 
            // labelRestitution
            // 
            this.labelRestitution.AutoSize = true;
            this.labelRestitution.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestitution.ForeColor = System.Drawing.Color.White;
            this.labelRestitution.Location = new System.Drawing.Point(26, 142);
            this.labelRestitution.Name = "labelRestitution";
            this.labelRestitution.Size = new System.Drawing.Size(77, 21);
            this.labelRestitution.TabIndex = 6;
            this.labelRestitution.Text = "Elasticity";
            // 
            // trackBarElasticity
            // 
            this.trackBarElasticity.Location = new System.Drawing.Point(103, 136);
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
            this.checkBoxGrid.Location = new System.Drawing.Point(78, 194);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(62, 25);
            this.checkBoxGrid.TabIndex = 4;
            this.checkBoxGrid.Text = "Grid";
            this.checkBoxGrid.UseVisualStyleBackColor = true;
            this.checkBoxGrid.CheckedChanged += new System.EventHandler(this.checkBoxGrid_CheckedChanged);
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(104, 61);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(162, 22);
            this.textBoxSpeed.TabIndex = 3;
            this.textBoxSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSpeed_KeyPress);
            // 
            // textBoxMass
            // 
            this.textBoxMass.Location = new System.Drawing.Point(104, 21);
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
            this.labelSpeed.Location = new System.Drawing.Point(38, 60);
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
            this.labelMass.Location = new System.Drawing.Point(45, 20);
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
            this.panelParticleCustomiser.Controls.Add(this.buttonModifyParticle);
            this.panelParticleCustomiser.Controls.Add(this.comboBoxColorModifier);
            this.panelParticleCustomiser.Controls.Add(this.labelMassModifier);
            this.panelParticleCustomiser.Controls.Add(this.textBoxSpeedModifier);
            this.panelParticleCustomiser.Controls.Add(this.labelSpeedModifier);
            this.panelParticleCustomiser.Controls.Add(this.textBoxMassModifier);
            this.panelParticleCustomiser.Controls.Add(this.label1);
            this.panelParticleCustomiser.Location = new System.Drawing.Point(28, 209);
            this.panelParticleCustomiser.Name = "panelParticleCustomiser";
            this.panelParticleCustomiser.Size = new System.Drawing.Size(412, 229);
            this.panelParticleCustomiser.TabIndex = 5;
            // 
            // buttonModifyParticle
            // 
            this.buttonModifyParticle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifyParticle.Location = new System.Drawing.Point(151, 159);
            this.buttonModifyParticle.Name = "buttonModifyParticle";
            this.buttonModifyParticle.Size = new System.Drawing.Size(92, 31);
            this.buttonModifyParticle.TabIndex = 24;
            this.buttonModifyParticle.Text = "MODIFY";
            this.buttonModifyParticle.UseVisualStyleBackColor = true;
            this.buttonModifyParticle.Click += new System.EventHandler(this.buttonModifyParticle_Click);
            // 
            // comboBoxColorModifier
            // 
            this.comboBoxColorModifier.FormattingEnabled = true;
            this.comboBoxColorModifier.Location = new System.Drawing.Point(113, 77);
            this.comboBoxColorModifier.Name = "comboBoxColorModifier";
            this.comboBoxColorModifier.Size = new System.Drawing.Size(85, 24);
            this.comboBoxColorModifier.TabIndex = 25;
            // 
            // labelMassModifier
            // 
            this.labelMassModifier.AutoSize = true;
            this.labelMassModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelMassModifier.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMassModifier.ForeColor = System.Drawing.Color.White;
            this.labelMassModifier.Location = new System.Drawing.Point(59, 34);
            this.labelMassModifier.Name = "labelMassModifier";
            this.labelMassModifier.Size = new System.Drawing.Size(48, 21);
            this.labelMassModifier.TabIndex = 22;
            this.labelMassModifier.Text = "Mass";
            // 
            // textBoxSpeedModifier
            // 
            this.textBoxSpeedModifier.Location = new System.Drawing.Point(275, 34);
            this.textBoxSpeedModifier.Name = "textBoxSpeedModifier";
            this.textBoxSpeedModifier.Size = new System.Drawing.Size(74, 22);
            this.textBoxSpeedModifier.TabIndex = 26;
            // 
            // labelSpeedModifier
            // 
            this.labelSpeedModifier.AutoSize = true;
            this.labelSpeedModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelSpeedModifier.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeedModifier.ForeColor = System.Drawing.Color.White;
            this.labelSpeedModifier.Location = new System.Drawing.Point(212, 33);
            this.labelSpeedModifier.Name = "labelSpeedModifier";
            this.labelSpeedModifier.Size = new System.Drawing.Size(55, 21);
            this.labelSpeedModifier.TabIndex = 21;
            this.labelSpeedModifier.Text = "Speed";
            // 
            // textBoxMassModifier
            // 
            this.textBoxMassModifier.Location = new System.Drawing.Point(116, 34);
            this.textBoxMassModifier.Name = "textBoxMassModifier";
            this.textBoxMassModifier.Size = new System.Drawing.Size(74, 22);
            this.textBoxMassModifier.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Colour";
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
            this.panelParticleCustomiser.ResumeLayout(false);
            this.panelParticleCustomiser.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonModifyParticle;
        private System.Windows.Forms.ComboBox comboBoxColorModifier;
        private System.Windows.Forms.Label labelMassModifier;
        private System.Windows.Forms.TextBox textBoxSpeedModifier;
        private System.Windows.Forms.Label labelSpeedModifier;
        private System.Windows.Forms.TextBox textBoxMassModifier;
        private System.Windows.Forms.Label label1;
    }
}