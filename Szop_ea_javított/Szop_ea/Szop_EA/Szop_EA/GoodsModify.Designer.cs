namespace Szop_EA
{
    partial class GoodsModify
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_modosit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.num_mennyiseg = new System.Windows.Forms.NumericUpDown();
            this.tb_termek = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_ar = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_mennyiseg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_back.Location = new System.Drawing.Point(12, 302);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(277, 64);
            this.btn_back.TabIndex = 26;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // btn_modosit
            // 
            this.btn_modosit.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_modosit.Location = new System.Drawing.Point(12, 217);
            this.btn_modosit.Name = "btn_modosit";
            this.btn_modosit.Size = new System.Drawing.Size(277, 79);
            this.btn_modosit.TabIndex = 25;
            this.btn_modosit.Text = "Modify Product";
            this.btn_modosit.UseVisualStyleBackColor = true;
            this.btn_modosit.Click += new System.EventHandler(this.Btn_modosit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quantity";
            // 
            // num_mennyiseg
            // 
            this.num_mennyiseg.Location = new System.Drawing.Point(12, 169);
            this.num_mennyiseg.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.num_mennyiseg.Name = "num_mennyiseg";
            this.num_mennyiseg.Size = new System.Drawing.Size(277, 20);
            this.num_mennyiseg.TabIndex = 23;
            // 
            // tb_termek
            // 
            this.tb_termek.Location = new System.Drawing.Point(12, 36);
            this.tb_termek.Name = "tb_termek";
            this.tb_termek.Size = new System.Drawing.Size(277, 20);
            this.tb_termek.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 26);
            this.label5.TabIndex = 21;
            this.label5.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Price";
            // 
            // num_ar
            // 
            this.num_ar.Location = new System.Drawing.Point(12, 98);
            this.num_ar.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.num_ar.Name = "num_ar";
            this.num_ar.Size = new System.Drawing.Size(277, 20);
            this.num_ar.TabIndex = 19;
            // 
            // GoodsModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(301, 388);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_modosit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_mennyiseg);
            this.Controls.Add(this.tb_termek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_ar);
            this.Name = "GoodsModify";
            this.Text = "AruMod";
            ((System.ComponentModel.ISupportInitialize)(this.num_mennyiseg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_modosit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_mennyiseg;
        private System.Windows.Forms.TextBox tb_termek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_ar;
    }
}