namespace Workshop_System
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectedCustomers = new System.Windows.Forms.DataGridView();
            this.CustomRemove = new System.Windows.Forms.Button();
            this.CustomEdit = new System.Windows.Forms.Button();
            this.CustomShow = new System.Windows.Forms.Button();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.ShowCustomer = new System.Windows.Forms.Button();
            this.ShowCustomers = new System.Windows.Forms.Button();
            this.RemoveCustomer = new System.Windows.Forms.Button();
            this.ModifyCustomer = new System.Windows.Forms.Button();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectedID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1354, 733);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SelectedCustomers
            // 
            this.SelectedCustomers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SelectedCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedCustomers.GridColor = System.Drawing.SystemColors.Window;
            this.SelectedCustomers.Location = new System.Drawing.Point(12, 482);
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
            this.SelectedCustomers.Size = new System.Drawing.Size(1150, 237);
            this.SelectedCustomers.TabIndex = 1;
            this.SelectedCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectedCustomers_CellContentClick);
            this.SelectedCustomers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectedCustomers_RowHeaderMouseClick);
            // 
            // CustomRemove
            // 
            this.CustomRemove.AutoSize = true;
            this.CustomRemove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomRemove.Location = new System.Drawing.Point(1184, 591);
            this.CustomRemove.Name = "CustomRemove";
            this.CustomRemove.Padding = new System.Windows.Forms.Padding(7);
            this.CustomRemove.Size = new System.Drawing.Size(137, 61);
            this.CustomRemove.TabIndex = 2;
            this.CustomRemove.Text = "حذف";
            this.CustomRemove.UseVisualStyleBackColor = false;
            this.CustomRemove.Click += new System.EventHandler(this.CustomRemove_Click);
            // 
            // CustomEdit
            // 
            this.CustomEdit.AutoSize = true;
            this.CustomEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomEdit.Location = new System.Drawing.Point(1184, 658);
            this.CustomEdit.Name = "CustomEdit";
            this.CustomEdit.Padding = new System.Windows.Forms.Padding(7);
            this.CustomEdit.Size = new System.Drawing.Size(137, 61);
            this.CustomEdit.TabIndex = 3;
            this.CustomEdit.Text = "تعديل";
            this.CustomEdit.UseVisualStyleBackColor = false;
            this.CustomEdit.Click += new System.EventHandler(this.CustomEdit_Click);
            // 
            // CustomShow
            // 
            this.CustomShow.AutoSize = true;
            this.CustomShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomShow.Location = new System.Drawing.Point(1184, 524);
            this.CustomShow.Name = "CustomShow";
            this.CustomShow.Padding = new System.Windows.Forms.Padding(7);
            this.CustomShow.Size = new System.Drawing.Size(137, 61);
            this.CustomShow.TabIndex = 5;
            this.CustomShow.Text = "عرض";
            this.CustomShow.UseVisualStyleBackColor = false;
            this.CustomShow.Click += new System.EventHandler(this.CustomShow_Click);
            // 
            // SearchInput
            // 
            this.SearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchInput.Location = new System.Drawing.Point(238, 423);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(395, 31);
            this.SearchInput.TabIndex = 6;
            this.SearchInput.TextChanged += new System.EventHandler(this.SearchInput_TextChanged);
            // 
            // ShowCustomer
            // 
            this.ShowCustomer.AutoSize = true;
            this.ShowCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowCustomer.Location = new System.Drawing.Point(1064, 65);
            this.ShowCustomer.Name = "ShowCustomer";
            this.ShowCustomer.Padding = new System.Windows.Forms.Padding(7);
            this.ShowCustomer.Size = new System.Drawing.Size(257, 61);
            this.ShowCustomer.TabIndex = 7;
            this.ShowCustomer.Text = "عرض بيانات عميل";
            this.ShowCustomer.UseVisualStyleBackColor = false;
            this.ShowCustomer.Click += new System.EventHandler(this.ShowCustomer_Click);
            // 
            // ShowCustomers
            // 
            this.ShowCustomers.AutoSize = true;
            this.ShowCustomers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCustomers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowCustomers.Location = new System.Drawing.Point(42, 219);
            this.ShowCustomers.Name = "ShowCustomers";
            this.ShowCustomers.Padding = new System.Windows.Forms.Padding(7);
            this.ShowCustomers.Size = new System.Drawing.Size(201, 61);
            this.ShowCustomers.TabIndex = 8;
            this.ShowCustomers.Text = "عرض العملاء";
            this.ShowCustomers.UseVisualStyleBackColor = false;
            this.ShowCustomers.Click += new System.EventHandler(this.ShowCustomers_Click);
            // 
            // RemoveCustomer
            // 
            this.RemoveCustomer.AutoSize = true;
            this.RemoveCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveCustomer.Location = new System.Drawing.Point(1156, 219);
            this.RemoveCustomer.Name = "RemoveCustomer";
            this.RemoveCustomer.Padding = new System.Windows.Forms.Padding(7);
            this.RemoveCustomer.Size = new System.Drawing.Size(165, 61);
            this.RemoveCustomer.TabIndex = 9;
            this.RemoveCustomer.Text = "حذف عميل";
            this.RemoveCustomer.UseVisualStyleBackColor = false;
            this.RemoveCustomer.Click += new System.EventHandler(this.RemoveCustomer_Click);
            // 
            // ModifyCustomer
            // 
            this.ModifyCustomer.AutoSize = true;
            this.ModifyCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModifyCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModifyCustomer.Location = new System.Drawing.Point(580, 65);
            this.ModifyCustomer.Name = "ModifyCustomer";
            this.ModifyCustomer.Padding = new System.Windows.Forms.Padding(7);
            this.ModifyCustomer.Size = new System.Drawing.Size(247, 61);
            this.ModifyCustomer.TabIndex = 10;
            this.ModifyCustomer.Text = "تعديل بيانات عميل";
            this.ModifyCustomer.UseVisualStyleBackColor = false;
            this.ModifyCustomer.Click += new System.EventHandler(this.ModifyCustomer_Click);
            // 
            // AddCustomer
            // 
            this.AddCustomer.AutoSize = true;
            this.AddCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddCustomer.Location = new System.Drawing.Point(42, 65);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Padding = new System.Windows.Forms.Padding(7);
            this.AddCustomer.Size = new System.Drawing.Size(238, 61);
            this.AddCustomer.TabIndex = 11;
            this.AddCustomer.Text = "اضافة عميل جديد";
            this.AddCustomer.UseVisualStyleBackColor = false;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(36, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "ابحث عن عميل";
            // 
            // SelectedID
            // 
            this.SelectedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedID.Location = new System.Drawing.Point(1184, 482);
            this.SelectedID.Name = "SelectedID";
            this.SelectedID.ReadOnly = true;
            this.SelectedID.Size = new System.Drawing.Size(137, 31);
            this.SelectedID.TabIndex = 14;
            this.SelectedID.TextChanged += new System.EventHandler(this.SelectedID_TextChanged);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.SelectedID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddCustomer);
            this.Controls.Add(this.ModifyCustomer);
            this.Controls.Add(this.RemoveCustomer);
            this.Controls.Add(this.ShowCustomers);
            this.Controls.Add(this.ShowCustomer);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.CustomShow);
            this.Controls.Add(this.CustomEdit);
            this.Controls.Add(this.CustomRemove);
            this.Controls.Add(this.SelectedCustomers);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "العملاء";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView SelectedCustomers;
        private System.Windows.Forms.Button CustomRemove;
        private System.Windows.Forms.Button CustomEdit;
        private System.Windows.Forms.Button CustomShow;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Button ShowCustomer;
        private System.Windows.Forms.Button ShowCustomers;
        private System.Windows.Forms.Button RemoveCustomer;
        private System.Windows.Forms.Button ModifyCustomer;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SelectedID;
    }
}