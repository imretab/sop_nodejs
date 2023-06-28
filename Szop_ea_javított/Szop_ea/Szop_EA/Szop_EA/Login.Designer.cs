namespace Szop_EA
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
            this.tb_uName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_OpenAPI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_uName
            // 
            this.tb_uName.Location = new System.Drawing.Point(12, 37);
            this.tb_uName.Name = "tb_uName";
            this.tb_uName.Size = new System.Drawing.Size(250, 20);
            this.tb_uName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Felhasználónév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jelszó:";
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(12, 116);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '□';
            this.tb_pwd.Size = new System.Drawing.Size(250, 20);
            this.tb_pwd.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_login.Location = new System.Drawing.Point(13, 178);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(249, 46);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Bejelentkezés";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Register.Location = new System.Drawing.Point(13, 282);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(249, 46);
            this.btn_Register.TabIndex = 5;
            this.btn_Register.Text = "Regisztráció";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // btn_OpenAPI
            // 
            this.btn_OpenAPI.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_OpenAPI.Location = new System.Drawing.Point(13, 231);
            this.btn_OpenAPI.Name = "btn_OpenAPI";
            this.btn_OpenAPI.Size = new System.Drawing.Size(249, 45);
            this.btn_OpenAPI.TabIndex = 6;
            this.btn_OpenAPI.Text = "OpenAPI";
            this.btn_OpenAPI.UseVisualStyleBackColor = true;
            this.btn_OpenAPI.Click += new System.EventHandler(this.Btn_OpenAPI_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(274, 340);
            this.Controls.Add(this.btn_OpenAPI);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_uName);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_uName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_OpenAPI;
    }
}

