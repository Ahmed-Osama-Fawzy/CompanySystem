namespace Workshop_System
{
    partial class Materials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materials));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Boards = new System.Windows.Forms.Button();
            this.Glasses = new System.Windows.Forms.Button();
            this.Aluminums = new System.Windows.Forms.Button();
            this.Accessories = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1354, 730);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Boards
            // 
            this.Boards.AutoSize = true;
            this.Boards.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Boards.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boards.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Boards.Location = new System.Drawing.Point(920, 140);
            this.Boards.Name = "Boards";
            this.Boards.Padding = new System.Windows.Forms.Padding(7);
            this.Boards.Size = new System.Drawing.Size(156, 61);
            this.Boards.TabIndex = 2;
            this.Boards.Text = "الالواح";
            this.Boards.UseVisualStyleBackColor = false;
            this.Boards.Click += new System.EventHandler(this.Addtions_Click);
            // 
            // Glasses
            // 
            this.Glasses.AutoSize = true;
            this.Glasses.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Glasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Glasses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Glasses.Location = new System.Drawing.Point(762, 140);
            this.Glasses.Name = "Glasses";
            this.Glasses.Padding = new System.Windows.Forms.Padding(7);
            this.Glasses.Size = new System.Drawing.Size(120, 61);
            this.Glasses.TabIndex = 3;
            this.Glasses.Text = "الزجاح";
            this.Glasses.UseVisualStyleBackColor = false;
            this.Glasses.Click += new System.EventHandler(this.Glasses_Click);
            // 
            // Aluminums
            // 
            this.Aluminums.AutoSize = true;
            this.Aluminums.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Aluminums.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aluminums.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Aluminums.Location = new System.Drawing.Point(335, 140);
            this.Aluminums.Name = "Aluminums";
            this.Aluminums.Padding = new System.Windows.Forms.Padding(7);
            this.Aluminums.Size = new System.Drawing.Size(148, 61);
            this.Aluminums.TabIndex = 4;
            this.Aluminums.Text = "الالوميتال";
            this.Aluminums.UseVisualStyleBackColor = false;
            this.Aluminums.Click += new System.EventHandler(this.Aluminum_Click);
            // 
            // Accessories
            // 
            this.Accessories.AutoSize = true;
            this.Accessories.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Accessories.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accessories.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Accessories.Location = new System.Drawing.Point(520, 140);
            this.Accessories.Name = "Accessories";
            this.Accessories.Padding = new System.Windows.Forms.Padding(7);
            this.Accessories.Size = new System.Drawing.Size(202, 61);
            this.Accessories.TabIndex = 6;
            this.Accessories.Text = " الاكسسوارات";
            this.Accessories.UseVisualStyleBackColor = false;
            this.Accessories.Click += new System.EventHandler(this.Accessories_Click);
            // 
            // Materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.Accessories);
            this.Controls.Add(this.Aluminums);
            this.Controls.Add(this.Glasses);
            this.Controls.Add(this.Boards);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Materials";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = " الاسعار";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Glasses;
        private System.Windows.Forms.Button Aluminums;
        private System.Windows.Forms.Button Boards;
        private System.Windows.Forms.Button Accessories;
    }
}