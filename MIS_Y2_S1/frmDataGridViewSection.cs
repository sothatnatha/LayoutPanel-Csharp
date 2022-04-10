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
    public partial class frmdgvStudent : Form
    {
        public frmdgvStudent()
        {
            InitializeComponent();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string studentID = txtStudentID.Text;
            string fullName = txtFullName.Text;
            string gender = cboGender.Text;
            string major = cboMajor.Text;
            string dob = txtDOB.Text;
            string pob = cboProvince.Text;

            Image img = picBox.Image;

            dgvStudent.Rows.Add(studentID, fullName, gender, major, dob, pob, img);
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex != -1)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Image img = Image.FromFile(openFileDialog.FileName);
                    int i = e.RowIndex;
                    dgvStudent.Rows[i].Cells[6].Value = img;
                }
            }
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Image img = Image.FromFile(fileDialog.FileName);
                picBox.Image = img;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //if (dgvStudent.Rows.Count == 0) return;
            //if(dgvStudent.Rows.Count != 0)
            //{
            //    DataGridViewRow dataGridView = dgvStudent.CurrentRow;
            //    dgvStudent.Rows.Remove(dataGridView);
            //}

            int i = dgvStudent.CurrentRow.Index;
            dgvStudent.Rows.RemoveAt(i);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvStudent.CurrentRow;
            dgvRow.Cells[0].Value = txtStudentID.Text;
            dgvRow.Cells[1].Value = txtFullName.Text;
            dgvRow.Cells[2].Value = cboGender.Text;
            dgvRow.Cells[3].Value = cboMajor.Text;
            dgvRow.Cells[4].Value = txtDOB.Text;
            dgvRow.Cells[5].Value = cboProvince.Text;
        }

        private void dgvStudent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dgvRow = dgvStudent.CurrentRow;
            txtStudentID.Text = dgvRow.Cells[0].Value.ToString();
            txtFullName.Text = dgvRow.Cells[1].Value.ToString();
            cboGender.Text = dgvRow.Cells[2].Value.ToString();
            cboMajor.Text = dgvRow.Cells[3].Value.ToString();
            txtDOB.Text = dgvRow.Cells[4].Value.ToString();
            cboProvince.Text = dgvRow.Cells[5].Value.ToString();

        }

     
    }
}
