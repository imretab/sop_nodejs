namespace Szop_EA
{
    partial class Shop
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
            this.btn_insert = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.purchase = new System.Windows.Forms.TabPage();
            this.php = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_amount = new System.Windows.Forms.NumericUpDown();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.dgv_purchase = new System.Windows.Forms.DataGridView();
            this.insert = new System.Windows.Forms.TabPage();
            this.btn_goodsDelete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.dgv_inventory = new System.Windows.Forms.DataGridView();
            this.logged = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.purchasehistory = new System.Windows.Forms.TabPage();
            this.dgv_PurchaseHistory = new System.Windows.Forms.DataGridView();
            this.loggedUser = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.purchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_purchase)).BeginInit();
            this.insert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).BeginInit();
            this.purchasehistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PurchaseHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_insert.Location = new System.Drawing.Point(568, 6);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(325, 53);
            this.btn_insert.TabIndex = 1;
            this.btn_insert.Text = "Product Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.purchase);
            this.tabControl1.Controls.Add(this.insert);
            this.tabControl1.Controls.Add(this.purchasehistory);
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 508);
            this.tabControl1.TabIndex = 2;
            // 
            // purchase
            // 
            this.purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchase.Controls.Add(this.php);
            this.purchase.Controls.Add(this.label1);
            this.purchase.Controls.Add(this.num_amount);
            this.purchase.Controls.Add(this.btn_purchase);
            this.purchase.Controls.Add(this.dgv_purchase);
            this.purchase.Location = new System.Drawing.Point(4, 22);
            this.purchase.Name = "purchase";
            this.purchase.Padding = new System.Windows.Forms.Padding(3);
            this.purchase.Size = new System.Drawing.Size(899, 482);
            this.purchase.TabIndex = 0;
            this.purchase.Text = "Purchase";
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
            this.label1.Size = new System.Drawing.Size(284, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "How much do you want to buy?";
            // 
            // num_amount
            // 
            this.num_amount.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_amount.Location = new System.Drawing.Point(569, 54);
            this.num_amount.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.num_amount.Name = "num_amount";
            this.num_amount.Size = new System.Drawing.Size(323, 34);
            this.num_amount.TabIndex = 2;
            // 
            // btn_purchase
            // 
            this.btn_purchase.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_purchase.Location = new System.Drawing.Point(568, 98);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(324, 112);
            this.btn_purchase.TabIndex = 1;
            this.btn_purchase.Text = "Buy";
            this.btn_purchase.UseVisualStyleBackColor = true;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // dgv_purchase
            // 
            this.dgv_purchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_purchase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_purchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_purchase.Location = new System.Drawing.Point(0, 0);
            this.dgv_purchase.MultiSelect = false;
            this.dgv_purchase.Name = "dgv_purchase";
            this.dgv_purchase.ReadOnly = true;
            this.dgv_purchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_purchase.Size = new System.Drawing.Size(562, 482);
            this.dgv_purchase.TabIndex = 0;
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insert.Controls.Add(this.btn_goodsDelete);
            this.insert.Controls.Add(this.btn_modify);
            this.insert.Controls.Add(this.dgv_inventory);
            this.insert.Controls.Add(this.btn_insert);
            this.insert.Location = new System.Drawing.Point(4, 22);
            this.insert.Name = "insert";
            this.insert.Padding = new System.Windows.Forms.Padding(3);
            this.insert.Size = new System.Drawing.Size(899, 482);
            this.insert.TabIndex = 1;
            this.insert.Text = "Goods";
            // 
            // btn_goodsDelete
            // 
            this.btn_goodsDelete.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_goodsDelete.Location = new System.Drawing.Point(568, 124);
            this.btn_goodsDelete.Name = "btn_goodsDelete";
            this.btn_goodsDelete.Size = new System.Drawing.Size(325, 53);
            this.btn_goodsDelete.TabIndex = 3;
            this.btn_goodsDelete.Text = "Product Delete";
            this.btn_goodsDelete.UseVisualStyleBackColor = true;
            this.btn_goodsDelete.Click += new System.EventHandler(this.btn_goodsDelete_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_modify.Location = new System.Drawing.Point(568, 65);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(325, 53);
            this.btn_modify.TabIndex = 2;
            this.btn_modify.Text = "Product Modify";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // dgv_inventory
            // 
            this.dgv_inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_inventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inventory.Location = new System.Drawing.Point(0, 0);
            this.dgv_inventory.MultiSelect = false;
            this.dgv_inventory.Name = "dgv_inventory";
            this.dgv_inventory.ReadOnly = true;
            this.dgv_inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_inventory.Size = new System.Drawing.Size(562, 482);
            this.dgv_inventory.TabIndex = 0;
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
            this.btn_logout.Size = new System.Drawing.Size(135, 32);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logout ->";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // purchasehistory
            // 
            this.purchasehistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchasehistory.Controls.Add(this.loggedUser);
            this.purchasehistory.Controls.Add(this.dgv_PurchaseHistory);
            this.purchasehistory.Location = new System.Drawing.Point(4, 22);
            this.purchasehistory.Name = "purchasehistory";
            this.purchasehistory.Size = new System.Drawing.Size(899, 482);
            this.purchasehistory.TabIndex = 2;
            this.purchasehistory.Text = "PurchaseHistory";
            // 
            // dgv_PurchaseHistory
            // 
            this.dgv_PurchaseHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PurchaseHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_PurchaseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PurchaseHistory.Location = new System.Drawing.Point(0, 35);
            this.dgv_PurchaseHistory.MultiSelect = false;
            this.dgv_PurchaseHistory.Name = "dgv_PurchaseHistory";
            this.dgv_PurchaseHistory.ReadOnly = true;
            this.dgv_PurchaseHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_PurchaseHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PurchaseHistory.Size = new System.Drawing.Size(899, 444);
            this.dgv_PurchaseHistory.TabIndex = 0;
            // 
            // loggedUser
            // 
            this.loggedUser.AutoSize = true;
            this.loggedUser.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.loggedUser.ForeColor = System.Drawing.Color.White;
            this.loggedUser.Location = new System.Drawing.Point(3, 9);
            this.loggedUser.Name = "loggedUser";
            this.loggedUser.Size = new System.Drawing.Size(51, 20);
            this.loggedUser.TabIndex = 1;
            this.loggedUser.Text = "label2";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_refresh.Image = global::Szop_EA.Properties.Resources.refresh_ico;
            this.btn_refresh.Location = new System.Drawing.Point(739, 4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(32, 32);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(931, 546);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.logged);
            this.Controls.Add(this.tabControl1);
            this.Name = "Shop";
            this.Text = "Bolt";
            this.tabControl1.ResumeLayout(false);
            this.purchase.ResumeLayout(false);
            this.purchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_purchase)).EndInit();
            this.insert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventory)).EndInit();
            this.purchasehistory.ResumeLayout(false);
            this.purchasehistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PurchaseHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage purchase;
        private System.Windows.Forms.DataGridView dgv_purchase;
        private System.Windows.Forms.TabPage insert;
        private System.Windows.Forms.Button btn_goodsDelete;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.DataGridView dgv_inventory;
        private System.Windows.Forms.Label logged;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_amount;
        private System.Windows.Forms.CheckBox php;
        private System.Windows.Forms.TabPage purchasehistory;
        private System.Windows.Forms.Label loggedUser;
        private System.Windows.Forms.DataGridView dgv_PurchaseHistory;
        private System.Windows.Forms.Button btn_refresh;
    }
}