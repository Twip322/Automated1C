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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnNom_Click(object sender, EventArgs e)
        {
            FormNomenclature form = new FormNomenclature();
            form.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private async void btnDoAll_Click(object sender, EventArgs e)
        {
           await Task.Run(()=> OperationsController.LoadAll());
        }

        private void btnNeedTicket_Click(object sender, EventArgs e)
        {
            FormNeedTicket form = new FormNeedTicket();
            form.ShowDialog();
        }
    }
}
