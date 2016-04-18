using System.ComponentModel;

namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.Klucz = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Adres_strony = new System.Windows.Forms.TextBox();
            this.lista_zadan = new System.Windows.Forms.ListBox();
            this.nazwaBox = new System.Windows.Forms.TextBox();
            this.Nazwa = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tabPageWheather = new System.Windows.Forms.TabControl();
            this.tabPageMail = new System.Windows.Forms.TabPage();
            this.tabPageWheather1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelNameCity = new System.Windows.Forms.Label();
            this.tabControlAction = new System.Windows.Forms.TabControl();
            this.tabPageShow = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPageWheather.SuspendLayout();
            this.tabPageMail.SuspendLayout();
            this.tabPageWheather1.SuspendLayout();
            this.tabControlAction.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Klucz
            // 
            this.Klucz.Location = new System.Drawing.Point(16, 85);
            this.Klucz.Name = "Klucz";
            this.Klucz.Size = new System.Drawing.Size(118, 22);
            this.Klucz.TabIndex = 1;
            this.Klucz.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(455, 163);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(79, 30);
            this.start.TabIndex = 2;
            this.start.Text = "Wykonaj!";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.WykonajZadaniaZListy);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(16, 32);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(118, 22);
            this.Email.TabIndex = 3;
            this.Email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.Location = new System.Drawing.Point(282, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj_lista";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.start_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(665, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Deserialize";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Deserialize);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(665, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 22);
            this.button3.TabIndex = 7;
            this.button3.Text = "Serialize";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Serialize);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(540, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "Czyść";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.WyczyscListe);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "AdresStrony";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Klucz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Adres_strony
            // 
            this.Adres_strony.Location = new System.Drawing.Point(54, 38);
            this.Adres_strony.Name = "Adres_strony";
            this.Adres_strony.Size = new System.Drawing.Size(227, 22);
            this.Adres_strony.TabIndex = 12;
            this.Adres_strony.TextChanged += new System.EventHandler(this.Adres_strony_TextChanged);
            // 
            // lista_zadan
            // 
            this.lista_zadan.FormattingEnabled = true;
            this.lista_zadan.Location = new System.Drawing.Point(458, 35);
            this.lista_zadan.Name = "lista_zadan";
            this.lista_zadan.Size = new System.Drawing.Size(292, 95);
            this.lista_zadan.TabIndex = 13;
            this.lista_zadan.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // nazwaBox
            // 
            this.nazwaBox.Location = new System.Drawing.Point(16, 140);
            this.nazwaBox.Name = "nazwaBox";
            this.nazwaBox.Size = new System.Drawing.Size(117, 22);
            this.nazwaBox.TabIndex = 14;
            this.nazwaBox.TextChanged += new System.EventHandler(this.nazwaBox_TextChanged_1);
            // 
            // Nazwa
            // 
            this.Nazwa.AutoSize = true;
            this.Nazwa.Location = new System.Drawing.Point(19, 123);
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Size = new System.Drawing.Size(43, 15);
            this.Nazwa.TabIndex = 15;
            this.Nazwa.Text = "Nazwa";
            this.Nazwa.Click += new System.EventHandler(this.Nazwa_Click);
            // 
            // tabPageWheather
            // 
            this.tabPageWheather.Controls.Add(this.tabPageMail);
            this.tabPageWheather.Controls.Add(this.tabPageWheather1);
            this.tabPageWheather.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageWheather.Location = new System.Drawing.Point(2, 24);
            this.tabPageWheather.Name = "tabPageWheather";
            this.tabPageWheather.SelectedIndex = 0;
            this.tabPageWheather.Size = new System.Drawing.Size(354, 212);
            this.tabPageWheather.TabIndex = 16;
            // 
            // tabPageMail
            // 
            this.tabPageMail.Controls.Add(this.Email);
            this.tabPageMail.Controls.Add(this.Nazwa);
            this.tabPageMail.Controls.Add(this.Klucz);
            this.tabPageMail.Controls.Add(this.label2);
            this.tabPageMail.Controls.Add(this.label1);
            this.tabPageMail.Controls.Add(this.nazwaBox);
            this.tabPageMail.Location = new System.Drawing.Point(4, 24);
            this.tabPageMail.Name = "tabPageMail";
            this.tabPageMail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMail.Size = new System.Drawing.Size(346, 184);
            this.tabPageMail.TabIndex = 0;
            this.tabPageMail.Text = "Mail";
            this.tabPageMail.UseVisualStyleBackColor = true;
            this.tabPageMail.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPageWheather1
            // 
            this.tabPageWheather1.Controls.Add(this.labelNameCity);
            this.tabPageWheather1.Controls.Add(this.textBoxCity);
            this.tabPageWheather1.Controls.Add(this.button5);
            this.tabPageWheather1.Location = new System.Drawing.Point(4, 24);
            this.tabPageWheather1.Name = "tabPageWheather1";
            this.tabPageWheather1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWheather1.Size = new System.Drawing.Size(346, 184);
            this.tabPageWheather1.TabIndex = 1;
            this.tabPageWheather1.Text = "Wheather";
            this.tabPageWheather1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(134, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 62);
            this.button5.TabIndex = 2;
            this.button5.Text = "Check the weather";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(31, 51);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(176, 22);
            this.textBoxCity.TabIndex = 3;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
            // 
            // labelNameCity
            // 
            this.labelNameCity.AutoSize = true;
            this.labelNameCity.Location = new System.Drawing.Point(22, 33);
            this.labelNameCity.Name = "labelNameCity";
            this.labelNameCity.Size = new System.Drawing.Size(112, 15);
            this.labelNameCity.TabIndex = 4;
            this.labelNameCity.Text = "Podaj nazwe miasta:";
            // 
            // tabControlAction
            // 
            this.tabControlAction.Controls.Add(this.tabPageShow);
            this.tabControlAction.Controls.Add(this.tabPage2);
            this.tabControlAction.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControlAction.Location = new System.Drawing.Point(17, 291);
            this.tabControlAction.Name = "tabControlAction";
            this.tabControlAction.SelectedIndex = 0;
            this.tabControlAction.Size = new System.Drawing.Size(339, 128);
            this.tabControlAction.TabIndex = 17;
            // 
            // tabPageShow
            // 
            this.tabPageShow.Location = new System.Drawing.Point(4, 25);
            this.tabPageShow.Name = "tabPageShow";
            this.tabPageShow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShow.Size = new System.Drawing.Size(331, 99);
            this.tabPageShow.TabIndex = 0;
            this.tabPageShow.Text = "Show";
            this.tabPageShow.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Adres_strony);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(331, 99);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mail";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 446);
            this.Controls.Add(this.tabControlAction);
            this.Controls.Add(this.tabPageWheather);
            this.Controls.Add(this.lista_zadan);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "JTTT 3.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPageWheather.ResumeLayout(false);
            this.tabPageMail.ResumeLayout(false);
            this.tabPageMail.PerformLayout();
            this.tabPageWheather1.ResumeLayout(false);
            this.tabPageWheather1.PerformLayout();
            this.tabControlAction.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Klucz;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Adres_strony;
        private System.Windows.Forms.ListBox lista_zadan;
        private System.Windows.Forms.TextBox nazwaBox;
        private System.Windows.Forms.Label Nazwa;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TabControl tabPageWheather;
        private System.Windows.Forms.TabPage tabPageMail;
        private System.Windows.Forms.TabPage tabPageWheather1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelNameCity;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TabControl tabControlAction;
        private System.Windows.Forms.TabPage tabPageShow;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

