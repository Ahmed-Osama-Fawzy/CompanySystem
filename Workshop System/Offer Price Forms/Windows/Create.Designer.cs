namespace Workshop_System.Offer_Price_Forms.Windows
{
    partial class Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sections = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShutterNum = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.AddWindow = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.EditRow = new System.Windows.Forms.Button();
            this.SelectedCustomers = new System.Windows.Forms.DataGridView();
            this.Show = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Printing = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
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
            // Sections
            // 
            this.Sections.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sections.FormattingEnabled = true;
            this.Sections.ItemHeight = 25;
            this.Sections.Items.AddRange(new object[] {
            "السعد",
            "العربية",
            "بي اس كبير",
            "بي اس صغير",
            "تانجو",
            "جامبو",
            "الوميل"});
            this.Sections.Location = new System.Drawing.Point(145, 146);
            this.Sections.Name = "Sections";
            this.Sections.Size = new System.Drawing.Size(268, 29);
            this.Sections.TabIndex = 24;
            this.Sections.SelectedIndexChanged += new System.EventHandler(this.Sections_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 33);
            this.label2.TabIndex = 23;
            this.label2.Text = "نوع الشباك";
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
            // ShutterNum
            // 
            this.ShutterNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShutterNum.Location = new System.Drawing.Point(628, 143);
            this.ShutterNum.Name = "ShutterNum";
            this.ShutterNum.Size = new System.Drawing.Size(260, 31);
            this.ShutterNum.TabIndex = 35;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "منزلق",
            "مفصلي",
            "قلاب",
            "منطبق"});
            this.listBox1.Location = new System.Drawing.Point(1071, 145);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 29);
            this.listBox1.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(930, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 33);
            this.label6.TabIndex = 36;
            this.label6.Text = "شكل الشباك";
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Items.AddRange(new object[] {
            "سنجل",
            "دبل"});
            this.listBox2.Location = new System.Drawing.Point(146, 205);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(268, 29);
            this.listBox2.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(13, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 33);
            this.label7.TabIndex = 38;
            this.label7.Text = "نوع الزجاج";
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
            this.AddWindow.Location = new System.Drawing.Point(146, 263);
            this.AddWindow.Name = "AddWindow";
            this.AddWindow.Padding = new System.Windows.Forms.Padding(7);
            this.AddWindow.Size = new System.Drawing.Size(195, 61);
            this.AddWindow.TabIndex = 42;
            this.AddWindow.Text = "اضافة";
            this.AddWindow.UseVisualStyleBackColor = false;
            // 
            // Clear
            // 
            this.Clear.AutoSize = true;
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Clear.Location = new System.Drawing.Point(936, 263);
            this.Clear.Name = "Clear";
            this.Clear.Padding = new System.Windows.Forms.Padding(7);
            this.Clear.Size = new System.Drawing.Size(206, 61);
            this.Clear.TabIndex = 43;
            this.Clear.Text = "افراغ البايانات";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // EditRow
            // 
            this.EditRow.AutoSize = true;
            this.EditRow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditRow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditRow.Location = new System.Drawing.Point(1147, 263);
            this.EditRow.Name = "EditRow";
            this.EditRow.Padding = new System.Windows.Forms.Padding(7);
            this.EditRow.Size = new System.Drawing.Size(196, 61);
            this.EditRow.TabIndex = 44;
            this.EditRow.Text = "تعديل البيانات";
            this.EditRow.UseVisualStyleBackColor = false;
            // 
            // SelectedCustomers
            // 
            this.SelectedCustomers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SelectedCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedCustomers.GridColor = System.Drawing.SystemColors.Window;
            this.SelectedCustomers.Location = new System.Drawing.Point(19, 351);
            this.SelectedCustomers.Name = "SelectedCustomers";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedCustomers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.SelectedCustomers.Size = new System.Drawing.Size(1313, 296);
            this.SelectedCustomers.TabIndex = 45;
            // 
            // Show
            // 
            this.Show.AutoSize = true;
            this.Show.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Show.Location = new System.Drawing.Point(74, 658);
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
            this.Edit.Location = new System.Drawing.Point(347, 658);
            this.Edit.Name = "Edit";
            this.Edit.Padding = new System.Windows.Forms.Padding(7);
            this.Edit.Size = new System.Drawing.Size(195, 61);
            this.Edit.TabIndex = 47;
            this.Edit.Text = "تعديل";
            this.Edit.UseVisualStyleBackColor = false;
            // 
            // Printing
            // 
            this.Printing.AutoSize = true;
            this.Printing.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Printing.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Printing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Printing.Location = new System.Drawing.Point(628, 658);
            this.Printing.Name = "Printing";
            this.Printing.Padding = new System.Windows.Forms.Padding(7);
            this.Printing.Size = new System.Drawing.Size(195, 61);
            this.Printing.TabIndex = 48;
            this.Printing.Text = "طباعة";
            this.Printing.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit.Location = new System.Drawing.Point(1099, 658);
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
            this.Remove.Location = new System.Drawing.Point(870, 658);
            this.Remove.Name = "Remove";
            this.Remove.Padding = new System.Windows.Forms.Padding(7);
            this.Remove.Size = new System.Drawing.Size(195, 61);
            this.Remove.TabIndex = 50;
            this.Remove.Text = "حذف";
            this.Remove.UseVisualStyleBackColor = false;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Printing);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.SelectedCustomers);
            this.Controls.Add(this.EditRow);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.AddWindow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ShutterNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Sections);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Create";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "انشاء عرض سعر شبابيك";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox Sections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ShutterNum;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.Button AddWindow;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button EditRow;
        private System.Windows.Forms.DataGridView SelectedCustomers;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Printing;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Remove;
    }
}