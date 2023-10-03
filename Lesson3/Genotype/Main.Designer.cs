namespace Genotype
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            BtSettings = new Button();
            LbMother = new Label();
            Father = new Label();
            LbMotherName = new Label();
            LbMotherGen = new Label();
            pictureBox1 = new PictureBox();
            LbFatherGen = new Label();
            LbFatherName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(130, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtGenerate_Click;
            // 
            // BtSettings
            // 
            BtSettings.Location = new Point(12, 12);
            BtSettings.Name = "BtSettings";
            BtSettings.Size = new Size(112, 34);
            BtSettings.TabIndex = 1;
            BtSettings.Text = "Settings";
            BtSettings.UseVisualStyleBackColor = true;
            BtSettings.Click += BtSettings_Click;
            // 
            // LbMother
            // 
            LbMother.AutoSize = true;
            LbMother.Location = new Point(35, 61);
            LbMother.Name = "LbMother";
            LbMother.Size = new Size(70, 25);
            LbMother.TabIndex = 2;
            LbMother.Text = "Mother";
            // 
            // Father
            // 
            Father.AutoSize = true;
            Father.Location = new Point(497, 61);
            Father.Name = "Father";
            Father.Size = new Size(60, 25);
            Father.TabIndex = 3;
            Father.Text = "Father";
            // 
            // LbMotherName
            // 
            LbMotherName.AutoSize = true;
            LbMotherName.Location = new Point(42, 96);
            LbMotherName.Name = "LbMotherName";
            LbMotherName.Size = new Size(63, 25);
            LbMotherName.TabIndex = 4;
            LbMotherName.Text = "Name:";
            // 
            // LbMotherGen
            // 
            LbMotherGen.AutoSize = true;
            LbMotherGen.Location = new Point(12, 121);
            LbMotherGen.Name = "LbMotherGen";
            LbMotherGen.Size = new Size(93, 25);
            LbMotherGen.TabIndex = 5;
            LbMotherGen.Text = "Genotype:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 199);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(924, 547);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // LbFatherGen
            // 
            LbFatherGen.AutoSize = true;
            LbFatherGen.Location = new Point(464, 121);
            LbFatherGen.Name = "LbFatherGen";
            LbFatherGen.Size = new Size(93, 25);
            LbFatherGen.TabIndex = 8;
            LbFatherGen.Text = "Genotype:";
            // 
            // LbFatherName
            // 
            LbFatherName.AutoSize = true;
            LbFatherName.Location = new Point(494, 96);
            LbFatherName.Name = "LbFatherName";
            LbFatherName.Size = new Size(63, 25);
            LbFatherName.TabIndex = 7;
            LbFatherName.Text = "Name:";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 758);
            Controls.Add(LbFatherGen);
            Controls.Add(LbFatherName);
            Controls.Add(pictureBox1);
            Controls.Add(LbMotherGen);
            Controls.Add(LbMotherName);
            Controls.Add(Father);
            Controls.Add(LbMother);
            Controls.Add(BtSettings);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button BtSettings;
        private Label LbMother;
        private Label Father;
        private Label LbMotherName;
        private Label LbMotherGen;
        private PictureBox pictureBox1;
        private Label LbFatherGen;
        private Label LbFatherName;
    }
}