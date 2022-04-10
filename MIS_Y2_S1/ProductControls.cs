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
    public partial class ProductControls : UserControl
    {
        public ProductControls()
        {
            InitializeComponent();
        }
        public int QTY { get; set; }    
        private int findRowIndex(int rowID)
        {
            for(int i = 0; i < Rows.Count; i++)
            {
                int orderId = int.Parse(Rows[i].Cells[0].Value.ToString());
                if(orderId == rowID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            QTY++;
            btnOrderAdd.Text = $"Orders: ({QTY})";
            btnDeleteOrder.Visible = true;
            int rowIndex = findRowIndex(ID);
            if(rowIndex >= 0)
            {
                Rows[rowIndex].Cells[3].Value = QTY;
                double amt = double.Parse(PRODUCTPRICE.Replace("$","")) * QTY;  
                Rows[rowIndex].Cells[4].Value = amt.ToString("c2");
            }
            else
            {
                Rows.Add(ID, PRODUCTNAME, PRODUCTPRICE, QTY, PRODUCTPRICE);
            }

        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            QTY--;
            int rowIndex = findRowIndex(ID);
            if(QTY == 0)
            {
                Rows.RemoveAt(rowIndex);
                btnDeleteOrder.Visible=false;
                btnOrderAdd.Text = "Add";
            } 
            else
            {
                btnOrderAdd.Text = $"Orders: ({QTY})";
                Rows[rowIndex].Cells[3].Value =QTY;
                double amt = double.Parse(PRODUCTPRICE.Replace("$", "")) * QTY;
                Rows[rowIndex].Cells[4].Value = amt.ToString("c2");

            }
        }
    }
}
