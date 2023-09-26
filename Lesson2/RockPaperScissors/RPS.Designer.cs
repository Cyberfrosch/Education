namespace RockPaperScissors
{
    partial class RPS
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPS));
            BtRock = new Button();
            BtPaper = new Button();
            BtScissors = new Button();
            BtPlay = new Button();
            BtReset = new Button();
            LbFigure = new Label();
            PnFigureControl = new Panel();
            ImLsFigure = new ImageList(components);
            PnGameCounter = new Panel();
            LbGameNumber = new Label();
            LbCompScore = new Label();
            LbUserScore = new Label();
            PnGameMenu = new Panel();
            PnGameField = new Panel();
            SpConGameField = new SplitContainer();
            LbUserFigure = new Label();
            PbUserFigure = new PictureBox();
            LbUser = new Label();
            LbCompFigure = new Label();
            PbCompFigure = new PictureBox();
            LbComp = new Label();
            PnFigureControl.SuspendLayout();
            PnGameCounter.SuspendLayout();
            PnGameMenu.SuspendLayout();
            PnGameField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpConGameField).BeginInit();
            SpConGameField.Panel1.SuspendLayout();
            SpConGameField.Panel2.SuspendLayout();
            SpConGameField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbUserFigure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbCompFigure).BeginInit();
            SuspendLayout();
            // 
            // BtRock
            // 
            BtRock.ImageAlign = ContentAlignment.MiddleLeft;
            BtRock.Location = new Point(3, 39);
            BtRock.Name = "BtRock";
            BtRock.Size = new Size(112, 45);
            BtRock.TabIndex = 0;
            BtRock.Tag = "0";
            BtRock.Text = "Rock";
            BtRock.TextAlign = ContentAlignment.MiddleRight;
            BtRock.UseVisualStyleBackColor = true;
            BtRock.Click += BtRock_Click;
            // 
            // BtPaper
            // 
            BtPaper.ImageAlign = ContentAlignment.MiddleLeft;
            BtPaper.Location = new Point(121, 39);
            BtPaper.Name = "BtPaper";
            BtPaper.Size = new Size(112, 45);
            BtPaper.TabIndex = 1;
            BtPaper.Tag = "1";
            BtPaper.Text = "Paper";
            BtPaper.TextAlign = ContentAlignment.MiddleRight;
            BtPaper.UseVisualStyleBackColor = true;
            BtPaper.Click += BtPaper_Click;
            // 
            // BtScissors
            // 
            BtScissors.ImageAlign = ContentAlignment.MiddleLeft;
            BtScissors.Location = new Point(239, 39);
            BtScissors.Name = "BtScissors";
            BtScissors.Size = new Size(112, 45);
            BtScissors.TabIndex = 2;
            BtScissors.Tag = "2";
            BtScissors.Text = "Scissors";
            BtScissors.TextAlign = ContentAlignment.MiddleRight;
            BtScissors.UseVisualStyleBackColor = true;
            BtScissors.Click += BtScissors_Click;
            // 
            // BtPlay
            // 
            BtPlay.Enabled = false;
            BtPlay.Location = new Point(3, 214);
            BtPlay.Name = "BtPlay";
            BtPlay.Size = new Size(468, 74);
            BtPlay.TabIndex = 3;
            BtPlay.Text = "Play";
            BtPlay.UseVisualStyleBackColor = true;
            BtPlay.Click += BtPlay_Click;
            // 
            // BtReset
            // 
            BtReset.Location = new Point(377, 0);
            BtReset.Name = "BtReset";
            BtReset.Size = new Size(94, 215);
            BtReset.TabIndex = 4;
            BtReset.Text = "Reset";
            BtReset.UseVisualStyleBackColor = true;
            BtReset.Click += BtReset_Click;
            // 
            // LbFigure
            // 
            LbFigure.AutoSize = true;
            LbFigure.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LbFigure.Location = new Point(3, 4);
            LbFigure.Name = "LbFigure";
            LbFigure.Size = new Size(86, 32);
            LbFigure.TabIndex = 6;
            LbFigure.Text = "Figure";
            // 
            // PnFigureControl
            // 
            PnFigureControl.Controls.Add(LbFigure);
            PnFigureControl.Controls.Add(BtRock);
            PnFigureControl.Controls.Add(BtPaper);
            PnFigureControl.Controls.Add(BtScissors);
            PnFigureControl.Location = new Point(3, 3);
            PnFigureControl.Name = "PnFigureControl";
            PnFigureControl.Size = new Size(361, 93);
            PnFigureControl.TabIndex = 7;
            // 
            // ImLsFigure
            // 
            ImLsFigure.ColorDepth = ColorDepth.Depth8Bit;
            ImLsFigure.ImageStream = (ImageListStreamer)resources.GetObject("ImLsFigure.ImageStream");
            ImLsFigure.TransparentColor = Color.Transparent;
            ImLsFigure.Images.SetKeyName(0, "stone-sphere_38060.png");
            ImLsFigure.Images.SetKeyName(1, "receipt-paper_icon-icons.com_56152.png");
            ImLsFigure.Images.SetKeyName(2, "fullcut_cut_scissors_4720.png");
            // 
            // PnGameCounter
            // 
            PnGameCounter.Controls.Add(LbGameNumber);
            PnGameCounter.Controls.Add(LbCompScore);
            PnGameCounter.Controls.Add(LbUserScore);
            PnGameCounter.Location = new Point(6, 101);
            PnGameCounter.Name = "PnGameCounter";
            PnGameCounter.Size = new Size(358, 107);
            PnGameCounter.TabIndex = 8;
            // 
            // LbGameNumber
            // 
            LbGameNumber.AutoSize = true;
            LbGameNumber.Location = new Point(53, 68);
            LbGameNumber.Name = "LbGameNumber";
            LbGameNumber.Size = new Size(77, 25);
            LbGameNumber.TabIndex = 9;
            LbGameNumber.Text = "Game: 0";
            // 
            // LbCompScore
            // 
            LbCompScore.AutoSize = true;
            LbCompScore.Location = new Point(3, 25);
            LbCompScore.Name = "LbCompScore";
            LbCompScore.Size = new Size(127, 25);
            LbCompScore.TabIndex = 1;
            LbCompScore.Text = "Comp score: 0";
            // 
            // LbUserScore
            // 
            LbUserScore.AutoSize = true;
            LbUserScore.Location = new Point(17, 0);
            LbUserScore.Name = "LbUserScore";
            LbUserScore.Size = new Size(113, 25);
            LbUserScore.TabIndex = 0;
            LbUserScore.Text = "Your score: 0";
            // 
            // PnGameMenu
            // 
            PnGameMenu.Controls.Add(BtPlay);
            PnGameMenu.Controls.Add(PnFigureControl);
            PnGameMenu.Controls.Add(PnGameCounter);
            PnGameMenu.Controls.Add(BtReset);
            PnGameMenu.Location = new Point(12, 12);
            PnGameMenu.Name = "PnGameMenu";
            PnGameMenu.Size = new Size(474, 292);
            PnGameMenu.TabIndex = 10;
            // 
            // PnGameField
            // 
            PnGameField.Controls.Add(SpConGameField);
            PnGameField.Enabled = false;
            PnGameField.Location = new Point(12, 310);
            PnGameField.Name = "PnGameField";
            PnGameField.Size = new Size(474, 316);
            PnGameField.TabIndex = 11;
            // 
            // SpConGameField
            // 
            SpConGameField.BorderStyle = BorderStyle.FixedSingle;
            SpConGameField.Dock = DockStyle.Fill;
            SpConGameField.Location = new Point(0, 0);
            SpConGameField.Name = "SpConGameField";
            // 
            // SpConGameField.Panel1
            // 
            SpConGameField.Panel1.Controls.Add(LbUserFigure);
            SpConGameField.Panel1.Controls.Add(PbUserFigure);
            SpConGameField.Panel1.Controls.Add(LbUser);
            // 
            // SpConGameField.Panel2
            // 
            SpConGameField.Panel2.Controls.Add(LbCompFigure);
            SpConGameField.Panel2.Controls.Add(PbCompFigure);
            SpConGameField.Panel2.Controls.Add(LbComp);
            SpConGameField.Size = new Size(474, 316);
            SpConGameField.SplitterDistance = 234;
            SpConGameField.TabIndex = 0;
            // 
            // LbUserFigure
            // 
            LbUserFigure.AutoSize = true;
            LbUserFigure.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LbUserFigure.Location = new Point(65, 270);
            LbUserFigure.Name = "LbUserFigure";
            LbUserFigure.Size = new Size(0, 32);
            LbUserFigure.TabIndex = 10;
            // 
            // PbUserFigure
            // 
            PbUserFigure.BorderStyle = BorderStyle.FixedSingle;
            PbUserFigure.Location = new Point(-1, 35);
            PbUserFigure.Name = "PbUserFigure";
            PbUserFigure.Size = new Size(236, 232);
            PbUserFigure.SizeMode = PictureBoxSizeMode.StretchImage;
            PbUserFigure.TabIndex = 10;
            PbUserFigure.TabStop = false;
            // 
            // LbUser
            // 
            LbUser.AutoSize = true;
            LbUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LbUser.Location = new Point(85, 0);
            LbUser.Name = "LbUser";
            LbUser.Size = new Size(64, 32);
            LbUser.TabIndex = 7;
            LbUser.Text = "You:";
            // 
            // LbCompFigure
            // 
            LbCompFigure.AutoSize = true;
            LbCompFigure.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LbCompFigure.Location = new Point(65, 270);
            LbCompFigure.Name = "LbCompFigure";
            LbCompFigure.Size = new Size(0, 32);
            LbCompFigure.TabIndex = 11;
            // 
            // PbCompFigure
            // 
            PbCompFigure.BorderStyle = BorderStyle.FixedSingle;
            PbCompFigure.Location = new Point(-1, 35);
            PbCompFigure.Name = "PbCompFigure";
            PbCompFigure.Size = new Size(236, 232);
            PbCompFigure.SizeMode = PictureBoxSizeMode.StretchImage;
            PbCompFigure.TabIndex = 9;
            PbCompFigure.TabStop = false;
            // 
            // LbComp
            // 
            LbComp.AutoSize = true;
            LbComp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LbComp.Location = new Point(49, 0);
            LbComp.Name = "LbComp";
            LbComp.Size = new Size(136, 32);
            LbComp.TabIndex = 8;
            LbComp.Text = "Computer:";
            // 
            // RPS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 633);
            Controls.Add(PnGameField);
            Controls.Add(PnGameMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RPS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rock Paper Scissors";
            PnFigureControl.ResumeLayout(false);
            PnFigureControl.PerformLayout();
            PnGameCounter.ResumeLayout(false);
            PnGameCounter.PerformLayout();
            PnGameMenu.ResumeLayout(false);
            PnGameField.ResumeLayout(false);
            SpConGameField.Panel1.ResumeLayout(false);
            SpConGameField.Panel1.PerformLayout();
            SpConGameField.Panel2.ResumeLayout(false);
            SpConGameField.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SpConGameField).EndInit();
            SpConGameField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbUserFigure).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbCompFigure).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtRock;
        private Button BtPaper;
        private Button BtScissors;
        private Button BtPlay;
        private Button BtReset;
        private Label LbFigure;
        private Panel PnFigureControl;
        private ImageList ImLsFigure;
        private Panel PnGameCounter;
        private Label LbCompScore;
        private Label LbUserScore;
        private Label LbGameNumber;
        private Panel PnGameMenu;
        private Panel PnGameField;
        private SplitContainer SpConGameField;
        private Label LbUser;
        private Label LbComp;
        private PictureBox PbCompFigure;
        private PictureBox PbUserFigure;
        private Label LbUserFigure;
        private Label LbCompFigure;
    }
}