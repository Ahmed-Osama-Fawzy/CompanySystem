namespace Workshop_System.Offer_Price_Forms.Windows
{
    partial class WindowsOfferPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsOfferPrice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Section = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Desciption = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.AddWindow = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SelectedCustomers = new System.Windows.Forms.DataGridView();
            this.Show = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.SelectedID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Details = new System.Windows.Forms.Button();
            this.RollsNumber = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1354, 733);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Section
            // 
            this.Section.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Section.FormattingEnabled = true;
            this.Section.ItemHeight = 25;
            this.Section.Items.AddRange(new object[] {
            "لا يوجد عناصر يجب اضافة عناصر"});
            this.Section.Location = new System.Drawing.Point(148, 146);
            this.Section.Name = "Section";
            this.Section.Size = new System.Drawing.Size(268, 29);
            this.Section.TabIndex = 24;
            this.Section.SelectedIndexChanged += new System.EventHandler(this.Sections_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 33);
            this.label2.TabIndex = 23;
            this.label2.Text = "فرع الشباك";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 33);
            this.label1.TabIndex = 26;
            this.label1.Text = "الارتفاع";
            // 
            // Height
            // 
            this.Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Height.Location = new System.Drawing.Point(114, 75);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(299, 31);
            this.Height.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(482, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 33);
            this.label3.TabIndex = 28;
            this.label3.Text = "العرض";
            // 
            // Width
            // 
            this.Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Width.Location = new System.Drawing.Point(577, 75);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(311, 31);
            this.Width.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(930, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 33);
            this.label5.TabIndex = 32;
            this.label5.Text = "العدد";
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number.Location = new System.Drawing.Point(1008, 74);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(324, 31);
            this.Number.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(482, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 33);
            this.label4.TabIndex = 33;
            this.label4.Text = "عدد الدرفات";
            // 
            // Type
            // 
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.FormattingEnabled = true;
            this.Type.ItemHeight = 25;
            this.Type.Items.AddRange(new object[] {
            "لا يوجد عناصر يجب اضافة عناصر"});
            this.Type.Location = new System.Drawing.Point(1081, 146);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(261, 29);
            this.Type.TabIndex = 37;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Desciption_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(930, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 33);
            this.label6.TabIndex = 36;
            this.label6.Text = "نوع الشباك";
            // 
            // Desciption
            // 
            this.Desciption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desciption.FormattingEnabled = true;
            this.Desciption.ItemHeight = 25;
            this.Desciption.Items.AddRange(new object[] {
            "لا يوجد عناصر يجب اضافة عناصر"});
            this.Desciption.Location = new System.Drawing.Point(155, 205);
            this.Desciption.Name = "Desciption";
            this.Desciption.Size = new System.Drawing.Size(268, 29);
            this.Desciption.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(13, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 33);
            this.label7.TabIndex = 38;
            this.label7.Text = "حالة الزجاج";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(13, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 33);
            this.label8.TabIndex = 41;
            this.label8.Text = "رقم العميل التعريفي";
            // 
            // CustomerID
            // 
            this.CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID.Location = new System.Drawing.Point(245, 21);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Size = new System.Drawing.Size(285, 31);
            this.CustomerID.TabIndex = 40;
            // 
            // AddWindow
            // 
            this.AddWindow.AutoSize = true;
            this.AddWindow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWindow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddWindow.Location = new System.Drawing.Point(42, 263);
            this.AddWindow.Name = "AddWindow";
            this.AddWindow.Padding = new System.Windows.Forms.Padding(7);
            this.AddWindow.Size = new System.Drawing.Size(195, 61);
            this.AddWindow.TabIndex = 42;
            this.AddWindow.Text = "اضافة";
            this.AddWindow.UseVisualStyleBackColor = false;
            this.AddWindow.Click += new System.EventHandler(this.AddWindow_Click);
            // 
            // Clear
            // 
            this.Clear.AutoSize = true;
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Clear.Location = new System.Drawing.Point(986, 263);
            this.Clear.Name = "Clear";
            this.Clear.Padding = new System.Windows.Forms.Padding(7);
            this.Clear.Size = new System.Drawing.Size(206, 61);
            this.Clear.TabIndex = 43;
            this.Clear.Text = "افراغ البيانات";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // SelectedCustomers
            // 
            this.SelectedCustomers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SelectedCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedCustomers.GridColor = System.Drawing.SystemColors.Window;
            this.SelectedCustomers.Location = new System.Drawing.Point(19, 351);
            this.SelectedCustomers.Name = "SelectedCustomers";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedCustomers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.SelectedCustomers.Size = new System.Drawing.Size(1313, 296);
            this.SelectedCustomers.TabIndex = 45;
            // 
            // Show
            // 
            this.Show.AutoSize = true;
            this.Show.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Show.Location = new System.Drawing.Point(72, 658);
            this.Show.Name = "Show";
            this.Show.Padding = new System.Windows.Forms.Padding(7);
            this.Show.Size = new System.Drawing.Size(195, 61);
            this.Show.TabIndex = 46;
            this.Show.Text = "عرض";
            this.Show.UseVisualStyleBackColor = false;
            // 
            // Edit
            // 
            this.Edit.AutoSize = true;
            this.Edit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Edit.Location = new System.Drawing.Point(675, 658);
            this.Edit.Name = "Edit";
            this.Edit.Padding = new System.Windows.Forms.Padding(7);
            this.Edit.Size = new System.Drawing.Size(195, 61);
            this.Edit.TabIndex = 47;
            this.Edit.Text = "تعديل";
            this.Edit.UseVisualStyleBackColor = false;
            // 
            // Print
            // 
            this.Print.AutoSize = true;
            this.Print.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Print.Location = new System.Drawing.Point(273, 658);
            this.Print.Name = "Print";
            this.Print.Padding = new System.Windows.Forms.Padding(7);
            this.Print.Size = new System.Drawing.Size(195, 61);
            this.Print.TabIndex = 48;
            this.Print.Text = "طباعة";
            this.Print.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit.Location = new System.Drawing.Point(1081, 658);
            this.Exit.Name = "Exit";
            this.Exit.Padding = new System.Windows.Forms.Padding(7);
            this.Exit.Size = new System.Drawing.Size(195, 61);
            this.Exit.TabIndex = 49;
            this.Exit.Text = "خروج";
            this.Exit.UseVisualStyleBackColor = false;
            // 
            // Remove
            // 
            this.Remove.AutoSize = true;
            this.Remove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Remove.Location = new System.Drawing.Point(880, 658);
            this.Remove.Name = "Remove";
            this.Remove.Padding = new System.Windows.Forms.Padding(7);
            this.Remove.Size = new System.Drawing.Size(195, 61);
            this.Remove.TabIndex = 50;
            this.Remove.Text = "حذف";
            this.Remove.UseVisualStyleBackColor = false;
            // 
            // SelectedID
            // 
            this.SelectedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedID.Location = new System.Drawing.Point(1202, 293);
            this.SelectedID.Name = "SelectedID";
            this.SelectedID.ReadOnly = true;
            this.SelectedID.Size = new System.Drawing.Size(111, 31);
            this.SelectedID.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(1198, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 23);
            this.label9.TabIndex = 52;
            this.label9.Text = "رقم العنصر المحدد";
            // 
            // Save
            // 
            this.Save.AutoSize = true;
            this.Save.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Save.Location = new System.Drawing.Point(474, 658);
            this.Save.Name = "Save";
            this.Save.Padding = new System.Windows.Forms.Padding(7);
            this.Save.Size = new System.Drawing.Size(195, 61);
            this.Save.TabIndex = 53;
            this.Save.Text = "حفظ";
            this.Save.UseVisualStyleBackColor = false;
            // 
            // Details
            // 
            this.Details.AutoSize = true;
            this.Details.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Details.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Details.Location = new System.Drawing.Point(780, 263);
            this.Details.Name = "Details";
            this.Details.Padding = new System.Windows.Forms.Padding(7);
            this.Details.Size = new System.Drawing.Size(163, 61);
            this.Details.TabIndex = 58;
            this.Details.Text = "الاختيارات";
            this.Details.UseVisualStyleBackColor = false;
            this.Details.Click += new System.EventHandler(this.Details_Click);
            // 
            // RollsNumber
            // 
            this.RollsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollsNumber.FormattingEnabled = true;
            this.RollsNumber.ItemHeight = 25;
            this.RollsNumber.Items.AddRange(new object[] {
            "لا يوجد عناصر يجب اضافة عناصر"});
            this.RollsNumber.Location = new System.Drawing.Point(643, 146);
            this.RollsNumber.Name = "RollsNumber";
            this.RollsNumber.Size = new System.Drawing.Size(268, 29);
            this.RollsNumber.TabIndex = 59;
            // 
            // WindowsOfferPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.RollsNumber);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SelectedID);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.SelectedCustomers);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.AddWindow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.Desciption);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Section);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowsOfferPrice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "انشاء عرض سعر شبابيك";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Create_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox Section;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox Desciption;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.Button AddWindow;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataGridView SelectedCustomers;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.TextBox SelectedID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Details;
        private System.Windows.Forms.ListBox RollsNumber;
    }
}