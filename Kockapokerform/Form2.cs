using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kockapokerform
{
    public partial class frmKezdo : Form
    {
        private frmFo foform;
        public frmKezdo(frmFo Fo)
        {
            InitializeComponent();
            foform = Fo;
            
        }

        private void btnHarom_Click(object sender, EventArgs e)
        {
            foform.korokSzama = 3;
            foform.Text += " | A körök száma 3";
            this.Close();
        }

        private void btnOt_Click(object sender, EventArgs e)
        {
            foform.korokSzama = 5;
            foform.Text += " | A körök száma 5";
            this.Close();

        }

        private void frmKezdo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (foform.korokSzama == 0)
            {
                var result = MessageBox.Show("Nincs beállítva a körök száma. Csak egykörös játék lesz","Beállítás nélkül",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            }
            if (DialogResult == DialogResult.Yes)
            {
                foform.korokSzama = 1;
                foform.Text += " | A körök száma 1";
                e.Cancel = false;
                return;
            }
        }
    }
}
