namespace Genotype
{
    partial class Settings
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
            LbOffspringNumber = new Label();
            LbMother = new Label();
            LbFather = new Label();
            LbMotherName = new Label();
            LbFatherName = new Label();
            LbParent = new Label();
            LbOffspring = new Label();
            RdBtMotherAllele1Dominant = new RadioButton();
            RdBtFatherAllele1Dominant = new RadioButton();
            RdBtFatherAllele2Dominant = new RadioButton();
            RdBtMotherAllele2Dominant = new RadioButton();
            RdBtMotherAllele1Recessive = new RadioButton();
            RdBtMotherAllele2Recessive = new RadioButton();
            RdBtFatherAllele1Recessive = new RadioButton();
            RdBtFatherAllele2Recessive = new RadioButton();
            TrBrOffspringNumber = new TrackBar();
            LbOffspringNumberMin = new Label();
            LbOffspringNumberMax = new Label();
            GrBxMotherAllele1 = new GroupBox();
            GrBxMotherAllele2 = new GroupBox();
            GrBxFatherAllele1 = new GroupBox();
            GrBxFatherAllele2 = new GroupBox();
            LbOffspringNumberNow = new Label();
            ((System.ComponentModel.ISupportInitialize)TrBrOffspringNumber).BeginInit();
            GrBxMotherAllele1.SuspendLayout();
            GrBxMotherAllele2.SuspendLayout();
            GrBxFatherAllele1.SuspendLayout();
            GrBxFatherAllele2.SuspendLayout();
            SuspendLayout();
            // 
            // LbOffspringNumber
            // 
            LbOffspringNumber.AutoSize = true;
            LbOffspringNumber.Location = new Point(47, 295);
            LbOffspringNumber.Name = "LbOffspringNumber";
            LbOffspringNumber.Size = new Size(81, 25);
            LbOffspringNumber.TabIndex = 0;
            LbOffspringNumber.Text = "Number:";
            // 
            // LbMother
            // 
            LbMother.AutoSize = true;
            LbMother.Location = new Point(99, 38);
            LbMother.Name = "LbMother";
            LbMother.Size = new Size(70, 25);
            LbMother.TabIndex = 1;
            LbMother.Text = "Mother";
            // 
            // LbFather
            // 
            LbFather.AutoSize = true;
            LbFather.Location = new Point(356, 38);
            LbFather.Name = "LbFather";
            LbFather.Size = new Size(60, 25);
            LbFather.TabIndex = 2;
            LbFather.Text = "Father";
            // 
            // LbMotherName
            // 
            LbMotherName.AutoSize = true;
            LbMotherName.Location = new Point(47, 63);
            LbMotherName.Name = "LbMotherName";
            LbMotherName.Size = new Size(63, 25);
            LbMotherName.TabIndex = 3;
            LbMotherName.Text = "Name:";
            // 
            // LbFatherName
            // 
            LbFatherName.AutoSize = true;
            LbFatherName.Location = new Point(294, 63);
            LbFatherName.Name = "LbFatherName";
            LbFatherName.Size = new Size(63, 25);
            LbFatherName.TabIndex = 6;
            LbFatherName.Text = "Name:";
            // 
            // LbParent
            // 
            LbParent.AutoSize = true;
            LbParent.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            LbParent.Location = new Point(12, 9);
            LbParent.Name = "LbParent";
            LbParent.Size = new Size(81, 30);
            LbParent.TabIndex = 9;
            LbParent.Text = "Parent";
            // 
            // LbOffspring
            // 
            LbOffspring.AutoSize = true;
            LbOffspring.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            LbOffspring.Location = new Point(12, 250);
            LbOffspring.Name = "LbOffspring";
            LbOffspring.Size = new Size(112, 30);
            LbOffspring.TabIndex = 10;
            LbOffspring.Text = "Offspring";
            // 
            // RdBtMotherAllele1Dominant
            // 
            RdBtMotherAllele1Dominant.AutoSize = true;
            RdBtMotherAllele1Dominant.Location = new Point(6, 30);
            RdBtMotherAllele1Dominant.Name = "RdBtMotherAllele1Dominant";
            RdBtMotherAllele1Dominant.Size = new Size(116, 29);
            RdBtMotherAllele1Dominant.TabIndex = 11;
            RdBtMotherAllele1Dominant.Tag = "Dominant";
            RdBtMotherAllele1Dominant.Text = "Dominant";
            RdBtMotherAllele1Dominant.UseVisualStyleBackColor = true;
            RdBtMotherAllele1Dominant.Click += AlleleRadioButton_Click;
            // 
            // RdBtFatherAllele1Dominant
            // 
            RdBtFatherAllele1Dominant.AutoSize = true;
            RdBtFatherAllele1Dominant.Location = new Point(6, 30);
            RdBtFatherAllele1Dominant.Name = "RdBtFatherAllele1Dominant";
            RdBtFatherAllele1Dominant.Size = new Size(116, 29);
            RdBtFatherAllele1Dominant.TabIndex = 12;
            RdBtFatherAllele1Dominant.Tag = "Dominant";
            RdBtFatherAllele1Dominant.Text = "Dominant";
            RdBtFatherAllele1Dominant.UseVisualStyleBackColor = true;
            RdBtFatherAllele1Dominant.Click += AlleleRadioButton_Click;
            // 
            // RdBtFatherAllele2Dominant
            // 
            RdBtFatherAllele2Dominant.AutoSize = true;
            RdBtFatherAllele2Dominant.Location = new Point(6, 30);
            RdBtFatherAllele2Dominant.Name = "RdBtFatherAllele2Dominant";
            RdBtFatherAllele2Dominant.Size = new Size(116, 29);
            RdBtFatherAllele2Dominant.TabIndex = 13;
            RdBtFatherAllele2Dominant.Tag = "Dominant";
            RdBtFatherAllele2Dominant.Text = "Dominant";
            RdBtFatherAllele2Dominant.UseVisualStyleBackColor = true;
            RdBtFatherAllele2Dominant.Click += AlleleRadioButton_Click;
            // 
            // RdBtMotherAllele2Dominant
            // 
            RdBtMotherAllele2Dominant.AutoSize = true;
            RdBtMotherAllele2Dominant.Location = new Point(6, 30);
            RdBtMotherAllele2Dominant.Name = "RdBtMotherAllele2Dominant";
            RdBtMotherAllele2Dominant.Size = new Size(116, 29);
            RdBtMotherAllele2Dominant.TabIndex = 14;
            RdBtMotherAllele2Dominant.Tag = "Dominant";
            RdBtMotherAllele2Dominant.Text = "Dominant";
            RdBtMotherAllele2Dominant.UseVisualStyleBackColor = true;
            RdBtMotherAllele2Dominant.Click += AlleleRadioButton_Click;
            // 
            // RdBtMotherAllele1Recessive
            // 
            RdBtMotherAllele1Recessive.AutoSize = true;
            RdBtMotherAllele1Recessive.Location = new Point(124, 30);
            RdBtMotherAllele1Recessive.Name = "RdBtMotherAllele1Recessive";
            RdBtMotherAllele1Recessive.Size = new Size(111, 29);
            RdBtMotherAllele1Recessive.TabIndex = 15;
            RdBtMotherAllele1Recessive.Tag = "Recessive";
            RdBtMotherAllele1Recessive.Text = "Recessive";
            RdBtMotherAllele1Recessive.UseVisualStyleBackColor = true;
            RdBtMotherAllele1Recessive.Click += AlleleRadioButton_Click;
            // 
            // RdBtMotherAllele2Recessive
            // 
            RdBtMotherAllele2Recessive.AutoSize = true;
            RdBtMotherAllele2Recessive.Location = new Point(124, 30);
            RdBtMotherAllele2Recessive.Name = "RdBtMotherAllele2Recessive";
            RdBtMotherAllele2Recessive.Size = new Size(111, 29);
            RdBtMotherAllele2Recessive.TabIndex = 16;
            RdBtMotherAllele2Recessive.Tag = "Recessive";
            RdBtMotherAllele2Recessive.Text = "Recessive";
            RdBtMotherAllele2Recessive.UseVisualStyleBackColor = true;
            RdBtMotherAllele2Recessive.Click += AlleleRadioButton_Click;
            // 
            // RdBtFatherAllele1Recessive
            // 
            RdBtFatherAllele1Recessive.AutoSize = true;
            RdBtFatherAllele1Recessive.Location = new Point(124, 30);
            RdBtFatherAllele1Recessive.Name = "RdBtFatherAllele1Recessive";
            RdBtFatherAllele1Recessive.Size = new Size(111, 29);
            RdBtFatherAllele1Recessive.TabIndex = 17;
            RdBtFatherAllele1Recessive.Tag = "Recessive";
            RdBtFatherAllele1Recessive.Text = "Recessive";
            RdBtFatherAllele1Recessive.UseVisualStyleBackColor = true;
            RdBtFatherAllele1Recessive.Click += AlleleRadioButton_Click;
            // 
            // RdBtFatherAllele2Recessive
            // 
            RdBtFatherAllele2Recessive.AutoSize = true;
            RdBtFatherAllele2Recessive.Location = new Point(124, 30);
            RdBtFatherAllele2Recessive.Name = "RdBtFatherAllele2Recessive";
            RdBtFatherAllele2Recessive.Size = new Size(111, 29);
            RdBtFatherAllele2Recessive.TabIndex = 18;
            RdBtFatherAllele2Recessive.Tag = "Recessive";
            RdBtFatherAllele2Recessive.Text = "Recessive";
            RdBtFatherAllele2Recessive.UseVisualStyleBackColor = true;
            RdBtFatherAllele2Recessive.Click += AlleleRadioButton_Click;
            // 
            // TrBrOffspringNumber
            // 
            TrBrOffspringNumber.Location = new Point(134, 295);
            TrBrOffspringNumber.Maximum = 100;
            TrBrOffspringNumber.Minimum = 1;
            TrBrOffspringNumber.Name = "TrBrOffspringNumber";
            TrBrOffspringNumber.Size = new Size(209, 69);
            TrBrOffspringNumber.TabIndex = 19;
            TrBrOffspringNumber.TickFrequency = 10;
            TrBrOffspringNumber.Value = 1;
            TrBrOffspringNumber.Scroll += TrBrOffspringNumber_Scroll;
            // 
            // LbOffspringNumberMin
            // 
            LbOffspringNumberMin.AutoSize = true;
            LbOffspringNumberMin.Location = new Point(143, 339);
            LbOffspringNumberMin.Name = "LbOffspringNumberMin";
            LbOffspringNumberMin.Size = new Size(22, 25);
            LbOffspringNumberMin.TabIndex = 20;
            LbOffspringNumberMin.Text = "1";
            // 
            // LbOffspringNumberMax
            // 
            LbOffspringNumberMax.AutoSize = true;
            LbOffspringNumberMax.Location = new Point(313, 339);
            LbOffspringNumberMax.Name = "LbOffspringNumberMax";
            LbOffspringNumberMax.Size = new Size(42, 25);
            LbOffspringNumberMax.TabIndex = 21;
            LbOffspringNumberMax.Text = "100";
            // 
            // GrBxMotherAllele1
            // 
            GrBxMotherAllele1.Controls.Add(RdBtMotherAllele1Dominant);
            GrBxMotherAllele1.Controls.Add(RdBtMotherAllele1Recessive);
            GrBxMotherAllele1.Location = new Point(47, 91);
            GrBxMotherAllele1.Name = "GrBxMotherAllele1";
            GrBxMotherAllele1.Size = new Size(241, 68);
            GrBxMotherAllele1.TabIndex = 22;
            GrBxMotherAllele1.TabStop = false;
            GrBxMotherAllele1.Text = "Allele 1:";
            // 
            // GrBxMotherAllele2
            // 
            GrBxMotherAllele2.Controls.Add(RdBtMotherAllele2Recessive);
            GrBxMotherAllele2.Controls.Add(RdBtMotherAllele2Dominant);
            GrBxMotherAllele2.Location = new Point(47, 165);
            GrBxMotherAllele2.Name = "GrBxMotherAllele2";
            GrBxMotherAllele2.Size = new Size(241, 68);
            GrBxMotherAllele2.TabIndex = 23;
            GrBxMotherAllele2.TabStop = false;
            GrBxMotherAllele2.Text = "Allele 2:";
            // 
            // GrBxFatherAllele1
            // 
            GrBxFatherAllele1.Controls.Add(RdBtFatherAllele1Dominant);
            GrBxFatherAllele1.Controls.Add(RdBtFatherAllele1Recessive);
            GrBxFatherAllele1.Location = new Point(294, 91);
            GrBxFatherAllele1.Name = "GrBxFatherAllele1";
            GrBxFatherAllele1.Size = new Size(241, 68);
            GrBxFatherAllele1.TabIndex = 23;
            GrBxFatherAllele1.TabStop = false;
            GrBxFatherAllele1.Text = "Allele 1:";
            // 
            // GrBxFatherAllele2
            // 
            GrBxFatherAllele2.Controls.Add(RdBtFatherAllele2Dominant);
            GrBxFatherAllele2.Controls.Add(RdBtFatherAllele2Recessive);
            GrBxFatherAllele2.Location = new Point(294, 165);
            GrBxFatherAllele2.Name = "GrBxFatherAllele2";
            GrBxFatherAllele2.Size = new Size(241, 68);
            GrBxFatherAllele2.TabIndex = 24;
            GrBxFatherAllele2.TabStop = false;
            GrBxFatherAllele2.Text = "Allele 2:";
            // 
            // LbOffspringNumberNow
            // 
            LbOffspringNumberNow.AutoSize = true;
            LbOffspringNumberNow.Location = new Point(349, 295);
            LbOffspringNumberNow.Name = "LbOffspringNumberNow";
            LbOffspringNumberNow.Size = new Size(22, 25);
            LbOffspringNumberNow.TabIndex = 26;
            LbOffspringNumberNow.Text = "0";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 397);
            Controls.Add(LbOffspringNumberNow);
            Controls.Add(GrBxFatherAllele2);
            Controls.Add(GrBxFatherAllele1);
            Controls.Add(GrBxMotherAllele2);
            Controls.Add(LbOffspringNumberMax);
            Controls.Add(LbOffspringNumberMin);
            Controls.Add(TrBrOffspringNumber);
            Controls.Add(LbOffspring);
            Controls.Add(LbParent);
            Controls.Add(LbFatherName);
            Controls.Add(LbMotherName);
            Controls.Add(LbFather);
            Controls.Add(LbMother);
            Controls.Add(LbOffspringNumber);
            Controls.Add(GrBxMotherAllele1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Settings";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)TrBrOffspringNumber).EndInit();
            GrBxMotherAllele1.ResumeLayout(false);
            GrBxMotherAllele1.PerformLayout();
            GrBxMotherAllele2.ResumeLayout(false);
            GrBxMotherAllele2.PerformLayout();
            GrBxFatherAllele1.ResumeLayout(false);
            GrBxFatherAllele1.PerformLayout();
            GrBxFatherAllele2.ResumeLayout(false);
            GrBxFatherAllele2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbOffspringNumber;
        private Label LbMother;
        private Label LbFather;
        private Label LbMotherName;
        private Label LbFatherName;
        private Label LbParent;
        private Label LbOffspring;
        private RadioButton RdBtMotherAllele1Dominant;
        private RadioButton RdBtFatherAllele1Dominant;
        private RadioButton RdBtFatherAllele2Dominant;
        private RadioButton RdBtMotherAllele2Dominant;
        private RadioButton RdBtMotherAllele1Recessive;
        private RadioButton RdBtMotherAllele2Recessive;
        private RadioButton RdBtFatherAllele1Recessive;
        private RadioButton RdBtFatherAllele2Recessive;
        private TrackBar TrBrOffspringNumber;
        private Label LbOffspringNumberMin;
        private Label LbOffspringNumberMax;
        private GroupBox GrBxMotherAllele1;
        private GroupBox GrBxMotherAllele2;
        private GroupBox GrBxFatherAllele1;
        private GroupBox GrBxFatherAllele2;
        private Label LbOffspringNumberNow;
    }
}