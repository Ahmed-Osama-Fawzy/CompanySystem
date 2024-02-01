namespace Workshop_System
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.LogIn = new System.Windows.Forms.Button();
            this.ForgetPassword = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BranchID = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 731);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(812, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم المستخدم";
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(977, 282);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(316, 31);
            this.Username.TabIndex = 3;
            // 
            // LogIn
            // 
            this.LogIn.AutoSize = true;
            this.LogIn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogIn.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn.ForeColor = System.Drawing.SystemColors.Control;
            this.LogIn.Location = new System.Drawing.Point(817, 483);
            this.LogIn.Margin = new System.Windows.Forms.Padding(10);
            this.LogIn.Name = "LogIn";
            this.LogIn.Padding = new System.Windows.Forms.Padding(7);
            this.LogIn.Size = new System.Drawing.Size(201, 63);
            this.LogIn.TabIndex = 6;
            this.LogIn.Text = "تسجيل الدخول";
            this.LogIn.UseVisualStyleBackColor = false;
            this.LogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForgetPassword
            // 
            this.ForgetPassword.AutoSize = true;
            this.ForgetPassword.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPassword.Location = new System.Drawing.Point(1177, 493);
            this.ForgetPassword.Name = "ForgetPassword";
            this.ForgetPassword.Size = new System.Drawing.Size(116, 23);
            this.ForgetPassword.TabIndex = 7;
            this.ForgetPassword.TabStop = true;
            this.ForgetPassword.Text = "نسيت كلمة المرور";
            this.ForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgetPassword_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(821, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "كلمة السر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(812, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "رقم الفرع";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title.Location = new System.Drawing.Point(762, 65);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(547, 39);
            this.Title.TabIndex = 11;
            this.Title.Text = "ELESRAA FOR ALUMINUIM PRODUCTS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(983, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "تسجيل الدخول";
            // 
            // BranchID
            // 
            this.BranchID.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchID.Location = new System.Drawing.Point(977, 410);
            this.BranchID.Name = "BranchID";
            this.BranchID.Size = new System.Drawing.Size(316, 31);
            this.BranchID.TabIndex = 13;
            this.BranchID.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(977, 346);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(316, 31);
            this.Password.TabIndex = 14;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1354, 731);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.BranchID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ForgetPassword);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تسجيل الدخول";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.LinkLabel ForgetPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BranchID;
        private System.Windows.Forms.TextBox Password;
    }
}

