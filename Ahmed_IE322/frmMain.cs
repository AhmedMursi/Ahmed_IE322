using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Ahmed_IE322
{
	public partial class frmMain : Form
	{
		string username = "Ahmed";
		string myPassword = "0000";
		bool loggedIn = false;

		int attempt = 1;
		int MaxAttempts = 3;

		public frmMain()
		{
			InitializeComponent();
		}
		private void frmMain_Load(object sender, EventArgs e)
		{
			foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
			{
				foreach (var btn in grp.Controls.OfType<Button>())
				{
					btn.Enabled = false;
				}
			}

			toolStripStatusLabel1.Text = "Login please...";

		}


		private void btnRadio_Click(object sender, EventArgs e)
		{
			frmRadio frm = new frmRadio();
			frm.ShowDialog();
		}
		private void BtnExit_Click(object sender, EventArgs e)
		{
			Close();
		}


		private void btnCombo_Click(object sender, EventArgs e)
		{
			{
				frmCombo frm = new frmCombo();
				frm.ShowDialog();

			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
		private void groupBox3_Enter(object sender, EventArgs e)
		{
			 
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{

			if (!loggedIn)
			{

				while (attempt <= MaxAttempts)
				{
					if (TxtUser.Text != username)
					{
						
						MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
						attempt++;
						return;
					}
					else
					{  
						
						if (TxtPassword.Text != myPassword)
						{
							
							attempt++;
							MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
							return;
						}
						else
						{
							
							attempt = 1; 
							loggedIn = true;
							MessageBox.Show("Hi " + username + ", your login successful");


							foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
							{
								foreach (var btn in grp.Controls.OfType<Button>())
								{
									btn.Enabled = true;
									btn.ForeColor = Color.Black;
								}
							}

							btnLogin.Text = "Logout";
							toolStripStatusLabel1.Text = "Hi " + username + ", you are logged in.";
							
							break; 
						}

					}
				}
			}
			else
			{
				btnLogin.Text = "Login";
				toolStripStatusLabel1.Text = "You are logged out.";
				loggedIn = false;

				TxtUser.Clear();
				TxtPassword.Clear();

				foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
				{
					foreach (var btn in grp.Controls.OfType<Button>())
					{
						btn.Enabled = false;
					}
				}
			}
		}

		private void btnRandom_Click(object sender, EventArgs e)
		{
			{
				frmRandom frm = new frmRandom();
				frm.ShowDialog();

				this.DialogResult = DialogResult.OK;
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void TxtUser_Click(object sender, EventArgs e)
		{
	
		}


		private void groupBox10_Enter(object sender, EventArgs e)
		{

		}

		private void button31_Click(object sender, EventArgs e)
		{

		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			frmCheck frm = new frmCheck();
			frm.ShowDialog();

			this.DialogResult = DialogResult.OK;
		}

		private void TxtUser_Enter(object sender, EventArgs e)
		{
			this.TxtUser.BackColor = Color.FromName("yellow");
		}

		private void TxtUser_Leave(object sender, EventArgs e)
		{
			this.TxtUser.BackColor = Color.FromName("white");
		}


		private void TxtPassword_Enter(object sender, EventArgs e)
		{
			this.TxtPassword.BackColor = Color.FromName("yellow");
		}

		private void TxtPassword_Leave(object sender, EventArgs e)
		{
			this.TxtPassword.BackColor = Color.FromName("white");
		}


		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void btnRandomCombo_Click(object sender, EventArgs e)
		{
			frmRandomCombo frm = new frmRandomCombo();
			frm.ShowDialog();
		}

		private void groupBox1_Enter_1(object sender, EventArgs e)
		{

		}

		private void ForgetLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Please try to remember your passwords");
		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{

		}

		private void btnPic2_Click(object sender, EventArgs e)
		{
			frmPic02 frm = new frmPic02();
			frm.ShowDialog();

			this.DialogResult = DialogResult.OK;
		}

		private void btnPic1_Click(object sender, EventArgs e)
		{
			frmPic01 frm = new frmPic01();
			frm.ShowDialog();

			this.DialogResult = DialogResult.OK;
		}

		private void button30_Click(object sender, EventArgs e)
		{

		}

		private void groupBox6_Enter(object sender, EventArgs e)
		{

		}

		private void button33_Click(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{

		}

		private void StsMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void LnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Please try to remember your passwords");
		}

		private void grpLogin_Enter(object sender, EventArgs e)
		{

		}

		private void lblUsername_Click(object sender, EventArgs e)
		{

		}

		private void TxtUser_TextChanged(object sender, EventArgs e)
		{

		}

		private void TxtPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void lblPW_Click(object sender, EventArgs e)
		{

		}
	}
}
