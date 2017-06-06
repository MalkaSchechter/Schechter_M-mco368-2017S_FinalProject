namespace FinalProjectStore
{
    partial class frmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsrnm = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtUsrnm = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(82, 134);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(169, 38);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsrnm
            // 
            this.lblUsrnm.AutoSize = true;
            this.lblUsrnm.Location = new System.Drawing.Point(61, 58);
            this.lblUsrnm.Name = "lblUsrnm";
            this.lblUsrnm.Size = new System.Drawing.Size(73, 17);
            this.lblUsrnm.TabIndex = 1;
            this.lblUsrnm.Text = "Username";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(61, 92);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(69, 17);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "Password";
            // 
            // txtUsrnm
            // 
            this.txtUsrnm.Location = new System.Drawing.Point(138, 56);
            this.txtUsrnm.Name = "txtUsrnm";
            this.txtUsrnm.Size = new System.Drawing.Size(130, 22);
            this.txtUsrnm.TabIndex = 3;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(138, 90);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(130, 22);
            this.txtPwd.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(64, 9);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 5;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 210);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUsrnm);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUsrnm);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsrnm;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtUsrnm;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblError;
    }
}

