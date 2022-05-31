using Logic.HelperModels;
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
    public partial class FormOperations : Form
    {
        public FormOperations()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        }
        private void LoadOperations()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = OperationsController.operationsList;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void FormOperations_Load(object sender, EventArgs e)
        {
            LoadOperations();
        }

        private async void btnDoAll_Click(object sender, EventArgs e)
        {
            await Task.Run(() => OperationsController.LoadAll());
            LoadOperations();
        }

        private async void btnDoNom_Click(object sender, EventArgs e)
        {
            await Task.Run(() => OperationsController.LoadNomenclature());
            LoadOperations();
        }

        private async void btnDoNeeds_Click(object sender, EventArgs e)
        {
            await Task.Run(() => OperationsController.LoadNeedTicket());
            LoadOperations();
        }

        private async void btnDoTrades_Click(object sender, EventArgs e)
        {
            await Task.Run(() => OperationsController.LoadTradeTicket());
            LoadOperations();
        }
    }
}
