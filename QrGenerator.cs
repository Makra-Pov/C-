using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrCodeGenerator
{
    public partial class frmQrCodeGenerator : Form
    {
        public frmQrCodeGenerator()
        {
            InitializeComponent();
        }

        private void txtQrText_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG=new QRCoder.QRCodeGenerator();
            var myData = QG.CreateQrCode(txtQrText.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code= new QRCoder.QRCode(myData);
            pictureBox1.Image = code.GetGraphic(50);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQrText.Clear();
        }
    }
}
