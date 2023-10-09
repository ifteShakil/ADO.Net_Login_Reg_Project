namespace Class_Project
{
    partial class Login
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
            this.RegisterNowbtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.Passwordtb = new System.Windows.Forms.TextBox();
            this.UserNametb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.UserNamelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterNowbtn
            // 
            this.RegisterNowbtn.Font = new System.Drawing.Font("HP Simplified Jpan", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterNowbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegisterNowbtn.Location = new System.Drawing.Point(188, 273);
            this.RegisterNowbtn.Name = "RegisterNowbtn";
            this.RegisterNowbtn.Size = new System.Drawing.Size(303, 53);
            this.RegisterNowbtn.TabIndex = 3;
            this.RegisterNowbtn.Text = "Don\'t Have Account? Create";
            this.RegisterNowbtn.UseVisualStyleBackColor = true;
            this.RegisterNowbtn.Click += new System.EventHandler(this.RegisterNowbtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("HP Simplified Jpan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginBtn.Location = new System.Drawing.Point(206, 199);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(268, 53);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login Now";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Passwordtb
            // 
            this.Passwordtb.Location = new System.Drawing.Point(206, 140);
            this.Passwordtb.Name = "Passwordtb";
            this.Passwordtb.Size = new System.Drawing.Size(268, 26);
            this.Passwordtb.TabIndex = 1;
           
            // 
            // UserNametb
            // 
            this.UserNametb.Location = new System.Drawing.Point(206, 83);
            this.UserNametb.Name = "UserNametb";
            this.UserNametb.Size = new System.Drawing.Size(268, 26);
            this.UserNametb.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("HP Simplified Jpan", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(51, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 28);
            this.label11.TabIndex = 8;
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Font = new System.Drawing.Font("HP Simplified Jpan", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Passwordlbl.Location = new System.Drawing.Point(51, 138);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(101, 28);
            this.Passwordlbl.TabIndex = 9;
            this.Passwordlbl.Text = "Password";
            // 
            // UserNamelbl
            // 
            this.UserNamelbl.AutoSize = true;
            this.UserNamelbl.Font = new System.Drawing.Font("HP Simplified Jpan", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNamelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserNamelbl.Location = new System.Drawing.Point(51, 81);
            this.UserNamelbl.Name = "UserNamelbl";
            this.UserNamelbl.Size = new System.Drawing.Size(111, 28);
            this.UserNamelbl.TabIndex = 10;
            this.UserNamelbl.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified Jpan", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(181, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Login Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterNowbtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.Passwordtb);
            this.Controls.Add(this.UserNametb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.UserNamelbl);
            this.Name = "Login";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterNowbtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox Passwordtb;
        private System.Windows.Forms.TextBox UserNametb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.Label UserNamelbl;
        private System.Windows.Forms.Label label1;
    }
}