using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iFun.DTO;
using BL = iFun.BusinessLayer;
using iFun.Utilities;

namespace iFunGameStation
{
    public partial class GamePricing : Form
    {
        public GamePricing()
        {
            InitializeComponent();
        }

        private void GamePricing_Load(object sender, EventArgs e)
        {
            LoadDefaultValues();
        }

        private void LoadDefaultValues()
        {
            //Load Default Game System Names
            BL.GameSystems gameSys = new BL.GameSystems();
            ddlsystemName.Items.Clear();
            var gameSyslist = gameSys.GetGameSystems();

            foreach (var gamesystem in gameSyslist)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = gamesystem.Description;
                item.Value = gamesystem.GameSystemID;
                ddlsystemName.Items.Add(item);


            }

            BL.GamePricingBL gamePrice = new BL.GamePricingBL();
            var gamePriceList = gamePrice.GetGamePrice();
           
            var lst = (from gameSysl in gameSyslist
                                 join pricelist in gamePriceList
                                 on gameSysl.GameSystemID equals pricelist.Game_SystemID
                                 select new
                                 {
                                     pricelist.PriceID,
                                     gameSysl.GameSystemID,
                                     gameSysl.Description,
                                     pricelist.PlayerNo,
                                     pricelist.Price,
                                     pricelist.Minutes,
                                     pricelist.IndividualPrice
                                 }
                                 ).ToList();
            dgPricingview.DataSource = lst;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "ADD")
            {
                var gameSystemID = (ComboboxItem)ddlsystemName.SelectedItem;
                var playerNo = ddlPlayerNo.SelectedItem;
                var price = Convert.ToInt32(txtprice.Text);
                var minutes = Convert.ToInt32(txtMins.Text);
                var individualPrice = Convert.ToInt32(txtIndividualPrice.Text);

                GamePriceDTO gamepriceDTO = new GamePriceDTO();
                gamepriceDTO.Game_SystemID = Convert.ToInt32(gameSystemID.Value);
                gamepriceDTO.PlayerNo = Convert.ToInt32(playerNo);
                gamepriceDTO.Price = price;
                gamepriceDTO.Minutes = minutes;
                gamepriceDTO.IndividualPrice = individualPrice;

                BL.GamePricingBL obj = new BL.GamePricingBL();
                var result = obj.AddGamePrice(gamepriceDTO);

                if (result)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                var gameSystemID = (ComboboxItem)ddlsystemName.SelectedItem;
                var playerNo = ddlPlayerNo.SelectedItem;
                var price = Convert.ToInt32(txtprice.Text);
                var minutes = Convert.ToInt32(txtMins.Text);
                var individualPrice = Convert.ToInt32(txtIndividualPrice.Text);
                var priceID = dgPricingview.CurrentRow.Cells["PriceID"].Value.ToString();
                GamePriceDTO gamepriceDTO = new GamePriceDTO();
                gamepriceDTO.PriceID = Convert.ToInt32(priceID);
                gamepriceDTO.Game_SystemID = Convert.ToInt32(gameSystemID.Value);
                gamepriceDTO.PlayerNo = Convert.ToInt32(playerNo);
                gamepriceDTO.Price = price;
                gamepriceDTO.Minutes = minutes;
                gamepriceDTO.IndividualPrice = individualPrice;

                BL.GamePricingBL obj = new BL.GamePricingBL();
                var result = obj.UpdateGamePrice(gamepriceDTO);

                if (result)
                {
                    MessageBox.Show("Updated");
                    btnAdd.Text = "ADD";
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            clear();
            LoadDefaultValues();


        }

        private void clear()
        {
            ddlsystemName.SelectedIndex = -1;
            ddlPlayerNo.SelectedIndex = -1;
            txtprice.Text = "";
            txtMins.Text = "";
            txtIndividualPrice.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ComboboxItem obj = new ComboboxItem();
            ////obj.Text = dgPricingview.CurrentRow.Cells["Description"].Value.ToString();
            ////obj.Value = Convert.ToInt32(dgPricingview.CurrentRow.Cells["GameSystemID"].Value);
            ////ddlsystemName.SelectedItem = obj;
            ////ddlsystemName.SelectedText = dgPricingview.CurrentRow.Cells["Description"].Value.ToString(); 
            ////ddlsystemName.SelectedValue = dgPricingview.CurrentRow.Cells["GameSystemID"].Value.ToString();
            ddlPlayerNo.SelectedItem = dgPricingview.CurrentRow.Cells["PlayerNo"].Value.ToString();
            txtprice.Text = dgPricingview.CurrentRow.Cells["Price"].Value.ToString(); ;
            txtMins.Text = dgPricingview.CurrentRow.Cells["Minutes"].Value.ToString(); ;
            txtIndividualPrice.Text = dgPricingview.CurrentRow.Cells["IndividualPrice"].Value.ToString(); ;
            btnAdd.Text = "Update";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            LoadDefaultValues();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var priceID = dgPricingview.CurrentRow.Cells["PriceID"].Value.ToString();
            BL.GamePricingBL obj = new BL.GamePricingBL();
            var result = obj.DeleteGamePrice(Convert.ToInt32(priceID));
            if (result)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Error");
            }
            LoadDefaultValues();
        }

        private void dgPricingview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIndividualPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIndividualPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtMins_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMins_Click(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void ddlPlayerNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ddlsystemName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void lblSystemName_Click(object sender, EventArgs e)
        {

        }
    }


}
