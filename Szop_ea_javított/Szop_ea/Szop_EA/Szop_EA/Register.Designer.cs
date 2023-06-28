namespace Szop_EA
{
    partial class Register
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
            this.label6 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.btn_vissza = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_fullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pwd_again = new System.Windows.Forms.TextBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 26);
            this.label6.TabIndex = 34;
            this.label6.Text = "Email:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(11, 276);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(324, 20);
            this.tb_email.TabIndex = 25;
            // 
            // btn_vissza
            // 
            this.btn_vissza.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_vissza.Location = new System.Drawing.Point(11, 424);
            this.btn_vissza.Name = "btn_vissza";
            this.btn_vissza.Size = new System.Drawing.Size(324, 54);
            this.btn_vissza.TabIndex = 28;
            this.btn_vissza.Text = "Vissza";
            this.btn_vissza.UseVisualStyleBackColor = true;
            this.btn_vissza.Click += new System.EventHandler(this.Btn_vissza_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 32;
            this.label4.Text = "Teljes név:";
            // 
            // tb_fullName
            // 
            this.tb_fullName.Location = new System.Drawing.Point(11, 36);
            this.tb_fullName.Name = "tb_fullName";
            this.tb_fullName.Size = new System.Drawing.Size(324, 20);
            this.tb_fullName.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 26);
            this.label3.TabIndex = 31;
            this.label3.Text = "Jelszó ismét:";
            // 
            // tb_pwd_again
            // 
            this.tb_pwd_again.Location = new System.Drawing.Point(11, 216);
            this.tb_pwd_again.Name = "tb_pwd_again";
            this.tb_pwd_again.PasswordChar = '+';
            this.tb_pwd_again.Size = new System.Drawing.Size(324, 20);
            this.tb_pwd_again.TabIndex = 24;
            this.tb_pwd_again.UseSystemPasswordChar = true;
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Register.Location = new System.Drawing.Point(11, 356);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(324, 62);
            this.btn_Register.TabIndex = 27;
            this.btn_Register.Text = "Regisztráció";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "Jelszó:";
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(11, 156);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '+';
            this.tb_pwd.Size = new System.Drawing.Size(324, 20);
            this.tb_pwd.TabIndex = 23;
            this.tb_pwd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 29;
            this.label1.Text = "Felhasználónév:";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(11, 95);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(324, 20);
            this.tb_username.TabIndex = 22;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(350, 492);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.btn_vissza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_fullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_pwd_again);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_username);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button btn_vissza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_fullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pwd_again;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_username;
    }
}