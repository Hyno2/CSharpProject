using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace 바코드_생성기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
            pictureBox1.Image = barcode.Encode(BarcodeLib.TYPE.CODE128, textBox1.Text, Color.Red, Color.White);
        }

        private void dwn_btn_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), textBox1.Text);
            pictureBox1.Image.Save(path + " .jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void Prt_btn_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            System.Drawing.Printing.PrintDocument Doc = new System.Drawing.Printing.PrintDocument();

            Doc.PrintPage += new PrintPageEventHandler(Doc_page);

            if (print.ShowDialog() == DialogResult.OK)
                Doc.Print();

        }

        private void Doc_page(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
        }

    }
}
