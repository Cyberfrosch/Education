namespace DICOM
{
    partial class FormXmlView
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
            dgwDicomElements = new DataGridView();
            dicomDatasetsBindingSource = new BindingSource(components);
            groupIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            elementIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgwDicomElements).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dicomDatasetsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgwDicomElements
            // 
            dgwDicomElements.AutoGenerateColumns = false;
            dgwDicomElements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwDicomElements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDicomElements.Columns.AddRange(new DataGridViewColumn[] { groupIdDataGridViewTextBoxColumn, elementIdDataGridViewTextBoxColumn, vrDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dgwDicomElements.DataSource = dicomDatasetsBindingSource;
            dgwDicomElements.Dock = DockStyle.Fill;
            dgwDicomElements.Location = new Point(0, 0);
            dgwDicomElements.Name = "dgwDicomElements";
            dgwDicomElements.RowHeadersWidth = 62;
            dgwDicomElements.Size = new Size(800, 450);
            dgwDicomElements.TabIndex = 0;
            // 
            // dicomDatasetsBindingSource
            // 
            dicomDatasetsBindingSource.DataSource = typeof(DicomXmlFile);
            // 
            // groupIdDataGridViewTextBoxColumn
            // 
            groupIdDataGridViewTextBoxColumn.DataPropertyName = "GroupId";
            groupIdDataGridViewTextBoxColumn.FillWeight = 83.19488F;
            groupIdDataGridViewTextBoxColumn.HeaderText = "GroupId";
            groupIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            groupIdDataGridViewTextBoxColumn.Name = "groupIdDataGridViewTextBoxColumn";
            // 
            // elementIdDataGridViewTextBoxColumn
            // 
            elementIdDataGridViewTextBoxColumn.DataPropertyName = "ElementId";
            elementIdDataGridViewTextBoxColumn.FillWeight = 74.57229F;
            elementIdDataGridViewTextBoxColumn.HeaderText = "ElementId";
            elementIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            elementIdDataGridViewTextBoxColumn.Name = "elementIdDataGridViewTextBoxColumn";
            // 
            // vrDataGridViewTextBoxColumn
            // 
            vrDataGridViewTextBoxColumn.DataPropertyName = "Vr";
            vrDataGridViewTextBoxColumn.FillWeight = 36.3636436F;
            vrDataGridViewTextBoxColumn.HeaderText = "Vr";
            vrDataGridViewTextBoxColumn.MinimumWidth = 8;
            vrDataGridViewTextBoxColumn.Name = "vrDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.FillWeight = 205.869217F;
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // FormXmlView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgwDicomElements);
            Name = "FormXmlView";
            Text = "XML View";
            ((System.ComponentModel.ISupportInitialize)dgwDicomElements).EndInit();
            ((System.ComponentModel.ISupportInitialize)dicomDatasetsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn elementNumberDataGridViewTextBoxColumn;
        private DataGridView dgwDicomElements;
        private BindingSource dicomDatasetsBindingSource;
        private DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn elementIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}