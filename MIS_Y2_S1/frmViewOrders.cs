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
    public partial class frmViewOrders : Form
    {
        public frmViewOrders()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public DataGridViewRowCollection GetRow()
        {
            return dgv_ViewOrders.Rows;
        }

        private void frmViewOrders_Load(object sender, EventArgs e)
        {
            double totalAmount = 0;
            for(int i = 0; i < dgv_ViewOrders.Rows.Count; i++)
            {

                string amt = dgv_ViewOrders.Rows[i].Cells[4].Value.ToString();
                amt = amt.Replace("$", "");
                totalAmount += double.Parse(amt);
            }
            txtTotalAmount.Text = totalAmount.ToString("c2");
        }
    }
}
