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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.User_Photo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.User_Country = new System.Windows.Forms.Label();
            this.User_City = new System.Windows.Forms.Label();
            this.User_Surname = new System.Windows.Forms.Label();
            this.User_Name = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Button_GetInformation = new System.Windows.Forms.Button();
            this.VerhnaPanelka = new System.Windows.Forms.Panel();
            this.ExitApplication = new System.Windows.Forms.Button();
            this.maximase = new System.Windows.Forms.Button();
            this.minimase = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.User_ID = new Bunifu.Framework.UI.BunifuTextbox();
            this.Button_GetToken = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.User_Frends = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.User_Photo)).BeginInit();
            this.VerhnaPanelka.SuspendLayout();
            this.SuspendLayout();
            // 
            // User_Photo
            // 
            this.User_Photo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.User_Photo, BunifuAnimatorNS.DecorationType.None);
            this.User_Photo.Location = new System.Drawing.Point(311, 31);
            this.User_Photo.Name = "User_Photo";
            this.User_Photo.Size = new System.Drawing.Size(231, 226);
            this.User_Photo.TabIndex = 0;
            this.User_Photo.TabStop = false;
            this.User_Photo.Click += new System.EventHandler(this.User_Photo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(282, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ім\'я:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(272, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Прізвище:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(277, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Місто:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(277, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Країна:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // User_Country
            // 
            this.User_Country.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.User_Country, BunifuAnimatorNS.DecorationType.None);
            this.User_Country.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_Country.ForeColor = System.Drawing.Color.White;
            this.User_Country.Location = new System.Drawing.Point(383, 329);
            this.User_Country.Name = "User_Country";
            this.User_Country.Size = new System.Drawing.Size(200, 23);
            this.User_Country.TabIndex = 9;
            this.User_Country.Text = "Немає";
            this.User_Country.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // User_City
            // 
            this.User_City.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.User_City, BunifuAnimatorNS.DecorationType.None);
            this.User_City.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_City.ForeColor = System.Drawing.Color.White;
            this.User_City.Location = new System.Drawing.Point(383, 306);
            this.User_City.Name = "User_City";
            this.User_City.Size = new System.Drawing.Size(200, 23);
            this.User_City.TabIndex = 8;
            this.User_City.Text = "Немає";
            this.User_City.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // User_Surname
            // 
            this.User_Surname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.User_Surname, BunifuAnimatorNS.DecorationType.None);
            this.User_Surname.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_Surname.ForeColor = System.Drawing.Color.White;
            this.User_Surname.Location = new System.Drawing.Point(383, 283);
            this.User_Surname.Name = "User_Surname";
            this.User_Surname.Size = new System.Drawing.Size(200, 23);
            this.User_Surname.TabIndex = 7;
            this.User_Surname.Text = "Немає";
            this.User_Surname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // User_Name
            // 
            this.User_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.User_Name, BunifuAnimatorNS.DecorationType.None);
            this.User_Name.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_Name.ForeColor = System.Drawing.Color.White;
            this.User_Name.Location = new System.Drawing.Point(383, 260);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(200, 23);
            this.User_Name.TabIndex = 6;
            this.User_Name.Text = "Немає";
            this.User_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(343, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 28);
            this.label9.TabIndex = 10;
            this.label9.Text = "UserID:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_GetInformation
            // 
            this.Button_GetInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.Button_GetInformation, BunifuAnimatorNS.DecorationType.None);
            this.Button_GetInformation.FlatAppearance.BorderSize = 0;
            this.Button_GetInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_GetInformation.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_GetInformation.ForeColor = System.Drawing.Color.White;
            this.Button_GetInformation.Location = new System.Drawing.Point(343, 481);
            this.Button_GetInformation.Name = "Button_GetInformation";
            this.Button_GetInformation.Size = new System.Drawing.Size(149, 35);
            this.Button_GetInformation.TabIndex = 12;
            this.Button_GetInformation.Text = "Взяти Інфу";
            this.Button_GetInformation.UseVisualStyleBackColor = true;
            this.Button_GetInformation.Click += new System.EventHandler(this.Button_GetInformation_Click);
            // 
            // VerhnaPanelka
            // 
            this.VerhnaPanelka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.VerhnaPanelka.Controls.Add(this.ExitApplication);
            this.VerhnaPanelka.Controls.Add(this.maximase);
            this.VerhnaPanelka.Controls.Add(this.minimase);
            this.bunifuTransition1.SetDecoration(this.VerhnaPanelka, BunifuAnimatorNS.DecorationType.None);
            this.VerhnaPanelka.Dock = System.Windows.Forms.DockStyle.Top;
            this.VerhnaPanelka.Location = new System.Drawing.Point(0, 0);
            this.VerhnaPanelka.Name = "VerhnaPanelka";
            this.VerhnaPanelka.Size = new System.Drawing.Size(852, 25);
            this.VerhnaPanelka.TabIndex = 13;
            this.VerhnaPanelka.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // ExitApplication
            // 
            this.ExitApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitApplication.BackColor = System.Drawing.Color.Transparent;
            this.ExitApplication.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitApplication.BackgroundImage")));
            this.ExitApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.ExitApplication, BunifuAnimatorNS.DecorationType.None);
            this.ExitApplication.FlatAppearance.BorderSize = 0;
            this.ExitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitApplication.Location = new System.Drawing.Point(831, 3);
            this.ExitApplication.Name = "ExitApplication";
            this.ExitApplication.Size = new System.Drawing.Size(18, 18);
            this.ExitApplication.TabIndex = 2;
            this.ExitApplication.UseVisualStyleBackColor = false;
            this.ExitApplication.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // maximase
            // 
            this.maximase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maximase.BackColor = System.Drawing.Color.Transparent;
            this.maximase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximase.BackgroundImage")));
            this.maximase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.maximase, BunifuAnimatorNS.DecorationType.None);
            this.maximase.FlatAppearance.BorderSize = 0;
            this.maximase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximase.Location = new System.Drawing.Point(813, 3);
            this.maximase.Name = "maximase";
            this.maximase.Size = new System.Drawing.Size(18, 18);
            this.maximase.TabIndex = 1;
            this.maximase.UseVisualStyleBackColor = false;
            this.maximase.Click += new System.EventHandler(this.maximase_Click);
            // 
            // minimase
            // 
            this.minimase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minimase.BackColor = System.Drawing.Color.Transparent;
            this.minimase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimase.BackgroundImage")));
            this.minimase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.minimase, BunifuAnimatorNS.DecorationType.None);
            this.minimase.FlatAppearance.BorderSize = 0;
            this.minimase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimase.Location = new System.Drawing.Point(795, 3);
            this.minimase.Name = "minimase";
            this.minimase.Size = new System.Drawing.Size(18, 18);
            this.minimase.TabIndex = 0;
            this.minimase.UseVisualStyleBackColor = false;
            this.minimase.Click += new System.EventHandler(this.minimase_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.VerhnaPanelka;
            this.bunifuDragControl1.Vertical = true;
           
            // 
            // User_ID
            // 
            this.User_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.User_ID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("User_ID.BackgroundImage")));
            this.User_ID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.User_ID, BunifuAnimatorNS.DecorationType.None);
            this.User_ID.ForeColor = System.Drawing.Color.SeaGreen;
            this.User_ID.Icon = ((System.Drawing.Image)(resources.GetObject("User_ID.Icon")));
            this.User_ID.Location = new System.Drawing.Point(301, 433);
            this.User_ID.Name = "User_ID";
            this.User_ID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.User_ID.Size = new System.Drawing.Size(250, 42);
            this.User_ID.TabIndex = 15;
            this.User_ID.text = "";
            // 
            // Button_GetToken
            // 
            this.Button_GetToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_GetToken.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.Button_GetToken, BunifuAnimatorNS.DecorationType.None);
            this.Button_GetToken.FlatAppearance.BorderSize = 0;
            this.Button_GetToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_GetToken.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_GetToken.ForeColor = System.Drawing.Color.White;
            this.Button_GetToken.Location = new System.Drawing.Point(80, 438);
            this.Button_GetToken.Name = "Button_GetToken";
            this.Button_GetToken.Size = new System.Drawing.Size(179, 37);
            this.Button_GetToken.TabIndex = 5;
            this.Button_GetToken.Text = "Залогінитись";
            this.Button_GetToken.UseVisualStyleBackColor = false;
            this.Button_GetToken.Click += new System.EventHandler(this.Button_GetToken_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(197, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Кількість друзів:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // User_Frends
            // 
            this.User_Frends.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.User_Frends, BunifuAnimatorNS.DecorationType.None);
            this.User_Frends.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_Frends.ForeColor = System.Drawing.Color.White;
            this.User_Frends.Location = new System.Drawing.Point(383, 352);
            this.User_Frends.Name = "User_Frends";
            this.User_Frends.Size = new System.Drawing.Size(200, 23);
            this.User_Frends.TabIndex = 17;
            this.User_Frends.Text = "Немає";
            this.User_Frends.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(852, 520);
            this.Controls.Add(this.User_Frends);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.User_ID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VerhnaPanelka);
            this.Controls.Add(this.Button_GetInformation);
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
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.User_Photo)).EndInit();
            this.VerhnaPanelka.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox User_Photo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label User_Country;
        private System.Windows.Forms.Label User_City;
        private System.Windows.Forms.Label User_Surname;
        private System.Windows.Forms.Label User_Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Button_GetInformation;
        private System.Windows.Forms.Panel VerhnaPanelka;
        private System.Windows.Forms.Button ExitApplication;
        private System.Windows.Forms.Button maximase;
        private System.Windows.Forms.Button minimase;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuTextbox User_ID;
        private System.Windows.Forms.Button Button_GetToken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label User_Frends;
    }
}

