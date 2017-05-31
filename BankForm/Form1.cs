using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankForm
{
    public partial class Form1 : Form
    {

        private ClientDB clientDB = null;
        private Client client = null;
        public Form1()
        {
            InitializeComponent();
            tabPage1.Text = "Клиент";
            tabPage2.Text = "Менеджер по кредиту";
            tabPage3.Text = "Менеджер по депозиту";
            tabPage4.Text = "Менеджер по страхованию";
            tabPage5.Text = "Менеджер по карте";
            tabPage6.Text = "Кассир";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ClientsDB.UpdateFile(false, true);
            Credits.SetCredits();


            Requests.UpdateFile(false, true);

            InitTableCreditsManager();
            InitTableCashier();
            //Кнопки
            EnterClient.Enabled = true;
            ExitClient.Enabled = false;
            ReqestButtonClient.Visible = false;
            GetInfoButtonClient.Visible = false;

            AddRequestBox.Visible = false;
            InfoClient.Visible = false;




        }

        private void EnterClient_Click(object sender, EventArgs e)
        {
            Console.WriteLine("dsdsd");
            if (LoginClient.Text == "" || FIOClient.Text == "")
                return;

            EnterClient.Enabled = false;
            LoginClientLable.Visible = false;
            LoginClient.Visible = false;
            FIOClient.Visible = false;
            FIOClientLable.Visible = false;
            ExitClient.Enabled = true;
            ReqestButtonClient.Visible = true;
            GetInfoButtonClient.Visible = true;

            AddRequestBox.Visible = true;

            clientDB = ClientsDB.SearchClient(LoginClient.Text, FIOClient.Text);
            if (clientDB  == null)
            {
                Console.WriteLine("11");
                client = new Client(LoginClient.Text, FIOClient.Text);
                AddRequestBox.Items.Add("Кредит");
                AddRequestBox.Items.Add("Депозит");
                //AddRequestBox.Items.Add("Страхование");
                //AddRequestBox.Items.Add("Карта");
                InfoClient.Visible = false;
                GetInfoButtonClient.Enabled = false;
            }
            else
            {
                client = new Client(LoginClient.Text, FIOClient.Text);
                foreach (var c in ClientDB.SearchServices(clientDB))
                {
                    AddRequestBox.Items.Add(c);
                }
                InfoClient.Visible = true;
                GetInfoButtonClient.Enabled = true;
            }

        }

        private void ExitClient_Click(object sender, EventArgs e)
        {
            ExitClient.Enabled = false;
            EnterClient.Enabled = true;
            FIOClientLable.Visible = true;
            LoginClientLable.Visible = true;
            LoginClient.Visible = true;
            FIOClient.Visible = true;
            EnterClient.Enabled = true;
            AddRequestBox.Visible = false;
            ReqestButtonClient.Visible = true;
            GetInfoButtonClient.Visible = false;
            //AddRequestBox.Items.Clear();
        }

        private void ReqestButtonClient_Click(object sender, EventArgs e)
        {
            if (AddRequestBox.Text == "")
                return;
            client.AddRequest(AddRequestBox.Text);
            AddRequestBox.Items.Clear();
        }

        private void GetInfoButtonClient_Click(object sender, EventArgs e)
        {
            InfoClient.Text = "";
            InfoClient.Text = clientDB.GetInfo();
        }

        private void InitTableCreditsManager()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "ФИО";
            column1.Name = "fio";
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column1.CellTemplate = new DataGridViewTextBoxCell();
            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Логин";
            column2.Name = "login";
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column2.CellTemplate = new DataGridViewTextBoxCell();
            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Тип заявки";
            column3.Name = "type";
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column3.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.AllowUserToAddRows = false;

            var column11 = new DataGridViewColumn();
            column11.HeaderText = "ФИО";
            column11.Name = "fio";
            column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column11.CellTemplate = new DataGridViewTextBoxCell();
            var column22 = new DataGridViewColumn();
            column22.HeaderText = "Логин";
            column22.Name = "login";
            column22.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column22.CellTemplate = new DataGridViewTextBoxCell();
            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Состояние";
            column4.Name = "status";
            column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column4.CellTemplate = new DataGridViewTextBoxCell();
            dataGridViewCredits.Columns.Add(column11);
            dataGridViewCredits.Columns.Add(column22);
            dataGridViewCredits.Columns.Add(column4);
            dataGridViewCredits.AllowUserToAddRows = false;
            InitCreditsTable();
        }

        private void InitTableCashier()
        {
            //dataGridViewCashier
            var columnCashier1 = new DataGridViewColumn();
            columnCashier1.HeaderText = "ФИО";
            columnCashier1.Name = "fio";
            columnCashier1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnCashier1.CellTemplate = new DataGridViewTextBoxCell();
            var columnCashier2 = new DataGridViewColumn();
            columnCashier2.HeaderText = "Логин";
            columnCashier2.Name = "login";
            columnCashier2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnCashier2.CellTemplate = new DataGridViewTextBoxCell();
            var columnCashier3 = new DataGridViewColumn();
            columnCashier3.HeaderText = "Кредит";
            columnCashier3.Name = "credit";
            columnCashier3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnCashier3.CellTemplate = new DataGridViewTextBoxCell();
            //var columnCashier4 = new DataGridViewColumn();
            //columnCashier4.HeaderText = "ФИО";
            //columnCashier4.Name = "deposit";
            //columnCashier4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //columnCashier4.CellTemplate = new DataGridViewTextBoxCell();
            //var columnCashier5 = new DataGridViewColumn();
            //columnCashier5.HeaderText = "ФИО";
            //columnCashier5.Name = "sequense";
            //columnCashier5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //columnCashier5.CellTemplate = new DataGridViewTextBoxCell();
            //var columnCashier6 = new DataGridViewColumn();
            //columnCashier6.HeaderText = "ФИО";
            //columnCashier6.Name = "fio";
            //columnCashier6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //columnCashier6.CellTemplate = new DataGridViewTextBoxCell();
            dataGridViewCashier.Columns.Add(columnCashier1);
            dataGridViewCashier.Columns.Add(columnCashier2);
            dataGridViewCashier.Columns.Add(columnCashier3);
            //dataGridView1.Columns.Add(columnCashier4);
            //dataGridView1.Columns.Add(columnCashier5);
            //dataGridView1.Columns.Add(columnCashier6);
            dataGridViewCashier.AllowUserToAddRows = false;
        }

        private void InitCreditsTable()
        {
            dataGridViewCredits.Rows.Clear();
            List<Credit> credits = Credits.GetCredits();
            if (credits != null)
            {
                foreach (var item in credits)
                {
                    dataGridViewCredits.Rows.Add(
                        item.FIO,
                        item.Login,
                        item.CurrentMoney.ToString() + "/" + item.MaxMoney.ToString());
                }
            }
        }

        private void UpdateCMButton_Click(object sender, EventArgs e)
        {
            //Requests.UpdateFile(false, true);
            //ClientsDB.UpdateFile(true, true);
            //Credits.UpdateFile(true, true);
            Credits.SetCredits();
            dataGridView1.Rows.Clear();
            Dictionary<int, Request> request = CreditManager.CheckRequest();
            if (request != null)
            {
                foreach (var item in request)
                {
                    dataGridView1.Rows.Add(item.Value.Fio, item.Value.Login, item.Value.TypeRequest);
                }
            }
            InitCreditsTable();
        }

        private void TakeRequestCMButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            int index = dataGridView1.SelectedCells[0].RowIndex;

            CreditManager.TakeRequest(
                dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                dataGridView1.CurrentRow.Cells[1].Value.ToString());
                
            dataGridView1.Rows.RemoveAt(index);
            CreditManager.DeleteRequest(index);

        }

        private void DeleteRequestCMButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            int index = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(index);
            CreditManager.DeleteRequest(index);
            // CreditManager.CheckRequest
        }

        private void DeleteCMButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewCredits.Rows.Count == 0)
            {
                return;
            }

            ClientsDB.SearchClient(
                dataGridViewCredits.CurrentRow.Cells[0].Value.ToString(),
                dataGridViewCredits.CurrentRow.Cells[1].Value.ToString()).Credit = null;
            ClientsDB.UpdateFile(true, true);

            dataGridViewCredits.Rows.RemoveAt(dataGridViewCredits.SelectedCells[0].RowIndex);

        }

        private void PaymentCreditButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewCashier.Rows.Count == 0)
            {
                return;
            }
            try
            {
                moneyTextBox.Text = Cashier.PaymentCredit(
                    dataGridViewCashier.CurrentRow.Cells[0].Value.ToString(),
                    dataGridViewCashier.CurrentRow.Cells[1].Value.ToString(),
                    Convert.ToInt32(moneyTextBox.Text)).ToString();
                ClientsDB.UpdateFile(true, true);
            }
            catch { }

        }

        private void UpdateCSButton_Click(object sender, EventArgs e)
        {
            dataGridViewCashier.Rows.Clear();

            var list = ClientsDB.GetClientsDB();
            if  (list == null) return;
            foreach (var item in list)
            {
                if (item.Credit == null) continue;
                dataGridViewCashier.Rows.Add(
                        item.Fio,
                        item.Login,
                        item.Credit.CurrentMoney.ToString() + "/" + item.Credit.MaxMoney.ToString());
            }
        }
    }
}
