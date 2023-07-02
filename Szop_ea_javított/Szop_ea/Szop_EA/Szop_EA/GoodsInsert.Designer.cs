namespace Szop_EA
{
    partial class GoodsInsert
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
            this.tb_product = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_price = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.num_quantity = new System.Windows.Forms.NumericUpDown();
            this.btn_feltolt = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_product
            // 
            this.tb_product.Location = new System.Drawing.Point(12, 36);
            this.tb_product.Name = "tb_product";
            this.tb_product.Size = new System.Drawing.Size(277, 20);
            this.tb_product.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 26);
            this.label5.TabIndex = 13;
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
            this.label3.TabIndex = 12;
            this.label3.Text = "Price";
            // 
            // num_price
            // 
            this.num_price.Location = new System.Drawing.Point(12, 98);
            this.num_price.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.num_price.Name = "num_price";
            this.num_price.Size = new System.Drawing.Size(277, 20);
            this.num_price.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quantity";
            // 
            // num_quantity
            // 
            this.num_quantity.Location = new System.Drawing.Point(12, 169);
            this.num_quantity.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.num_quantity.Name = "num_quantity";
            this.num_quantity.Size = new System.Drawing.Size(277, 20);
            this.num_quantity.TabIndex = 15;
            // 
            // btn_feltolt
            // 
            this.btn_feltolt.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_feltolt.Location = new System.Drawing.Point(12, 217);
            this.btn_feltolt.Name = "btn_feltolt";
            this.btn_feltolt.Size = new System.Drawing.Size(277, 79);
            this.btn_feltolt.TabIndex = 17;
            this.btn_feltolt.Text = "Insert product";
            this.btn_feltolt.UseVisualStyleBackColor = true;
            this.btn_feltolt.Click += new System.EventHandler(this.Btn_feltolt_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_back.Location = new System.Drawing.Point(12, 302);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(277, 64);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // GoodsInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(301, 381);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_feltolt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_quantity);
            this.Controls.Add(this.tb_product);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_price);
            this.Name = "GoodsInsert";
            this.Text = "AruFeltolt";
            ((System.ComponentModel.ISupportInitialize)(this.num_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_product;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_quantity;
        private System.Windows.Forms.Button btn_feltolt;
        private System.Windows.Forms.Button btn_back;
    }
}