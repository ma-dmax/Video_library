using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Video_libarary
{
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
        }
        private void Search_btn_Click(object sender, EventArgs e)
        {
            string name_of = search_box.Text;
            if (name_of != "Пошук в програмі...")
            {
                MessageBox.Show($"You write: {name_of}");
                Console.WriteLine($"You write: {name_of}");
            }
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox type_video = (System.Windows.Forms.ComboBox)sender;
            search_box.Text = type_video.Text;
            Search_btn_Click(this, e);
        }

        private void ComboBox_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;
            comboBox.DroppedDown = true;
        }

        private void ComboBox_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;
            comboBox.DroppedDown = false;
        }

        private void Search_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Advenced_search_CheckedChanged(object sender, EventArgs e)
        {
            movie_combo_box.Visible = !movie_combo_box.Visible;
            serial_combo_box.Visible = !serial_combo_box.Visible;
            cartoons_combo_box.Visible = !cartoons_combo_box.Visible;
            if (cartoons_combo_box.Visible == false)
            {
                horizon_border.Location = new System.Drawing.Point(-26, 50);
            }
            else
            {
                horizon_border.Location = new System.Drawing.Point(-26, 100);
            }

        }

        private void Search_box_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            if (textBox.Text == "Пошук в програмі...")
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void Search_box_Leave(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Пошук в програмі...";
                textBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void Disfocus(object sender, EventArgs e)
        {
            main_bg.Focus();
        }

        private void Clear_Click(object sender, EventArgs e)
        {

        }

    }
}
