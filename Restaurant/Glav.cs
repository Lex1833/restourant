using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Glav : Form
    {             
        private readonly int userId;
        private readonly SQL data;       

        private readonly TableButton table1;
        private readonly TableButton table2;
        private readonly TableButton table3;
        private readonly TableButton table4;
        private readonly TableButton table5;
        private readonly TableButton table6;

        public Glav(int userId)
        {            
            InitializeComponent();
            this.userId = userId;
            data = new SQL();
            
            labelUserId.Text = "ID пользователя: " + userId.ToString();
            LoadUserData();

            table1 = InitializeTableButton(new Point(380, 90), "Стол 1", new Size(200, 160), false);
            table2 = InitializeTableButton(new Point(720, 90), "Стол 2", new Size(200, 160), false);
            table3 = InitializeTableButton(new Point(400, 330), "Стол 3", new Size(140, 180), true);
            table4 = InitializeTableButton(new Point(750, 330), "Стол 4", new Size(140, 180), true);
            table5 = InitializeTableButton(new Point(300, 610), "Стол 5", new Size(280, 100), true);
            table6 = InitializeTableButton(new Point(700, 610), "Стол 6", new Size(290, 100), true);

            UpdateButtonColors();
        }
     
        private void LoadUserData() //данные по id привет
        {
            data.LoadUserData(userId, this);            
        }
        public void SetUserData(string fio, string phone)  //данные по id привет2
        {
            labelFIO.Text = fio;
            labelphone.Text = phone;
        }

        // Метод для инициализации кнопки стола
        private TableButton InitializeTableButton(Point location, string tableName, Size size, bool isSquare)
        {
            TableButton tableButton = new TableButton(location, tableName, size, isSquare);
            tableButton.Click += TableButton_Click;
            this.Controls.Add(tableButton);
            return tableButton;
        }      
        

        private void TableButton_Click(object sender, EventArgs e) //НАЖАТИЕ СТОЛА
        {
            // Получаем информацию о нажатой кнопке стола
            TableButton clickedButton = (TableButton)sender;
            string tableName = clickedButton.TableName;

            // Предположим, что у вас есть переменные selectedDate и selectedTime, представляющие выбранную дату и время
            DateTime selectedDate = Calendar1.SelectionStart;
            int selectedTime = Convert.ToInt32(NumericUpDown1.Value);

            // Проверяем и обновляем данные в базе данных
            data.CheckBookingAndUpdateButton(clickedButton, selectedDate, selectedTime);

            // Проверяем цвет кнопки
            if (clickedButton.BackColor == Color.Red)
            {
                MessageBox.Show("Этот стол забронирован и недоступен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string formattedDate = selectedDate.ToShortDateString();
            // Если бронирование еще не существует, спросим пользователя о бронировании
            DialogResult result = MessageBox.Show($"Вы хотите забронировать '{tableName}' на {formattedDate} в {selectedTime} часов?", "Бронирование", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Добавляем данные в базу данных
                data.AddBookingToDatabase(tableName, selectedDate, selectedTime, userId);

                // После успешного добавления, обновляем цвет кнопки
                UpdateButtonColors();
            }
        }


        private void Glav_Paint(object sender, PaintEventArgs e) //РИСОВАЛКА
        {
            // Создаем объект Graphics из PaintEventArgs
            Graphics g = e.Graphics;
            // Устанавливаем толщину линии и заливку
            Pen pen1 = new Pen(Color.Black, 3);
            Pen pen2 = new Pen(Color.DeepSkyBlue, 1);
            Pen pen3 = new Pen(Color.Tomato, 1);
            Pen pen4 = new Pen(Color.Brown, 1);
            Brush brush1 = new SolidBrush(Color.PeachPuff);
            Brush brush2 = new SolidBrush(Color.LightSkyBlue);
            Brush brush3 = new SolidBrush(Color.SandyBrown);
            Brush brush4 = new SolidBrush(Color.SaddleBrown);

                // форма
            Rectangle rectangle1 = new Rectangle(20, 20, 1000, 770);
            g.FillRectangle(brush1, rectangle1);
            g.DrawRectangle(pen1, rectangle1);
                // форма стена
            Rectangle rectangle2 = new Rectangle(235, 570, 30, 220);
            g.FillRectangle(brush1, rectangle2);
            g.DrawRectangle(pen1, rectangle2);

                // окно 1
            Rectangle win1 = new Rectangle(570, 15, 450, 6);
            g.FillRectangle(brush2, win1);
            g.DrawRectangle(pen2, win1);
                // окно 2
            Rectangle win2 = new Rectangle(1020, 15, 6, 380);
            g.FillRectangle(brush2, win2);
            g.DrawRectangle(pen2, win2);
                // окно 3
            Rectangle win3 = new Rectangle(1020, 450, 6, 130);
            g.FillRectangle(brush2, win3);
            g.DrawRectangle(pen2, win3);
                // окно 4
            Rectangle win4 = new Rectangle(1020, 628, 6, 130);
            g.FillRectangle(brush2, win4);
            g.DrawRectangle(pen2, win4);
                // окно 5
            Rectangle win5 = new Rectangle(370, 15, 150, 6);
            g.FillRectangle(brush2, win5);
            g.DrawRectangle(pen2, win5);

                // дверь 1
            Rectangle door1 = new Rectangle(20, 300, 6, 100);
            g.FillRectangle(brush4, door1);
            g.DrawRectangle(pen4, door1);
                // дверь 2
            Rectangle door2 = new Rectangle(20, 500, 6, 100);
            g.FillRectangle(brush4, door2);
            g.DrawRectangle(pen4, door2);
                // дверь 3
            Rectangle door3 = new Rectangle(55, 784, 140, 6);
            g.FillRectangle(brush4, door3);
            g.DrawRectangle(pen4, door3);

                // стул 1
            Rectangle chair1 = new Rectangle(380, 90, 40, 40);
            g.FillRectangle(brush3, chair1);
            g.DrawRectangle(pen3, chair1);
                // стул 2
            Rectangle chair2 = new Rectangle(380, 210, 40, 40);
            g.FillRectangle(brush3, chair2);
            g.DrawRectangle(pen3, chair2);
                // стул 3
            Rectangle chair3 = new Rectangle(530, 90, 40, 40);
            g.FillRectangle(brush3, chair3);
            g.DrawRectangle(pen3, chair3);
                // стул 4
            Rectangle chair4 = new Rectangle(530, 210, 40, 40);
            g.FillRectangle(brush3, chair4);
            g.DrawRectangle(pen3, chair4);
                // стул 5
            Rectangle chair5 = new Rectangle(720, 90, 40, 40);
            g.FillRectangle(brush3, chair5);
            g.DrawRectangle(pen3, chair5);
                // стул 6
            Rectangle chair6 = new Rectangle(720, 210, 40, 40);
            g.FillRectangle(brush3, chair6);
            g.DrawRectangle(pen3, chair6);
                // стул 7
            Rectangle chair7 = new Rectangle(870, 90, 40, 40);
            g.FillRectangle(brush3, chair7);
            g.DrawRectangle(pen3, chair7);
                // стул 8
            Rectangle chair8 = new Rectangle(870, 210, 40, 40);
            g.FillRectangle(brush3, chair8);
            g.DrawRectangle(pen3, chair8);
                // стул 9
            Rectangle chair9 = new Rectangle(340, 350, 40, 140);
            g.FillRectangle(brush3, chair9);
            g.DrawRectangle(pen3, chair9);
                // стул 10
            Rectangle chair10 = new Rectangle(560, 350, 40, 140);
            g.FillRectangle(brush3, chair10);
            g.DrawRectangle(pen3, chair10);
                // стул 11
            Rectangle chair11 = new Rectangle(690, 350, 40, 140);
            g.FillRectangle(brush3, chair11);
            g.DrawRectangle(pen3, chair11);
                // стул 12
            Rectangle chair12 = new Rectangle(910, 350, 40, 140);
            g.FillRectangle(brush3, chair12);
            g.DrawRectangle(pen3, chair12);
                // стул 13
            Rectangle chair13 = new Rectangle(320, 560, 80, 40);
            g.FillRectangle(brush3, chair13);
            g.DrawRectangle(pen3, chair13);
                // стул 14
            Rectangle chair14 = new Rectangle(480, 560, 80, 40);
            g.FillRectangle(brush3, chair14);
            g.DrawRectangle(pen3, chair14);
                // стул 15
            Rectangle chair15 = new Rectangle(720, 560, 80, 40);
            g.FillRectangle(brush3, chair15);
            g.DrawRectangle(pen3, chair15);
                // стул 16
            Rectangle chair16 = new Rectangle(880, 560, 80, 40);
            g.FillRectangle(brush3, chair16);
            g.DrawRectangle(pen3, chair16);
                // стул 17
            Rectangle chair17 = new Rectangle(275, 720, 340, 40);
            g.FillRectangle(brush3, chair17);
            g.DrawRectangle(pen3, chair17);
                // стул 18
            Rectangle chair18 = new Rectangle(670, 720, 340, 40);
            g.FillRectangle(brush3, chair18);
            g.DrawRectangle(pen3, chair18);

                // бар 1
            Rectangle bar1 = new Rectangle(20, 20, 40, 220);
            g.FillRectangle(brush4, bar1);
            g.DrawRectangle(pen4, bar1);
                // бар 2
            Rectangle bar2 = new Rectangle(20, 200, 220, 40);
            g.FillRectangle(brush4, bar2);
            g.DrawRectangle(pen4, bar2);
                // бар 3
            Rectangle bar3 = new Rectangle(200, 70, 40, 170);
            g.FillRectangle(brush4, bar3);
            g.DrawRectangle(pen4, bar3);

                // Не забываем освободить ресурсы           
            pen1.Dispose();
            pen2.Dispose();
            pen3.Dispose();
            pen4.Dispose();
            brush1.Dispose();
            brush2.Dispose();
            brush3.Dispose();
            brush4.Dispose();
        } 


        private void UpdateButtonColors() //МЕТОД ПРОВЕРКИ С БД СТОЛОВ
        {
            DateTime selectedDate = Calendar1.SelectionStart;
            int selectedTime = Convert.ToInt32(NumericUpDown1.Value);

            data.CheckBookingAndUpdateButton(table1, selectedDate, selectedTime);
            data.CheckBookingAndUpdateButton(table2, selectedDate, selectedTime);
            data.CheckBookingAndUpdateButton(table3, selectedDate, selectedTime);
            data.CheckBookingAndUpdateButton(table4, selectedDate, selectedTime);
            data.CheckBookingAndUpdateButton(table5, selectedDate, selectedTime);
            data.CheckBookingAndUpdateButton(table6, selectedDate, selectedTime);
        }
        private void Calendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateButtonColors();
        }
        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateButtonColors();
        }



        private void PanelBack_Click(object sender, EventArgs e)
        {
            Logo newForm = new Logo();
            newForm.Show();
            this.Hide();
        }
        private void LabelBack_Click(object sender, EventArgs e)
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
    }
}
