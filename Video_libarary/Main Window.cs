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
            GET_Video();
        }
        private void GET_Video()
        {
            Video_Panel.Controls.Clear();


            Videos videos = new Videos();
            Video[] videoArray = videos.GetVideos();

            int element_count = videoArray.Length;
            int columns = (int)Math.Floor((double)Video_Panel.Width / 205);
            int rows = (int)Math.Ceiling((double)element_count / columns);
            if (rows > 0)
            {

                TableLayoutPanel tableLayout = new TableLayoutPanel();

            tableLayout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayout.Width = Video_Panel.Width;
            tableLayout.Height = 260 * rows;
            ScrollBarr.Value = 0;
            ScrollBarr.Maximum = 255 * rows;

            
                tableLayout.RowCount = rows;
                tableLayout.ColumnCount = columns;
           
            

            int added_count = 0;

            for (int i = 0; i < element_count; i++)             
            {
                System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel();
                if (true) { 
                    int row = added_count / columns;
                    int column = added_count % columns;
                    panel.Name = i.ToString();
                    panel.Size = new Size(200, 250);

                    System.Windows.Forms.Label textLabel = new System.Windows.Forms.Label();
                    textLabel.Text = videoArray[i].Name.ToString();
                    textLabel.TextAlign = ContentAlignment.MiddleCenter;
                    textLabel.Location = new System.Drawing.Point(55, 5);
                    panel.Controls.Add(textLabel);


                    System.Windows.Forms.Label textLabel2 = new System.Windows.Forms.Label();
                    textLabel2.Text = $"Опис: {videoArray[i].Description.ToString()}";
                        textLabel2.TextAlign = ContentAlignment.TopLeft;
                    textLabel2.Location = new System.Drawing.Point(15, 25);
                    textLabel2.Size = new Size(170, 110);
                    panel.Controls.Add(textLabel2);

                    System.Windows.Forms.Label textLabel3 = new System.Windows.Forms.Label();
                    textLabel3.Text = $"Оцінка: { videoArray[i].Rating.ToString() }/100";
                    textLabel3.TextAlign = ContentAlignment.TopLeft;
                    textLabel3.Location = new System.Drawing.Point(15, 135);
                    textLabel3.Size = new Size(170, 20);
                    panel.Controls.Add(textLabel3);

                    System.Windows.Forms.Label textLabel4 = new System.Windows.Forms.Label();
                    textLabel4.Text = $"Рік виходу: {videoArray[i].Year.ToString()}";
                    textLabel4.TextAlign = ContentAlignment.TopLeft;
                    textLabel4.Location = new System.Drawing.Point(15, 155);
                    textLabel4.Size = new Size(170, 20);
                    panel.Controls.Add(textLabel4);

                    System.Windows.Forms.Button Button = new System.Windows.Forms.Button();
                    Button.Text = $"Взяти фільми в оренду";
                    Button.TextAlign = ContentAlignment.TopLeft;
                    Button.Location = new System.Drawing.Point(50, 185);
                    Button.Size = new Size(140, 25);
                    Button.Name = i.ToString();
                    Button.Click += Add_Movie;
                    panel.Controls.Add(Button);

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
        }
        private void Search_btn_Click(object sender, EventArgs e)
        {
            string name_of = search_box.Text;
            if (name_of != "Пошук в програмі...")
            {
                MessageBox.Show($"You write: {name_of}");
            }
        }
        private void Add_Movie(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            string buttonName = clickedButton.Name;
                
            MessageBox.Show($"You wanna to add movie by ID :{buttonName}");
                
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*System.Windows.Forms.ComboBox type_video = (System.Windows.Forms.ComboBox)sender;
            search_box.Text = type_video.Text;
            Search_btn_Click(this, e);*/
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
                ScrollBarr.Location = new System.Drawing.Point(main_bg.Width - 15, 52);
                ScrollBarr.Size = new System.Drawing.Size(15, main_bg.Height - 100);
                Video_Panel.Location = new System.Drawing.Point(0, 52);
                Video_Panel.Size = new System.Drawing.Size(main_bg.Width - 15, main_bg.Height - 100);

            }
            else
            {
                horizon_border.Location = new System.Drawing.Point(-26, 100);
                ScrollBarr.Location = new System.Drawing.Point(main_bg.Width - 15, 102);
                ScrollBarr.Size = new System.Drawing.Size(15, main_bg.Height - 150);
                Video_Panel.Location = new System.Drawing.Point(0, 102);
                Video_Panel.Size = new System.Drawing.Size(main_bg.Width - 15, main_bg.Height - 50);
            }
            movie_combo_box.SelectedIndex = 0;
            serial_combo_box.SelectedIndex = 0;
            cartoons_combo_box.SelectedIndex = 0;

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
            ScrollBarr.Focus();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            movie_combo_box.SelectedIndex = 0;
            serial_combo_box.SelectedIndex = 0;
            cartoons_combo_box.SelectedIndex = 0;
            search_box.Text = "Пошук в програмі...";
        }
        private void VScrollBar_Scroll(object sender, ScrollEventArgs e)
        {

            foreach (Control control in Video_Panel.Controls)
            {
                control.Top = control.Top + e.OldValue - e.NewValue;
            }
            Video_Panel.PerformLayout();
        }

        private void Main_Window_SizeChanged(object sender, EventArgs e)
        {
            GET_Video();

        }
    }
}
