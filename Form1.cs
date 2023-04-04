using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace machine_treatment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string CoordMouseToString(MouseEventArgs mea)
        {
            return $"Mouse coordinates:  x = {mea.X.ToString()} y = {mea.Y.ToString()}";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = CoordMouseToString(e);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string message = "";
            if(e.Button == MouseButtons.Left)
            {
                message = "You pressed left";
            }
            else
                if (e.Button == MouseButtons.Right)
            {
                message = "You pressed right";
            }
            message += $"\n{CoordMouseToString(e)}";

            string caption = "mouse click";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
