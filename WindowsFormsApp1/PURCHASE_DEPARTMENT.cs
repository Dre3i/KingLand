using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PURCHASE_DEPARTMENT : Form
    {
        public PURCHASE_DEPARTMENT()
        {
            InitializeComponent();
        }
        public void loadpanel(object Form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
                Form f = Form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(f);
                this.panel1.Tag = f;
                f.Show();
            }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            loadpanel(new Supplier_Price());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            loadpanel(new Purchase_Order());
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            loadpanel(new Purchase_Order_Status()); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadpanel(new Purchase_Order_Status());
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor= Color.Silver;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;    
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Silver;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Silver;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
