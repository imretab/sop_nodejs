using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szop_EA.Command;

namespace Szop_EA
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
            UpdatePurchaseList();
            UpdatePurchaseHistoryList();
            logged.Text = $"Greetings {Login.uName}";
            loggedUser.Text = $"{Login.uName}'s purchase history";
        }
        private void UpdatePurchaseList()
        {
            GetInventoryItemsCommand getInventoryItemsCommand = new GetInventoryItemsCommand(dgv_purchase,dgv_inventory);
            getInventoryItemsCommand.execute();
        }
        private void UpdatePurchaseHistoryList()
        {
            GetPurchaseHistoryCommand getPurchaseHistoryCommand = new GetPurchaseHistoryCommand(dgv_PurchaseHistory);
            getPurchaseHistoryCommand.execute();
        }
        private void Delete()
        {
            try
            {
                DeleteSelectedItemCommand deleteSelectedItemCommand = new DeleteSelectedItemCommand(dgv_inventory);
                deleteSelectedItemCommand.execute();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Purchase()
        {
            try
            {
                PurchaseCommand purchaseCommand = new PurchaseCommand(dgv_purchase, num_amount);
                purchaseCommand.execute();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                php.Checked = false;
            }
        }
        private void Btn_logout_Click(object sender, EventArgs e)
        {
            Login.uName = null;
            Login.password = null;
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }
        private void Php_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (php.Checked)
                {
                    GetTransferDataCommand getTransferDataCommand = new GetTransferDataCommand(dgv_purchase);
                    getTransferDataCommand.execute();
                }
                else
                {
                    GetInventoryItemsCommand getInventoryItemsCommand = new GetInventoryItemsCommand(dgv_purchase, dgv_inventory);
                    getInventoryItemsCommand.execute();
                }
                dgv_inventory.Columns[0].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_goodsDelete_Click(object sender, EventArgs e)
        {
            DialogResult torolE = MessageBox.Show("Are you sure that you'd like to delete the selected item?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (torolE == DialogResult.Yes)
            {
                Delete();
                UpdatePurchaseList();
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            try
            {
                GoodsData data = dgv_inventory.CurrentRow.DataBoundItem as GoodsData;
                if (data == null)
                {
                    throw new Exception();
                }
                else
                {
                    GoodsModify mod = new GoodsModify(data);
                    mod.ShowDialog();
                    UpdatePurchaseList();
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            GoodsInsert goodsInsert = new GoodsInsert();
            goodsInsert.ShowDialog();
            UpdatePurchaseList();
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            Purchase();
            UpdatePurchaseList();
            UpdatePurchaseHistoryList();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            UpdatePurchaseList();
            UpdatePurchaseHistoryList();
        }
    }
}
