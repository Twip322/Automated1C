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
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNetCore
{
    public partial class FormNomenclature : Form
    {
        private List<NomenclatureModel> list = new List<NomenclatureModel>();
        public FormNomenclature()
        {
            InitializeComponent();
        }

        private void FormNomenclature_Load(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(File.ReadAllText(FileSettings.NomenclatureFilePath)))
                {
                    list = NomenclatureFileController.Read(FileSettings.NomenclatureFilePath);
                    dataGridViewNomenclature.DataSource = list;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет Загруженных данных");
            }

        }
        private async Task hardRead()
        {
            await Task.Run(() => LoadController.LoadNomenclature());
            MessageBox.Show("Bruh");

        }
        private async void button1_Click(object sender, EventArgs e)
        {
            await hardRead();
            list = NomenclatureFileController.Read(FileSettings.NomenclatureFilePath);
            dataGridViewNomenclature.DataSource = list;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            FormCreateOrUpdateNomecnlature form = new FormCreateOrUpdateNomecnlature(null);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                list.Add(form.model);
                dataGridViewNomenclature.DataSource = null;
                dataGridViewNomenclature.DataSource = list;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            FormCreateOrUpdateNomecnlature form = new FormCreateOrUpdateNomecnlature(list[dataGridViewNomenclature.SelectedRows[0].Index]);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                list[dataGridViewNomenclature.SelectedRows[0].Index] = form.model;
                dataGridViewNomenclature.DataSource = null;
                dataGridViewNomenclature.DataSource = list;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            OperationsController.operationsList.Add(new OperationModel
            {
                Operation = OperationEnum.Удаление,
                DataType = DataTypeEnum.Номенклатура,
                Data = list[dataGridViewNomenclature.SelectedRows[0].Index]
            });
            list.RemoveAt(dataGridViewNomenclature.SelectedRows[0].Index);
            dataGridViewNomenclature.DataSource = null;
            dataGridViewNomenclature.DataSource = list;
        }
    }
}
