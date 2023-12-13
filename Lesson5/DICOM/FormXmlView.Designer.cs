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
            dataGridView1 = new DataGridView();
            groupIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            elementIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dicomDatasetsBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dicomDatasetsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { groupIdDataGridViewTextBoxColumn, elementIdDataGridViewTextBoxColumn, vrDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = dicomDatasetsBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(800, 450);
            dataGridView1.TabIndex = 0;
            // 
            // groupIdDataGridViewTextBoxColumn
            // 
            groupIdDataGridViewTextBoxColumn.DataPropertyName = "GroupId";
            groupIdDataGridViewTextBoxColumn.HeaderText = "GroupId";
            groupIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            groupIdDataGridViewTextBoxColumn.Name = "groupIdDataGridViewTextBoxColumn";
            // 
            // elementIdDataGridViewTextBoxColumn
            // 
            elementIdDataGridViewTextBoxColumn.DataPropertyName = "ElementId";
            elementIdDataGridViewTextBoxColumn.HeaderText = "ElementId";
            elementIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            elementIdDataGridViewTextBoxColumn.Name = "elementIdDataGridViewTextBoxColumn";
            // 
            // vrDataGridViewTextBoxColumn
            // 
            vrDataGridViewTextBoxColumn.DataPropertyName = "Vr";
            vrDataGridViewTextBoxColumn.HeaderText = "Vr";
            vrDataGridViewTextBoxColumn.MinimumWidth = 8;
            vrDataGridViewTextBoxColumn.Name = "vrDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // dicomDatasetsBindingSource
            // 
            dicomDatasetsBindingSource.DataSource = typeof(DicomXmlFile);
            // 
            // FormXmlView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "FormXmlView";
            Text = "XML View";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dicomDatasetsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn elementNumberDataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
        private BindingSource dicomDatasetsBindingSource;
        private DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn elementIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}