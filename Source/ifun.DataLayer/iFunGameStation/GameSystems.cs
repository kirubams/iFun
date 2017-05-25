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

namespace iFunGameStation
{
    public partial class GameSystems : Form
    {
        public GameSystems()
        {
            InitializeComponent();
        }

        private void GameSystems_Load(object sender, EventArgs e)
        {
            LoadGameSystems();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                if (btnAdd.Text == "ADD")
                {
                    GameSystemsDTO gameSystemDTO = new GameSystemsDTO();
                    gameSystemDTO.Name = txtName.Text;
                    gameSystemDTO.ModelNo = txtModelNo.Text;

                    BL.GameSystems gameSys = new BL.GameSystems();
                    var result = gameSys.AddGameSystems(gameSystemDTO);
                    LoadGameSystems();

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
                    GameSystemsDTO gameSystemDTO = new GameSystemsDTO();
                    gameSystemDTO.Name = txtName.Text;
                    gameSystemDTO.ModelNo = txtModelNo.Text;
                    gameSystemDTO.GameSystemID = Convert.ToInt32(dgGameSystems.CurrentRow.Cells["GameSystemID"].Value);
                    BL.GameSystems gameSys = new BL.GameSystems();
                    var result = gameSys.UpdateGameSystems(gameSystemDTO);
                    btnAdd.Text = "ADD";

                }
                clear();
                LoadGameSystems();
            }
            else
            {
                MessageBox.Show("Name or Model No cannot be Empty");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            var selectedName = dgGameSystems.CurrentRow.Cells["Description"].Value.ToString();

            var selectedModel = dgGameSystems.CurrentRow.Cells["ModelNo"].Value.ToString();

            txtName.Text = selectedName;
            txtModelNo.Text = selectedModel;
            btnAdd.Text = "Update";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var gameSystemID = dgGameSystems.CurrentRow.Cells["GameSystemID"].Value.ToString();
            BL.GameSystems gameSys = new BL.GameSystems();
            var result = gameSys.DeleteGameSystems(Convert.ToInt32(gameSystemID));
            if (result)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Error");
            }
            clear();
            LoadGameSystems();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadGameSystems()
        {
            BL.GameSystems gameSys = new BL.GameSystems();

            dgGameSystems.DataSource = gameSys.GetGameSystems().Select(o => new
            { GameSystemID = o.GameSystemID, Description = o.Description, ModelNo = o.ModelNo }).ToList();

           if(dgGameSystems.Rows.Count == 0)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
           
        }

        private void clear()
        {
            txtName.Text = "";
            txtModelNo.Text = "";
        }

        private bool validate()
        {
            var flag = true;
            if(txtName.Text == string.Empty || txtModelNo.Text == string.Empty)
            {
                flag = false;
            }
            return flag;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
