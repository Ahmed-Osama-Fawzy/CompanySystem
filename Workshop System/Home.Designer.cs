﻿namespace Workshop_System
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Customers = new System.Windows.Forms.Button();
            this.Materials = new System.Windows.Forms.Button();
            this.GetOfferPrice = new System.Windows.Forms.Button();
            this.GetIndextion = new System.Windows.Forms.Button();
            this.CWorks = new System.Windows.Forms.Button();
            this.Supliers = new System.Windows.Forms.Button();
            this.Emploess = new System.Windows.Forms.Button();
            this.Cars = new System.Windows.Forms.Button();
            this.Sections = new System.Windows.Forms.Button();
            this.Contract = new System.Windows.Forms.Button();
            this.Treasury = new System.Windows.Forms.Button();
            this.Commitments = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.AddNewWork = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.PromoCodes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.Day = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(192, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(991, 758);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Customers
            // 
            this.Customers.AutoSize = true;
            this.Customers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Customers.Location = new System.Drawing.Point(1047, 218);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(7);
            this.Customers.Size = new System.Drawing.Size(279, 61);
            this.Customers.TabIndex = 1;
            this.Customers.Text = "العملاء";
            this.Customers.UseVisualStyleBackColor = false;
            this.Customers.Click += new System.EventHandler(this.Customer_Click);
            // 
            // Materials
            // 
            this.Materials.AutoSize = true;
            this.Materials.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Materials.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Materials.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Materials.Location = new System.Drawing.Point(1047, 84);
            this.Materials.Name = "Materials";
            this.Materials.Padding = new System.Windows.Forms.Padding(7);
            this.Materials.Size = new System.Drawing.Size(279, 61);
            this.Materials.TabIndex = 2;
            this.Materials.Text = "الخامات";
            this.Materials.UseVisualStyleBackColor = false;
            this.Materials.Click += new System.EventHandler(this.Prices_Click);
            // 
            // GetOfferPrice
            // 
            this.GetOfferPrice.AutoSize = true;
            this.GetOfferPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GetOfferPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetOfferPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GetOfferPrice.Location = new System.Drawing.Point(389, 84);
            this.GetOfferPrice.Name = "GetOfferPrice";
            this.GetOfferPrice.Padding = new System.Windows.Forms.Padding(7);
            this.GetOfferPrice.Size = new System.Drawing.Size(181, 61);
            this.GetOfferPrice.TabIndex = 3;
            this.GetOfferPrice.Text = " عرض سعر";
            this.GetOfferPrice.UseVisualStyleBackColor = false;
            this.GetOfferPrice.Click += new System.EventHandler(this.GetOfferPrice_Click);
            // 
            // GetIndextion
            // 
            this.GetIndextion.AutoSize = true;
            this.GetIndextion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GetIndextion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetIndextion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GetIndextion.Location = new System.Drawing.Point(612, 84);
            this.GetIndextion.Name = "GetIndextion";
            this.GetIndextion.Padding = new System.Windows.Forms.Padding(7);
            this.GetIndextion.Size = new System.Drawing.Size(144, 61);
            this.GetIndextion.TabIndex = 4;
            this.GetIndextion.Text = " مقايسة";
            this.GetIndextion.UseVisualStyleBackColor = false;
            // 
            // CWorks
            // 
            this.CWorks.AutoSize = true;
            this.CWorks.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CWorks.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CWorks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CWorks.Location = new System.Drawing.Point(71, 352);
            this.CWorks.Name = "CWorks";
            this.CWorks.Padding = new System.Windows.Forms.Padding(7);
            this.CWorks.Size = new System.Drawing.Size(279, 61);
            this.CWorks.TabIndex = 5;
            this.CWorks.Text = "المشاريع";
            this.CWorks.UseVisualStyleBackColor = false;
            // 
            // Supliers
            // 
            this.Supliers.AutoSize = true;
            this.Supliers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Supliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supliers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Supliers.Location = new System.Drawing.Point(71, 84);
            this.Supliers.Name = "Supliers";
            this.Supliers.Padding = new System.Windows.Forms.Padding(7);
            this.Supliers.Size = new System.Drawing.Size(279, 61);
            this.Supliers.TabIndex = 6;
            this.Supliers.Text = " الموردين";
            this.Supliers.UseVisualStyleBackColor = false;
            // 
            // Emploess
            // 
            this.Emploess.AutoSize = true;
            this.Emploess.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Emploess.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emploess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Emploess.Location = new System.Drawing.Point(71, 218);
            this.Emploess.Name = "Emploess";
            this.Emploess.Padding = new System.Windows.Forms.Padding(7);
            this.Emploess.Size = new System.Drawing.Size(279, 61);
            this.Emploess.TabIndex = 7;
            this.Emploess.Text = "الموظفين";
            this.Emploess.UseVisualStyleBackColor = false;
            // 
            // Cars
            // 
            this.Cars.AutoSize = true;
            this.Cars.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cars.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cars.Location = new System.Drawing.Point(71, 151);
            this.Cars.Name = "Cars";
            this.Cars.Padding = new System.Windows.Forms.Padding(7);
            this.Cars.Size = new System.Drawing.Size(279, 61);
            this.Cars.TabIndex = 8;
            this.Cars.Text = " السيارات";
            this.Cars.UseVisualStyleBackColor = false;
            // 
            // Sections
            // 
            this.Sections.AutoSize = true;
            this.Sections.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sections.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sections.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sections.Location = new System.Drawing.Point(71, 486);
            this.Sections.Name = "Sections";
            this.Sections.Padding = new System.Windows.Forms.Padding(7);
            this.Sections.Size = new System.Drawing.Size(279, 61);
            this.Sections.TabIndex = 9;
            this.Sections.Text = "ادارة المهام";
            this.Sections.UseVisualStyleBackColor = false;
            // 
            // Contract
            // 
            this.Contract.AutoSize = true;
            this.Contract.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contract.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Contract.Location = new System.Drawing.Point(1047, 352);
            this.Contract.Name = "Contract";
            this.Contract.Padding = new System.Windows.Forms.Padding(7);
            this.Contract.Size = new System.Drawing.Size(279, 61);
            this.Contract.TabIndex = 10;
            this.Contract.Text = "العقد";
            this.Contract.UseVisualStyleBackColor = false;
            // 
            // Treasury
            // 
            this.Treasury.AutoSize = true;
            this.Treasury.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Treasury.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Treasury.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Treasury.Location = new System.Drawing.Point(71, 285);
            this.Treasury.Name = "Treasury";
            this.Treasury.Padding = new System.Windows.Forms.Padding(7);
            this.Treasury.Size = new System.Drawing.Size(279, 61);
            this.Treasury.TabIndex = 11;
            this.Treasury.Text = " الخزنة";
            this.Treasury.UseVisualStyleBackColor = false;
            this.Treasury.Click += new System.EventHandler(this.button1_Click);
            // 
            // Commitments
            // 
            this.Commitments.AutoSize = true;
            this.Commitments.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Commitments.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commitments.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Commitments.Location = new System.Drawing.Point(71, 419);
            this.Commitments.Name = "Commitments";
            this.Commitments.Padding = new System.Windows.Forms.Padding(7);
            this.Commitments.Size = new System.Drawing.Size(279, 61);
            this.Commitments.TabIndex = 12;
            this.Commitments.Text = "الالتزامات";
            this.Commitments.UseVisualStyleBackColor = false;
            // 
            // History
            // 
            this.History.AutoSize = true;
            this.History.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.History.Location = new System.Drawing.Point(71, 620);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(7);
            this.History.Size = new System.Drawing.Size(279, 61);
            this.History.TabIndex = 13;
            this.History.Text = " السجلات";
            this.History.UseVisualStyleBackColor = false;
            // 
            // AddNewWork
            // 
            this.AddNewWork.AutoSize = true;
            this.AddNewWork.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddNewWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewWork.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddNewWork.Location = new System.Drawing.Point(822, 84);
            this.AddNewWork.Name = "AddNewWork";
            this.AddNewWork.Padding = new System.Windows.Forms.Padding(7);
            this.AddNewWork.Size = new System.Drawing.Size(161, 61);
            this.AddNewWork.TabIndex = 14;
            this.AddNewWork.Text = " عمل جديد";
            this.AddNewWork.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title.Location = new System.Drawing.Point(102, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(547, 39);
            this.Title.TabIndex = 15;
            this.Title.Text = "ELESRAA FOR ALUMINUIM PRODUCTS";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Time.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Time.Location = new System.Drawing.Point(694, 20);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(143, 39);
            this.Time.TabIndex = 16;
            this.Time.Text = "ELESRAA";
            this.Time.Click += new System.EventHandler(this.label1_Click);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Date.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Date.Location = new System.Drawing.Point(1049, 20);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(150, 39);
            this.Date.TabIndex = 17;
            this.Date.Text = "ELESRAA ";
            // 
            // PromoCodes
            // 
            this.PromoCodes.AutoSize = true;
            this.PromoCodes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PromoCodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromoCodes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PromoCodes.Location = new System.Drawing.Point(762, 658);
            this.PromoCodes.Name = "PromoCodes";
            this.PromoCodes.Padding = new System.Windows.Forms.Padding(7);
            this.PromoCodes.Size = new System.Drawing.Size(279, 61);
            this.PromoCodes.TabIndex = 18;
            this.PromoCodes.Text = "اكواد الخصم";
            this.PromoCodes.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(1047, 151);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(7);
            this.button2.Size = new System.Drawing.Size(279, 61);
            this.button2.TabIndex = 19;
            this.button2.Text = "التخصيمات";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(762, 591);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(7);
            this.button1.Size = new System.Drawing.Size(279, 61);
            this.button1.TabIndex = 20;
            this.button1.Text = "عروض السعر";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(1047, 620);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(7);
            this.button3.Size = new System.Drawing.Size(279, 61);
            this.button3.TabIndex = 21;
            this.button3.Text = "المقايسات";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(1047, 419);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(7);
            this.button4.Size = new System.Drawing.Size(279, 61);
            this.button4.TabIndex = 22;
            this.button4.Text = "المستخدمين";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(356, 658);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(7);
            this.button5.Size = new System.Drawing.Size(279, 61);
            this.button5.TabIndex = 23;
            this.button5.Text = "الوظائف";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(356, 591);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(7);
            this.button6.Size = new System.Drawing.Size(279, 61);
            this.button6.TabIndex = 24;
            this.button6.Text = "الاقتراحات";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(1047, 285);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(7);
            this.button7.Size = new System.Drawing.Size(279, 61);
            this.button7.TabIndex = 25;
            this.button7.Text = "النماذج";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Location = new System.Drawing.Point(1047, 486);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(7);
            this.button8.Size = new System.Drawing.Size(279, 61);
            this.button8.TabIndex = 26;
            this.button8.Text = "نسبة الارباح";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Location = new System.Drawing.Point(1047, 553);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(7);
            this.button9.Size = new System.Drawing.Size(279, 61);
            this.button9.TabIndex = 27;
            this.button9.Text = "الشروط و الاحكام";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Location = new System.Drawing.Point(71, 553);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(7);
            this.button10.Size = new System.Drawing.Size(279, 61);
            this.button10.TabIndex = 28;
            this.button10.Text = "ادارة التقارير";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Day.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Day.Location = new System.Drawing.Point(874, 20);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(143, 39);
            this.Day.TabIndex = 29;
            this.Day.Text = "ELESRAA";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PromoCodes);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.AddNewWork);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Commitments);
            this.Controls.Add(this.Treasury);
            this.Controls.Add(this.Contract);
            this.Controls.Add(this.Sections);
            this.Controls.Add(this.Cars);
            this.Controls.Add(this.Emploess);
            this.Controls.Add(this.Supliers);
            this.Controls.Add(this.CWorks);
            this.Controls.Add(this.GetIndextion);
            this.Controls.Add(this.GetOfferPrice);
            this.Controls.Add(this.Materials);
            this.Controls.Add(this.Customers);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Customers;
        private System.Windows.Forms.Button Materials;
        private System.Windows.Forms.Button GetOfferPrice;
        private System.Windows.Forms.Button GetIndextion;
        private System.Windows.Forms.Button CWorks;
        private System.Windows.Forms.Button Supliers;
        private System.Windows.Forms.Button Emploess;
        private System.Windows.Forms.Button Cars;
        private System.Windows.Forms.Button Sections;
        private System.Windows.Forms.Button Contract;
        private System.Windows.Forms.Button Treasury;
        private System.Windows.Forms.Button Commitments;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Button AddNewWork;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button PromoCodes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Timer timer1;
    }
}