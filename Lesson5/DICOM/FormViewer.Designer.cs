namespace DICOM
{
    partial class FormViewer
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            lengthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dicomElementGroupIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dicomElementElementIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dicomElementVrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dicomElementDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsDicomFile = new BindingSource(components);
            DataStr = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDicomFile).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { lengthDataGridViewTextBoxColumn, dicomElementGroupIdDataGridViewTextBoxColumn, dicomElementElementIdDataGridViewTextBoxColumn, dicomElementVrDataGridViewTextBoxColumn, dicomElementDescriptionDataGridViewTextBoxColumn, DataStr });
            dataGridView1.DataSource = bsDicomFile;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1032, 473);
            dataGridView1.TabIndex = 0;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            lengthDataGridViewTextBoxColumn.MinimumWidth = 8;
            lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            // 
            // dicomElementGroupIdDataGridViewTextBoxColumn
            // 
            dicomElementGroupIdDataGridViewTextBoxColumn.DataPropertyName = "DicomElementGroupId";
            dicomElementGroupIdDataGridViewTextBoxColumn.HeaderText = "DicomElementGroupId";
            dicomElementGroupIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            dicomElementGroupIdDataGridViewTextBoxColumn.Name = "dicomElementGroupIdDataGridViewTextBoxColumn";
            dicomElementGroupIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dicomElementElementIdDataGridViewTextBoxColumn
            // 
            dicomElementElementIdDataGridViewTextBoxColumn.DataPropertyName = "DicomElementElementId";
            dicomElementElementIdDataGridViewTextBoxColumn.HeaderText = "DicomElementElementId";
            dicomElementElementIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            dicomElementElementIdDataGridViewTextBoxColumn.Name = "dicomElementElementIdDataGridViewTextBoxColumn";
            dicomElementElementIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dicomElementVrDataGridViewTextBoxColumn
            // 
            dicomElementVrDataGridViewTextBoxColumn.DataPropertyName = "DicomElementVr";
            dicomElementVrDataGridViewTextBoxColumn.HeaderText = "DicomElementVr";
            dicomElementVrDataGridViewTextBoxColumn.MinimumWidth = 8;
            dicomElementVrDataGridViewTextBoxColumn.Name = "dicomElementVrDataGridViewTextBoxColumn";
            dicomElementVrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dicomElementDescriptionDataGridViewTextBoxColumn
            // 
            dicomElementDescriptionDataGridViewTextBoxColumn.DataPropertyName = "DicomElementDescription";
            dicomElementDescriptionDataGridViewTextBoxColumn.HeaderText = "DicomElementDescription";
            dicomElementDescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            dicomElementDescriptionDataGridViewTextBoxColumn.Name = "dicomElementDescriptionDataGridViewTextBoxColumn";
            dicomElementDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsDicomFile
            // 
            bsDicomFile.DataSource = typeof(DicomInfo);
            // 
            // DataStr
            // 
            DataStr.DataPropertyName = "DataStr";
            DataStr.HeaderText = "DataStr";
            DataStr.MinimumWidth = 8;
            DataStr.Name = "DataStr";
            DataStr.ReadOnly = true;
            // 
            // FormViewer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 473);
            Controls.Add(dataGridView1);
            MinimumSize = new Size(640, 480);
            Name = "FormViewer";
            Text = "FormViewer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDicomFile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bsDicomFile;
        private DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dicomElementGroupIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dicomElementElementIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dicomElementVrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dicomElementDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DataStr;
    }
}