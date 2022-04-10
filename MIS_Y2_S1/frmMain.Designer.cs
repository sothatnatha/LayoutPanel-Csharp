namespace MIS_Y2_S1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsingLstBox = new System.Windows.Forms.Button();
            this.btnUsingDGV = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Platforms";
            // 
            // btnUsingLstBox
            // 
            this.btnUsingLstBox.ForeColor = System.Drawing.Color.Black;
            this.btnUsingLstBox.Location = new System.Drawing.Point(213, 227);
            this.btnUsingLstBox.Name = "btnUsingLstBox";
            this.btnUsingLstBox.Size = new System.Drawing.Size(368, 45);
            this.btnUsingLstBox.TabIndex = 1;
            this.btnUsingLstBox.Text = "Using Table Layout Panel";
            this.btnUsingLstBox.UseVisualStyleBackColor = true;
            this.btnUsingLstBox.Click += new System.EventHandler(this.btnUsingLstBox_Click);
            // 
            // btnUsingDGV
            // 
            this.btnUsingDGV.ForeColor = System.Drawing.Color.Black;
            this.btnUsingDGV.Location = new System.Drawing.Point(212, 176);
            this.btnUsingDGV.Name = "btnUsingDGV";
            this.btnUsingDGV.Size = new System.Drawing.Size(369, 45);
            this.btnUsingDGV.TabIndex = 3;
            this.btnUsingDGV.Text = "Using DataGridView";
            this.btnUsingDGV.UseVisualStyleBackColor = true;
            this.btnUsingDGV.Click += new System.EventHandler(this.btnUsingDGV_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(213, 292);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(369, 42);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 536);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUsingDGV);
            this.Controls.Add(this.btnUsingLstBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Main Form Choosing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsingLstBox;
        private System.Windows.Forms.Button btnUsingDGV;
        private System.Windows.Forms.Button btnExit;
    }
}