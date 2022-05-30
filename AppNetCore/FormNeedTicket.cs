using Logic.DataModels;
using Logic.FileLogic;
using Logic.Models;
using Logic.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppNetCore
{
    public partial class FormNeedTicket : Form
    {
        private List<NeedTicketModel> needs;
        private List<NomenclatureModel> nomenclatures;
        public FormNeedTicket()
        {
            InitializeComponent();
            nomenclatures = NomenclatureFileController.Read(FileSettings.NomenclatureFilePath);
            comboBoxNomenclature.DataSource = nomenclatures;
            comboBoxNomenclature.DisplayMember = "Name";
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            needs.Add(new NeedTicketModel { Model= (NomenclatureModel)comboBoxNomenclature.SelectedItem, Count = int.Parse(textBoxCount.Text) });
            dataGridViewNeedTicket.DataSource = needs;
        }
    }
}
