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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            panel1 = new Panel();
            button2 = new Button();
            panel3 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.CausesValidation = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(52, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(120, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Фільми";
            comboBox1.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            comboBox1.MouseLeave += comboBox_MouseLeave;
            comboBox1.MouseHover += comboBox_MouseHover;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox2.FlatStyle = FlatStyle.Popup;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Мульфільми", "Фантастика", "Боєвики", "Казки", "Сімейні", "Пригодницькі", "Дитячі", "Мультсеріали", "Короткометражні", "Полнометражні" });
            comboBox2.Location = new Point(178, 49);
            comboBox2.Name = "comboBox2";
            comboBox2.RightToLeft = RightToLeft.No;
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 1;
            comboBox2.Text = "Cеріали";
            comboBox2.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            comboBox2.MouseLeave += comboBox_MouseLeave;
            comboBox2.MouseHover += comboBox_MouseHover;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox3.FlatStyle = FlatStyle.Popup;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Мульфільми", "Фантастика", "Боєвики", "Казки", "Сімейні", "Пригодницькі", "Дитячі", "Мультсеріали", "Короткометражні", "Полнометражні" });
            comboBox3.Location = new Point(305, 49);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 2;
            comboBox3.Text = "Мульфільми";
            comboBox3.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            comboBox3.MouseLeave += comboBox_MouseLeave;
            comboBox3.MouseHover += comboBox_MouseHover;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 106, 247);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(440, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 431);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(250, 128, 90);
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(57, 65);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Очистити";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(441, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 432);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(247, 190, 49);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 20);
            button1.MaximumSize = new Size(120, 0);
            button1.MinimumSize = new Size(80, 0);
            button1.Name = "button1";
            button1.Size = new Size(120, 39);
            button1.TabIndex = 4;
            button1.Text = "Пошук";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(250, 128, 90);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.MinimumSize = new Size(0, 480);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 480);
            panel2.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(-26, 78);
            panel4.Name = "panel4";
            panel4.Size = new Size(469, 2);
            panel4.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(243, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Main_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 431);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MinimumSize = new Size(600, 0);
            Name = "Main_Window";
            Text = "Main_Window";
            Load += Main_Window_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private TextBox textBox1;
        private Button button2;
        private Panel panel3;
        private Panel panel4;
    }
}