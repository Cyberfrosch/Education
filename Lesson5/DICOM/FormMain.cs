using System.Drawing;
using Extensions;

namespace DICOM
{
    public partial class FormMain : Form
    {
        public DicomXmlFile DicomXmlFile { get; set; }

        public FormMain()
        {
            InitializeComponent();

            string filePath = PathExtension.GetParentDirectory(Environment.CurrentDirectory) + "\\dicom-elements.xml";
            DicomXmlFile = new DicomXmlFile(filePath);
        }

#if !DEBUG
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You sure?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
#endif

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog_dicomXml.ShowDialog() != DialogResult.OK) return;

            try
            {
                DicomInfo dicom = new(openFileDialog_dicomXml.FileName, DicomXmlFile);

                FormViewer dicomFileForm = new(dicom);
                dicomFileForm.MdiParent = this;
                dicomFileForm.Show();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void XmlViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormXmlView xmlView = new(DicomXmlFile);
            xmlView.MdiParent = this;
            xmlView.Show();
        }
    }
}
