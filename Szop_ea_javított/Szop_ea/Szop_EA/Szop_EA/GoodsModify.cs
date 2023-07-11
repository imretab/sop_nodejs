using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szop_EA.Command;

namespace Szop_EA
{
    public partial class GoodsModify : Form
    {
        private GoodsData data;
        public GoodsModify(GoodsData data = null)
        {
            InitializeComponent();
            this.data = data;
            tb_product.Text = data.ProductName;
            num_price.Value = data.Price;
            num_quantity.Value = data.Quantity;
        }
        private bool areAllEmpty()
        {
            return tb_product.Text.Length <= 0 ||
                num_price.Value.ToString().Length <= 0 ||
                num_quantity.Value.ToString().Length <= 0;
        }
        private bool lessThanZero()
        {
            return num_price.Value <= 0 ||
                num_quantity.Value <= 0;
        }
        public void ModifyGoods(string goodsName, int price, int quantity)
        {
            try
            {
                int priceC, quantityC;
                if (areAllEmpty())
                {
                    MessageBox.Show("All the fields should be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!(int.TryParse(price.ToString(), out priceC)) && !(int.TryParse(quantity.ToString(), out quantityC)))
                {
                    MessageBox.Show("Quantity should be number type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (lessThanZero())
                {
                    MessageBox.Show("Value of price or quantity should be higher than 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    UpdateGoodsCommand updateGoodsCommand = new UpdateGoodsCommand(data, goodsName, price, quantity);
                    updateGoodsCommand.execute();
                    this.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            ModifyGoods(tb_product.Text, (int)num_price.Value, (int)num_quantity.Value);
        }
    }
}
