namespace WinFormsApp1
{
    partial class auth
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(auth));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            login = new TextBox();
            pass = new TextBox();
            passvis = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 204, 153);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(349, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 204, 153);
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 41);
            label3.Name = "label3";
            label3.Size = new Size(155, 23);
            label3.TabIndex = 0;
            label3.Text = "ООО \"Украшение\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(196, 193);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 1;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(184, 252);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // login
            // 
            login.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            login.Location = new Point(136, 219);
            login.Name = "login";
            login.Size = new Size(169, 30);
            login.TabIndex = 3;
            login.Text = "\tloginDEbct2018\t\t  ";
            // 
            // pass
            // 
            pass.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pass.Location = new Point(136, 278);
            pass.Name = "pass";
            pass.Size = new Size(169, 30);
            pass.TabIndex = 4;
            pass.Text = "\tQg3gff\t ";
            // 
            // passvis
            // 
            passvis.AutoSize = true;
            passvis.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passvis.Location = new Point(141, 314);
            passvis.Name = "passvis";
            passvis.Size = new Size(164, 27);
            passvis.TabIndex = 5;
            passvis.Text = "Показать пароль";
            passvis.UseVisualStyleBackColor = true;
            passvis.CheckedChanged += passvis_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(204, 102, 0);
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(0, 411);
            button1.Name = "button1";
            button1.Size = new Size(451, 45);
            button1.TabIndex = 6;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(204, 102, 0);
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(0, 462);
            button2.Name = "button2";
            button2.Size = new Size(451, 45);
            button2.TabIndex = 7;
            button2.Text = "Войти как гость";
            button2.UseVisualStyleBackColor = false;
            // 
            // auth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 509);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(passvis);
            Controls.Add(pass);
            Controls.Add(login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "auth";
            Text = "Авторизация";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox login;
        private TextBox pass;
        private CheckBox passvis;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}