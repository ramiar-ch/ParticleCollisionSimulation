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
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonCreateParticle = new System.Windows.Forms.Button();
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
            this.labelMassModifier = new System.Windows.Forms.Label();
            this.labelSpeedModifier = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMassModifier = new System.Windows.Forms.TextBox();
            this.textBoxSpeedModifier = new System.Windows.Forms.TextBox();
            this.comboBoxColorModifier = new System.Windows.Forms.ComboBox();
            this.labelAngle = new System.Windows.Forms.Label();
            this.textBoxAngleModifier = new System.Windows.Forms.TextBox();
            this.buttonModifyParticle = new System.Windows.Forms.Button();
            this.panelParticleInitialiser.SuspendLayout();
            this.panelModifer.SuspendLayout();
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
            this.panelDisplayArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDisplayArea_MouseDown);
            this.panelDisplayArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDisplayArea_MouseMove);
            this.panelDisplayArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDisplayArea_MouseUp);
            // 
            // panelParticleInitialiser
            // 
            this.panelParticleInitialiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.panelParticleInitialiser.Controls.Add(this.comboBoxColor);
            this.panelParticleInitialiser.Controls.Add(this.labelColor);
            this.panelParticleInitialiser.Controls.Add(this.buttonCreateParticle);
            this.panelParticleInitialiser.Location = new System.Drawing.Point(432, 418);
            this.panelParticleInitialiser.Name = "panelParticleInitialiser";
            this.panelParticleInitialiser.Size = new System.Drawing.Size(342, 269);
            this.panelParticleInitialiser.TabIndex = 1;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(110, 96);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(162, 24);
            this.comboBoxColor.TabIndex = 18;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelColor.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.ForeColor = System.Drawing.Color.White;
            this.labelColor.Location = new System.Drawing.Point(44, 94);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(57, 21);
            this.labelColor.TabIndex = 17;
            this.labelColor.Text = "Colour";
            // 
            // buttonCreateParticle
            // 
            this.buttonCreateParticle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateParticle.Location = new System.Drawing.Point(117, 215);
            this.buttonCreateParticle.Name = "buttonCreateParticle";
            this.buttonCreateParticle.Size = new System.Drawing.Size(92, 31);
            this.buttonCreateParticle.TabIndex = 9;
            this.buttonCreateParticle.Text = "CREATE";
            this.buttonCreateParticle.UseVisualStyleBackColor = true;
            this.buttonCreateParticle.Click += new System.EventHandler(this.buttonCreateParticle_Click);
            // 
            // panelModifer
            // 
            this.panelModifer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.panelModifer.Controls.Add(this.buttonModifyParticle);
            this.panelModifer.Controls.Add(this.textBoxAngleModifier);
            this.panelModifer.Controls.Add(this.labelAngle);
            this.panelModifer.Controls.Add(this.comboBoxColorModifier);
            this.panelModifer.Controls.Add(this.textBoxSpeedModifier);
            this.panelModifer.Controls.Add(this.textBoxMassModifier);
            this.panelModifer.Controls.Add(this.label1);
            this.panelModifer.Controls.Add(this.labelSpeedModifier);
            this.panelModifer.Controls.Add(this.labelMassModifier);
            this.panelModifer.Location = new System.Drawing.Point(32, 473);
            this.panelModifer.Name = "panelModifer";
            this.panelModifer.Size = new System.Drawing.Size(375, 214);
            this.panelModifer.TabIndex = 2;
            // 
            // buttonRunReset
            // 
            this.buttonRunReset.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunReset.Location = new System.Drawing.Point(122, 418);
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
            this.buttonClear.Location = new System.Drawing.Point(229, 418);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 33);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // checkBoxArrows
            // 
            this.checkBoxArrows.AutoSize = true;
            this.checkBoxArrows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.checkBoxArrows.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.checkBoxArrows.ForeColor = System.Drawing.Color.White;
            this.checkBoxArrows.Location = new System.Drawing.Point(594, 597);
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
            this.labelElasticity.Location = new System.Drawing.Point(465, 553);
            this.labelElasticity.Name = "labelElasticity";
            this.labelElasticity.Size = new System.Drawing.Size(77, 21);
            this.labelElasticity.TabIndex = 15;
            this.labelElasticity.Text = "Elasticity";
            // 
            // trackBarElasticity
            // 
            this.trackBarElasticity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.trackBarElasticity.Location = new System.Drawing.Point(542, 546);
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
            this.checkBoxGrid.Location = new System.Drawing.Point(507, 598);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(62, 25);
            this.checkBoxGrid.TabIndex = 13;
            this.checkBoxGrid.Text = "Grid";
            this.checkBoxGrid.UseVisualStyleBackColor = false;
            this.checkBoxGrid.CheckedChanged += new System.EventHandler(this.checkBoxGrid_CheckedChanged);
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(542, 475);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(162, 22);
            this.textBoxSpeed.TabIndex = 12;
            this.textBoxSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSpeed_KeyPress);
            // 
            // textBoxMass
            // 
            this.textBoxMass.Location = new System.Drawing.Point(542, 436);
            this.textBoxMass.Name = "textBoxMass";
            this.textBoxMass.Size = new System.Drawing.Size(162, 22);
            this.textBoxMass.TabIndex = 11;
            this.textBoxMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMass_KeyPress);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelSpeed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.ForeColor = System.Drawing.Color.White;
            this.labelSpeed.Location = new System.Drawing.Point(476, 474);
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
            this.labelMass.Location = new System.Drawing.Point(483, 435);
            this.labelMass.Name = "labelMass";
            this.labelMass.Size = new System.Drawing.Size(48, 21);
            this.labelMass.TabIndex = 8;
            this.labelMass.Text = "Mass";
            // 
            // labelMassModifier
            // 
            this.labelMassModifier.AutoSize = true;
            this.labelMassModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelMassModifier.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMassModifier.ForeColor = System.Drawing.Color.White;
            this.labelMassModifier.Location = new System.Drawing.Point(40, 31);
            this.labelMassModifier.Name = "labelMassModifier";
            this.labelMassModifier.Size = new System.Drawing.Size(48, 21);
            this.labelMassModifier.TabIndex = 17;
            this.labelMassModifier.Text = "Mass";
            // 
            // labelSpeedModifier
            // 
            this.labelSpeedModifier.AutoSize = true;
            this.labelSpeedModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelSpeedModifier.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeedModifier.ForeColor = System.Drawing.Color.White;
            this.labelSpeedModifier.Location = new System.Drawing.Point(193, 30);
            this.labelSpeedModifier.Name = "labelSpeedModifier";
            this.labelSpeedModifier.Size = new System.Drawing.Size(55, 21);
            this.labelSpeedModifier.TabIndex = 17;
            this.labelSpeedModifier.Text = "Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Colour";
            // 
            // textBoxMassModifier
            // 
            this.textBoxMassModifier.Location = new System.Drawing.Point(97, 31);
            this.textBoxMassModifier.Name = "textBoxMassModifier";
            this.textBoxMassModifier.Size = new System.Drawing.Size(74, 22);
            this.textBoxMassModifier.TabIndex = 17;
            this.textBoxMassModifier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMass_KeyPress);
            // 
            // textBoxSpeedModifier
            // 
            this.textBoxSpeedModifier.Location = new System.Drawing.Point(256, 31);
            this.textBoxSpeedModifier.Name = "textBoxSpeedModifier";
            this.textBoxSpeedModifier.Size = new System.Drawing.Size(74, 22);
            this.textBoxSpeedModifier.TabIndex = 19;
            this.textBoxSpeedModifier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSpeed_KeyPress);
            // 
            // comboBoxColorModifier
            // 
            this.comboBoxColorModifier.FormattingEnabled = true;
            this.comboBoxColorModifier.Location = new System.Drawing.Point(94, 74);
            this.comboBoxColorModifier.Name = "comboBoxColorModifier";
            this.comboBoxColorModifier.Size = new System.Drawing.Size(85, 24);
            this.comboBoxColorModifier.TabIndex = 19;
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelAngle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAngle.ForeColor = System.Drawing.Color.White;
            this.labelAngle.Location = new System.Drawing.Point(196, 75);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(52, 21);
            this.labelAngle.TabIndex = 20;
            this.labelAngle.Text = "Angle";
            // 
            // textBoxAngleModifier
            // 
            this.textBoxAngleModifier.Location = new System.Drawing.Point(256, 76);
            this.textBoxAngleModifier.Name = "textBoxAngleModifier";
            this.textBoxAngleModifier.Size = new System.Drawing.Size(74, 22);
            this.textBoxAngleModifier.TabIndex = 21;
            // 
            // buttonModifyParticle
            // 
            this.buttonModifyParticle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifyParticle.Location = new System.Drawing.Point(132, 156);
            this.buttonModifyParticle.Name = "buttonModifyParticle";
            this.buttonModifyParticle.Size = new System.Drawing.Size(92, 31);
            this.buttonModifyParticle.TabIndex = 19;
            this.buttonModifyParticle.Text = "MODIFY";
            this.buttonModifyParticle.UseVisualStyleBackColor = true;
            this.buttonModifyParticle.Click += new System.EventHandler(this.buttonModifyParticle_Click);
            // 
            // _2DCollisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(800, 699);
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
            this.panelParticleInitialiser.PerformLayout();
            this.panelModifer.ResumeLayout(false);
            this.panelModifer.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelMassModifier;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.ComboBox comboBoxColorModifier;
        private System.Windows.Forms.TextBox textBoxSpeedModifier;
        private System.Windows.Forms.TextBox textBoxMassModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSpeedModifier;
        private System.Windows.Forms.TextBox textBoxAngleModifier;
        private System.Windows.Forms.Button buttonModifyParticle;
    }
}