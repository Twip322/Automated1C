using Logic.HelperModels;
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
    public partial class FormCreateOrUpdateNomecnlature : Form
    {
        private NomenclatureModel oldModel = new NomenclatureModel { Name = "",Article = ""};
        public NomenclatureModel model { get; private set; }
        public FormCreateOrUpdateNomecnlature(NomenclatureModel model)
        {
            InitializeComponent();
            if(model!=null)
            {
                this.model = model;
                this.oldModel = model;
                textBoxName.Text = model.Name;
                textBoxArticle.Text = model.Article;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            OperationEnum operation;
            if (model!=null)
            {
                 operation= OperationEnum.Изменение;
            }
            else
            {
                operation = OperationEnum.Добавление;
            }
            model = new NomenclatureModel
            {
                Name = textBoxName.Text,
                Article = textBoxArticle.Text
            };
            OperationsController.operationsList.Add(new Logic.DataModels.OperationModel
            {
                Operation = operation,
                DataType = DataTypeEnum.Номенклатура,
                Data = model,
                oldData = oldModel

            });
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
