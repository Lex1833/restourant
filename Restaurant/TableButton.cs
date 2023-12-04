using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    // Класс для круглой кнопки, представляющей стол
    public class TableButton : Button
    {
        public string TableName { get; private set; }

        public TableButton(Point location, string tableName, Size size, bool isSquare)
        {
            this.TableName = tableName;
            this.Size = size;
            this.Location = location;
            this.BackColor = Color.LightGreen;
            this.Text = tableName;

            // Установим стиль кнопки в Flat
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            float newSize = this.Font.Size + 8;
            this.Font = new Font(this.Font.FontFamily, newSize, this.Font.Style);

            // Создадим границу в зависимости от выбранной формы кнопки
            GraphicsPath buttonPath = new GraphicsPath();
            if (isSquare)
            {
                buttonPath.AddRectangle(new Rectangle(0, 0, this.Width, this.Height));
            }
            else
            {
                buttonPath.AddEllipse(0, 0, this.Width, this.Height);
            }
            this.Region = new Region(buttonPath);
        }

        public void SetButtonProperties(Color color)
        {
            this.BackColor = color;
        }
    }
}
