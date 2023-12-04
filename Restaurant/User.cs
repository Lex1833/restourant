using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Restaurant
{
    public partial class User : Form
    {
        private readonly SQL loginManager;
        readonly string query1 = "SELECT id FROM user WHERE phone = @phone AND password = @password";


        public User()
        {
            InitializeComponent();
            loginManager = new SQL(query1);
        }
        private void In()
        {
            string Phone = txtPhone.Text;
            string Password = txtPassword.Text;
            string query = query1;

            loginManager.UserClick(Phone, Password, query, txtPhone, txtPassword, this);
        }

        private void LabelLogin_Click(object sender, EventArgs e)
        {
            In();
        }
        private void PanelLogin_Click(object sender, EventArgs e)
        {
            In();
        }

        private void LabelBack_Click(object sender, EventArgs e)
        {
            Logo newForm = new Logo();
            newForm.Show();
            this.Hide();
        }
        private void PanelBack_Click(object sender, EventArgs e)
        {
            Logo newForm = new Logo();
            newForm.Show();
            this.Hide();
        }

        private void LabelBack_MouseEnter(object sender, EventArgs e)
        {
            Design.MouseOver(PanelBack, LabelBack, this);
        }
        private void LabelBack_MouseLeave(object sender, EventArgs e)
        {
            Design.MouseOut(PanelBack, LabelBack, this);
        }
        private void PanelBack_MouseEnter(object sender, EventArgs e)
        {
            Design.MouseOver(PanelBack, LabelBack, this);
        }
        private void PanelBack_MouseLeave(object sender, EventArgs e)
        {
            Design.MouseOut(PanelBack, LabelBack, this);
        }

        private void LabelLogin_MouseEnter(object sender, EventArgs e)
        {
            Design.MouseOver(PanelLogin, LabelLogin, this);
        }
        private void LabelLogin_MouseLeave(object sender, EventArgs e)
        {
            Design.MouseOut(PanelLogin, LabelLogin, this);
        }
        private void PanelLogin_MouseEnter(object sender, EventArgs e)
        {
            Design.MouseOver(PanelLogin, LabelLogin, this);
        }
        private void PanelLogin_MouseLeave(object sender, EventArgs e)
        {
            Design.MouseOut(PanelLogin, LabelLogin, this);
        }
    }
}
