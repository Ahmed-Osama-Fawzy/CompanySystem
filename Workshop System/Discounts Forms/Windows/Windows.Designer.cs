namespace Workshop_System.Discounts_Forms.Windows.Sliding_Windows
{
    partial class Silding_Windows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Silding_Windows));
            this.SelectedID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.CustomShow = new System.Windows.Forms.Button();
            this.CustomEdit = new System.Windows.Forms.Button();
            this.CustomRemove = new System.Windows.Forms.Button();
            this.SelectedDiscounts = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedDiscounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedID
            // 
            this.SelectedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedID.Location = new System.Drawing.Point(1205, 464);
            this.SelectedID.Name = "SelectedID";
            this.SelectedID.ReadOnly = true;
            this.SelectedID.Size = new System.Drawing.Size(137, 31);
            this.SelectedID.TabIndex = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(57, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 33);
            this.label5.TabIndex = 124;
            this.label5.Text = "ابحث عن تخصيم";
            // 
            // SearchInput
            // 
            this.SearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchInput.Location = new System.Drawing.Point(259, 405);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(395, 31);
            this.SearchInput.TabIndex = 123;
            this.SearchInput.TextChanged += new System.EventHandler(this.SearchInput_TextChanged);
            // 
            // CustomShow
            // 
            this.CustomShow.AutoSize = true;
            this.CustomShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomShow.Location = new System.Drawing.Point(1205, 506);
            this.CustomShow.Name = "CustomShow";
            this.CustomShow.Padding = new System.Windows.Forms.Padding(7);
            this.CustomShow.Size = new System.Drawing.Size(137, 61);
            this.CustomShow.TabIndex = 122;
            this.CustomShow.Text = "عرض";
            this.CustomShow.UseVisualStyleBackColor = false;
            this.CustomShow.Click += new System.EventHandler(this.CustomShow_Click);
            // 
            // CustomEdit
            // 
            this.CustomEdit.AutoSize = true;
            this.CustomEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomEdit.Location = new System.Drawing.Point(1205, 640);
            this.CustomEdit.Name = "CustomEdit";
            this.CustomEdit.Padding = new System.Windows.Forms.Padding(7);
            this.CustomEdit.Size = new System.Drawing.Size(137, 61);
            this.CustomEdit.TabIndex = 121;
            this.CustomEdit.Text = "تعديل";
            this.CustomEdit.UseVisualStyleBackColor = false;
            this.CustomEdit.Click += new System.EventHandler(this.CustomEdit_Click);
            // 
            // CustomRemove
            // 
            this.CustomRemove.AutoSize = true;
            this.CustomRemove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomRemove.Location = new System.Drawing.Point(1205, 573);
            this.CustomRemove.Name = "CustomRemove";
            this.CustomRemove.Padding = new System.Windows.Forms.Padding(7);
            this.CustomRemove.Size = new System.Drawing.Size(137, 61);
            this.CustomRemove.TabIndex = 120;
            this.CustomRemove.Text = "حذف";
            this.CustomRemove.UseVisualStyleBackColor = false;
            this.CustomRemove.Click += new System.EventHandler(this.CustomRemove_Click);
            // 
            // SelectedDiscounts
            // 
            this.SelectedDiscounts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SelectedDiscounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedDiscounts.GridColor = System.Drawing.SystemColors.Window;
            this.SelectedDiscounts.Location = new System.Drawing.Point(33, 464);
            this.SelectedDiscounts.Name = "SelectedDiscounts";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedDiscounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedDiscounts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.SelectedDiscounts.Size = new System.Drawing.Size(1150, 237);
            this.SelectedDiscounts.TabIndex = 119;
            this.SelectedDiscounts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectedDiscounts_RowHeaderMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1380, 731);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add.Location = new System.Drawing.Point(73, 65);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(7);
            this.Add.Size = new System.Drawing.Size(195, 61);
            this.Add.TabIndex = 114;
            this.Add.Text = "اضافة تخصيم";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(571, 65);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(7);
            this.button1.Size = new System.Drawing.Size(195, 61);
            this.button1.TabIndex = 115;
            this.button1.Text = "تعديل تخصيم";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(1081, 65);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(7);
            this.button2.Size = new System.Drawing.Size(195, 61);
            this.button2.TabIndex = 116;
            this.button2.Text = "حذف تخصيم";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(1081, 238);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(7);
            this.button3.Size = new System.Drawing.Size(198, 61);
            this.button3.TabIndex = 117;
            this.button3.Text = "عرض تخصيم";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(63, 238);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(7);
            this.button4.Size = new System.Drawing.Size(249, 61);
            this.button4.TabIndex = 118;
            this.button4.Text = "عرض التخصيمات";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Silding_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.SelectedID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.CustomShow);
            this.Controls.Add(this.CustomEdit);
            this.Controls.Add(this.CustomRemove);
            this.Controls.Add(this.SelectedDiscounts);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Silding_Windows";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تخصيمات الشبابيك";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Silding_Windows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedDiscounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SelectedID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Button CustomShow;
        private System.Windows.Forms.Button CustomEdit;
        private System.Windows.Forms.Button CustomRemove;
        private System.Windows.Forms.DataGridView SelectedDiscounts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}