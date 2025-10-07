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
    public partial class SALES_TEAM : Form
    {
        public SALES_TEAM()
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

        private void SALES_TEAM_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            loadpanel(new quotation_converter());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            loadpanel(new product_quotation());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            loadpanel(new quotation_track());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            loadpanel(new purchase_request());
        }
    }
}
