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
    public partial class FormNeedTicket : Form
    {
        private List<NeedTicketDataModel> needs = new List<NeedTicketDataModel>();
        private DocumentModel ticket;
        private bool isExisted=false;
        private List<NomenclatureModel> nomenclatures;
        public FormNeedTicket(DocumentModel ticket)
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
            needs = await Task.Run(() => NeedTicketController.LoadNeedTicket(ticket));
            dataGridViewNeedTicket.DataSource = needs;
            dataGridViewNeedTicket.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private async void btnDo_Click(object sender, EventArgs e)
        {
            OperationEnum operation;
            if(isExisted)
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
                DataType = DataTypeEnum.Требование,
                Data = needs,
                oldData = ticket
            });
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            needs.Add(new NeedTicketDataModel
            {
                Name = comboBoxNomenclature.SelectedValue.ToString(),
                Count = int.Parse(textBoxCount.Text)
            }
            );
            dataGridViewNeedTicket.DataSource = null;
            dataGridViewNeedTicket.DataSource = needs;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            needs.RemoveAt(dataGridViewNeedTicket.SelectedRows[0].Index);
            dataGridViewNeedTicket.DataSource = null;
            dataGridViewNeedTicket.DataSource = needs;
        }
    }
}
