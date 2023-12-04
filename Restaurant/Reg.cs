using MySql.Data.MySqlClient;
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
    public partial class Reg : Form
    {
        private SQL NUM;
        private SQL ADD;
        string query2 = "SELECT COUNT(*) FROM user WHERE phone = @PhoneNumber";
        string query3 = "INSERT INTO user (FIO, phone, password) VALUES (@FIO, @PhoneNumber, @Password)";

        public Reg()
        {
            InitializeComponent();
            NUM = new SQL(query2);
            ADD = new SQL(query3);
        }   

        private void In()
        {
            string fio = txtFIO.Text;
            string phoneNumber = txtPhone.Text;
            string password = txtPassword.Text;

                // Проверка наличия корректных данных
            if (string.IsNullOrEmpty(fio) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                // Проверка наличия номера телефона в базе данных
            else if (NUM.PhoneNumberExists(phoneNumber, query2))
            {
                MessageBox.Show("Этот номер телефона уже зарегистрирован.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                // Проверка минимальной длины пароля
            else if (password.Length < 8)
            {
                MessageBox.Show("Пароль должен содержать минимум 8 символов.","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            // Вставка данных в базу данных
            int userId = ADD.AddData(fio, phoneNumber, password, query3);

            if (userId > 0)
            {
                Glav newForm = new Glav(userId);
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка при регистрации. Пожалуйста, повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
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
    }
}
