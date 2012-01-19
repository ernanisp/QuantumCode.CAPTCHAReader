using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuantumCode.CAPTCHAReader.Common;

namespace QuantumCode.CAPTCHAReader.Sample
{
    public partial class frmThresholdingAlgorithm : Form
    {
        public frmThresholdingAlgorithm()
        {
            InitializeComponent();
        }

        private void btnNormalGray_Click(object sender, EventArgs e)
        {
            pbDEST.Image = (pbSRC.Image as Bitmap).ConvertGray();
        }

        private void btnReselectImg_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                pbSRC.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void btnThreshodingGray_Click(object sender, EventArgs e)
        {
            Bitmap srcBMP = (pbSRC.Image as Bitmap);
            pbDEST.Image = srcBMP.ConvertGray().ScanImage().ComputerThreshoding(srcBMP.Width, srcBMP.Height).WriteBitmap(srcBMP.Width, srcBMP.Height);
            //pbDEST.Image = srcBMP.ConvertGray().ScanImage().WriteBitmap(srcBMP.Width, srcBMP.Height);
        }
    }
}
