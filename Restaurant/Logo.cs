using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Logo : Form
    {
        public Logo()
        {
            InitializeComponent();
        }

        private void PanelUser_MouseEnter(object sender, EventArgs e)
        {
            Design.MouseOver(PanelUser, LabelUser, this);
        }
        private void PanelUser_MouseLeave(object sender, EventArgs e)
        {
            Design.MouseOut(PanelUser, LabelUser, this);
        }
        private void LabelUser_MouseEnter(object sender, EventArgs e)
        {
            Design.MouseOver(PanelUser, LabelUser, this);
        }
        private void LabelUser_MouseLeave(object sender, EventArgs e)
        {
            Design.MouseOut(PanelUser, LabelUser, this);
        }

        private void LabelAdmin_MouseEnter(object sender, EventArgs e)
        {
            Design.MouseOver(PanelAdmin, LabelAdmin, this);
        }
        private void LabelAdmin_MouseLeave(object sender, EventArgs e)
        {
            Design.MouseOut(PanelAdmin, LabelAdmin, this);
        }
        private void PanelAdmin_MouseEnter(object sender, EventArgs e)
        {
            Design.MouseOver(PanelAdmin, LabelAdmin, this);
        }
        private void PanelAdmin_MouseLeave(object sender, EventArgs e)
        {
            Design.MouseOut(PanelAdmin, LabelAdmin, this);
        }

        private void LabelCreate_MouseEnter(object sender, EventArgs e)
        {
            Design.MouseOver(LabelCreate, this);
        }
        private void LabelCreate_MouseLeave(object sender, EventArgs e)
        {
            Design.MouseOut(LabelCreate, this);
        }

        private void LabelUser_Click(object sender, EventArgs e)
        {
            User newForm = new User();
            newForm.Show();
            this.Hide();
        }
        private void PanelUser_Click(object sender, EventArgs e)
        {
            User newForm = new User();
            newForm.Show();
            this.Hide();
        }

        private void LabelAdmin_Click(object sender, EventArgs e)
        {
            Admin newForm = new Admin();
            newForm.Show();
            this.Hide();
        }
        private void PanelAdmin_Click(object sender, EventArgs e)
        {
            Admin newForm = new Admin();
            newForm.Show();
            this.Hide();
        }

        private void LabelCreate_Click(object sender, EventArgs e)
        {
            Reg newForm = new Reg();
            newForm.Show();
            this.Hide();
        }
    }
}
