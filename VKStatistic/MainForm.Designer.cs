namespace VKStatistic
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.User_Photo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_GetToken = new System.Windows.Forms.Button();
            this.User_Country = new System.Windows.Forms.Label();
            this.User_City = new System.Windows.Forms.Label();
            this.User_Surname = new System.Windows.Forms.Label();
            this.User_Name = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.User_ID = new System.Windows.Forms.TextBox();
            this.Button_GetInformation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.User_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // User_Photo
            // 
            this.User_Photo.Location = new System.Drawing.Point(12, 12);
            this.User_Photo.Name = "User_Photo";
            this.User_Photo.Size = new System.Drawing.Size(231, 226);
            this.User_Photo.TabIndex = 0;
            this.User_Photo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ім\'я";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(268, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Прізвище";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(268, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Місто";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(268, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Країна";
            // 
            // Button_GetToken
            // 
            this.Button_GetToken.Location = new System.Drawing.Point(271, 104);
            this.Button_GetToken.Name = "Button_GetToken";
            this.Button_GetToken.Size = new System.Drawing.Size(215, 23);
            this.Button_GetToken.TabIndex = 5;
            this.Button_GetToken.Text = "Взяти токен";
            this.Button_GetToken.UseVisualStyleBackColor = true;
            this.Button_GetToken.Click += new System.EventHandler(this.Button_GetToken_Click);
            // 
            // User_Country
            // 
            this.User_Country.Location = new System.Drawing.Point(332, 78);
            this.User_Country.Name = "User_Country";
            this.User_Country.Size = new System.Drawing.Size(154, 23);
            this.User_Country.TabIndex = 9;
            this.User_Country.Text = "Немає";
            // 
            // User_City
            // 
            this.User_City.Location = new System.Drawing.Point(332, 55);
            this.User_City.Name = "User_City";
            this.User_City.Size = new System.Drawing.Size(154, 23);
            this.User_City.TabIndex = 8;
            this.User_City.Text = "Немає";
            // 
            // User_Surname
            // 
            this.User_Surname.Location = new System.Drawing.Point(332, 32);
            this.User_Surname.Name = "User_Surname";
            this.User_Surname.Size = new System.Drawing.Size(154, 23);
            this.User_Surname.TabIndex = 7;
            this.User_Surname.Text = "Немає";
            // 
            // User_Name
            // 
            this.User_Name.Location = new System.Drawing.Point(332, 9);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(154, 23);
            this.User_Name.TabIndex = 6;
            this.User_Name.Text = "Немає";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(679, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "UserID:";
            // 
            // User_ID
            // 
            this.User_ID.Location = new System.Drawing.Point(728, 6);
            this.User_ID.Name = "User_ID";
            this.User_ID.Size = new System.Drawing.Size(100, 20);
            this.User_ID.TabIndex = 11;
            // 
            // Button_GetInformation
            // 
            this.Button_GetInformation.Location = new System.Drawing.Point(682, 35);
            this.Button_GetInformation.Name = "Button_GetInformation";
            this.Button_GetInformation.Size = new System.Drawing.Size(101, 23);
            this.Button_GetInformation.TabIndex = 12;
            this.Button_GetInformation.Text = "Взяти Інфу";
            this.Button_GetInformation.UseVisualStyleBackColor = true;
            this.Button_GetInformation.Click += new System.EventHandler(this.Button_GetInformation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 250);
            this.Controls.Add(this.Button_GetInformation);
            this.Controls.Add(this.User_ID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.User_Country);
            this.Controls.Add(this.User_City);
            this.Controls.Add(this.User_Surname);
            this.Controls.Add(this.User_Name);
            this.Controls.Add(this.Button_GetToken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.User_Photo);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.User_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox User_Photo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_GetToken;
        private System.Windows.Forms.Label User_Country;
        private System.Windows.Forms.Label User_City;
        private System.Windows.Forms.Label User_Surname;
        private System.Windows.Forms.Label User_Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox User_ID;
        private System.Windows.Forms.Button Button_GetInformation;
    }
}

