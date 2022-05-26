using Logic.FileLogic;
using Logic.IntegrationLogic;
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
    public partial class FormNomenclature : Form
    {
        public FormNomenclature()
        {
            InitializeComponent();
        }

        private void FormNomenclature_Load(object sender, EventArgs e)
        {
            ReadNomenclatureFrom1C from1C = new ReadNomenclatureFrom1C();
            AuthLogic authLogic = new AuthLogic();
            ReadNomenclature read = new ReadNomenclature();
            from1C.Read(Client.bromClient, FileSettings.NomenclatureFilePath);
            
            dataGridViewNomenclature.DataSource = read.Read(FileSettings.NomenclatureFilePath);
        }
    }
}
