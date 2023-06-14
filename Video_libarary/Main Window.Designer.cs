namespace Video_libarary
{
    partial class Main_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            movie_combo_box = new ComboBox();
            serial_combo_box = new ComboBox();
            cartoons_combo_box = new ComboBox();
            right_bg = new Panel();
            advenced_search = new CheckBox();
            clear_btn = new Button();
            search_btn = new Button();
            vertical_border = new Panel();
            main_bg = new Panel();
            Video_Panel = new Panel();
            ScrollBarr = new VScrollBar();
            horizon_border = new Panel();
            search_box = new TextBox();
            right_bg.SuspendLayout();
            main_bg.SuspendLayout();
            SuspendLayout();
            // 
            // movie_combo_box
            // 
            movie_combo_box.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            movie_combo_box.CausesValidation = false;
            movie_combo_box.FormattingEnabled = true;
            movie_combo_box.Items.AddRange(new object[] { "Фільми", "Фантастика", "Боєвики", "Казки", "Сімейні", "Пригодницькі", "Дитячі", "Мультсеріали", "Короткометражні", "Полнометражні" });
            movie_combo_box.Location = new Point(50, 45);
            movie_combo_box.Name = "movie_combo_box";
            movie_combo_box.Size = new Size(120, 23);
            movie_combo_box.TabIndex = 0;
            movie_combo_box.Text = "Фільми";
            movie_combo_box.Visible = false;
            movie_combo_box.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            movie_combo_box.MouseLeave += ComboBox_MouseLeave;
            movie_combo_box.MouseHover += ComboBox_MouseHover;
            // 
            // serial_combo_box
            // 
            serial_combo_box.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            serial_combo_box.FlatStyle = FlatStyle.Popup;
            serial_combo_box.FormattingEnabled = true;
            serial_combo_box.Items.AddRange(new object[] { "Серіали", "Фантастика", "Боєвики", "Казки", "Сімейні", "Пригодницькі", "Дитячі", "Мультсеріали", "Короткометражні", "Полнометражні" });
            serial_combo_box.Location = new Point(175, 45);
            serial_combo_box.Name = "serial_combo_box";
            serial_combo_box.RightToLeft = RightToLeft.No;
            serial_combo_box.Size = new Size(120, 23);
            serial_combo_box.TabIndex = 1;
            serial_combo_box.Text = "Cеріали";
            serial_combo_box.Visible = false;
            serial_combo_box.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            serial_combo_box.MouseLeave += ComboBox_MouseLeave;
            serial_combo_box.MouseHover += ComboBox_MouseHover;
            // 
            // cartoons_combo_box
            // 
            cartoons_combo_box.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cartoons_combo_box.FlatStyle = FlatStyle.Popup;
            cartoons_combo_box.FormattingEnabled = true;
            cartoons_combo_box.Items.AddRange(new object[] { "Мульфільми", "Фантастика", "Боєвики", "Казки", "Сімейні", "Пригодницькі", "Дитячі", "Мультсеріали", "Короткометражні", "Полнометражні" });
            cartoons_combo_box.Location = new Point(300, 45);
            cartoons_combo_box.Name = "cartoons_combo_box";
            cartoons_combo_box.Size = new Size(120, 23);
            cartoons_combo_box.TabIndex = 2;
            cartoons_combo_box.Text = "Мульфільми";
            cartoons_combo_box.Visible = false;
            cartoons_combo_box.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cartoons_combo_box.MouseLeave += ComboBox_MouseLeave;
            cartoons_combo_box.MouseHover += ComboBox_MouseHover;
            // 
            // right_bg
            // 
            right_bg.BackColor = Color.FromArgb(49, 106, 247);
            right_bg.Controls.Add(advenced_search);
            right_bg.Controls.Add(clear_btn);
            right_bg.Controls.Add(search_btn);
            right_bg.Dock = DockStyle.Right;
            right_bg.Location = new Point(440, 0);
            right_bg.Margin = new Padding(0);
            right_bg.Name = "right_bg";
            right_bg.Size = new Size(144, 431);
            right_bg.TabIndex = 3;
            right_bg.Click += Disfocus;
            // 
            // advenced_search
            // 
            advenced_search.AutoSize = true;
            advenced_search.CheckAlign = ContentAlignment.TopLeft;
            advenced_search.Cursor = Cursors.Hand;
            advenced_search.Location = new Point(7, 89);
            advenced_search.Name = "advenced_search";
            advenced_search.Size = new Size(137, 19);
            advenced_search.TabIndex = 6;
            advenced_search.Text = "Розширений пошук";
            advenced_search.UseVisualStyleBackColor = true;
            advenced_search.CheckedChanged += Advenced_search_CheckedChanged;
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.FromArgb(250, 128, 90);
            clear_btn.BackgroundImageLayout = ImageLayout.Center;
            clear_btn.FlatStyle = FlatStyle.Popup;
            clear_btn.Location = new Point(57, 60);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(75, 23);
            clear_btn.TabIndex = 5;
            clear_btn.Text = "Очистити";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += Clear_Click;
            // 
            // search_btn
            // 
            search_btn.BackColor = Color.FromArgb(247, 190, 49);
            search_btn.Cursor = Cursors.Hand;
            search_btn.FlatStyle = FlatStyle.Popup;
            search_btn.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            search_btn.Location = new Point(12, 15);
            search_btn.MaximumSize = new Size(120, 0);
            search_btn.MinimumSize = new Size(80, 0);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(120, 39);
            search_btn.TabIndex = 4;
            search_btn.Text = "Пошук";
            search_btn.UseVisualStyleBackColor = false;
            search_btn.Click += Search_btn_Click;
            // 
            // vertical_border
            // 
            vertical_border.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            vertical_border.BackColor = Color.Black;
            vertical_border.Location = new Point(441, 0);
            vertical_border.Name = "vertical_border";
            vertical_border.Size = new Size(2, 432);
            vertical_border.TabIndex = 6;
            // 
            // main_bg
            // 
            main_bg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            main_bg.BackColor = Color.FromArgb(250, 128, 90);
            main_bg.Controls.Add(Video_Panel);
            main_bg.Controls.Add(ScrollBarr);
            main_bg.Controls.Add(horizon_border);
            main_bg.Controls.Add(search_box);
            main_bg.Controls.Add(cartoons_combo_box);
            main_bg.Controls.Add(serial_combo_box);
            main_bg.Controls.Add(movie_combo_box);
            main_bg.Location = new Point(0, 0);
            main_bg.Margin = new Padding(0);
            main_bg.MinimumSize = new Size(0, 480);
            main_bg.Name = "main_bg";
            main_bg.Size = new Size(440, 480);
            main_bg.TabIndex = 6;
            main_bg.Click += Disfocus;
            // 
            // Video_Panel
            // 
            Video_Panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Video_Panel.BackColor = Color.FromArgb(250, 128, 90);
            Video_Panel.Location = new Point(0, 52);
            Video_Panel.Margin = new Padding(0);
            Video_Panel.Name = "Video_Panel";
            Video_Panel.Size = new Size(425, 379);
            Video_Panel.TabIndex = 9;
            // 
            // ScrollBarr
            // 
            ScrollBarr.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ScrollBarr.Location = new Point(425, 51);
            ScrollBarr.Name = "ScrollBarr";
            ScrollBarr.Size = new Size(15, 380);
            ScrollBarr.TabIndex = 8;
            ScrollBarr.Scroll += VScrollBar_Scroll;
            // 
            // horizon_border
            // 
            horizon_border.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            horizon_border.BackColor = Color.Black;
            horizon_border.Location = new Point(-26, 50);
            horizon_border.Name = "horizon_border";
            horizon_border.Size = new Size(469, 2);
            horizon_border.TabIndex = 7;
            horizon_border.Click += Disfocus;
            // 
            // search_box
            // 
            search_box.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            search_box.Location = new Point(243, 15);
            search_box.MaximumSize = new Size(250, 0);
            search_box.Name = "search_box";
            search_box.Size = new Size(181, 23);
            search_box.TabIndex = 3;
            search_box.Text = "Пошук в програмі...";
            search_box.TextChanged += Search_box_TextChanged;
            search_box.Enter += Search_box_Enter;
            search_box.Leave += Search_box_Leave;
            // 
            // Main_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 431);
            Controls.Add(main_bg);
            Controls.Add(vertical_border);
            Controls.Add(right_bg);
            MinimumSize = new Size(600, 0);
            Name = "Main_Window";
            Text = "Main_Window";
            SizeChanged += Main_Window_SizeChanged;
            Click += Disfocus;
            right_bg.ResumeLayout(false);
            right_bg.PerformLayout();
            main_bg.ResumeLayout(false);
            main_bg.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox movie_combo_box;
        private ComboBox serial_combo_box;
        private ComboBox cartoons_combo_box;
        private Panel right_bg;
        private Button search_btn;
        private Panel main_bg;
        private TextBox search_box;
        private Button clear_btn;
        private Panel vertical_border;
        private Panel horizon_border;
        private CheckBox advenced_search;
        private VScrollBar ScrollBarr;
        private Panel Video_Panel;
    }
}