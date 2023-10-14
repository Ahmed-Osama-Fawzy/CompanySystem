namespace Workshop_System.Materials_Forms.Accessories
{
    partial class ShowAccessories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAccessories));
            this.AllAccessories = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllAccessories)).BeginInit();
            this.SuspendLayout();
            // 
            // AllAccessories
            // 
            this.AllAccessories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllAccessories.Location = new System.Drawing.Point(-1, 0);
            this.AllAccessories.Name = "AllAccessories";
            this.AllAccessories.Size = new System.Drawing.Size(1356, 730);
            this.AllAccessories.TabIndex = 4;
            this.AllAccessories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllShapes_CellContentClick);
            // 
            // ShowAccessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.AllAccessories);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowAccessories";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "عرض جميع بيانات القطع";
            ((System.ComponentModel.ISupportInitialize)(this.AllAccessories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AllAccessories;
    }
}