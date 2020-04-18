using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahmed_IE322
{
    public partial class frmPic02 : Form
    {
        System.Drawing.Graphics graphicsObj3;
        Pen myPen = new Pen(System.Drawing.Color.Blue, 1);


        public frmPic02()
        {
            InitializeComponent();
            picTry3.SizeMode = PictureBoxSizeMode.StretchImage;
            graphicsObj3 = this.picTry3.CreateGraphics();

        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {

                picTry3.Image = Image.FromFile("C: Desktop\\KAU.PNG");

            }
            catch
            {
                MessageBox.Show("Error creating image!");

            }
        }
        private void picTry3_Click(object sender, EventArgs e)
        {
            Point coordinates = picTry3.PointToClient(Cursor.Position); 

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
