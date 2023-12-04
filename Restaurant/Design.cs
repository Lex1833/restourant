using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public class Design
    {
        public static void MouseOver(Panel panelButton, Label labelButtonText, Form form)
        {
            panelButton.BackColor = Color.DeepPink;
            labelButtonText.ForeColor = Color.Yellow;
            form.Cursor = Cursors.Hand;
        }
        public static void MouseOut(Panel panelButton, Label labelButtonText, Form form)
        {
            panelButton.BackColor = Color.Crimson;
            labelButtonText.ForeColor = Color.White;
            form.Cursor = Cursors.Default;
        }

        public static void MouseOver(Label labelButtonText, Form form)
        {

            labelButtonText.ForeColor = Color.Yellow;
            form.Cursor = Cursors.Hand;
        }
        public static void MouseOut(Label labelButtonText, Form form)
        {
            labelButtonText.ForeColor = Color.White;
            form.Cursor = Cursors.Default;
        }
    }
}