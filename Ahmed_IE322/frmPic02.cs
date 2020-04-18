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
        private readonly Stream _imageStream;
        private object graphicsObj3;
        private object myPen;

        public frmPic02()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            try
            {

                picTry3.Image = Image.FromStream(_imageStream);

            }
            catch
            {
                MessageBox.Show("Error creating image!");

            }
        }

        private void picTry3_Click(object sender, EventArgs e)
        {


            Point coordinates = picTry3.PointToClient(Cursor.Position); 


            graphicsObj3.DrawLine(myPen, coordinates.X - 1, coordinates.Y - 1, coordinates.X, coordinates.Y);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
