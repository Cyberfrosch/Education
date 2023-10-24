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
            BtStart = new Button();
            LbFather = new Label();
            LbFatherName = new Label();
            LbMother = new Label();
            LbMotherName = new Label();
            PnMain = new Panel();
            PnOffspring = new Panel();
            PbOffspring = new PictureBox();
            PbFather = new PictureBox();
            PbMother = new PictureBox();
            PnSettings = new Panel();
            LbOffspringNumberCurrent = new Label();
            LbOffspringNumberMax = new Label();
            LbOffspringNumberMin = new Label();
            TbOffspringNumber = new TrackBar();
            FlpMother = new FlowLayoutPanel();
            LbOffspring = new Label();
            FlpFather = new FlowLayoutPanel();
            LbMotherPnSettings = new Label();
            LbFatherPnSettings = new Label();
            PnChildInfo = new Panel();
            GbFilter = new GroupBox();
            RbSortNone = new RadioButton();
            RbSortFemale = new RadioButton();
            RbSortMale = new RadioButton();
            CbSortName = new CheckBox();
            LbGeneName = new Label();
            LbAllele2Name = new Label();
            LbAllele1Name = new Label();
            LbGene3Allele2 = new Label();
            LbGene3Allele1 = new Label();
            LbGene2Allele2 = new Label();
            LbGene2Allele1 = new Label();
            LbGene1Allele2 = new Label();
            LbGene1Allele1 = new Label();
            LbGene3Name = new Label();
            LbGene2Name = new Label();
            LbGene1Name = new Label();
            ListBoxChildren = new ListBox();
            LbChildSex = new Label();
            LbChildName = new Label();
            PbChild = new PictureBox();
            MenuStrip = new MenuStrip();
            TsmiMain = new ToolStripMenuItem();
            TsmiSettings = new ToolStripMenuItem();
            PnMain.SuspendLayout();
            PnOffspring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbOffspring).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbFather).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbMother).BeginInit();
            PnSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TbOffspringNumber).BeginInit();
            PnChildInfo.SuspendLayout();
            GbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbChild).BeginInit();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // BtStart
            // 
            BtStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtStart.Location = new Point(508, 192);
            BtStart.Margin = new Padding(4);
            BtStart.Name = "BtStart";
            BtStart.Size = new Size(224, 62);
            BtStart.TabIndex = 0;
            BtStart.Text = "Generate!";
            BtStart.UseVisualStyleBackColor = true;
            BtStart.Click += BtStart_Click;
            // 
            // LbFather
            // 
            LbFather.AutoSize = true;
            LbFather.Location = new Point(168, 31);
            LbFather.Margin = new Padding(4, 0, 4, 0);
            LbFather.Name = "LbFather";
            LbFather.Size = new Size(60, 25);
            LbFather.TabIndex = 2;
            LbFather.Text = "Father";
            // 
            // LbFatherName
            // 
            LbFatherName.AutoSize = true;
            LbFatherName.Location = new Point(160, 72);
            LbFatherName.Margin = new Padding(4, 0, 4, 0);
            LbFatherName.Name = "LbFatherName";
            LbFatherName.Size = new Size(68, 25);
            LbFatherName.TabIndex = 3;
            LbFatherName.Text = "Name: ";
            // 
            // LbMother
            // 
            LbMother.AutoSize = true;
            LbMother.Location = new Point(715, 31);
            LbMother.Margin = new Padding(4, 0, 4, 0);
            LbMother.Name = "LbMother";
            LbMother.Size = new Size(70, 25);
            LbMother.TabIndex = 5;
            LbMother.Text = "Mother";
            // 
            // LbMotherName
            // 
            LbMotherName.AutoSize = true;
            LbMotherName.Location = new Point(717, 72);
            LbMotherName.Margin = new Padding(4, 0, 4, 0);
            LbMotherName.Name = "LbMotherName";
            LbMotherName.Size = new Size(68, 25);
            LbMotherName.TabIndex = 6;
            LbMotherName.Text = "Name: ";
            // 
            // PnMain
            // 
            PnMain.Controls.Add(PnOffspring);
            PnMain.Controls.Add(PbFather);
            PnMain.Controls.Add(PbMother);
            PnMain.Controls.Add(LbMother);
            PnMain.Controls.Add(BtStart);
            PnMain.Controls.Add(LbMotherName);
            PnMain.Controls.Add(LbFatherName);
            PnMain.Controls.Add(LbFather);
            PnMain.Location = new Point(0, 37);
            PnMain.Margin = new Padding(4);
            PnMain.Name = "PnMain";
            PnMain.Size = new Size(1249, 625);
            PnMain.TabIndex = 8;
            // 
            // PnOffspring
            // 
            PnOffspring.AutoScroll = true;
            PnOffspring.Controls.Add(PbOffspring);
            PnOffspring.Location = new Point(0, 281);
            PnOffspring.Margin = new Padding(4);
            PnOffspring.Name = "PnOffspring";
            PnOffspring.Size = new Size(1249, 381);
            PnOffspring.TabIndex = 11;
            // 
            // PbOffspring
            // 
            PbOffspring.Location = new Point(0, 25);
            PbOffspring.Margin = new Padding(4);
            PbOffspring.Name = "PbOffspring";
            PbOffspring.Size = new Size(1226, 356);
            PbOffspring.TabIndex = 8;
            PbOffspring.TabStop = false;
            PbOffspring.Paint += Main_Paint;
            // 
            // PbFather
            // 
            PbFather.Location = new Point(412, 22);
            PbFather.Margin = new Padding(4);
            PbFather.Name = "PbFather";
            PbFather.Size = new Size(169, 120);
            PbFather.TabIndex = 10;
            PbFather.TabStop = false;
            // 
            // PbMother
            // 
            PbMother.Location = new Point(950, 22);
            PbMother.Margin = new Padding(4);
            PbMother.Name = "PbMother";
            PbMother.Size = new Size(169, 120);
            PbMother.TabIndex = 9;
            PbMother.TabStop = false;
            // 
            // PnSettings
            // 
            PnSettings.Controls.Add(LbOffspringNumberCurrent);
            PnSettings.Controls.Add(LbOffspringNumberMax);
            PnSettings.Controls.Add(LbOffspringNumberMin);
            PnSettings.Controls.Add(TbOffspringNumber);
            PnSettings.Controls.Add(FlpMother);
            PnSettings.Controls.Add(LbOffspring);
            PnSettings.Controls.Add(FlpFather);
            PnSettings.Controls.Add(LbMotherPnSettings);
            PnSettings.Controls.Add(LbFatherPnSettings);
            PnSettings.Location = new Point(0, 37);
            PnSettings.Margin = new Padding(4);
            PnSettings.Name = "PnSettings";
            PnSettings.Size = new Size(1249, 625);
            PnSettings.TabIndex = 8;
            PnSettings.Visible = false;
            // 
            // LbOffspringNumberCurrent
            // 
            LbOffspringNumberCurrent.AutoSize = true;
            LbOffspringNumberCurrent.Location = new Point(276, 415);
            LbOffspringNumberCurrent.Name = "LbOffspringNumberCurrent";
            LbOffspringNumberCurrent.Size = new Size(22, 25);
            LbOffspringNumberCurrent.TabIndex = 25;
            LbOffspringNumberCurrent.Text = "0";
            // 
            // LbOffspringNumberMax
            // 
            LbOffspringNumberMax.AutoSize = true;
            LbOffspringNumberMax.Location = new Point(228, 459);
            LbOffspringNumberMax.Name = "LbOffspringNumberMax";
            LbOffspringNumberMax.Size = new Size(42, 25);
            LbOffspringNumberMax.TabIndex = 24;
            LbOffspringNumberMax.Text = "100";
            // 
            // LbOffspringNumberMin
            // 
            LbOffspringNumberMin.AutoSize = true;
            LbOffspringNumberMin.Location = new Point(25, 459);
            LbOffspringNumberMin.Name = "LbOffspringNumberMin";
            LbOffspringNumberMin.Size = new Size(22, 25);
            LbOffspringNumberMin.TabIndex = 23;
            LbOffspringNumberMin.Text = "0";
            // 
            // TbOffspringNumber
            // 
            TbOffspringNumber.Location = new Point(16, 415);
            TbOffspringNumber.Maximum = 100;
            TbOffspringNumber.Minimum = 1;
            TbOffspringNumber.Name = "TbOffspringNumber";
            TbOffspringNumber.Size = new Size(254, 69);
            TbOffspringNumber.TabIndex = 22;
            TbOffspringNumber.TickFrequency = 10;
            TbOffspringNumber.Value = 1;
            TbOffspringNumber.Scroll += TbOffspringNumber_Scroll;
            // 
            // FlpMother
            // 
            FlpMother.AutoScroll = true;
            FlpMother.Location = new Point(634, 74);
            FlpMother.Margin = new Padding(4);
            FlpMother.Name = "FlpMother";
            FlpMother.Size = new Size(608, 296);
            FlpMother.TabIndex = 10;
            // 
            // LbOffspring
            // 
            LbOffspring.AutoSize = true;
            LbOffspring.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LbOffspring.Location = new Point(12, 374);
            LbOffspring.Margin = new Padding(4, 0, 4, 0);
            LbOffspring.Name = "LbOffspring";
            LbOffspring.Size = new Size(123, 32);
            LbOffspring.TabIndex = 21;
            LbOffspring.Text = "Offspring";
            // 
            // FlpFather
            // 
            FlpFather.Location = new Point(11, 74);
            FlpFather.Margin = new Padding(4);
            FlpFather.Name = "FlpFather";
            FlpFather.Size = new Size(608, 296);
            FlpFather.TabIndex = 9;
            // 
            // LbMotherPnSettings
            // 
            LbMotherPnSettings.AutoSize = true;
            LbMotherPnSettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LbMotherPnSettings.Location = new Point(634, 22);
            LbMotherPnSettings.Margin = new Padding(4, 0, 4, 0);
            LbMotherPnSettings.Name = "LbMotherPnSettings";
            LbMotherPnSettings.Size = new Size(98, 32);
            LbMotherPnSettings.TabIndex = 9;
            LbMotherPnSettings.Text = "Mother";
            // 
            // LbFatherPnSettings
            // 
            LbFatherPnSettings.AutoSize = true;
            LbFatherPnSettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LbFatherPnSettings.Location = new Point(31, 22);
            LbFatherPnSettings.Margin = new Padding(4, 0, 4, 0);
            LbFatherPnSettings.Name = "LbFatherPnSettings";
            LbFatherPnSettings.Size = new Size(84, 32);
            LbFatherPnSettings.TabIndex = 8;
            LbFatherPnSettings.Text = "Father";
            // 
            // PnChildInfo
            // 
            PnChildInfo.Controls.Add(GbFilter);
            PnChildInfo.Controls.Add(CbSortName);
            PnChildInfo.Controls.Add(LbGeneName);
            PnChildInfo.Controls.Add(LbAllele2Name);
            PnChildInfo.Controls.Add(LbAllele1Name);
            PnChildInfo.Controls.Add(LbGene3Allele2);
            PnChildInfo.Controls.Add(LbGene3Allele1);
            PnChildInfo.Controls.Add(LbGene2Allele2);
            PnChildInfo.Controls.Add(LbGene2Allele1);
            PnChildInfo.Controls.Add(LbGene1Allele2);
            PnChildInfo.Controls.Add(LbGene1Allele1);
            PnChildInfo.Controls.Add(LbGene3Name);
            PnChildInfo.Controls.Add(LbGene2Name);
            PnChildInfo.Controls.Add(LbGene1Name);
            PnChildInfo.Controls.Add(ListBoxChildren);
            PnChildInfo.Controls.Add(LbChildSex);
            PnChildInfo.Controls.Add(LbChildName);
            PnChildInfo.Controls.Add(PbChild);
            PnChildInfo.Location = new Point(1270, 33);
            PnChildInfo.Margin = new Padding(4);
            PnChildInfo.Name = "PnChildInfo";
            PnChildInfo.Size = new Size(471, 673);
            PnChildInfo.TabIndex = 9;
            // 
            // GbFilter
            // 
            GbFilter.Controls.Add(RbSortNone);
            GbFilter.Controls.Add(RbSortFemale);
            GbFilter.Controls.Add(RbSortMale);
            GbFilter.Location = new Point(4, 474);
            GbFilter.Margin = new Padding(4);
            GbFilter.Name = "GbFilter";
            GbFilter.Padding = new Padding(4);
            GbFilter.Size = new Size(144, 128);
            GbFilter.TabIndex = 17;
            GbFilter.TabStop = false;
            // 
            // RbSortNone
            // 
            RbSortNone.AutoSize = true;
            RbSortNone.Location = new Point(0, 72);
            RbSortNone.Margin = new Padding(4);
            RbSortNone.Name = "RbSortNone";
            RbSortNone.Size = new Size(141, 29);
            RbSortNone.TabIndex = 2;
            RbSortNone.TabStop = true;
            RbSortNone.Text = "View m and f";
            RbSortNone.UseVisualStyleBackColor = true;
            // 
            // RbSortFemale
            // 
            RbSortFemale.AutoSize = true;
            RbSortFemale.Location = new Point(0, 35);
            RbSortFemale.Margin = new Padding(4);
            RbSortFemale.Name = "RbSortFemale";
            RbSortFemale.Size = new Size(132, 29);
            RbSortFemale.TabIndex = 1;
            RbSortFemale.TabStop = true;
            RbSortFemale.Text = "View female";
            RbSortFemale.UseVisualStyleBackColor = true;
            RbSortFemale.CheckedChanged += RbSortFemale_CheckedChanged;
            // 
            // RbSortMale
            // 
            RbSortMale.AutoSize = true;
            RbSortMale.Location = new Point(-1, -2);
            RbSortMale.Margin = new Padding(4);
            RbSortMale.Name = "RbSortMale";
            RbSortMale.Size = new Size(117, 29);
            RbSortMale.TabIndex = 0;
            RbSortMale.TabStop = true;
            RbSortMale.Text = "View male";
            RbSortMale.UseVisualStyleBackColor = true;
            RbSortMale.CheckedChanged += RbSortMale_CheckedChanged;
            // 
            // CbSortName
            // 
            CbSortName.AutoSize = true;
            CbSortName.Location = new Point(4, 435);
            CbSortName.Margin = new Padding(4);
            CbSortName.Name = "CbSortName";
            CbSortName.Size = new Size(145, 29);
            CbSortName.TabIndex = 16;
            CbSortName.Text = "Sort by name";
            CbSortName.UseVisualStyleBackColor = true;
            CbSortName.CheckedChanged += CbSortName_CheckedChanged;
            // 
            // LbGeneName
            // 
            LbGeneName.AutoSize = true;
            LbGeneName.Location = new Point(15, 244);
            LbGeneName.Margin = new Padding(4, 0, 4, 0);
            LbGeneName.Name = "LbGeneName";
            LbGeneName.Size = new Size(52, 25);
            LbGeneName.TabIndex = 15;
            LbGeneName.Text = "Gene";
            // 
            // LbAllele2Name
            // 
            LbAllele2Name.AutoSize = true;
            LbAllele2Name.Location = new Point(15, 340);
            LbAllele2Name.Margin = new Padding(4, 0, 4, 0);
            LbAllele2Name.Name = "LbAllele2Name";
            LbAllele2Name.Size = new Size(69, 25);
            LbAllele2Name.TabIndex = 14;
            LbAllele2Name.Text = "Allele 2";
            // 
            // LbAllele1Name
            // 
            LbAllele1Name.AutoSize = true;
            LbAllele1Name.Location = new Point(15, 290);
            LbAllele1Name.Margin = new Padding(4, 0, 4, 0);
            LbAllele1Name.Name = "LbAllele1Name";
            LbAllele1Name.Size = new Size(69, 25);
            LbAllele1Name.TabIndex = 13;
            LbAllele1Name.Text = "Allele 1";
            // 
            // LbGene3Allele2
            // 
            LbGene3Allele2.AutoSize = true;
            LbGene3Allele2.Location = new Point(348, 340);
            LbGene3Allele2.Margin = new Padding(4, 0, 4, 0);
            LbGene3Allele2.Name = "LbGene3Allele2";
            LbGene3Allele2.Size = new Size(0, 25);
            LbGene3Allele2.TabIndex = 12;
            // 
            // LbGene3Allele1
            // 
            LbGene3Allele1.AutoSize = true;
            LbGene3Allele1.Location = new Point(348, 290);
            LbGene3Allele1.Margin = new Padding(4, 0, 4, 0);
            LbGene3Allele1.Name = "LbGene3Allele1";
            LbGene3Allele1.Size = new Size(0, 25);
            LbGene3Allele1.TabIndex = 11;
            // 
            // LbGene2Allele2
            // 
            LbGene2Allele2.AutoSize = true;
            LbGene2Allele2.Location = new Point(256, 340);
            LbGene2Allele2.Margin = new Padding(4, 0, 4, 0);
            LbGene2Allele2.Name = "LbGene2Allele2";
            LbGene2Allele2.Size = new Size(0, 25);
            LbGene2Allele2.TabIndex = 10;
            // 
            // LbGene2Allele1
            // 
            LbGene2Allele1.AutoSize = true;
            LbGene2Allele1.Location = new Point(256, 290);
            LbGene2Allele1.Margin = new Padding(4, 0, 4, 0);
            LbGene2Allele1.Name = "LbGene2Allele1";
            LbGene2Allele1.Size = new Size(0, 25);
            LbGene2Allele1.TabIndex = 9;
            // 
            // LbGene1Allele2
            // 
            LbGene1Allele2.AutoSize = true;
            LbGene1Allele2.Location = new Point(148, 340);
            LbGene1Allele2.Margin = new Padding(4, 0, 4, 0);
            LbGene1Allele2.Name = "LbGene1Allele2";
            LbGene1Allele2.Size = new Size(0, 25);
            LbGene1Allele2.TabIndex = 8;
            // 
            // LbGene1Allele1
            // 
            LbGene1Allele1.AutoSize = true;
            LbGene1Allele1.Location = new Point(148, 290);
            LbGene1Allele1.Margin = new Padding(4, 0, 4, 0);
            LbGene1Allele1.Name = "LbGene1Allele1";
            LbGene1Allele1.Size = new Size(0, 25);
            LbGene1Allele1.TabIndex = 7;
            // 
            // LbGene3Name
            // 
            LbGene3Name.AutoSize = true;
            LbGene3Name.Location = new Point(348, 244);
            LbGene3Name.Margin = new Padding(4, 0, 4, 0);
            LbGene3Name.Name = "LbGene3Name";
            LbGene3Name.Size = new Size(0, 25);
            LbGene3Name.TabIndex = 6;
            // 
            // LbGene2Name
            // 
            LbGene2Name.AutoSize = true;
            LbGene2Name.Location = new Point(256, 244);
            LbGene2Name.Margin = new Padding(4, 0, 4, 0);
            LbGene2Name.Name = "LbGene2Name";
            LbGene2Name.Size = new Size(0, 25);
            LbGene2Name.TabIndex = 5;
            // 
            // LbGene1Name
            // 
            LbGene1Name.AutoSize = true;
            LbGene1Name.Location = new Point(148, 244);
            LbGene1Name.Margin = new Padding(4, 0, 4, 0);
            LbGene1Name.Name = "LbGene1Name";
            LbGene1Name.Size = new Size(0, 25);
            LbGene1Name.TabIndex = 4;
            // 
            // ListBoxChildren
            // 
            ListBoxChildren.FormattingEnabled = true;
            ListBoxChildren.ItemHeight = 25;
            ListBoxChildren.Location = new Point(157, 430);
            ListBoxChildren.Margin = new Padding(4);
            ListBoxChildren.Name = "ListBoxChildren";
            ListBoxChildren.Size = new Size(310, 179);
            ListBoxChildren.TabIndex = 3;
            ListBoxChildren.SelectedIndexChanged += ListboxChildren_SelectedIndexChanged;
            // 
            // LbChildSex
            // 
            LbChildSex.AutoSize = true;
            LbChildSex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbChildSex.Location = new Point(32, 102);
            LbChildSex.Margin = new Padding(4, 0, 4, 0);
            LbChildSex.Name = "LbChildSex";
            LbChildSex.Size = new Size(0, 32);
            LbChildSex.TabIndex = 2;
            // 
            // LbChildName
            // 
            LbChildName.AutoSize = true;
            LbChildName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LbChildName.Location = new Point(32, 26);
            LbChildName.Margin = new Padding(4, 0, 4, 0);
            LbChildName.Name = "LbChildName";
            LbChildName.Size = new Size(0, 32);
            LbChildName.TabIndex = 1;
            // 
            // PbChild
            // 
            PbChild.Location = new Point(285, 26);
            PbChild.Margin = new Padding(4);
            PbChild.Name = "PbChild";
            PbChild.Size = new Size(171, 179);
            PbChild.TabIndex = 0;
            PbChild.TabStop = false;
            // 
            // MenuStrip
            // 
            MenuStrip.ImageScalingSize = new Size(24, 24);
            MenuStrip.Items.AddRange(new ToolStripItem[] { TsmiMain, TsmiSettings });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(1745, 33);
            MenuStrip.TabIndex = 10;
            MenuStrip.Text = "menuStrip1";
            // 
            // TsmiMain
            // 
            TsmiMain.Name = "TsmiMain";
            TsmiMain.Size = new Size(67, 29);
            TsmiMain.Text = "Main";
            TsmiMain.Click += TsmiMain_Click;
            // 
            // TsmiSettings
            // 
            TsmiSettings.Name = "TsmiSettings";
            TsmiSettings.Size = new Size(92, 29);
            TsmiSettings.Text = "Settings";
            TsmiSettings.Click += TsmiSettings_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(700, 500);
            ClientSize = new Size(1745, 710);
            Controls.Add(PnChildInfo);
            Controls.Add(PnMain);
            Controls.Add(MenuStrip);
            Controls.Add(PnSettings);
            Margin = new Padding(4);
            MinimumSize = new Size(1767, 766);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crossing";
            Resize += Main_Resize;
            PnMain.ResumeLayout(false);
            PnMain.PerformLayout();
            PnOffspring.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbOffspring).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbFather).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbMother).EndInit();
            PnSettings.ResumeLayout(false);
            PnSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TbOffspringNumber).EndInit();
            PnChildInfo.ResumeLayout(false);
            PnChildInfo.PerformLayout();
            GbFilter.ResumeLayout(false);
            GbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbChild).EndInit();
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtStart;
        private Label LbFather;
        private Label LbFatherName;
        private Label LbMother;
        private Label LbMotherName;
        private Panel PnMain;
        private Panel PnSettings;
        private Label LbMotherPnSettings;
        private Label LbFatherPnSettings;
        private PictureBox PbOffspring;
        private Label LbOffspring;
        private PictureBox PbFather;
        private PictureBox PbMother;
        private Panel PnControl;
        private FlowLayoutPanel FlpFather;
        private FlowLayoutPanel FlpMother;
        private GroupBox GbAllele1Father;
        private GroupBox GbAllele2Father;
        private GroupBox GbAllele3Father;
        private GroupBox GbAllele2Mother;
        private GroupBox GbAllele3Mother;
        private GroupBox GbAllele1Mother;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel PnOffspring;
        private Panel PnChildInfo;
        private ListBox ListBoxChildren;
        private Label LbChildSex;
        private Label LbChildName;
        private PictureBox PbChild;
        private Label LbGeneName;
        private Label LbAllele1Name;
        private Label LbAllele2Name;
        private Label LbGene1Allele1;
        private Label LbGene1Allele2;
        private Label LbGene2Allele1;
        private Label LbGene2Allele2;
        private Label LbGene3Allele1;
        private Label LbGene3Allele2;
        private Label LbGene1Name;
        private Label LbGene2Name;
        private Label LbGene3Name;
        private CheckBox CbSortName;
        private GroupBox GbFilter;
        private RadioButton RbSortFemale;
        private RadioButton RbSortMale;
        private RadioButton RbSortNone;
        private TrackBar TbOffspringNumber;
        private Label LbOffspringNumberCurrent;
        private Label LbOffspringNumberMax;
        private Label LbOffspringNumberMin;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem TsmiMain;
        private ToolStripMenuItem TsmiSettings;
    }
}