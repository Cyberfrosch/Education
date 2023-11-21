namespace SerpinskyTriangle
{
    partial class SerpinskyTriangle
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
            PnSettings = new Panel();
            BtClear = new Button();
            BtSave = new Button();
            BtSaveAs = new Button();
            PbColor = new PictureBox();
            LbImageDepth = new Label();
            NmUDDepth = new NumericUpDown();
            BtColor = new Button();
            BtDraw = new Button();
            PbImage = new PictureBox();
            colorDialogPbImage = new ColorDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            PnSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NmUDDepth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbImage).BeginInit();
            SuspendLayout();
            // 
            // PnSettings
            // 
            PnSettings.Controls.Add(BtClear);
            PnSettings.Controls.Add(BtSave);
            PnSettings.Controls.Add(BtSaveAs);
            PnSettings.Controls.Add(PbColor);
            PnSettings.Controls.Add(LbImageDepth);
            PnSettings.Controls.Add(NmUDDepth);
            PnSettings.Controls.Add(BtColor);
            PnSettings.Controls.Add(BtDraw);
            PnSettings.Dock = DockStyle.Left;
            PnSettings.Location = new Point(0, 0);
            PnSettings.Name = "PnSettings";
            PnSettings.Size = new Size(300, 692);
            PnSettings.TabIndex = 0;
            // 
            // BtClear
            // 
            BtClear.Enabled = false;
            BtClear.Location = new Point(12, 287);
            BtClear.Name = "BtClear";
            BtClear.Size = new Size(121, 41);
            BtClear.TabIndex = 8;
            BtClear.Text = "Clear image";
            BtClear.UseVisualStyleBackColor = true;
            BtClear.Click += BtClear_Click;
            // 
            // BtSave
            // 
            BtSave.Enabled = false;
            BtSave.Location = new Point(12, 148);
            BtSave.Name = "BtSave";
            BtSave.Size = new Size(95, 41);
            BtSave.TabIndex = 7;
            BtSave.Text = "Save";
            BtSave.TextAlign = ContentAlignment.MiddleLeft;
            BtSave.UseVisualStyleBackColor = true;
            BtSave.Click += BtSave_Click;
            // 
            // BtSaveAs
            // 
            BtSaveAs.Enabled = false;
            BtSaveAs.Location = new Point(12, 195);
            BtSaveAs.Name = "BtSaveAs";
            BtSaveAs.Size = new Size(95, 41);
            BtSaveAs.TabIndex = 6;
            BtSaveAs.Text = "Save as...";
            BtSaveAs.TextAlign = ContentAlignment.MiddleLeft;
            BtSaveAs.UseVisualStyleBackColor = true;
            BtSaveAs.Click += BtSaveAs_Click;
            // 
            // PbColor
            // 
            PbColor.BorderStyle = BorderStyle.FixedSingle;
            PbColor.Location = new Point(188, 12);
            PbColor.Name = "PbColor";
            PbColor.Size = new Size(46, 34);
            PbColor.TabIndex = 5;
            PbColor.TabStop = false;
            // 
            // LbImageDepth
            // 
            LbImageDepth.AutoSize = true;
            LbImageDepth.Location = new Point(12, 60);
            LbImageDepth.Name = "LbImageDepth";
            LbImageDepth.Size = new Size(65, 25);
            LbImageDepth.TabIndex = 4;
            LbImageDepth.Text = "Depth:";
            // 
            // NmUDDepth
            // 
            NmUDDepth.Location = new Point(83, 58);
            NmUDDepth.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            NmUDDepth.Name = "NmUDDepth";
            NmUDDepth.Size = new Size(69, 31);
            NmUDDepth.TabIndex = 3;
            NmUDDepth.ValueChanged += NmUDDepth_ValueChanged;
            // 
            // BtColor
            // 
            BtColor.Location = new Point(12, 12);
            BtColor.Name = "BtColor";
            BtColor.Size = new Size(170, 34);
            BtColor.TabIndex = 1;
            BtColor.Text = "Choice color";
            BtColor.UseVisualStyleBackColor = true;
            BtColor.Click += BtColor_Click;
            // 
            // BtDraw
            // 
            BtDraw.Dock = DockStyle.Bottom;
            BtDraw.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            BtDraw.Location = new Point(0, 627);
            BtDraw.Name = "BtDraw";
            BtDraw.Size = new Size(300, 65);
            BtDraw.TabIndex = 0;
            BtDraw.Text = "Draw";
            BtDraw.UseVisualStyleBackColor = true;
            BtDraw.Click += BtDraw_Click;
            // 
            // PbImage
            // 
            PbImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PbImage.BackColor = SystemColors.Control;
            PbImage.Location = new Point(306, 12);
            PbImage.Name = "PbImage";
            PbImage.Size = new Size(946, 668);
            PbImage.TabIndex = 1;
            PbImage.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer_Tick;
            // 
            // SerpinskyTriangle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 692);
            Controls.Add(PbImage);
            Controls.Add(PnSettings);
            MinimumSize = new Size(1286, 748);
            Name = "SerpinskyTriangle";
            Text = "Serpinsky Triangle";
            PnSettings.ResumeLayout(false);
            PnSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)NmUDDepth).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnSettings;
        private Button BtDraw;
        private PictureBox PbImage;
        private Button BtColor;
        private ColorDialog colorDialogPbImage;
        private Label LbImageDepth;
        private NumericUpDown NmUDDepth;
        private PictureBox PbColor;
        private Button BtSaveAs;
        private Button BtSave;
        private Button BtClear;
        private System.Windows.Forms.Timer timer1;
    }
}