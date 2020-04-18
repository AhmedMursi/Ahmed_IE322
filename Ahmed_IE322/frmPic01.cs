using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;            
using System.Reflection;    



namespace Ahmed_IE322
{
    public partial class frmPic01 : Form
    {
        Assembly _assembly; 
        Stream _imageStream;


        System.Drawing.Graphics graphicsObj3;
        Pen myPen = new Pen(System.Drawing.Color.Blue, 1);

        public frmPic01()
        {
            InitializeComponent();

            picTry.SizeMode = PictureBoxSizeMode.StretchImage;
            picTry2.SizeMode = PictureBoxSizeMode.StretchImage;

            graphicsObj3 = this.picTry.CreateGraphics();
        }
        private void BtnImageFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                picTry.Image = Image.FromFile("C:Desktop.KAU.png");
            }
            catch
            {
                MessageBox.Show("Image file not found!");
            }


        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnImageFromRes_Click(object sender, EventArgs e)
        {
            try
            {
                picTry2.Image = Image.FromStream(_imageStream);
            }
            catch
            {
                MessageBox.Show("Error creating image from resource!");
            }
        }

        private void picTry_Click(object sender, EventArgs e)
        {

            Point coordinates = picTry.PointToClient(Cursor.Position);

            graphicsObj3.DrawLine(myPen, coordinates.X - 1, coordinates.Y - 1, coordinates.X, coordinates.Y);

        }
        private void frmPic01_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("IE322_App_KAU.res.A.jpg");
        }

        private void picTry2_Click(object sender, EventArgs e)
        {

        }

        private void picTry2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
