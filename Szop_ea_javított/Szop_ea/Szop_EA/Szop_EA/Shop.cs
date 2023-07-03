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

namespace Szop_EA
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
            UpdatePurchaseList();
            logged.Text = $"Greetings {Login.uName}";
        }
        private void UpdatePurchaseList()
        {
            RestRequest request = new RestRequest("inventory", Method.Get);
            RestResponse response = Login.Client.Execute(request);
            PossibleErrors(request);
            List<GoodsData> goods = JsonSerializer.Deserialize<List<GoodsData>>(response.Content);
            dgv_purchase.DataSource = goods;
            dgv_inventory.DataSource = goods;
            dgv_inventory.Columns[0].Visible = false;
            dgv_purchase.Columns[0].Visible = false;
        }
        private void PossibleErrors(RestRequest request)
        {
            RestResponse response = Login.Client.Execute(request);
            if (response.StatusCode == 0)
            {
                MessageBox.Show("Connecting to server failed!");
                return;
            }
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"ERROR: {response.ErrorMessage}");
                return;
            }
        }
        private void GetResponse(RestRequest request)
        {
            RestResponse response = Login.Client.Execute(request);
            if (response.StatusCode == 0)
            {
                MessageBox.Show("Connecting to server failed!");
                return;
            }
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show($"ERROR: {response.ErrorMessage}");
                return;
            }
            Response res = Login.Client.Deserialize<Response>(response).Data;
            if (res.Status == 1)
            {
                MessageBox.Show(res.Msg, "Success");
            }
            else
            {
                MessageBox.Show(res.Msg, "Error");
            }
        }

        private void Delete()
        {
            try
            {
                GoodsData adatok = dgv_inventory.CurrentRow.DataBoundItem as GoodsData;
                int id = adatok.ID;
                RestRequest request = new RestRequest($"inventory/{id}", Method.Delete);
                if(adatok == null) { throw new Exception(); }
                request.AddJsonBody(new
                {
                    username = Login.uName,
                    password = Login.password,
                });
                GetResponse(request);
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
                RestRequest request = new RestRequest("purchase", Method.Put);
                GoodsData goods = dgv_purchase.CurrentRow.DataBoundItem as GoodsData;
                if (goods == null) { throw new Exception(); }
                if (num_amount.Value <= 0)
                {
                    MessageBox.Show("You can't buy items if the value of quantity is less or equals to 0", "ERROR");
                    return;
                }
                if (num_amount.Value > goods.Mennyiseg)
                {
                    MessageBox.Show("You can't buy more than what's in stock", "ERROR");
                    return;
                }
                request.AddJsonBody(new
                {
                    username = Login.uName,
                    password = Login.password,
                    id = goods.ID,
                    quantity = num_amount.Value
                });
                GetResponse(request);
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
        private void Btn_vasarlas_Click(object sender, EventArgs e)
        {
            Purchase();
            UpdatePurchaseList();
        }

        private void Php_CheckedChanged(object sender, EventArgs e)
        {
            RestRequest request = null;
            if (php.Checked)
            {
                request = new RestRequest("php", Method.Get);
                RestResponse response = Login.Client.Execute(request);
                PossibleErrors(request);
                List<UtalasAdatok> adatok = JsonSerializer.Deserialize<List<UtalasAdatok>>(response.Content);
                dgv_purchase.DataSource = adatok;
            }
            else
            {
                request = new RestRequest("inventory", Method.Get);
                RestResponse response = Login.Client.Execute(request);
                PossibleErrors(request);
                List<GoodsData> aruk = JsonSerializer.Deserialize<List<GoodsData>>(response.Content);
                dgv_purchase.DataSource = aruk;
            }
            dgv_inventory.Columns[0].Visible = false;
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
                GoodsData adatok = dgv_inventory.CurrentRow.DataBoundItem as GoodsData;
                if (adatok == null)
                {
                    throw new Exception();
                }
                else
                {
                    GoodsModify mod = new GoodsModify(adatok);
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
        }
    }
}
