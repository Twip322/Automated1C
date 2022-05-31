using Logic.DataModels;
using Logic.FileLogic;
using Logic.HelperModels;
using Logic.IntegrationLogic;
using Logic.Models;
using Logic.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNetCore
{
    public partial class FormTrade : Form
    {
        private List<TradeDataModel> trades = new List<TradeDataModel>();
        private DocumentModel ticket;
        private bool isExisted = false;
        private List<NomenclatureModel> nomenclatures;
        public FormTrade(DocumentModel ticket)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            if (ticket != null)
            {
                this.ticket = ticket;
                isExisted = true;
                LoadDocument();
            }
            nomenclatures = NomenclatureFileController.Read(FileSettings.NomenclatureFilePath);
            comboBoxNomenclature.DataSource = nomenclatures;
            comboBoxNomenclature.DisplayMember = "Name";
            comboBoxNomenclature.ValueMember = "Name";
        }
        private async void LoadDocument()
        {
            trades = await Task.Run(() => TradeTicketController.LoadTradeTicket(ticket));
            dataGridViewNeedTicket.DataSource = trades;
            dataGridViewNeedTicket.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            trades.Add(new TradeDataModel
            {
                Name = comboBoxNomenclature.SelectedValue.ToString(),
                Count = int.Parse(textBoxCount.Text),
                Price = int.Parse(textBox1.Text)
            }
            );
            dataGridViewNeedTicket.DataSource = null;
            dataGridViewNeedTicket.DataSource = trades;
            dataGridViewNeedTicket.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            trades.RemoveAt(dataGridViewNeedTicket.SelectedRows[0].Index);
            dataGridViewNeedTicket.DataSource = null;
            dataGridViewNeedTicket.DataSource = trades;
            dataGridViewNeedTicket.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            OperationEnum operation;
            if (isExisted)
            {
                operation = OperationEnum.Изменение;
            }
            else
            {
                operation = OperationEnum.Добавление;
            }
            OperationsController.operationsList.Add(new OperationModel
            {
                Operation = operation,
                DataType = DataTypeEnum.Продажа,
                Data = trades,
                oldData = ticket
            });
            this.Close();
        }
    }
}
