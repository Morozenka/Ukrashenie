namespace WinFormsApp1
{
    partial class Form2
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
            panel1 = new Panel();
            filter = new ComboBox();
            sort = new ComboBox();
            search = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            panel7 = new Panel();
            label13 = new Label();
            label12 = new Label();
            panel6 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            dg = new DataGridView();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 204, 153);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(filter);
            panel1.Controls.Add(sort);
            panel1.Controls.Add(search);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 134);
            panel1.TabIndex = 0;
            // 
            // filter
            // 
            filter.DropDownStyle = ComboBoxStyle.DropDownList;
            filter.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            filter.FormattingEnabled = true;
            filter.Items.AddRange(new object[] { "Все диапазоны", "0-9,99%", "10-14,99%", "15% и более " });
            filter.Location = new Point(287, 57);
            filter.Name = "filter";
            filter.Size = new Size(121, 31);
            filter.TabIndex = 5;
            filter.SelectedIndexChanged += filter_SelectedIndexChanged;
            // 
            // sort
            // 
            sort.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sort.FormattingEnabled = true;
            sort.Items.AddRange(new object[] { "По возрастанию", "По убыванию" });
            sort.Location = new Point(160, 57);
            sort.Name = "sort";
            sort.Size = new Size(121, 31);
            sort.TabIndex = 4;
            sort.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // search
            // 
            search.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            search.Location = new Point(33, 57);
            search.Name = "search";
            search.Size = new Size(121, 30);
            search.TabIndex = 3;
            search.TextChanged += search_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(287, 31);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 2;
            label3.Text = "Фильтр";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(160, 31);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 1;
            label2.Text = "Сортировка";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 0;
            label1.Text = "Поиск";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 204, 153);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(1, 434);
            panel2.Name = "panel2";
            panel2.Size = new Size(988, 134);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(204, 102, 0);
            button3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(838, 95);
            button3.Name = "button3";
            button3.Size = new Size(147, 37);
            button3.TabIndex = 4;
            button3.Text = "Выход";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(204, 102, 0);
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(679, 59);
            button1.Name = "button1";
            button1.Size = new Size(306, 37);
            button1.TabIndex = 2;
            button1.Text = "Работа с заказами";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(204, 102, 0);
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(679, 95);
            button2.Name = "button2";
            button2.Size = new Size(153, 37);
            button2.TabIndex = 3;
            button2.Text = "Просмотр заказа";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(label13);
            panel7.Controls.Add(label12);
            panel7.Location = new Point(679, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(306, 56);
            panel7.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(128, 30);
            label13.Name = "label13";
            label13.Size = new Size(63, 23);
            label13.TabIndex = 7;
            label13.Text = "Скидка";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(96, 3);
            label12.Name = "label12";
            label12.Size = new Size(125, 23);
            label12.TabIndex = 6;
            label12.Text = "Размер скидки:";
            // 
            // panel6
            // 
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(287, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(386, 128);
            panel6.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(3, 96);
            label11.Name = "label11";
            label11.Size = new Size(141, 23);
            label11.TabIndex = 5;
            label11.Text = "Цена со скидкой:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(3, 72);
            label10.Name = "label10";
            label10.Size = new Size(138, 23);
            label10.TabIndex = 4;
            label10.Text = "Цена без скидки:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(3, 49);
            label9.Name = "label9";
            label9.Size = new Size(135, 23);
            label9.TabIndex = 3;
            label9.Text = "Производитель:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 26);
            label8.Name = "label8";
            label8.Size = new Size(146, 23);
            label8.TabIndex = 2;
            label8.Text = "Описание товара:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 3);
            label7.Name = "label7";
            label7.Size = new Size(181, 23);
            label7.TabIndex = 1;
            label7.Text = "Наименование товара:";
            label7.Click += label7_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox2);
            panel5.Location = new Point(143, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(134, 128);
            panel5.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.picture;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(134, 128);
            panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dg);
            panel3.Location = new Point(1, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(988, 288);
            panel3.TabIndex = 1;
            // 
            // dg
            // 
            dg.BackgroundColor = SystemColors.ButtonHighlight;
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg.Location = new Point(3, 3);
            dg.Name = "dg";
            dg.RowTemplate.Height = 25;
            dg.Size = new Size(982, 282);
            dg.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 204, 153);
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(807, 57);
            label4.Name = "label4";
            label4.Size = new Size(155, 23);
            label4.TabIndex = 6;
            label4.Text = "ООО \"Украшение\"";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 204, 153);
            ClientSize = new Size(989, 565);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Товары";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox filter;
        private ComboBox sort;
        private TextBox search;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dg;
        private Button button3;
        private Button button1;
        private Button button2;
        private Panel panel7;
        private Panel panel6;
        private Label label8;
        private Label label7;
        private Panel panel5;
        private Panel panel4;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label13;
        private Label label12;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label4;
    }
}