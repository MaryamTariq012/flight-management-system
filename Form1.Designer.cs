namespace FlightManagementSystem
    {
    partial class Form1
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
            this.label1_userID = new System.Windows.Forms.Label();
            this.label2_password = new System.Windows.Forms.Label();
            this.textUserID = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_userID
            // 
            this.label1_userID.AutoSize = true;
            this.label1_userID.Location = new System.Drawing.Point(94, 53);
            this.label1_userID.Name = "label1_userID";
            this.label1_userID.Size = new System.Drawing.Size(49, 16);
            this.label1_userID.TabIndex = 0;
            this.label1_userID.Text = "UserID";
            // 
            // label2_password
            // 
            this.label2_password.AutoSize = true;
            this.label2_password.Location = new System.Drawing.Point(100, 101);
            this.label2_password.Name = "label2_password";
            this.label2_password.Size = new System.Drawing.Size(67, 16);
            this.label2_password.TabIndex = 1;
            this.label2_password.Text = "Password";
            // 
            // textUserID
            // 
            this.textUserID.Location = new System.Drawing.Point(252, 47);
            this.textUserID.Multiline = true;
            this.textUserID.Name = "textUserID";
            this.textUserID.Size = new System.Drawing.Size(211, 22);
            this.textUserID.TabIndex = 2;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(252, 101);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(211, 22);
            this.textPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(103, 185);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUserID);
            this.Controls.Add(this.label2_password);
            this.Controls.Add(this.label1_userID);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label label1_userID;
        private System.Windows.Forms.Label label2_password;
        private System.Windows.Forms.TextBox textUserID;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button btnLogin;
        }
    }

