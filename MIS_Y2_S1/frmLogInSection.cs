using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS_Y2_S1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        public void btnLogIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.UserName = txtUsername.Text;
            login.PassWord = txtUserPassword.Text;

            if (login.UserName == "thatna")
            {
                if (login.PassWord == "123")
                {
                    this.Hide();
                    frmMain obj = new frmMain();
                    obj.ShowDialog();
                }
                else
                {
                    DialogResult dia_res = new DialogResult();
                           dia_res = MessageBox.Show("Incorrect Password!", "Warning",
                              MessageBoxButtons.OK,
                             MessageBoxIcon.Warning);
                }

            }
            else
            {
                DialogResult dia_res = new DialogResult();
                    dia_res = MessageBox.Show("Incorrect Username!", "Warning",
                        MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

   
    }
}
