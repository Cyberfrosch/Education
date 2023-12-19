using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DICOM
{
    public partial class FormViewer : Form
    {
        private readonly DicomInfo _dicomInfo;

        public FormViewer(DicomInfo dicomInfo)
        {
            InitializeComponent();

            _dicomInfo = dicomInfo;
            bsDicomFile.DataSource = _dicomInfo;
        }
    }
}
