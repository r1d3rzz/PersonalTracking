using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTracking
{
    public partial class frmTasksList : Form
    {
        public frmTasksList()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //
        }

        private void userNo_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = General.isNumber(e);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTasksList_Load(object sender, EventArgs e)
        {
            adminPanel.Hide();
        }
    }
}
