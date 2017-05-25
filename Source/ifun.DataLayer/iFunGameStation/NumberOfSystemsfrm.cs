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
    public partial class NumberOfSystemsfrm : Form
    {
        public NumberOfSystemsfrm()
        {
            InitializeComponent();
        }

        private void NumberOfSystemsfrm_Load(object sender, EventArgs e)
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

            BL.NumberOfSystemBL noOfSystems = new BL.NumberOfSystemBL();
            var noOfSystemList = noOfSystems.GetNumberOfSystem();

            var lst = (from gameSysl in gameSyslist
                       join noOfSysList in noOfSystemList
                       on gameSysl.GameSystemID equals noOfSysList.Game_SystemID
                       select new
                       {
                           noOfSysList.ID,
                           gameSysl.GameSystemID,
                           gameSysl.Description,
                           noOfSysList.SystemOrderId
                            }
                                 ).ToList();
            dgNoOfSystemsview.DataSource = lst;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "ADD")
            {
                var gameSystemID = (ComboboxItem)ddlsystemName.SelectedItem;
                var systemNo = ddlSystemNo.SelectedItem;
                
                NumberOfSystemDTO numberOfSystemDTO = new NumberOfSystemDTO();
                numberOfSystemDTO.Game_SystemID = Convert.ToInt32(gameSystemID.Value);
                numberOfSystemDTO.SystemOrderId = Convert.ToInt32(systemNo);


                BL.NumberOfSystemBL obj = new BL.NumberOfSystemBL();
                var result = obj.AddNumberOfSystem(numberOfSystemDTO);

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
                var systemNo = ddlSystemNo.SelectedItem;
                //var price = Convert.ToInt32(txtprice.Text);
                //var minutes = Convert.ToInt32(txtMins.Text);
                //var individualPrice = Convert.ToInt32(txtIndividualPrice.Text);
                var ID = dgNoOfSystemsview.CurrentRow.Cells["ID"].Value.ToString();
                NumberOfSystemDTO numberOfSystemDTO = new NumberOfSystemDTO();
                numberOfSystemDTO.ID = Convert.ToInt32(ID);
                numberOfSystemDTO.Game_SystemID = Convert.ToInt32(gameSystemID.Value);
                numberOfSystemDTO.SystemOrderId = Convert.ToInt32(systemNo);
                
                BL.NumberOfSystemBL obj = new BL.NumberOfSystemBL();
                var result = obj.UpdateNumberOfSystems(numberOfSystemDTO);

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
            ddlSystemNo.SelectedIndex = -1;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ComboboxItem obj = new ComboboxItem();
            ////obj.Text = dgPricingview.CurrentRow.Cells["Description"].Value.ToString();
            ////obj.Value = Convert.ToInt32(dgPricingview.CurrentRow.Cells["GameSystemID"].Value);
            ////ddlsystemName.SelectedItem = obj;
            ////ddlsystemName.SelectedText = dgPricingview.CurrentRow.Cells["Description"].Value.ToString(); 
            ////ddlsystemName.SelectedValue = dgPricingview.CurrentRow.Cells["GameSystemID"].Value.ToString();
            ddlSystemNo.SelectedItem = dgNoOfSystemsview.CurrentRow.Cells["SystemOrderId"].Value.ToString();
            btnAdd.Text = "Update";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            LoadDefaultValues();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var ID = dgNoOfSystemsview.CurrentRow.Cells["ID"].Value.ToString();
            BL.NumberOfSystemBL obj = new BL.NumberOfSystemBL();
            var result = obj.DeleteNumberOfSystems(Convert.ToInt32(ID));
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }
    }
}
