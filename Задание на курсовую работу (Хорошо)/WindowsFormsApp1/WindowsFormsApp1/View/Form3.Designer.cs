
namespace WindowsFormsApp1.View
{
    partial class Form3
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.label_menu = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.label_university = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Controls.Add(this.label_exit);
            this.panel_main.Controls.Add(this.label_menu);
            this.panel_main.Controls.Add(this.label_start);
            this.panel_main.Location = new System.Drawing.Point(1, 340);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1308, 258);
            this.panel_main.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(108, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 85);
            this.label1.TabIndex = 3;
            this.label1.Text = "Курсовая работа по дисциплине \"Программирование\"\r\n\r\nТема: \"Разработка приложения " +
    "с графическим интерфейсом \"Приемная комиссия\"\r\n\r\nРазработал: студент группы БИТ2" +
    "0-11 Парфинович А.В.";
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exit.Location = new System.Drawing.Point(1039, 196);
            this.label_exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(116, 39);
            this.label_exit.TabIndex = 2;
            this.label_exit.Text = "Выход";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            this.label_exit.MouseHover += new System.EventHandler(this.label_exit_MouseHover);
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_menu.Location = new System.Drawing.Point(524, 196);
            this.label_menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(236, 39);
            this.label_menu.TabIndex = 1;
            this.label_menu.Text = "Главное меню";
            this.label_menu.Click += new System.EventHandler(this.label_menu_Click);
            this.label_menu.MouseLeave += new System.EventHandler(this.label_menu_MouseLeave);
            this.label_menu.MouseHover += new System.EventHandler(this.label_menu_MouseHover);
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_start.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_start.Location = new System.Drawing.Point(104, 196);
            this.label_start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(124, 39);
            this.label_start.TabIndex = 0;
            this.label_start.Text = "Запуск";
            this.label_start.Click += new System.EventHandler(this.label_start_Click);
            this.label_start.MouseLeave += new System.EventHandler(this.label_start_MouseLeave);
            this.label_start.MouseHover += new System.EventHandler(this.label_start_MouseHover);
            // 
            // label_university
            // 
            this.label_university.AutoSize = true;
            this.label_university.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_university.ForeColor = System.Drawing.SystemColors.Info;
            this.label_university.Location = new System.Drawing.Point(109, 634);
            this.label_university.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_university.Name = "label_university";
            this.label_university.Size = new System.Drawing.Size(766, 16);
            this.label_university.TabIndex = 5;
            this.label_university.Text = "ФГБОУ ВО \"Сибирский государственный университет имени М.Ф. Решетнева\" Лесосибирск" +
    "ий филиал";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.приемка;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(237, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(901, 331);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1307, 686);
            this.Controls.Add(this.label_university);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Информация о приложении";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_university;
    }
}