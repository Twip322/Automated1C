using Logic.DataModels;
using Logic.FileLogic;
using Logic.HelperModels;
using Logic.IntegrationLogic;
using Logic.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNetCore
{
    public partial class FormTrades : Form
    {
        private List<DocumentModel> trades = new List<DocumentModel>();
        public FormTrades()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        }

        private async void btnHardLoad_Click(object sender, EventArgs e)
        {
            await Task.Run(() => TradeTicketController.ReadTradeTickets());
            trades = TradeFileController.Read(FileSettings.TradesFilePath);
            dataGridView1.DataSource = trades;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormTrade form = new FormTrade(null);
            form.ShowDialog();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            FormTrade form = new FormTrade(trades[dataGridView1.SelectedRows[0].Index]);
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OperationsController.operationsList.Add(new OperationModel
            {
                Operation = OperationEnum.Удаление,
                DataType = DataTypeEnum.Продажа,
                Data = trades[dataGridView1.SelectedRows[0].Index]
            });
            trades.RemoveAt(dataGridView1.SelectedRows[0].Index);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = trades;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FormTrades_Load(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(File.ReadAllText(FileSettings.TradesFilePath)))
                {
                    trades = NeedsFileController.Read(FileSettings.TradesFilePath);
                    dataGridView1.DataSource = trades;
                    dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет Загруженных данных");
            }
        }
    }
}
