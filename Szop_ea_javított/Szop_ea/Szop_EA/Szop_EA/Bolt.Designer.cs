namespace Szop_EA
{
    partial class Bolt
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
            this.btn_feltolt = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.vasar = new System.Windows.Forms.TabPage();
            this.php = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_mennyit = new System.Windows.Forms.NumericUpDown();
            this.btn_vasarlas = new System.Windows.Forms.Button();
            this.dgv_vasarolt = new System.Windows.Forms.DataGridView();
            this.feltolt = new System.Windows.Forms.TabPage();
            this.btn_aruTorles = new System.Windows.Forms.Button();
            this.btn_frissit = new System.Windows.Forms.Button();
            this.dgv_raktar = new System.Windows.Forms.DataGridView();
            this.logged = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.vasar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_mennyit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vasarolt)).BeginInit();
            this.feltolt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_raktar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_feltolt
            // 
            this.btn_feltolt.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_feltolt.Location = new System.Drawing.Point(568, 6);
            this.btn_feltolt.Name = "btn_feltolt";
            this.btn_feltolt.Size = new System.Drawing.Size(325, 53);
            this.btn_feltolt.TabIndex = 1;
            this.btn_feltolt.Text = "Árufeltöltés";
            this.btn_feltolt.UseVisualStyleBackColor = true;
            this.btn_feltolt.Click += new System.EventHandler(this.Btn_feltolt_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.vasar);
            this.tabControl1.Controls.Add(this.feltolt);
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 508);
            this.tabControl1.TabIndex = 2;
            // 
            // vasar
            // 
            this.vasar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vasar.Controls.Add(this.php);
            this.vasar.Controls.Add(this.label1);
            this.vasar.Controls.Add(this.num_mennyit);
            this.vasar.Controls.Add(this.btn_vasarlas);
            this.vasar.Controls.Add(this.dgv_vasarolt);
            this.vasar.Location = new System.Drawing.Point(4, 22);
            this.vasar.Name = "vasar";
            this.vasar.Padding = new System.Windows.Forms.Padding(3);
            this.vasar.Size = new System.Drawing.Size(899, 482);
            this.vasar.TabIndex = 0;
            this.vasar.Text = "Vásárlás";
            // 
            // php
            // 
            this.php.AutoSize = true;
            this.php.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.php.ForeColor = System.Drawing.Color.White;
            this.php.Location = new System.Drawing.Point(569, 446);
            this.php.Name = "php";
            this.php.Size = new System.Drawing.Size(94, 30);
            this.php.TabIndex = 4;
            this.php.Text = "getPHP";
            this.php.UseVisualStyleBackColor = true;
            this.php.CheckedChanged += new System.EventHandler(this.Php_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(569, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mennyit szeretne vásárolni?";
            // 
            // num_mennyit
            // 
            this.num_mennyit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_mennyit.Location = new System.Drawing.Point(569, 54);
            this.num_mennyit.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.num_mennyit.Name = "num_mennyit";
            this.num_mennyit.Size = new System.Drawing.Size(323, 34);
            this.num_mennyit.TabIndex = 2;
            // 
            // btn_vasarlas
            // 
            this.btn_vasarlas.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_vasarlas.Location = new System.Drawing.Point(568, 98);
            this.btn_vasarlas.Name = "btn_vasarlas";
            this.btn_vasarlas.Size = new System.Drawing.Size(324, 112);
            this.btn_vasarlas.TabIndex = 1;
            this.btn_vasarlas.Text = "Vásárlás";
            this.btn_vasarlas.UseVisualStyleBackColor = true;
            this.btn_vasarlas.Click += new System.EventHandler(this.Btn_vasarlas_Click);
            // 
            // dgv_vasarolt
            // 
            this.dgv_vasarolt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_vasarolt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_vasarolt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vasarolt.Location = new System.Drawing.Point(0, 0);
            this.dgv_vasarolt.MultiSelect = false;
            this.dgv_vasarolt.Name = "dgv_vasarolt";
            this.dgv_vasarolt.ReadOnly = true;
            this.dgv_vasarolt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vasarolt.Size = new System.Drawing.Size(562, 482);
            this.dgv_vasarolt.TabIndex = 0;
            // 
            // feltolt
            // 
            this.feltolt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.feltolt.Controls.Add(this.btn_aruTorles);
            this.feltolt.Controls.Add(this.btn_frissit);
            this.feltolt.Controls.Add(this.dgv_raktar);
            this.feltolt.Controls.Add(this.btn_feltolt);
            this.feltolt.Location = new System.Drawing.Point(4, 22);
            this.feltolt.Name = "feltolt";
            this.feltolt.Padding = new System.Windows.Forms.Padding(3);
            this.feltolt.Size = new System.Drawing.Size(899, 482);
            this.feltolt.TabIndex = 1;
            this.feltolt.Text = "Árufeltöltés";
            // 
            // btn_aruTorles
            // 
            this.btn_aruTorles.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_aruTorles.Location = new System.Drawing.Point(568, 124);
            this.btn_aruTorles.Name = "btn_aruTorles";
            this.btn_aruTorles.Size = new System.Drawing.Size(325, 53);
            this.btn_aruTorles.TabIndex = 3;
            this.btn_aruTorles.Text = "Árutörlés";
            this.btn_aruTorles.UseVisualStyleBackColor = true;
            this.btn_aruTorles.Click += new System.EventHandler(this.Btn_aruTorles_Click);
            // 
            // btn_frissit
            // 
            this.btn_frissit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_frissit.Location = new System.Drawing.Point(568, 65);
            this.btn_frissit.Name = "btn_frissit";
            this.btn_frissit.Size = new System.Drawing.Size(325, 53);
            this.btn_frissit.TabIndex = 2;
            this.btn_frissit.Text = "Árufrissítés";
            this.btn_frissit.UseVisualStyleBackColor = true;
            this.btn_frissit.Click += new System.EventHandler(this.Btn_frissit_Click);
            // 
            // dgv_raktar
            // 
            this.dgv_raktar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_raktar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_raktar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_raktar.Location = new System.Drawing.Point(0, 0);
            this.dgv_raktar.MultiSelect = false;
            this.dgv_raktar.Name = "dgv_raktar";
            this.dgv_raktar.ReadOnly = true;
            this.dgv_raktar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_raktar.Size = new System.Drawing.Size(562, 482);
            this.dgv_raktar.TabIndex = 0;
            // 
            // logged
            // 
            this.logged.AutoSize = true;
            this.logged.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logged.ForeColor = System.Drawing.Color.White;
            this.logged.Location = new System.Drawing.Point(506, 12);
            this.logged.Name = "logged";
            this.logged.Size = new System.Drawing.Size(49, 20);
            this.logged.TabIndex = 3;
            this.logged.Text = "label1";
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_logout.Location = new System.Drawing.Point(777, 4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(135, 34);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Kijelentkezés ->";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // Bolt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(931, 546);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.logged);
            this.Controls.Add(this.tabControl1);
            this.Name = "Bolt";
            this.Text = "Bolt";
            this.tabControl1.ResumeLayout(false);
            this.vasar.ResumeLayout(false);
            this.vasar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_mennyit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vasarolt)).EndInit();
            this.feltolt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_raktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_feltolt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage vasar;
        private System.Windows.Forms.DataGridView dgv_vasarolt;
        private System.Windows.Forms.TabPage feltolt;
        private System.Windows.Forms.Button btn_aruTorles;
        private System.Windows.Forms.Button btn_frissit;
        private System.Windows.Forms.DataGridView dgv_raktar;
        private System.Windows.Forms.Label logged;
        private System.Windows.Forms.Button btn_vasarlas;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_mennyit;
        private System.Windows.Forms.CheckBox php;
    }
}