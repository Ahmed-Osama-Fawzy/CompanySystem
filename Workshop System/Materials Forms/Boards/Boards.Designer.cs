namespace Workshop_System.Prices_Options.Addtions
{
    partial class Boards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boards));
            this.SelectedID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBoard = new System.Windows.Forms.Button();
            this.ModifyBoard = new System.Windows.Forms.Button();
            this.RemoveBoard = new System.Windows.Forms.Button();
            this.ShowBoards = new System.Windows.Forms.Button();
            this.ShowBoard = new System.Windows.Forms.Button();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.CustomShow = new System.Windows.Forms.Button();
            this.CustomEdit = new System.Windows.Forms.Button();
            this.CustomRemove = new System.Windows.Forms.Button();
            this.SelectedBoards = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedBoards)).BeginInit();
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
            this.label5.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(36, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 33);
            this.label5.TabIndex = 39;
            this.label5.Text = "ابحث عن لوح";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AddBoard
            // 
            this.AddBoard.AutoSize = true;
            this.AddBoard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBoard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddBoard.Location = new System.Drawing.Point(42, 64);
            this.AddBoard.Name = "AddBoard";
            this.AddBoard.Padding = new System.Windows.Forms.Padding(7);
            this.AddBoard.Size = new System.Drawing.Size(251, 61);
            this.AddBoard.TabIndex = 38;
            this.AddBoard.Text = " اضافة لوح جديد";
            this.AddBoard.UseVisualStyleBackColor = false;
            this.AddBoard.Click += new System.EventHandler(this.AddBoard_Click);
            // 
            // ModifyBoard
            // 
            this.ModifyBoard.AutoSize = true;
            this.ModifyBoard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModifyBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyBoard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModifyBoard.Location = new System.Drawing.Point(580, 64);
            this.ModifyBoard.Name = "ModifyBoard";
            this.ModifyBoard.Padding = new System.Windows.Forms.Padding(7);
            this.ModifyBoard.Size = new System.Drawing.Size(250, 61);
            this.ModifyBoard.TabIndex = 37;
            this.ModifyBoard.Text = "تعديل بيانات لوح";
            this.ModifyBoard.UseVisualStyleBackColor = false;
            this.ModifyBoard.Click += new System.EventHandler(this.ModifyBoard_Click);
            // 
            // RemoveBoard
            // 
            this.RemoveBoard.AutoSize = true;
            this.RemoveBoard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBoard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveBoard.Location = new System.Drawing.Point(1156, 218);
            this.RemoveBoard.Name = "RemoveBoard";
            this.RemoveBoard.Padding = new System.Windows.Forms.Padding(7);
            this.RemoveBoard.Size = new System.Drawing.Size(168, 61);
            this.RemoveBoard.TabIndex = 36;
            this.RemoveBoard.Text = "حذف لوح";
            this.RemoveBoard.UseVisualStyleBackColor = false;
            this.RemoveBoard.Click += new System.EventHandler(this.RemoveBoard_Click);
            // 
            // ShowBoards
            // 
            this.ShowBoards.AutoSize = true;
            this.ShowBoards.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowBoards.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBoards.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowBoards.Location = new System.Drawing.Point(42, 218);
            this.ShowBoards.Name = "ShowBoards";
            this.ShowBoards.Padding = new System.Windows.Forms.Padding(7);
            this.ShowBoards.Size = new System.Drawing.Size(231, 61);
            this.ShowBoards.TabIndex = 35;
            this.ShowBoards.Text = "عرض الالواح";
            this.ShowBoards.UseVisualStyleBackColor = false;
            this.ShowBoards.Click += new System.EventHandler(this.ShowBoards_Click);
            // 
            // ShowBoard
            // 
            this.ShowBoard.AutoSize = true;
            this.ShowBoard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBoard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowBoard.Location = new System.Drawing.Point(1064, 64);
            this.ShowBoard.Name = "ShowBoard";
            this.ShowBoard.Padding = new System.Windows.Forms.Padding(7);
            this.ShowBoard.Size = new System.Drawing.Size(263, 61);
            this.ShowBoard.TabIndex = 34;
            this.ShowBoard.Text = "عرض بيانات لوح";
            this.ShowBoard.UseVisualStyleBackColor = false;
            this.ShowBoard.Click += new System.EventHandler(this.ShowBoard_Click);
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
            // SelectedBoards
            // 
            this.SelectedBoards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedBoards.Location = new System.Drawing.Point(12, 481);
            this.SelectedBoards.Name = "SelectedBoards";
            this.SelectedBoards.Size = new System.Drawing.Size(1166, 237);
            this.SelectedBoards.TabIndex = 29;
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
            // Boards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.SelectedID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddBoard);
            this.Controls.Add(this.ModifyBoard);
            this.Controls.Add(this.RemoveBoard);
            this.Controls.Add(this.ShowBoards);
            this.Controls.Add(this.ShowBoard);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.CustomShow);
            this.Controls.Add(this.CustomEdit);
            this.Controls.Add(this.CustomRemove);
            this.Controls.Add(this.SelectedBoards);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Boards";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الاضافات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.SelectedBoards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SelectedID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddBoard;
        private System.Windows.Forms.Button ModifyBoard;
        private System.Windows.Forms.Button RemoveBoard;
        private System.Windows.Forms.Button ShowBoards;
        private System.Windows.Forms.Button ShowBoard;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Button CustomShow;
        private System.Windows.Forms.Button CustomEdit;
        private System.Windows.Forms.Button CustomRemove;
        private System.Windows.Forms.DataGridView SelectedBoards;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}