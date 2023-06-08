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
using Video_libarary;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Video_libarary
{
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
            Videos videos = new Videos();
            Video[] videoArray = videos.GetVideos();

            int element_count = videoArray.Length; 
            int columns = 3; 
            int rows = (int)Math.Ceiling((double)element_count / columns); 

            TableLayoutPanel tableLayout = new TableLayoutPanel();

            tableLayout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayout.Width = 500;
            tableLayout.Height = 10000000;

            tableLayout.RowCount = rows;
            tableLayout.ColumnCount = columns;

            int added_count = 0;

            for (int i = 0; i <= element_count; i++)
            {
                System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel();
                if (i%5 != 0) 
                {
                    int row = added_count / columns;
                    int column = added_count % columns;
                    panel.Text = i.ToString();
                    panel.BackColor = Color.White;
                    added_count++;

                    if (tableLayout.RowStyles.Count <= row)
                    {
                        tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    }
                    if (tableLayout.ColumnStyles.Count <= column)
                    {
                        tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    }

                    tableLayout.Controls.Add(panel, column, row);
                }
          

            }
            Video_Panel.Controls.Add(tableLayout);


        }
        private void Search_btn_Click(object sender, EventArgs e)
        {
            string name_of = search_box.Text;
            if (name_of != "Пошук в програмі...")
            {
                MessageBox.Show($"You write: {name_of}");
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
                ScrollBarr.Location = new System.Drawing.Point(425, 52);
                ScrollBarr.Size = new System.Drawing.Size(15, 380);
                Video_Panel.Location = new System.Drawing.Point(0, 52);
                Video_Panel.Size = new System.Drawing.Size(425, 380);

            }
            else
            {
                horizon_border.Location = new System.Drawing.Point(-26, 100);
                ScrollBarr.Location = new System.Drawing.Point(425, 102);
                ScrollBarr.Size = new System.Drawing.Size(15, 330);
                Video_Panel.Location = new System.Drawing.Point(0, 102);
                Video_Panel.Size = new System.Drawing.Size(425, 330);
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
            search_box.Text = null;
            movie_combo_box.SelectedIndex = -1;
            serial_combo_box.SelectedIndex = -1;
            cartoons_combo_box.SelectedIndex = -1;

        }
        private void VScrollBar_Scroll(object sender, ScrollEventArgs e)
        {

            foreach (Control control in Video_Panel.Controls)
            {
                control.Top = control.Top + e.OldValue - e.NewValue;
            }
            Video_Panel.PerformLayout();
        }
    }
}
