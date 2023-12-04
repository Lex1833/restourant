using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Restaurant
{
    public class SQL
    {
        private string connectionString = "Server=localhost;User ID=root;Database=db;Password=12345678;";
        private string query;

        public SQL(string query)
        {
            this.query = query;
        }
        public SQL()
        {
 
        }
        



        //ФОРМА ВХОДА ЮЗЕРА
        private int LoginUser(string phone, string password) //ПРОВЕРКА СУЩЕСТВОВАНИЯ В БД И ВЫВОД ID
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@password", password);

                    object id1 = command.ExecuteScalar();

                    if (id1 != null)
                    {
                        return Convert.ToInt32(id1);
                    }
                    else
                    {
                        return -1; 
                    }

                }
            }
        }
        public void UserClick(string phone, string password, string query, TextBox txtPhone, TextBox txtPassword, Form currentForm) //ПЕРЕХОД НА СЛЕД ФОРМУ
        {
            if (LoginUser(phone, password)>0)
            {
                Glav newForm = new Glav(LoginUser(phone, password));
                newForm.Show();
                currentForm.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка входа. Пожалуйста, проверьте свой номер телефона и пароль.");
            }
        }



        //ФОРМА РЕГИСТРАЦИИ
        public bool PhoneNumberExists(string phoneNumber, string query) //ПРОВЕРКА НА СУЩЕСТВОВАНИЕ НОМЕРА
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }
        public int AddData(string fio, string phoneNumber, string password, string query) //ДОБАВЛЕНИЕ В БД И ВЫВОД ID
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FIO", fio);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Password", password);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Возвращаем id только если вставка прошла успешно
                        return (int)command.LastInsertedId;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }



        //ФОРМА ГЛАВНАЯ
        public void LoadUserData(int userId, Glav glavForm) //ИЗВЛЕКАЕМ ДАННЫЕ ПО ID
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT FIO, phone FROM user WHERE id = @UserId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Извлекаем данные из результата запроса
                            string fio = reader["FIO"].ToString();
                            string phone = reader["phone"].ToString();

                            // Вызываем переданную функцию для установки данных
                            glavForm.SetUserData(fio, phone);
                        }
                    }
                }
            }
        }

        public void CheckBookingAndUpdateButton(TableButton button, DateTime selectedDate, int selectedTime)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Получаем данные для проверки из кнопки
                string tableName = button.TableName;

                // Формируем SQL-запрос с использованием параметров для избегания SQL-инъекций
                string query = "SELECT COUNT(*) FROM book WHERE `table` = @tableName AND `date` = @selectedDate AND `time` = @selectedTime";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Добавляем параметры
                    command.Parameters.AddWithValue("@tableName", tableName);
                    command.Parameters.AddWithValue("@selectedDate", selectedDate.Date);
                    command.Parameters.AddWithValue("@selectedTime", selectedTime);

                    // Выполняем запрос и получаем результат
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Обновляем цвет кнопки в зависимости от наличия записи в базе данных
                    if (count > 0)
                    {
                        ChangeButtonColor(button, Color.Red);
                    }
                    else
                    {
                        ChangeButtonColor(button, Color.LightGreen);
                    }
                }
            }
        }
        private void ChangeButtonColor(TableButton button, Color color)
        {
            button.SetButtonProperties(color);
        }

        public void AddBookingToDatabase(string tableName, DateTime selectedDate, int selectedTime, int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Формируем SQL-запрос для добавления записи в базу данных
                string query5 = "INSERT INTO book (`table`, `date`, `time`, ` userID`) VALUES (@tableName, @selectedDate, @selectedTime, @userId)";

                using (MySqlCommand command = new MySqlCommand(query5, connection))
                {
                    command.Parameters.AddWithValue("@tableName", tableName);
                    command.Parameters.AddWithValue("@selectedDate", selectedDate.Date);
                    command.Parameters.AddWithValue("@selectedTime", selectedTime);
                    command.Parameters.AddWithValue("@userId", userId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
