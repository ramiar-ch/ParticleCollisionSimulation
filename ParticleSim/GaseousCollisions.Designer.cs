namespace ParticleSim
{
    partial class GaseousCollisions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GaseousCollisions));
            this.panelDisplayArea = new System.Windows.Forms.Panel();
            this.panelParticleGen = new System.Windows.Forms.Panel();
            this.textBoxElasticity = new System.Windows.Forms.TextBox();
            this.textBoxHeat = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelMass = new System.Windows.Forms.Label();
            this.labelAvgSpeed = new System.Windows.Forms.Label();
            this.checkBoxArrows = new System.Windows.Forms.CheckBox();
            this.textBoxMass = new System.Windows.Forms.TextBox();
            this.checkBoxGrid = new System.Windows.Forms.CheckBox();
            this.textBoxAvgSpeed = new System.Windows.Forms.TextBox();
            this.trackBarElasticity = new System.Windows.Forms.TrackBar();
            this.trackBarHeat = new System.Windows.Forms.TrackBar();
            this.labelHeat = new System.Windows.Forms.Label();
            this.labelElasticity = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.panelStats = new System.Windows.Forms.Panel();
            this.labelPressure = new System.Windows.Forms.Label();
            this.textBoxPressure = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRunReset = new System.Windows.Forms.Button();
            this.buttonArrowBack = new System.Windows.Forms.Button();
            this.panelParticleGen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarElasticity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeat)).BeginInit();
            this.panelStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDisplayArea
            // 
            this.panelDisplayArea.BackColor = System.Drawing.Color.White;
            this.panelDisplayArea.Location = new System.Drawing.Point(31, 35);
            this.panelDisplayArea.Name = "panelDisplayArea";
            this.panelDisplayArea.Size = new System.Drawing.Size(714, 398);
            this.panelDisplayArea.TabIndex = 0;
            this.panelDisplayArea.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDisplayArea_Paint);
            // 
            // panelParticleGen
            // 
            this.panelParticleGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.panelParticleGen.Controls.Add(this.textBoxElasticity);
            this.panelParticleGen.Controls.Add(this.textBoxHeat);
            this.panelParticleGen.Controls.Add(this.textBoxQuantity);
            this.panelParticleGen.Controls.Add(this.labelQuantity);
            this.panelParticleGen.Controls.Add(this.labelMass);
            this.panelParticleGen.Controls.Add(this.labelAvgSpeed);
            this.panelParticleGen.Controls.Add(this.checkBoxArrows);
            this.panelParticleGen.Controls.Add(this.textBoxMass);
            this.panelParticleGen.Controls.Add(this.checkBoxGrid);
            this.panelParticleGen.Controls.Add(this.textBoxAvgSpeed);
            this.panelParticleGen.Controls.Add(this.trackBarElasticity);
            this.panelParticleGen.Controls.Add(this.trackBarHeat);
            this.panelParticleGen.Controls.Add(this.labelHeat);
            this.panelParticleGen.Controls.Add(this.labelElasticity);
            this.panelParticleGen.Controls.Add(this.buttonCreate);
            this.panelParticleGen.Location = new System.Drawing.Point(403, 448);
            this.panelParticleGen.Name = "panelParticleGen";
            this.panelParticleGen.Size = new System.Drawing.Size(342, 269);
            this.panelParticleGen.TabIndex = 2;
            // 
            // textBoxElasticity
            // 
            this.textBoxElasticity.Location = new System.Drawing.Point(285, 150);
            this.textBoxElasticity.Name = "textBoxElasticity";
            this.textBoxElasticity.Size = new System.Drawing.Size(39, 22);
            this.textBoxElasticity.TabIndex = 23;
            // 
            // textBoxHeat
            // 
            this.textBoxHeat.Location = new System.Drawing.Point(285, 117);
            this.textBoxHeat.Name = "textBoxHeat";
            this.textBoxHeat.Size = new System.Drawing.Size(39, 22);
            this.textBoxHeat.TabIndex = 22;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(117, 83);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(162, 22);
            this.textBoxQuantity.TabIndex = 21;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelQuantity.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.ForeColor = System.Drawing.Color.White;
            this.labelQuantity.Location = new System.Drawing.Point(29, 84);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(73, 21);
            this.labelQuantity.TabIndex = 20;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelMass
            // 
            this.labelMass.AutoSize = true;
            this.labelMass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelMass.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMass.ForeColor = System.Drawing.Color.White;
            this.labelMass.Location = new System.Drawing.Point(44, 20);
            this.labelMass.Name = "labelMass";
            this.labelMass.Size = new System.Drawing.Size(48, 21);
            this.labelMass.TabIndex = 13;
            this.labelMass.Text = "Mass";
            // 
            // labelAvgSpeed
            // 
            this.labelAvgSpeed.AutoSize = true;
            this.labelAvgSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelAvgSpeed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvgSpeed.ForeColor = System.Drawing.Color.White;
            this.labelAvgSpeed.Location = new System.Drawing.Point(14, 52);
            this.labelAvgSpeed.Name = "labelAvgSpeed";
            this.labelAvgSpeed.Size = new System.Drawing.Size(93, 21);
            this.labelAvgSpeed.TabIndex = 14;
            this.labelAvgSpeed.Text = "Avg. Speed";
            // 
            // checkBoxArrows
            // 
            this.checkBoxArrows.AutoSize = true;
            this.checkBoxArrows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.checkBoxArrows.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.checkBoxArrows.ForeColor = System.Drawing.Color.White;
            this.checkBoxArrows.Location = new System.Drawing.Point(171, 180);
            this.checkBoxArrows.Name = "checkBoxArrows";
            this.checkBoxArrows.Size = new System.Drawing.Size(85, 25);
            this.checkBoxArrows.TabIndex = 17;
            this.checkBoxArrows.Text = "Arrows";
            this.checkBoxArrows.UseVisualStyleBackColor = false;
            // 
            // textBoxMass
            // 
            this.textBoxMass.Location = new System.Drawing.Point(117, 19);
            this.textBoxMass.Name = "textBoxMass";
            this.textBoxMass.Size = new System.Drawing.Size(162, 22);
            this.textBoxMass.TabIndex = 15;
            this.textBoxMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMass_KeyPress);
            // 
            // checkBoxGrid
            // 
            this.checkBoxGrid.AutoSize = true;
            this.checkBoxGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.checkBoxGrid.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.checkBoxGrid.ForeColor = System.Drawing.Color.White;
            this.checkBoxGrid.Location = new System.Drawing.Point(91, 180);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(62, 25);
            this.checkBoxGrid.TabIndex = 14;
            this.checkBoxGrid.Text = "Grid";
            this.checkBoxGrid.UseVisualStyleBackColor = false;
            // 
            // textBoxAvgSpeed
            // 
            this.textBoxAvgSpeed.Location = new System.Drawing.Point(117, 51);
            this.textBoxAvgSpeed.Name = "textBoxAvgSpeed";
            this.textBoxAvgSpeed.Size = new System.Drawing.Size(162, 22);
            this.textBoxAvgSpeed.TabIndex = 16;
            this.textBoxAvgSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAvgSpeed_KeyPress);
            // 
            // trackBarElasticity
            // 
            this.trackBarElasticity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.trackBarElasticity.Location = new System.Drawing.Point(117, 140);
            this.trackBarElasticity.Name = "trackBarElasticity";
            this.trackBarElasticity.Size = new System.Drawing.Size(162, 56);
            this.trackBarElasticity.TabIndex = 16;
            this.trackBarElasticity.Scroll += new System.EventHandler(this.trackBarElasticity_Scroll);
            // 
            // trackBarHeat
            // 
            this.trackBarHeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.trackBarHeat.Location = new System.Drawing.Point(117, 108);
            this.trackBarHeat.Name = "trackBarHeat";
            this.trackBarHeat.Size = new System.Drawing.Size(162, 56);
            this.trackBarHeat.TabIndex = 18;
            this.trackBarHeat.Scroll += new System.EventHandler(this.trackBarHeat_Scroll);
            // 
            // labelHeat
            // 
            this.labelHeat.AutoSize = true;
            this.labelHeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelHeat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeat.ForeColor = System.Drawing.Color.White;
            this.labelHeat.Location = new System.Drawing.Point(43, 115);
            this.labelHeat.Name = "labelHeat";
            this.labelHeat.Size = new System.Drawing.Size(45, 21);
            this.labelHeat.TabIndex = 19;
            this.labelHeat.Text = "Heat";
            // 
            // labelElasticity
            // 
            this.labelElasticity.AutoSize = true;
            this.labelElasticity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelElasticity.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElasticity.ForeColor = System.Drawing.Color.White;
            this.labelElasticity.Location = new System.Drawing.Point(29, 147);
            this.labelElasticity.Name = "labelElasticity";
            this.labelElasticity.Size = new System.Drawing.Size(77, 21);
            this.labelElasticity.TabIndex = 17;
            this.labelElasticity.Text = "Elasticity";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(117, 215);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(96, 31);
            this.buttonCreate.TabIndex = 9;
            this.buttonCreate.Text = "CREATE";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.panelStats.Controls.Add(this.labelPressure);
            this.panelStats.Controls.Add(this.textBoxPressure);
            this.panelStats.Location = new System.Drawing.Point(31, 509);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(356, 208);
            this.panelStats.TabIndex = 3;
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.labelPressure.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressure.ForeColor = System.Drawing.Color.White;
            this.labelPressure.Location = new System.Drawing.Point(42, 15);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(74, 21);
            this.labelPressure.TabIndex = 16;
            this.labelPressure.Text = "Pressure";
            // 
            // textBoxPressure
            // 
            this.textBoxPressure.Location = new System.Drawing.Point(122, 14);
            this.textBoxPressure.Name = "textBoxPressure";
            this.textBoxPressure.ReadOnly = true;
            this.textBoxPressure.Size = new System.Drawing.Size(162, 22);
            this.textBoxPressure.TabIndex = 17;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(215, 456);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 33);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRunReset
            // 
            this.buttonRunReset.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRunReset.Location = new System.Drawing.Point(108, 456);
            this.buttonRunReset.Name = "buttonRunReset";
            this.buttonRunReset.Size = new System.Drawing.Size(79, 33);
            this.buttonRunReset.TabIndex = 6;
            this.buttonRunReset.Text = "RUN";
            this.buttonRunReset.UseVisualStyleBackColor = true;
            this.buttonRunReset.Click += new System.EventHandler(this.buttonRunReset_Click);
            // 
            // buttonArrowBack
            // 
            this.buttonArrowBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.buttonArrowBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonArrowBack.FlatAppearance.BorderSize = 0;
            this.buttonArrowBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArrowBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonArrowBack.Image")));
            this.buttonArrowBack.Location = new System.Drawing.Point(33, -1);
            this.buttonArrowBack.Margin = new System.Windows.Forms.Padding(0);
            this.buttonArrowBack.Name = "buttonArrowBack";
            this.buttonArrowBack.Size = new System.Drawing.Size(35, 35);
            this.buttonArrowBack.TabIndex = 18;
            this.buttonArrowBack.UseVisualStyleBackColor = false;
            this.buttonArrowBack.Click += new System.EventHandler(this.buttonArrowBack_Click);
            // 
            // GaseousCollisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(772, 739);
            this.Controls.Add(this.buttonArrowBack);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRunReset);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelParticleGen);
            this.Controls.Add(this.panelDisplayArea);
            this.Name = "GaseousCollisions";
            this.Text = "GaseousCollisions";
            this.panelParticleGen.ResumeLayout(false);
            this.panelParticleGen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarElasticity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeat)).EndInit();
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDisplayArea;
        private System.Windows.Forms.Panel panelParticleGen;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.CheckBox checkBoxGrid;
        private System.Windows.Forms.CheckBox checkBoxArrows;
        private System.Windows.Forms.TrackBar trackBarElasticity;
        private System.Windows.Forms.TrackBar trackBarHeat;
        private System.Windows.Forms.Label labelHeat;
        private System.Windows.Forms.Label labelElasticity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelMass;
        private System.Windows.Forms.Label labelAvgSpeed;
        private System.Windows.Forms.TextBox textBoxMass;
        private System.Windows.Forms.TextBox textBoxAvgSpeed;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.TextBox textBoxPressure;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRunReset;
        private System.Windows.Forms.TextBox textBoxElasticity;
        private System.Windows.Forms.TextBox textBoxHeat;
        private System.Windows.Forms.Button buttonArrowBack;
    }
}