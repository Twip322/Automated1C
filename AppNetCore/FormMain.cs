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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        }

        private void btnNom_Click(object sender, EventArgs e)
        {
            FormNomenclatures form = new FormNomenclatures();
            form.Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void btnDoAll_Click(object sender, EventArgs e)
        {
            FormOperations form = new FormOperations();
            form.ShowDialog();
        }

        private void btnNeedTicket_Click(object sender, EventArgs e)
        {
            FormNeedTickets form = new FormNeedTickets();
            form.ShowDialog();
        }

        private void btnTrade_Click(object sender, EventArgs e)
        {
            FormTrades form = new FormTrades();
            form.ShowDialog();
        }
    }
}
