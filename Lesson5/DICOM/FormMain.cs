using System.Drawing;
using Extensions;

namespace DICOM
{
    public partial class FormMain : Form
    {
        public DicomXmlFile dicomXmlFile;

        public FormMain()
        {
            InitializeComponent();

            string filePath = PathExtension.GetParentDirectory(Environment.CurrentDirectory) + "\\dicom-elements.xml";
            dicomXmlFile = new DicomXmlFile(filePath);
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DicomInfo dcm = new(openFileDialog1.FileName, dicomXmlFile);

                    FormViewer newForm = new FormViewer(dcm);
                    newForm.MdiParent = this;
                    newForm.Show();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void XmlViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormXmlView xmlView = new(dicomXmlFile);
            xmlView.MdiParent = this;
            xmlView.Show();
        }
    }
}
