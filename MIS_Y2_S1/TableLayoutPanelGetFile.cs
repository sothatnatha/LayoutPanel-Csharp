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

namespace MIS_Y2_S1
{
    public partial class frmTableLayoutPanelGetFile : Form
    {
        public frmTableLayoutPanelGetFile()
        {
            InitializeComponent();
            string[] getFileName = Directory.GetFiles("C:\\Users\\TanaUK\\Desktop\\foods");
            int col = 0, row = 0;
            int id = 1;
            Random random = new Random();
            foreach (string file in getFileName)
            {
                ProductControls productControls = new ProductControls();
                Image img = Image.FromFile(file);

                productControls.IMG = img;
                productControls.PRODUCTNAME = Path.GetFileNameWithoutExtension(file);

                productControls.ID = id;
                id++;

                int price = random.Next(5) + 1;
                productControls.PRODUCTPRICE =  price.ToString("c2");

                tblLayoutPanel.Controls.Add(productControls, col, row);
                col++;


            }
            ProductControls.Rows = view_orders.GetRow();
        }
        frmViewOrders view_orders = new frmViewOrders();  // declareed obj ass a global
        private void viewOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            view_orders.ShowDialog();
        }
    }
}
