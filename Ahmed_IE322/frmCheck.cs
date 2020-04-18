using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahmed_IE322
{
    public partial class frmCheck : Form
    {
        public frmCheck()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            {
                string msg = "";

                if (chkCoffee.Checked == true)
                {
                    msg = chkCoffee.Text;
                }

                if (chkDonut.Checked == true)
                {
                    msg = msg + " " + chkDonut.Text;
                }

                if (chkBrownie.Checked == true)
                {
                    msg = msg + " " + chkBrownie.Text;
                }

                if (msg.Length > 0)
                {
                    MessageBox.Show(msg + " selected ");
                }
                else 
                {
                    MessageBox.Show("Nothing selected");
                }

            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkDonut_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBrownie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
