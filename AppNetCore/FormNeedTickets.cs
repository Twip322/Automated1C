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
    public partial class FormNeedTickets : Form
    {
        private List<DocumentModel> needs = new List<DocumentModel>();
        public FormNeedTickets()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormNeedTicket form = new FormNeedTicket(null);
            form.ShowDialog();
        }

        private async void btnHardLoad_Click(object sender, EventArgs e)
        {
            await Task.Run(()=>NeedTicketController.ReadNeedTickets());
            needs = NeedsFileController.Read(FileSettings.NeedsFilePath);
            dataGridView1.DataSource = needs;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            FormNeedTicket form = new FormNeedTicket(needs[dataGridView1.SelectedRows[0].Index]);
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OperationsController.operationsList.Add(new OperationModel
            {
                Operation = OperationEnum.Удаление,
                DataType = DataTypeEnum.Требование,
                Data = needs[dataGridView1.SelectedRows[0].Index]
            });
            needs.RemoveAt(dataGridView1.SelectedRows[0].Index);
            
        }

        private void FormNeedTickets_Load(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(File.ReadAllText(FileSettings.NeedsFilePath)))
                {
                    needs = NeedsFileController.Read(FileSettings.NeedsFilePath);
                    dataGridView1.DataSource = needs;
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
