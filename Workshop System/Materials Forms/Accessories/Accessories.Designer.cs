namespace Workshop_System.Materials_Forms.Accessories
{
    partial class Accessories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accessories));
            this.SelectedID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddAccessorie = new System.Windows.Forms.Button();
            this.ModifyAccessorie = new System.Windows.Forms.Button();
            this.RemoveAccessorie = new System.Windows.Forms.Button();
            this.ShowAccessories = new System.Windows.Forms.Button();
            this.ShowAccessorie = new System.Windows.Forms.Button();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.CustomShow = new System.Windows.Forms.Button();
            this.CustomEdit = new System.Windows.Forms.Button();
            this.CustomRemove = new System.Windows.Forms.Button();
            this.SelectedShapes = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedShapes)).BeginInit();
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
            this.SelectedID.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(36, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 33);
            this.label5.TabIndex = 39;
            this.label5.Text = "ابحث عن قطعة";
            // 
            // AddAccessorie
            // 
            this.AddAccessorie.AutoSize = true;
            this.AddAccessorie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddAccessorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAccessorie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddAccessorie.Location = new System.Drawing.Point(42, 64);
            this.AddAccessorie.Name = "AddAccessorie";
            this.AddAccessorie.Padding = new System.Windows.Forms.Padding(7);
            this.AddAccessorie.Size = new System.Drawing.Size(238, 61);
            this.AddAccessorie.TabIndex = 38;
            this.AddAccessorie.Text = "اضافة قطعة جديد";
            this.AddAccessorie.UseVisualStyleBackColor = false;
            this.AddAccessorie.Click += new System.EventHandler(this.AddAccessorie_Click);
            // 
            // ModifyAccessorie
            // 
            this.ModifyAccessorie.AutoSize = true;
            this.ModifyAccessorie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModifyAccessorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyAccessorie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModifyAccessorie.Location = new System.Drawing.Point(580, 64);
            this.ModifyAccessorie.Name = "ModifyAccessorie";
            this.ModifyAccessorie.Padding = new System.Windows.Forms.Padding(7);
            this.ModifyAccessorie.Size = new System.Drawing.Size(247, 61);
            this.ModifyAccessorie.TabIndex = 37;
            this.ModifyAccessorie.Text = "تعديل بيانات قطعة";
            this.ModifyAccessorie.UseVisualStyleBackColor = false;
            this.ModifyAccessorie.Click += new System.EventHandler(this.ModifyAccessorie_Click);
            // 
            // RemoveAccessorie
            // 
            this.RemoveAccessorie.AutoSize = true;
            this.RemoveAccessorie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveAccessorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveAccessorie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveAccessorie.Location = new System.Drawing.Point(1156, 218);
            this.RemoveAccessorie.Name = "RemoveAccessorie";
            this.RemoveAccessorie.Padding = new System.Windows.Forms.Padding(7);
            this.RemoveAccessorie.Size = new System.Drawing.Size(165, 61);
            this.RemoveAccessorie.TabIndex = 36;
            this.RemoveAccessorie.Text = "حذف قطعة";
            this.RemoveAccessorie.UseVisualStyleBackColor = false;
            this.RemoveAccessorie.Click += new System.EventHandler(this.RemoveAccessorie_Click);
            // 
            // ShowAccessories
            // 
            this.ShowAccessories.AutoSize = true;
            this.ShowAccessories.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowAccessories.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAccessories.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowAccessories.Location = new System.Drawing.Point(42, 218);
            this.ShowAccessories.Name = "ShowAccessories";
            this.ShowAccessories.Padding = new System.Windows.Forms.Padding(7);
            this.ShowAccessories.Size = new System.Drawing.Size(226, 61);
            this.ShowAccessories.TabIndex = 35;
            this.ShowAccessories.Text = "عرض القطع";
            this.ShowAccessories.UseVisualStyleBackColor = false;
            this.ShowAccessories.Click += new System.EventHandler(this.ShowAccessories_Click);
            // 
            // ShowAccessorie
            // 
            this.ShowAccessorie.AutoSize = true;
            this.ShowAccessorie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowAccessorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAccessorie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowAccessorie.Location = new System.Drawing.Point(1064, 64);
            this.ShowAccessorie.Name = "ShowAccessorie";
            this.ShowAccessorie.Padding = new System.Windows.Forms.Padding(7);
            this.ShowAccessorie.Size = new System.Drawing.Size(257, 61);
            this.ShowAccessorie.TabIndex = 34;
            this.ShowAccessorie.Text = "عرض بيانات قطعة";
            this.ShowAccessorie.UseVisualStyleBackColor = false;
            this.ShowAccessorie.Click += new System.EventHandler(this.ShowAccessorie_Click);
            // 
            // SearchInput
            // 
            this.SearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchInput.Location = new System.Drawing.Point(238, 422);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(395, 31);
            this.SearchInput.TabIndex = 33;
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
            this.CustomShow.TabIndex = 32;
            this.CustomShow.Text = "عرض";
            this.CustomShow.UseVisualStyleBackColor = false;
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
            this.CustomEdit.TabIndex = 31;
            this.CustomEdit.Text = "تعديل";
            this.CustomEdit.UseVisualStyleBackColor = false;
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
            this.CustomRemove.TabIndex = 30;
            this.CustomRemove.Text = "حذف";
            this.CustomRemove.UseVisualStyleBackColor = false;
            // 
            // SelectedShapes
            // 
            this.SelectedShapes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SelectedShapes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedShapes.GridColor = System.Drawing.SystemColors.Window;
            this.SelectedShapes.Location = new System.Drawing.Point(12, 481);
            this.SelectedShapes.Name = "SelectedShapes";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedShapes.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedShapes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.SelectedShapes.Size = new System.Drawing.Size(1150, 237);
            this.SelectedShapes.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1354, 733);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Accessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.SelectedID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddAccessorie);
            this.Controls.Add(this.ModifyAccessorie);
            this.Controls.Add(this.RemoveAccessorie);
            this.Controls.Add(this.ShowAccessories);
            this.Controls.Add(this.ShowAccessorie);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.CustomShow);
            this.Controls.Add(this.CustomEdit);
            this.Controls.Add(this.CustomRemove);
            this.Controls.Add(this.SelectedShapes);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accessories";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الاكسسوارات";
            ((System.ComponentModel.ISupportInitialize)(this.SelectedShapes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SelectedID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddAccessorie;
        private System.Windows.Forms.Button ModifyAccessorie;
        private System.Windows.Forms.Button RemoveAccessorie;
        private System.Windows.Forms.Button ShowAccessories;
        private System.Windows.Forms.Button ShowAccessorie;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Button CustomShow;
        private System.Windows.Forms.Button CustomEdit;
        private System.Windows.Forms.Button CustomRemove;
        private System.Windows.Forms.DataGridView SelectedShapes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}