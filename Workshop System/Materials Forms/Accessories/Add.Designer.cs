﻿namespace Workshop_System.Materials_Forms.Accessories
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.Clear = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.ListBox();
            this.AName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.ListBox();
            this.Section = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Details = new System.Windows.Forms.Button();
            this.companypSystemDataSet1 = new Workshop_System.CompanypSystemDataSet1();
            this.accessoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accessoriesTableAdapter = new Workshop_System.CompanypSystemDataSet1TableAdapters.AccessoriesTableAdapter();
            this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesTableAdapter = new Workshop_System.CompanypSystemDataSet1TableAdapters.TypesTableAdapter();
            this.Type = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companypSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.AutoSize = true;
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Clear.Location = new System.Drawing.Point(911, 629);
            this.Clear.Name = "Clear";
            this.Clear.Padding = new System.Windows.Forms.Padding(7);
            this.Clear.Size = new System.Drawing.Size(198, 61);
            this.Clear.TabIndex = 42;
            this.Clear.Text = "افراغ البيانات";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Insert
            // 
            this.Insert.AutoSize = true;
            this.Insert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Insert.Location = new System.Drawing.Point(239, 629);
            this.Insert.Name = "Insert";
            this.Insert.Padding = new System.Windows.Forms.Padding(7);
            this.Insert.Size = new System.Drawing.Size(203, 61);
            this.Insert.TabIndex = 28;
            this.Insert.Text = "اضافة البيانات";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(557, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(312, 39);
            this.label8.TabIndex = 43;
            this.label8.Text = "اضافة بيانات قطعة جديد";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1380, 731);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(239, 147);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(395, 31);
            this.ID.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "الرقم الكودي";
            // 
            // Size
            // 
            this.Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size.Location = new System.Drawing.Point(239, 298);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(395, 31);
            this.Size.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "المقاس";
            // 
            // Category
            // 
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.FormattingEnabled = true;
            this.Category.ItemHeight = 25;
            this.Category.Items.AddRange(new object[] {
            "لا يوجد عناصر يجب اضافة عنصر"});
            this.Category.Location = new System.Drawing.Point(239, 379);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(395, 29);
            this.Category.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "القسم";
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(868, 223);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(395, 31);
            this.Price.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(705, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "السعر";
            // 
            // Color
            // 
            this.Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color.FormattingEnabled = true;
            this.Color.ItemHeight = 25;
            this.Color.Items.AddRange(new object[] {
            "لا يوجد عناصر يجب اضافة عنصر"});
            this.Color.Location = new System.Drawing.Point(868, 148);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(395, 29);
            this.Color.TabIndex = 45;
            // 
            // AName
            // 
            this.AName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AName.Location = new System.Drawing.Point(239, 223);
            this.AName.Name = "AName";
            this.AName.Size = new System.Drawing.Size(395, 31);
            this.AName.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "الكنية";
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.FormattingEnabled = true;
            this.Description.ItemHeight = 25;
            this.Description.Items.AddRange(new object[] {
            "لا يوجد عناصر يجب اضافة عنصر"});
            this.Description.Location = new System.Drawing.Point(868, 298);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(395, 29);
            this.Description.TabIndex = 58;
            // 
            // Section
            // 
            this.Section.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Section.FormattingEnabled = true;
            this.Section.ItemHeight = 25;
            this.Section.Items.AddRange(new object[] {
            "لا يوجد عناصر يجب اضافة عنصر"});
            this.Section.Location = new System.Drawing.Point(239, 470);
            this.Section.Name = "Section";
            this.Section.Size = new System.Drawing.Size(395, 29);
            this.Section.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(701, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "الوصف";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 55;
            this.label6.Text = "الفرع";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(705, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 25);
            this.label9.TabIndex = 59;
            this.label9.Text = "اللون";
            // 
            // Details
            // 
            this.Details.AutoSize = true;
            this.Details.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Details.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Details.Location = new System.Drawing.Point(608, 629);
            this.Details.Name = "Details";
            this.Details.Padding = new System.Windows.Forms.Padding(7);
            this.Details.Size = new System.Drawing.Size(163, 61);
            this.Details.TabIndex = 60;
            this.Details.Text = "الاختيارات";
            this.Details.UseVisualStyleBackColor = false;
            this.Details.Click += new System.EventHandler(this.Details_Click);
            // 
            // companypSystemDataSet1
            // 
            this.companypSystemDataSet1.DataSetName = "CompanypSystemDataSet1";
            this.companypSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accessoriesBindingSource
            // 
            this.accessoriesBindingSource.DataMember = "Accessories";
            this.accessoriesBindingSource.DataSource = this.companypSystemDataSet1;
            // 
            // accessoriesTableAdapter
            // 
            this.accessoriesTableAdapter.ClearBeforeFill = true;
            // 
            // typesBindingSource
            // 
            this.typesBindingSource.DataMember = "Types";
            this.typesBindingSource.DataSource = this.companypSystemDataSet1;
            // 
            // typesTableAdapter
            // 
            this.typesTableAdapter.ClearBeforeFill = true;
            // 
            // Type
            // 
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.FormattingEnabled = true;
            this.Type.ItemHeight = 25;
            this.Type.Items.AddRange(new object[] {
            "لا يوجد عناصر يجب اضافة عنصر"});
            this.Type.Location = new System.Drawing.Point(868, 379);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(395, 29);
            this.Type.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(701, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 25);
            this.label10.TabIndex = 61;
            this.label10.Text = "النوع";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Section);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافة قطعة جديدة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companypSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Color;
        private System.Windows.Forms.TextBox AName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Description;
        private System.Windows.Forms.ListBox Section;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Details;
        private CompanypSystemDataSet1 companypSystemDataSet1;
        private System.Windows.Forms.BindingSource accessoriesBindingSource;
        private CompanypSystemDataSet1TableAdapters.AccessoriesTableAdapter accessoriesTableAdapter;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private CompanypSystemDataSet1TableAdapters.TypesTableAdapter typesTableAdapter;
        private System.Windows.Forms.ListBox Type;
        private System.Windows.Forms.Label label10;
    }
}