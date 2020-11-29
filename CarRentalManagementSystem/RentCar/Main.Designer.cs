﻿
namespace RentCar
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnAdminLogin = new System.Windows.Forms.Button();
            this.CbLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbsize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RentDate = new System.Windows.Forms.DateTimePicker();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSrchData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(560, 42);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(188, 49);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "로그인";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Location = new System.Drawing.Point(767, 42);
            this.BtnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(188, 49);
            this.BtnCreate.TabIndex = 1;
            this.BtnCreate.Text = "회원가입";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnAdminLogin
            // 
            this.BtnAdminLogin.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdminLogin.Location = new System.Drawing.Point(22, 488);
            this.BtnAdminLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAdminLogin.Name = "BtnAdminLogin";
            this.BtnAdminLogin.Size = new System.Drawing.Size(189, 50);
            this.BtnAdminLogin.TabIndex = 2;
            this.BtnAdminLogin.Text = "관리자로그인";
            this.BtnAdminLogin.UseVisualStyleBackColor = true;
            this.BtnAdminLogin.Click += new System.EventHandler(this.BtnAdminLogin_Click);
            // 
            // CbLocation
            // 
            this.CbLocation.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbLocation.FormattingEnabled = true;
            this.CbLocation.Items.AddRange(new object[] {
            "지점1",
            "지점2",
            "지점3"});
            this.CbLocation.Location = new System.Drawing.Point(707, 185);
            this.CbLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbLocation.Name = "CbLocation";
            this.CbLocation.Size = new System.Drawing.Size(248, 41);
            this.CbLocation.TabIndex = 3;
            this.CbLocation.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "지점";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "차 크기";
            this.label2.Visible = false;
            // 
            // Cbsize
            // 
            this.Cbsize.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbsize.FormattingEnabled = true;
            this.Cbsize.Items.AddRange(new object[] {
            "경형",
            "소형",
            "준중형",
            "중형",
            "준대형",
            "대형"});
            this.Cbsize.Location = new System.Drawing.Point(707, 251);
            this.Cbsize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbsize.Name = "Cbsize";
            this.Cbsize.Size = new System.Drawing.Size(248, 41);
            this.Cbsize.TabIndex = 5;
            this.Cbsize.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(576, 312);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "대여일자";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(576, 365);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "반납일자";
            this.label4.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 113);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // RentDate
            // 
            this.RentDate.CalendarFont = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentDate.Location = new System.Drawing.Point(707, 315);
            this.RentDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RentDate.Name = "RentDate";
            this.RentDate.Size = new System.Drawing.Size(249, 28);
            this.RentDate.TabIndex = 18;
            this.RentDate.Visible = false;
            // 
            // ReturnDate
            // 
            this.ReturnDate.Location = new System.Drawing.Point(707, 368);
            this.ReturnDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(249, 28);
            this.ReturnDate.TabIndex = 19;
            this.ReturnDate.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(375, 61);
            this.label5.TabIndex = 20;
            this.label5.Text = "RentCar Page";
            // 
            // btnSrchData
            // 
            this.btnSrchData.Location = new System.Drawing.Point(836, 435);
            this.btnSrchData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSrchData.Name = "btnSrchData";
            this.btnSrchData.Size = new System.Drawing.Size(120, 46);
            this.btnSrchData.TabIndex = 21;
            this.btnSrchData.Text = "검색";
            this.btnSrchData.UseVisualStyleBackColor = true;
            this.btnSrchData.Visible = false;
            this.btnSrchData.Click += new System.EventHandler(this.btnSrchData_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 551);
            this.Controls.Add(this.btnSrchData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.RentDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cbsize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbLocation);
            this.Controls.Add(this.BtnAdminLogin);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtnLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "RentCar";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnAdminLogin;
        private System.Windows.Forms.ComboBox CbLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbsize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker RentDate;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSrchData;
    }
}