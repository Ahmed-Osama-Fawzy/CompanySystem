namespace Workshop_System.Prices_Options.Glasses
{
    partial class Glasses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glasses));
            this.SelectedID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddGlass = new System.Windows.Forms.Button();
            this.ModifyGlass = new System.Windows.Forms.Button();
            this.RemoveGlass = new System.Windows.Forms.Button();
            this.ShowGlasses = new System.Windows.Forms.Button();
            this.ShowGlass = new System.Windows.Forms.Button();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.CustomShow = new System.Windows.Forms.Button();
            this.CustomEdit = new System.Windows.Forms.Button();
            this.CustomRemove = new System.Windows.Forms.Button();
            this.SelectedCustomers = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedID
            // 
            this.SelectedID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedID.Location = new System.Drawing.Point(1184, 481);
            this.SelectedID.Name = "SelectedID";
            this.SelectedID.ReadOnly = true;
            this.SelectedID.Size = new System.Drawing.Size(137, 31);
            this.SelectedID.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(36, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 33);
            this.label5.TabIndex = 26;
            this.label5.Text = "ابحث عن نوع";
            // 
            // AddGlass
            // 
            this.AddGlass.AutoSize = true;
            this.AddGlass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddGlass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGlass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddGlass.Location = new System.Drawing.Point(42, 64);
            this.AddGlass.Name = "AddGlass";
            this.AddGlass.Padding = new System.Windows.Forms.Padding(7);
            this.AddGlass.Size = new System.Drawing.Size(238, 61);
            this.AddGlass.TabIndex = 25;
            this.AddGlass.Text = "اضافة نوع جديد";
            this.AddGlass.UseVisualStyleBackColor = false;
            this.AddGlass.Click += new System.EventHandler(this.AddGlass_Click);
            // 
            // ModifyGlass
            // 
            this.ModifyGlass.AutoSize = true;
            this.ModifyGlass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModifyGlass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyGlass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModifyGlass.Location = new System.Drawing.Point(580, 64);
            this.ModifyGlass.Name = "ModifyGlass";
            this.ModifyGlass.Padding = new System.Windows.Forms.Padding(7);
            this.ModifyGlass.Size = new System.Drawing.Size(247, 61);
            this.ModifyGlass.TabIndex = 24;
            this.ModifyGlass.Text = "تعديل بيانات نوع";
            this.ModifyGlass.UseVisualStyleBackColor = false;
            this.ModifyGlass.Click += new System.EventHandler(this.ModifyGlass_Click);
            // 
            // RemoveGlass
            // 
            this.RemoveGlass.AutoSize = true;
            this.RemoveGlass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveGlass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveGlass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveGlass.Location = new System.Drawing.Point(1156, 218);
            this.RemoveGlass.Name = "RemoveGlass";
            this.RemoveGlass.Padding = new System.Windows.Forms.Padding(7);
            this.RemoveGlass.Size = new System.Drawing.Size(165, 61);
            this.RemoveGlass.TabIndex = 23;
            this.RemoveGlass.Text = "حذف نوع";
            this.RemoveGlass.UseVisualStyleBackColor = false;
            this.RemoveGlass.Click += new System.EventHandler(this.RemoveGlass_Click);
            // 
            // ShowGlasses
            // 
            this.ShowGlasses.AutoSize = true;
            this.ShowGlasses.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowGlasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowGlasses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowGlasses.Location = new System.Drawing.Point(42, 218);
            this.ShowGlasses.Name = "ShowGlasses";
            this.ShowGlasses.Padding = new System.Windows.Forms.Padding(7);
            this.ShowGlasses.Size = new System.Drawing.Size(210, 61);
            this.ShowGlasses.TabIndex = 22;
            this.ShowGlasses.Text = " عرض الانواع";
            this.ShowGlasses.UseVisualStyleBackColor = false;
            this.ShowGlasses.Click += new System.EventHandler(this.ShowGlasses_Click);
            // 
            // ShowGlass
            // 
            this.ShowGlass.AutoSize = true;
            this.ShowGlass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowGlass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowGlass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowGlass.Location = new System.Drawing.Point(1064, 64);
            this.ShowGlass.Name = "ShowGlass";
            this.ShowGlass.Padding = new System.Windows.Forms.Padding(7);
            this.ShowGlass.Size = new System.Drawing.Size(257, 61);
            this.ShowGlass.TabIndex = 21;
            this.ShowGlass.Text = "عرض بيانات نوع";
            this.ShowGlass.UseVisualStyleBackColor = false;
            this.ShowGlass.Click += new System.EventHandler(this.ShowGlass_Click);
            // 
            // SearchInput
            // 
            this.SearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchInput.Location = new System.Drawing.Point(238, 422);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(395, 31);
            this.SearchInput.TabIndex = 20;
            this.SearchInput.TextChanged += new System.EventHandler(this.SearchInput_TextChanged);
            // 
            // CustomShow
            // 
            this.CustomShow.AutoSize = true;
            this.CustomShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomShow.Location = new System.Drawing.Point(1184, 523);
            this.CustomShow.Name = "CustomShow";
            this.CustomShow.Padding = new System.Windows.Forms.Padding(7);
            this.CustomShow.Size = new System.Drawing.Size(137, 61);
            this.CustomShow.TabIndex = 19;
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
            this.CustomEdit.Location = new System.Drawing.Point(1184, 657);
            this.CustomEdit.Name = "CustomEdit";
            this.CustomEdit.Padding = new System.Windows.Forms.Padding(7);
            this.CustomEdit.Size = new System.Drawing.Size(137, 61);
            this.CustomEdit.TabIndex = 18;
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
            this.CustomRemove.Location = new System.Drawing.Point(1184, 590);
            this.CustomRemove.Name = "CustomRemove";
            this.CustomRemove.Padding = new System.Windows.Forms.Padding(7);
            this.CustomRemove.Size = new System.Drawing.Size(137, 61);
            this.CustomRemove.TabIndex = 17;
            this.CustomRemove.Text = "حذف";
            this.CustomRemove.UseVisualStyleBackColor = false;
            this.CustomRemove.Click += new System.EventHandler(this.CustomRemove_Click);
            // 
            // SelectedCustomers
            // 
            this.SelectedCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedCustomers.Location = new System.Drawing.Point(12, 481);
            this.SelectedCustomers.Name = "SelectedCustomers";
            this.SelectedCustomers.Size = new System.Drawing.Size(1166, 237);
            this.SelectedCustomers.TabIndex = 16;
            this.SelectedCustomers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectedCustomers_RowHeaderMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1354, 733);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Glasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.SelectedID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddGlass);
            this.Controls.Add(this.ModifyGlass);
            this.Controls.Add(this.RemoveGlass);
            this.Controls.Add(this.ShowGlasses);
            this.Controls.Add(this.ShowGlass);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.CustomShow);
            this.Controls.Add(this.CustomEdit);
            this.Controls.Add(this.CustomRemove);
            this.Controls.Add(this.SelectedCustomers);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Glasses";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = " الزجاج";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.SelectedCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SelectedID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddGlass;
        private System.Windows.Forms.Button ModifyGlass;
        private System.Windows.Forms.Button RemoveGlass;
        private System.Windows.Forms.Button ShowGlasses;
        private System.Windows.Forms.Button ShowGlass;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Button CustomShow;
        private System.Windows.Forms.Button CustomEdit;
        private System.Windows.Forms.Button CustomRemove;
        private System.Windows.Forms.DataGridView SelectedCustomers;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}