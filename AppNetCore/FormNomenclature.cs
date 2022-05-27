using Logic.FileLogic;
using Logic.IntegrationLogic;
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
    public partial class FormNomenclature : Form
    {
        ReadNomenclatureFrom1C from1C = new ReadNomenclatureFrom1C();
        AuthLogic authLogic = new AuthLogic();
        ReadNomenclature read = new ReadNomenclature();
        public FormNomenclature()
        {
            InitializeComponent();
        }

        private  void FormNomenclature_Load(object sender, EventArgs e)
        {
            
        }
        private async Task readFromFile()
        {
            await Task.Run(()=>from1C.Read(Client.bromClient, FileSettings.NomenclatureFilePath));
            MessageBox.Show("Bruh");

        }
        private async void button1_Click(object sender, EventArgs e)
        {
            await readFromFile();
            dataGridViewNomenclature.DataSource = read.Read(FileSettings.NomenclatureFilePath);
        }
    }
}
