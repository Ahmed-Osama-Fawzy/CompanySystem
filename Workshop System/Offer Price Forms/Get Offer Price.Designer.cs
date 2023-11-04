namespace Workshop_System.Offer_Price_Forms
{
    partial class Get_Offer_Price
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Get_Offer_Price));
            this.label5 = new System.Windows.Forms.Label();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.SelectedCustomers = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Sections = new System.Windows.Forms.ListBox();
            this.NextStep = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 33);
            this.label5.TabIndex = 17;
            this.label5.Text = "ابحث عن عميل";
            // 
            // SearchInput
            // 
            this.SearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchInput.Location = new System.Drawing.Point(238, 19);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(395, 31);
            this.SearchInput.TabIndex = 16;
            this.SearchInput.TextChanged += new System.EventHandler(this.SearchInput_TextChanged);
            // 
            // SelectedCustomers
            // 
            this.SelectedCustomers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SelectedCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedCustomers.GridColor = System.Drawing.SystemColors.Window;
            this.SelectedCustomers.Location = new System.Drawing.Point(12, 78);
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
            this.SelectedCustomers.Size = new System.Drawing.Size(1150, 149);
            this.SelectedCustomers.TabIndex = 15;
            this.SelectedCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectedCustomers_CellContentClick);
            this.SelectedCustomers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectedCustomers_RowHeaderMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1354, 733);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "رقم العميل التعريفي";
            // 
            // CustomerID
            // 
            this.CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID.Location = new System.Drawing.Point(238, 255);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Size = new System.Drawing.Size(285, 31);
            this.CustomerID.TabIndex = 18;
            // 
            // AddCustomer
            // 
            this.AddCustomer.AutoSize = true;
            this.AddCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddCustomer.Location = new System.Drawing.Point(1165, 114);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Padding = new System.Windows.Forms.Padding(7);
            this.AddCustomer.Size = new System.Drawing.Size(177, 61);
            this.AddCustomer.TabIndex = 20;
            this.AddCustomer.Text = "اضافة عميل";
            this.AddCustomer.UseVisualStyleBackColor = false;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 33);
            this.label2.TabIndex = 21;
            this.label2.Text = "نوع العمل المطلوب";
            // 
            // Sections
            // 
            this.Sections.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sections.FormattingEnabled = true;
            this.Sections.ItemHeight = 25;
            this.Sections.Items.AddRange(new object[] {
            "شبابيك",
            "مطبخ",
            "وحدات منفصلة",
            "تند",
            "ابواب",
            "شيش حصيرة",
            "صيانة",
            "اخري"});
            this.Sections.Location = new System.Drawing.Point(238, 333);
            this.Sections.Name = "Sections";
            this.Sections.Size = new System.Drawing.Size(285, 29);
            this.Sections.TabIndex = 22;
            // 
            // NextStep
            // 
            this.NextStep.AutoSize = true;
            this.NextStep.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextStep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NextStep.Location = new System.Drawing.Point(106, 658);
            this.NextStep.Name = "NextStep";
            this.NextStep.Padding = new System.Windows.Forms.Padding(7);
            this.NextStep.Size = new System.Drawing.Size(195, 61);
            this.NextStep.TabIndex = 23;
            this.NextStep.Text = "الخطوة التالية";
            this.NextStep.UseVisualStyleBackColor = false;
            this.NextStep.Click += new System.EventHandler(this.NextStep_Click);
            // 
            // Clear
            // 
            this.Clear.AutoSize = true;
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Clear.Location = new System.Drawing.Point(1097, 658);
            this.Clear.Name = "Clear";
            this.Clear.Padding = new System.Windows.Forms.Padding(7);
            this.Clear.Size = new System.Drawing.Size(198, 61);
            this.Clear.TabIndex = 24;
            this.Clear.Text = "افراغ البيانات";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Get_Offer_Price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.NextStep);
            this.Controls.Add(this.Sections);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.SelectedCustomers);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Get_Offer_Price";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = " استخراج عرض سعر";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Get_Offer_Price_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.DataGridView SelectedCustomers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Sections;
        private System.Windows.Forms.Button NextStep;
        private System.Windows.Forms.Button Clear;
    }
}