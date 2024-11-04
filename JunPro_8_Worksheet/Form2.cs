using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace JunPro_8_Worksheet
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        Form f1;
        public Form2(Form f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        public static string GenerateQR(string nama, string alamat, string no_handphone)
        {
            string result = "#" + nama + alamat + no_handphone;
            return result;
        }
        public static string GenerateQR(string nama, string alamat, string no_handphone, out Bitmap bitmap)
        {
            string text = GenerateQR(nama, alamat, no_handphone);
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrData);
            bitmap = qrCode.GetGraphic(7);
            return text;


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Bitmap qr;
            string nama = f1.NamaBox.Text;
            string alamat = f1.AlamatBox.Text;
            string no_hp = f1.HandphoneBox.Text;
            dataLabel.Text = GenerateQR(nama, alamat, no_hp, out qr);
            qrImg.BackgroundImage = qr; 
        }
    }
}
A