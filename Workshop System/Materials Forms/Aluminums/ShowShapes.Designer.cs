namespace Workshop_System.Materials_Forms.Aluminum
{
    partial class Show_Shapes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Shapes));
            this.AllShapes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AllShapes)).BeginInit();
            this.SuspendLayout();
            // 
            // AllShapes
            // 
            this.AllShapes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.AllShapes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllShapes.Location = new System.Drawing.Point(-1, 0);
            this.AllShapes.Name = "AllShapes";
            this.AllShapes.Size = new System.Drawing.Size(1356, 730);
            this.AllShapes.TabIndex = 3;
            this.AllShapes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllShapes_CellContentClick);
            // 
            // Show_Shapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.AllShapes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Show_Shapes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "عرض جميع بيانات القطاعات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Show_Shapes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllShapes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AllShapes;
    }
}