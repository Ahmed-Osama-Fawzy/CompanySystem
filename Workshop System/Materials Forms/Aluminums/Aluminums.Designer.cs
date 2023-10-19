namespace Workshop_System.Materials_Forms.Aluminum
{
    partial class Aluminum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aluminum));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectedShapes = new System.Windows.Forms.DataGridView();
            this.CustomRemove = new System.Windows.Forms.Button();
            this.CustomEdit = new System.Windows.Forms.Button();
            this.CustomShow = new System.Windows.Forms.Button();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.ShowShape = new System.Windows.Forms.Button();
            this.ShowShapes = new System.Windows.Forms.Button();
            this.RemoveShape = new System.Windows.Forms.Button();
            this.ModifyShape = new System.Windows.Forms.Button();
            this.AddShape = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectedID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedShapes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1354, 733);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.SelectedShapes.TabIndex = 16;
            this.SelectedShapes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectedShapes_RowHeaderMouseClick);
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
            // SearchInput
            // 
            this.SearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchInput.Location = new System.Drawing.Point(238, 422);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(395, 31);
            this.SearchInput.TabIndex = 20;
            this.SearchInput.TextChanged += new System.EventHandler(this.SearchInput_TextChanged);
            // 
            // ShowShape
            // 
            this.ShowShape.AutoSize = true;
            this.ShowShape.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowShape.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowShape.Location = new System.Drawing.Point(1064, 64);
            this.ShowShape.Name = "ShowShape";
            this.ShowShape.Padding = new System.Windows.Forms.Padding(7);
            this.ShowShape.Size = new System.Drawing.Size(257, 61);
            this.ShowShape.TabIndex = 21;
            this.ShowShape.Text = "عرض بيانات قطاع";
            this.ShowShape.UseVisualStyleBackColor = false;
            this.ShowShape.Click += new System.EventHandler(this.ShowShape_Click);
            // 
            // ShowShapes
            // 
            this.ShowShapes.AutoSize = true;
            this.ShowShapes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowShapes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowShapes.Location = new System.Drawing.Point(42, 218);
            this.ShowShapes.Name = "ShowShapes";
            this.ShowShapes.Padding = new System.Windows.Forms.Padding(7);
            this.ShowShapes.Size = new System.Drawing.Size(226, 61);
            this.ShowShapes.TabIndex = 22;
            this.ShowShapes.Text = "عرض القطاعات";
            this.ShowShapes.UseVisualStyleBackColor = false;
            this.ShowShapes.Click += new System.EventHandler(this.ShowShapes_Click);
            // 
            // RemoveShape
            // 
            this.RemoveShape.AutoSize = true;
            this.RemoveShape.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveShape.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveShape.Location = new System.Drawing.Point(1156, 218);
            this.RemoveShape.Name = "RemoveShape";
            this.RemoveShape.Padding = new System.Windows.Forms.Padding(7);
            this.RemoveShape.Size = new System.Drawing.Size(165, 61);
            this.RemoveShape.TabIndex = 23;
            this.RemoveShape.Text = "حذف قطاع";
            this.RemoveShape.UseVisualStyleBackColor = false;
            this.RemoveShape.Click += new System.EventHandler(this.RemoveShape_Click);
            // 
            // ModifyShape
            // 
            this.ModifyShape.AutoSize = true;
            this.ModifyShape.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModifyShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyShape.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModifyShape.Location = new System.Drawing.Point(580, 64);
            this.ModifyShape.Name = "ModifyShape";
            this.ModifyShape.Padding = new System.Windows.Forms.Padding(7);
            this.ModifyShape.Size = new System.Drawing.Size(247, 61);
            this.ModifyShape.TabIndex = 24;
            this.ModifyShape.Text = "تعديل بيانات قطاع";
            this.ModifyShape.UseVisualStyleBackColor = false;
            this.ModifyShape.Click += new System.EventHandler(this.ModifyShape_Click);
            // 
            // AddShape
            // 
            this.AddShape.AutoSize = true;
            this.AddShape.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddShape.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddShape.Location = new System.Drawing.Point(42, 64);
            this.AddShape.Name = "AddShape";
            this.AddShape.Padding = new System.Windows.Forms.Padding(7);
            this.AddShape.Size = new System.Drawing.Size(238, 61);
            this.AddShape.TabIndex = 25;
            this.AddShape.Text = "اضافة قطاع جديد";
            this.AddShape.UseVisualStyleBackColor = false;
            this.AddShape.Click += new System.EventHandler(this.AddShape_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(36, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 33);
            this.label5.TabIndex = 26;
            this.label5.Text = "ابحث عن عميل";
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
            // Aluminum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.SelectedID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddShape);
            this.Controls.Add(this.ModifyShape);
            this.Controls.Add(this.RemoveShape);
            this.Controls.Add(this.ShowShapes);
            this.Controls.Add(this.ShowShape);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.CustomShow);
            this.Controls.Add(this.CustomEdit);
            this.Controls.Add(this.CustomRemove);
            this.Controls.Add(this.SelectedShapes);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Aluminum";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "قطاعات الالوميتال";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Aluminum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedShapes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView SelectedShapes;
        private System.Windows.Forms.Button CustomRemove;
        private System.Windows.Forms.Button CustomEdit;
        private System.Windows.Forms.Button CustomShow;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Button ShowShape;
        private System.Windows.Forms.Button ShowShapes;
        private System.Windows.Forms.Button RemoveShape;
        private System.Windows.Forms.Button ModifyShape;
        private System.Windows.Forms.Button AddShape;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SelectedID;
    }
}