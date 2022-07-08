
namespace WindowsFormsApp1.View
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_exit = new System.Windows.Forms.Label();
            this.label_information = new System.Windows.Forms.Label();
            this.label_menu = new System.Windows.Forms.Label();
            this.Open_start = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label_university = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_main.Controls.Add(this.label_exit);
            this.panel_main.Controls.Add(this.label_information);
            this.panel_main.Controls.Add(this.label_menu);
            this.panel_main.Location = new System.Drawing.Point(1, 517);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1308, 81);
            this.panel_main.TabIndex = 3;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exit.Location = new System.Drawing.Point(1039, 20);
            this.label_exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(116, 39);
            this.label_exit.TabIndex = 2;
            this.label_exit.Text = "Выход";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // label_information
            // 
            this.label_information.AutoSize = true;
            this.label_information.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_information.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_information.Location = new System.Drawing.Point(524, 20);
            this.label_information.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_information.Name = "label_information";
            this.label_information.Size = new System.Drawing.Size(230, 39);
            this.label_information.TabIndex = 1;
            this.label_information.Text = "Информация";
            this.label_information.Click += new System.EventHandler(this.label_information_Click);
            this.label_information.MouseLeave += new System.EventHandler(this.label_information_MouseLeave);
            this.label_information.MouseHover += new System.EventHandler(this.label_information_MouseHover);
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_menu.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_menu.Location = new System.Drawing.Point(103, 20);
            this.label_menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(236, 39);
            this.label_menu.TabIndex = 0;
            this.label_menu.Text = "Главное меню";
            this.label_menu.Click += new System.EventHandler(this.label_menu_Click);
            this.label_menu.MouseLeave += new System.EventHandler(this.label_menu_MouseLeave);
            this.label_menu.MouseHover += new System.EventHandler(this.label_menu_MouseHover);
            // 
            // Open_start
            // 
            this.Open_start.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Open_start.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Open_start.Location = new System.Drawing.Point(479, 15);
            this.Open_start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Open_start.Name = "Open_start";
            this.Open_start.Size = new System.Drawing.Size(157, 47);
            this.Open_start.TabIndex = 4;
            this.Open_start.Text = "Запустить";
            this.Open_start.UseVisualStyleBackColor = false;
            this.Open_start.Click += new System.EventHandler(this.Open_start_Click);
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save_button.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_button.Location = new System.Drawing.Point(644, 15);
            this.Save_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(157, 47);
            this.Save_button.TabIndex = 5;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 69);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(420, 440);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label_university
            // 
            this.label_university.AutoSize = true;
            this.label_university.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_university.ForeColor = System.Drawing.SystemColors.Info;
            this.label_university.Location = new System.Drawing.Point(108, 633);
            this.label_university.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_university.Name = "label_university";
            this.label_university.Size = new System.Drawing.Size(766, 16);
            this.label_university.TabIndex = 7;
            this.label_university.Text = "ФГБОУ ВО \"Сибирский государственный университет имени М.Ф. Решетнева\" Лесосибирск" +
    "ий филиал";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(445, 69);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(420, 440);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(875, 69);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(420, 440);
            this.richTextBox3.TabIndex = 9;
            this.richTextBox3.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1307, 686);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label_university);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Open_start);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Информационный лист";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label_information;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Button Open_start;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label_university;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}