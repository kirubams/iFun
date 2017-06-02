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
using iFun.BusinessLayer;

namespace iFunGameStation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GamePricing frm = new GamePricing();
            frm.Show();
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expenses frm = new Expenses();
            frm.Show();
        }

        private void numberOfSystemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumberOfSystemsfrm frm = new NumberOfSystemsfrm();
            frm.Show();
        }

        private void gameSystemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameSystems frm = new GameSystems();
            frm.Show();
        }

        private void dailyExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseTransactionfrm frm = new ExpenseTransactionfrm();
            frm.Show();
        }


        private void generateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports frm = new Reports();
            frm.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (ddlPlayerNo1.SelectedIndex != -1 || ddlMinutes1.SelectedIndex != -1)
            {
                var selectedPlayerNo = Convert.ToInt32(ddlPlayerNo1.SelectedItem);
                var minutes = Convert.ToInt32(ddlMinutes1.SelectedItem);
                bool isIndividualflag = false;
                if (rdbtnYesforInd1.Checked) { isIndividualflag = true; }
                bool isManualFlag = false;
                if (rdbtnYesManual1.Checked) { isManualFlag = true; }
                var manualPrice = 0;
                if (txtPrice1.Text != string.Empty || txtPrice1.Text != "")
                {
                    manualPrice = Convert.ToInt32(txtPrice1.Text);
                }
                var manualComments = txtComments1.Text;
                var systemOrderId = 1;
                if (btn1.Text == "GET PRICE")
                {
                    var incomeTran = GetPrice(systemOrderId, minutes, selectedPlayerNo, isIndividualflag);
                    DialogResult dialogResult = MessageBox.Show("Pay Rs." + incomeTran.FinalPrice, "Final Price!!!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        lblPrice1.Text = incomeTran.FinalPrice.ToString();
                        var flag = SavePrice(incomeTran.Game_SystemID, selectedPlayerNo, isIndividualflag, isManualFlag, manualPrice, manualComments, incomeTran.FinalPrice, systemOrderId, minutes);
                        if (flag)
                        {
                            MessageBox.Show("Price Saved!!!");
                            ddlPlayerNo1.SelectedIndex = -1;
                            ddlMinutes1.SelectedIndex = -1;
                            rdbtnNoManual1.Checked = true;
                            rdbtnNoforInd1.Checked = true;
                            txtPrice1.Text = "";
                            txtComments1.Text = "";
                            lblPrice1.Text = "PRICE!!!";
                        }
                        else
                        {
                            MessageBox.Show("Price Not Saved!!!");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else
                {
                    lblPrice1.Text = txtPrice1.Text;
                    IncomeTransactionBL incomeTranBl = new IncomeTransactionBL();
                    var gameSystemId = incomeTranBl.GetGameSystemId(1);//Gaem System Id - 1
                    var flag = SavePrice(gameSystemId, selectedPlayerNo, isIndividualflag, isManualFlag, manualPrice, manualComments, Convert.ToInt32(txtPrice1.Text), systemOrderId, minutes);
                    if (flag)
                    {
                        MessageBox.Show("Price Saved!!!");
                        ddlPlayerNo1.SelectedIndex = -1;
                        ddlMinutes1.SelectedIndex = -1;
                        rdbtnNoManual1.Checked = true;
                        rdbtnNoforInd1.Checked = true;
                        txtPrice1.Text = "";
                        txtComments1.Text = "";
                        lblPrice1.Text = "PRICE!!!";
                    }
                    else
                    {
                        MessageBox.Show("Price Not Saved!!!");
                    }

                }
            }
            else
            {
                MessageBox.Show("Player Number or Minutes cannot be empty!!!");
            }

        }

        private IncomeTransactionDTO GetPrice(int SystemOrderId, int minutes, int playerNo, bool isIndividual)
        {
            IncomeTransactionDTO incomeDTO = new IncomeTransactionDTO();
            incomeDTO.SystemOrderId = SystemOrderId;
            incomeDTO.noOfPlayers = playerNo;
            incomeDTO.isIndividual = isIndividual;
            incomeDTO.Minutes = minutes;
            IncomeTransactionBL incomeTranBl = new IncomeTransactionBL();
            return incomeTranBl.GetPrice(incomeDTO);
        }

        private bool SavePrice(int GameSystemID, int NoofPlayers, bool isIndividual, bool isManual, int manualPrice, string comments, int FinalPrice , int systemOrderId, int minutes)
        {
            IncomeTransactionDTO incomeDTO = new IncomeTransactionDTO();
            incomeDTO.Game_SystemID = GameSystemID;
            incomeDTO.noOfPlayers = NoofPlayers;
            incomeDTO.isIndividual = isIndividual;
            incomeDTO.isManual = isManual;
            incomeDTO.ManualPrice = manualPrice;
            incomeDTO.Comments = comments;
            incomeDTO.FinalPrice = FinalPrice;
            incomeDTO.SystemOrderId = systemOrderId;
            incomeDTO.Minutes = minutes;
            IncomeTransactionBL incomeTranBl = new IncomeTransactionBL();
            return incomeTranBl.SavePrice(incomeDTO);
        }
        
        private void ddlPlayerNo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var selectedPlayerNo = ddlPlayerNo1.SelectedText;
            //bool isIndividualflag = false;
            //if(rd)
        }

        private void rdbtnYesManual1_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbtnYesManual1.Checked)
            {
                pnlManual1.Visible = true;
                btn1.Text = "PAY!!!";
            }
            else
            {
                pnlManual1.Visible = false;
                btn1.Text = "GET PRICE";
            }
        }

        private void rdbtnNoManual1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnNoManual1.Checked)
            {
                pnlManual1.Visible = false;
                btn1.Text = "GET PRICE";
            }
            else
            {
                pnlManual1.Visible = true;
                btn1.Text = "PAY!!!";
            }

        }

        private void rdbtnYesforInd1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnNoforInd1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ddlPlayerNo2.SelectedIndex != -1 || ddlMinutes2.SelectedIndex != -1)
            {
                var selectedPlayerNo = Convert.ToInt32(ddlPlayerNo2.SelectedItem);
                var minutes = Convert.ToInt32(ddlMinutes2.SelectedItem);
                bool isIndividualflag = false;
                if (rdnYesForInd2.Checked) { isIndividualflag = true; }
                bool isManualFlag = false;
                if (rdnYesForMan2.Checked) { isManualFlag = true; }
                var manualPrice = 0;
                if (txtPrice2.Text != string.Empty || txtPrice2.Text != "")
                {
                    manualPrice = Convert.ToInt32(txtPrice2.Text);
                }
                var manualComments = txtComments2.Text;
                var systemOrderId = 2;
                if (btn2.Text == "GET PRICE")
                {
                    var incomeTran = GetPrice(systemOrderId, minutes, selectedPlayerNo, isIndividualflag);
                    DialogResult dialogResult = MessageBox.Show("Pay Rs." + incomeTran.FinalPrice, "Final Price!!!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        lblPrice2.Text = incomeTran.FinalPrice.ToString();
                        var flag = SavePrice(incomeTran.Game_SystemID, selectedPlayerNo, isIndividualflag, isManualFlag, manualPrice, manualComments, incomeTran.FinalPrice, systemOrderId, minutes);
                        if (flag)
                        {
                            MessageBox.Show("Price Saved!!!");
                            ddlPlayerNo2.SelectedIndex = -1;
                            ddlMinutes2.SelectedIndex = -1;
                            rdnNoForMan2.Checked = true;
                            rdnNoForInd2.Checked = true;
                            txtPrice2.Text = "";
                            txtComments2.Text = "";
                            lblPrice2.Text = "PRICE!!!";
                        }
                        else
                        {
                            MessageBox.Show("Price Not Saved!!!");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else
                {
                    lblPrice2.Text = txtPrice2.Text;
                    IncomeTransactionBL incomeTranBl = new IncomeTransactionBL();
                    var gameSystemId = incomeTranBl.GetGameSystemId(2);//Game System Id - 2
                    var flag = SavePrice(gameSystemId, selectedPlayerNo, isIndividualflag, isManualFlag, manualPrice, manualComments, Convert.ToInt32(txtPrice2.Text), systemOrderId, minutes);
                    if (flag)
                    {
                        MessageBox.Show("Price Saved!!!");
                        ddlPlayerNo2.SelectedIndex = -1;
                        ddlMinutes2.SelectedIndex = -1;
                        rdnNoForMan2.Checked = true;
                        rdnNoForInd2.Checked = true;
                        txtPrice2.Text = "";
                        txtComments2.Text = "";
                        lblPrice2.Text = "PRICE!!!";
                    }
                    else
                    {
                        MessageBox.Show("Price Not Saved!!!");
                    }

                }
            }
            else
            {
                MessageBox.Show("Player Number or Minutes cannot be empty!!!");
            }

        }

        private void rdnYesForMan2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnYesForMan2.Checked)
            {
                pnlManual2.Visible = true;
                btn2.Text = "PAY!!!";
            }
            else
            {
                pnlManual2.Visible = false;
                btn2.Text = "GET PRICE";
            }

        }

        private void rdnNoForMan2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnNoForMan2.Checked)
            {
                pnlManual2.Visible = false;
                btn2.Text = "GET PRICE";
            }
            else
            {
                pnlManual2.Visible = true;
                btn2.Text = "PAY!!!";
            }
        }

        private void rdnYesForMan3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnYesForMan3.Checked)
            {
                pnlManual3.Visible = true;
                btn3.Text = "PAY!!!";
            }
            else
            {
                pnlManual3.Visible = false;
                btn3.Text = "GET PRICE";
            }
        }

        private void rdnNoForMan3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnNoForMan3.Checked)
            {
                pnlManual3.Visible = false;
                btn3.Text = "GET PRICE";
            }
            else
            {
                pnlManual3.Visible = true;
                btn3.Text = "PAY!!!";
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (ddlPlayerNo3.SelectedIndex != -1 || ddlMinutes3.SelectedIndex != -1)
            {
                var selectedPlayerNo = Convert.ToInt32(ddlPlayerNo3.SelectedItem);
                var minutes = Convert.ToInt32(ddlMinutes3.SelectedItem);
                bool isIndividualflag = false;
                if (rdnYesForInd3.Checked) { isIndividualflag = true; }
                bool isManualFlag = false;
                if (rdnYesForMan3.Checked) { isManualFlag = true; }
                var manualPrice = 0;
                if (txtPrice3.Text != string.Empty || txtPrice3.Text != "")
                {
                    manualPrice = Convert.ToInt32(txtPrice3.Text);
                }
                var manualComments = txtComments3.Text;
                var systemOrderId = 3;
                if (btn3.Text == "GET PRICE")
                {
                    var incomeTran = GetPrice(systemOrderId, minutes, selectedPlayerNo, isIndividualflag);
                    DialogResult dialogResult = MessageBox.Show("Pay Rs." + incomeTran.FinalPrice, "Final Price!!!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        lblPrice3.Text = incomeTran.FinalPrice.ToString();
                        var flag = SavePrice(incomeTran.Game_SystemID, selectedPlayerNo, isIndividualflag, isManualFlag, manualPrice, manualComments, incomeTran.FinalPrice, systemOrderId, minutes);
                        if (flag)
                        {
                            MessageBox.Show("Price Saved!!!");
                            ddlPlayerNo3.SelectedIndex = -1;
                            ddlMinutes3.SelectedIndex = -1;
                            rdnNoForMan3.Checked = true;
                            rdnNoForInd3.Checked = true;
                            txtPrice3.Text = "";
                            txtComments3.Text = "";
                            lblPrice3.Text = "PRICE!!!";
                        }
                        else
                        {
                            MessageBox.Show("Price Not Saved!!!");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else
                {
                    lblPrice3.Text = txtPrice3.Text;
                    IncomeTransactionBL incomeTranBl = new IncomeTransactionBL();
                    var gameSystemId = incomeTranBl.GetGameSystemId(3);//Game System Id - 2
                    var flag = SavePrice(gameSystemId, selectedPlayerNo, isIndividualflag, isManualFlag, manualPrice, manualComments, Convert.ToInt32(txtPrice3.Text), systemOrderId, minutes);
                    if (flag)
                    {
                        MessageBox.Show("Price Saved!!!");
                        ddlPlayerNo3.SelectedIndex = -1;
                        ddlMinutes3.SelectedIndex = -1;
                        rdnNoForMan3.Checked = true;
                        rdnNoForInd3.Checked = true;
                        txtPrice3.Text = "";
                        txtComments3.Text = "";
                        lblPrice3.Text = "PRICE!!!";
                    }
                    else
                    {
                        MessageBox.Show("Price Not Saved!!!");
                    }

                }
            }
            else
            {
                MessageBox.Show("Player Number or Minutes cannot be empty!!!");
            }


        }

        private void rdnYesForMan4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnYesForMan4.Checked)
            {
                pnlManual4.Visible = true;
                btn4.Text = "PAY!!!";
            }
            else
            {
                pnlManual4.Visible = false;
                btn4.Text = "GET PRICE";
            }
        }

        private void rdnNoForMan4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnNoForMan4.Checked)
            {
                pnlManual4.Visible = false;
                btn4.Text = "GET PRICE";
            }
            else
            {
                pnlManual4.Visible = true;
                btn4.Text = "PAY!!!";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (ddlPlayerNo4.SelectedIndex != -1 || ddlMinutes4.SelectedIndex != -1)
            {
                var selectedPlayerNo = Convert.ToInt32(ddlPlayerNo4.SelectedItem);
                var minutes = Convert.ToInt32(ddlMinutes4.SelectedItem);
                bool isIndividualflag = false;
                if (rdnYesForInd4.Checked) { isIndividualflag = true; }
                bool isManualFlag = false;
                if (rdnYesForMan4.Checked) { isManualFlag = true; }
                var manualPrice = 0;
                if (txtPrice4.Text != string.Empty || txtPrice4.Text != "")
                {
                    manualPrice = Convert.ToInt32(txtPrice4.Text);
                }
                var manualComments = txtComments4.Text;
                var systemOrderId = 4;
                if (btn4.Text == "GET PRICE")
                {
                    var incomeTran = GetPrice(systemOrderId, minutes, selectedPlayerNo, isIndividualflag);
                    DialogResult dialogResult = MessageBox.Show("Pay Rs." + incomeTran.FinalPrice, "Final Price!!!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        lblPrice4.Text = incomeTran.FinalPrice.ToString();
                        var flag = SavePrice(incomeTran.Game_SystemID, selectedPlayerNo, isIndividualflag, isManualFlag, manualPrice, manualComments, incomeTran.FinalPrice, systemOrderId, minutes);
                        if (flag)
                        {
                            MessageBox.Show("Price Saved!!!");
                            ddlPlayerNo4.SelectedIndex = -1;
                            ddlMinutes4.SelectedIndex = -1;
                            rdnNoForMan4.Checked = true;
                            rdnNoForInd4.Checked = true;
                            txtPrice4.Text = "";
                            txtComments4.Text = "";
                            lblPrice4.Text = "PRICE!!!";
                        }
                        else
                        {
                            MessageBox.Show("Price Not Saved!!!");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else
                {
                    lblPrice4.Text = txtPrice4.Text;
                    IncomeTransactionBL incomeTranBl = new IncomeTransactionBL();
                    var gameSystemId = incomeTranBl.GetGameSystemId(4);//Game System Id - 4
                    var flag = SavePrice(gameSystemId, selectedPlayerNo, isIndividualflag, isManualFlag, manualPrice, manualComments, Convert.ToInt32(txtPrice4.Text), systemOrderId, minutes);
                    if (flag)
                    {
                        MessageBox.Show("Price Saved!!!");
                        ddlPlayerNo4.SelectedIndex = -1;
                        ddlMinutes4.SelectedIndex = -1;
                        rdnNoForMan4.Checked = true;
                        rdnNoForInd4.Checked = true;
                        txtPrice4.Text = "";
                        txtComments4.Text = "";
                        lblPrice4.Text = "PRICE!!!";
                    }
                    else
                    {
                        MessageBox.Show("Price Not Saved!!!");
                    }

                }
            }
            else
            {
                MessageBox.Show("Player Number or Minutes cannot be empty!!!");
            }


        }
        private void rdnYesForMan5_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnYesForMan5.Checked)
            {
                pnlManual5.Visible = true;
                btn5.Text = "PAY!!!";
            }
            else
            {
                pnlManual5.Visible = false;
                btn5.Text = "GET PRICE";
            }
        }

        private void rdnNoForMan5_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnNoForMan5.Checked)
            {
                pnlManual5.Visible = false;
                btn5.Text = "GET PRICE";
            }
            else
            {
                pnlManual5.Visible = true;
                btn5.Text = "PAY!!!";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (ddlPlayerNo5.SelectedIndex != -1 || ddlMinutes5.SelectedIndex != -1)
            {
                var selectedPlayerNo = Convert.ToInt32(ddlPlayerNo5.SelectedItem);
                var minutes = Convert.ToInt32(ddlMinutes5.SelectedItem);
                bool isIndividualflag = false;
                if (rdnYesForInd5.Checked) { isIndividualflag = true; }
                bool isManualFlag = false;
                if (rdnYesForMan5.Checked) { isManualFlag = true; }
                var manualPrice = 0;
                if (txtPrice5.Text != string.Empty || txtPrice5.Text != "")
                {
                    manualPrice = Convert.ToInt32(txtPrice5.Text);
                }
                var manualComments = txtComments5.Text;
                var systemOrderId = 5;
                if (btn5.Text == "GET PRICE")
                {
                    var incomeTran = GetPrice(systemOrderId, minutes, selectedPlayerNo, isIndividualflag);
                    DialogResult dialogResult = MessageBox.Show("Pay Rs." + incomeTran.FinalPrice, "Final Price!!!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        lblPrice5.Text = incomeTran.FinalPrice.ToString();
                        var flag = SavePrice(incomeTran.Game_SystemID, selectedPlayerNo, isIndividualflag, isManualFlag, manualPrice, manualComments, incomeTran.FinalPrice, systemOrderId, minutes);
                        if (flag)
                        {
                            MessageBox.Show("Price Saved!!!");
                            ddlPlayerNo5.SelectedIndex = -1;
                            ddlMinutes5.SelectedIndex = -1;
                            rdnNoForMan5.Checked = true;
                            rdnNoForInd5.Checked = true;
                            txtPrice5.Text = "";
                            txtComments5.Text = "";
                            lblPrice5.Text = "PRICE!!!";
                        }
                        else
                        {
                            MessageBox.Show("Price Not Saved!!!");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else
                {
                    lblPrice5.Text = txtPrice5.Text;
                    IncomeTransactionBL incomeTranBl = new IncomeTransactionBL();
                    var gameSystemId = incomeTranBl.GetGameSystemId(5);//Game System Id - 5
                    var flag = SavePrice(gameSystemId, selectedPlayerNo, isIndividualflag, isManualFlag, manualPrice, manualComments, Convert.ToInt32(txtPrice5.Text), systemOrderId, minutes);
                    if (flag)
                    {
                        MessageBox.Show("Price Saved!!!");
                        ddlPlayerNo5.SelectedIndex = -1;
                        ddlMinutes5.SelectedIndex = -1;
                        rdnNoForMan5.Checked = true;
                        rdnNoForInd5.Checked = true;
                        txtPrice5.Text = "";
                        txtComments5.Text = "";
                        lblPrice5.Text = "PRICE!!!";
                    }
                    else
                    {
                        MessageBox.Show("Price Not Saved!!!");
                    }

                }
            }
            else
            {
                MessageBox.Show("Player Number or Minutes cannot be empty!!!");
            }


        }

        private void rdnYesForMan6_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnYesForMan6.Checked)
            {
                pnlManual6.Visible = true;
                btn6.Text = "PAY!!!";
            }
            else
            {
                pnlManual6.Visible = false;
                btn6.Text = "GET PRICE";
            }
        }

        private void rdnNoForMan6_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnNoForMan6.Checked)
            {
                pnlManual6.Visible = false;
                btn6.Text = "GET PRICE";
            }
            else
            {
                pnlManual6.Visible = true;
                btn6.Text = "PAY!!!";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (ddlPlayerNo6.SelectedIndex != -1 || ddlMinutes6.SelectedIndex != -1)
            {
                var selectedPlayerNo = Convert.ToInt32(ddlPlayerNo6.SelectedItem);
                var minutes = Convert.ToInt32(ddlMinutes6.SelectedItem);
                bool isIndividualflag = false;
                if (rdnYesForInd6.Checked) { isIndividualflag = true; }
                bool isManualFlag = false;
                if (rdnYesForMan6.Checked) { isManualFlag = true; }
                var manualPrice = 0;
                if (txtPrice6.Text != string.Empty || txtPrice6.Text != "")
                {
                    manualPrice = Convert.ToInt32(txtPrice6.Text);
                }
                var manualComments = txtComments6.Text;
                var systemOrderId = 6;
                if (btn6.Text == "GET PRICE")
                {
                    var incomeTran = GetPrice(systemOrderId, minutes, selectedPlayerNo, isIndividualflag);
                    DialogResult dialogResult = MessageBox.Show("Pay Rs." + incomeTran.FinalPrice, "Final Price!!!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        lblPrice6.Text = incomeTran.FinalPrice.ToString();
                        var flag = SavePrice(incomeTran.Game_SystemID, selectedPlayerNo, isIndividualflag, isManualFlag, manualPrice, manualComments, incomeTran.FinalPrice, systemOrderId, minutes);
                        if (flag)
                        {
                            MessageBox.Show("Price Saved!!!");
                            ddlPlayerNo6.SelectedIndex = -1;
                            ddlMinutes6.SelectedIndex = -1;
                            rdnNoForMan6.Checked = true;
                            rdnNoForInd6.Checked = true;
                            txtPrice6.Text = "";
                            txtComments6.Text = "";
                            lblPrice6.Text = "PRICE!!!";
                        }
                        else
                        {
                            MessageBox.Show("Price Not Saved!!!");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else
                {
                    lblPrice6.Text = txtPrice6.Text;
                    IncomeTransactionBL incomeTranBl = new IncomeTransactionBL();
                    var gameSystemId = incomeTranBl.GetGameSystemId(6);//Game System Id - 6
                    var flag = SavePrice(gameSystemId, selectedPlayerNo, isIndividualflag, isManualFlag, manualPrice, manualComments, Convert.ToInt32(txtPrice6.Text), systemOrderId, minutes);
                    if (flag)
                    {
                        MessageBox.Show("Price Saved!!!");
                        ddlPlayerNo6.SelectedIndex = -1;
                        ddlMinutes6.SelectedIndex = -1;
                        rdnNoForMan6.Checked = true;
                        rdnNoForInd6.Checked = true;
                        txtPrice6.Text = "";
                        txtComments6.Text = "";
                        lblPrice6.Text = "PRICE!!!";
                    }
                    else
                    {
                        MessageBox.Show("Price Not Saved!!!");
                    }

                }
            }
            else
            {
                MessageBox.Show("Player Number or Minutes cannot be empty!!!");
            }


        }

        private void rdnYesForMan7_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnYesForMan7.Checked)
            {
                pnlManual7.Visible = true;
                btn7.Text = "PAY!!!";
            }
            else
            {
                pnlManual7.Visible = false;
                btn7.Text = "GET PRICE";
            }
        }

        private void rdnNoForMan7_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnNoForMan7.Checked)
            {
                pnlManual7.Visible = false;
                btn7.Text = "GET PRICE";
            }
            else
            {
                pnlManual7.Visible = true;
                btn7.Text = "PAY!!!";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (ddlPlayerNo7.SelectedIndex != -1 || ddlMinutes7.SelectedIndex != -1)
            {
                var selectedPlayerNo = Convert.ToInt32(ddlPlayerNo7.SelectedItem);
                var minutes = Convert.ToInt32(ddlMinutes7.SelectedItem);
                bool isIndividualflag = false;
                if (rdnYesForInd7.Checked) { isIndividualflag = true; }
                bool isManualFlag = false;
                if (rdnYesForMan7.Checked) { isManualFlag = true; }
                var manualPrice = 0;
                if (txtPrice7.Text != string.Empty || txtPrice7.Text != "")
                {
                    manualPrice = Convert.ToInt32(txtPrice7.Text);
                }
                var manualComments = txtComments7.Text;
                var systemOrderId = 7;
                if (btn7.Text == "GET PRICE")
                {
                    var incomeTran = GetPrice(systemOrderId, minutes, selectedPlayerNo, isIndividualflag);
                    DialogResult dialogResult = MessageBox.Show("Pay Rs." + incomeTran.FinalPrice, "Final Price!!!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        lblPrice7.Text = incomeTran.FinalPrice.ToString();
                        var flag = SavePrice(incomeTran.Game_SystemID, selectedPlayerNo, isIndividualflag, isManualFlag, manualPrice, manualComments, incomeTran.FinalPrice, systemOrderId, minutes);
                        if (flag)
                        {
                            MessageBox.Show("Price Saved!!!");
                            ddlPlayerNo7.SelectedIndex = -1;
                            ddlMinutes7.SelectedIndex = -1;
                            rdnNoForMan7.Checked = true;
                            rdnNoForInd7.Checked = true;
                            txtPrice7.Text = "";
                            txtComments7.Text = "";
                            lblPrice7.Text = "PRICE!!!";
                        }
                        else
                        {
                            MessageBox.Show("Price Not Saved!!!");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else
                {
                    lblPrice7.Text = txtPrice7.Text;
                    IncomeTransactionBL incomeTranBl = new IncomeTransactionBL();
                    var gameSystemId = incomeTranBl.GetGameSystemId(7);//Game System Id - 7
                    var flag = SavePrice(gameSystemId, selectedPlayerNo, isIndividualflag, isManualFlag, manualPrice, manualComments, Convert.ToInt32(txtPrice7.Text), systemOrderId, minutes);
                    if (flag)
                    {
                        MessageBox.Show("Price Saved!!!");
                        ddlPlayerNo7.SelectedIndex = -1;
                        ddlMinutes7.SelectedIndex = -1;
                        rdnNoForMan7.Checked = true;
                        rdnNoForInd7.Checked = true;
                        txtPrice7.Text = "";
                        txtComments7.Text = "";
                        lblPrice7.Text = "PRICE!!!";
                    }
                    else
                    {
                        MessageBox.Show("Price Not Saved!!!");
                    }

                }
            }
            else
            {
                MessageBox.Show("Player Number or Minutes cannot be empty!!!");
            }


        }

        private void rdnYesForMan8_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnYesForMan8.Checked)
            {
                pnlManual8.Visible = true;
                btn8.Text = "PAY!!!";
            }
            else
            {
                pnlManual8.Visible = false;
                btn8.Text = "GET PRICE";
            }
        }

        private void rdnNoForMan8_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnNoForMan8.Checked)
            {
                pnlManual8.Visible = false;
                btn8.Text = "GET PRICE";
            }
            else
            {
                pnlManual8.Visible = true;
                btn8.Text = "PAY!!!";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (ddlPlayerNo8.SelectedIndex != -1 || ddlMinutes8.SelectedIndex != -1)
            {
                var selectedPlayerNo = Convert.ToInt32(ddlPlayerNo8.SelectedItem);
                var minutes = Convert.ToInt32(ddlMinutes8.SelectedItem);
                bool isIndividualflag = false;
                if (rdnYesForInd8.Checked) { isIndividualflag = true; }
                bool isManualFlag = false;
                if (rdnYesForMan8.Checked) { isManualFlag = true; }
                var manualPrice = 0;
                if (txtPrice8.Text != string.Empty || txtPrice8.Text != "")
                {
                    manualPrice = Convert.ToInt32(txtPrice8.Text);
                }
                var manualComments = txtComments8.Text;
                var systemOrderId = 8;
                if (btn8.Text == "GET PRICE")
                {
                    var incomeTran = GetPrice(systemOrderId, minutes, selectedPlayerNo, isIndividualflag);
                    DialogResult dialogResult = MessageBox.Show("Pay Rs." + incomeTran.FinalPrice, "Final Price!!!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        lblPrice8.Text = incomeTran.FinalPrice.ToString();
                        var flag = SavePrice(incomeTran.Game_SystemID, selectedPlayerNo, isIndividualflag, isManualFlag, manualPrice, manualComments, incomeTran.FinalPrice, systemOrderId, minutes);
                        if (flag)
                        {
                            MessageBox.Show("Price Saved!!!");
                            ddlPlayerNo8.SelectedIndex = -1;
                            ddlMinutes8.SelectedIndex = -1;
                            rdnNoForMan8.Checked = true;
                            rdnNoForInd8.Checked = true;
                            txtPrice8.Text = "";
                            txtComments8.Text = "";
                            lblPrice8.Text = "PRICE!!!";
                        }
                        else
                        {
                            MessageBox.Show("Price Not Saved!!!");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else
                {
                    lblPrice8.Text = txtPrice8.Text;
                    IncomeTransactionBL incomeTranBl = new IncomeTransactionBL();
                    var gameSystemId = incomeTranBl.GetGameSystemId(8);//Game System Id - 8
                    var flag = SavePrice(gameSystemId, selectedPlayerNo, isIndividualflag, isManualFlag, manualPrice, manualComments, Convert.ToInt32(txtPrice8.Text), systemOrderId, minutes);
                    if (flag)
                    {
                        MessageBox.Show("Price Saved!!!");
                        ddlPlayerNo8.SelectedIndex = -1;
                        ddlMinutes8.SelectedIndex = -1;
                        rdnNoForMan8.Checked = true;
                        rdnNoForInd8.Checked = true;
                        txtPrice8.Text = "";
                        txtComments8.Text = "";
                        lblPrice8.Text = "PRICE!!!";
                    }
                    else
                    {
                        MessageBox.Show("Price Not Saved!!!");
                    }

                }
            }
            else
            {
                MessageBox.Show("Player Number or Minutes cannot be empty!!!");
            }


        }

    }


}
