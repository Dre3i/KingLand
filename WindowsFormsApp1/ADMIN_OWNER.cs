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
    public partial class ADMIN_OWNER : Form
    {
        public ADMIN_OWNER()
        {
            InitializeComponent();
        }
        public void loadpanel(object Form)
        {
            if (this.admin_panel.Controls.Count > 0)
                this.admin_panel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.admin_panel.Controls.Add(f);
            this.admin_panel.Tag = f;
            f.Show();
        }

        private void Admin_Owner_Load(object sender, EventArgs e)
        {

        }

        private void ADMIN_OWNER_Load_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            loadpanel(new customer_order());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            loadpanel(new order_process());
        }

        private void admin_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            loadpanel(new employee());

        }

        private void label5_Click(object sender, EventArgs e)
        {
            loadpanel(new purchase_request());
        }

        private void label7_Click(object sender, EventArgs e)
        {
            loadpanel(new companies());
        }
    }
}
