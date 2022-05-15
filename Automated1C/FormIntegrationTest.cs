using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.FileLogic;
using Logic.Models;

namespace Automated1C
{
    public partial class FormIntegrationTest : Form
    {
        private readonly string filepath;
        private List<NomModel> Noms = new List<NomModel>();
        public FormIntegrationTest()
        {
            InitializeComponent();
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = Path.GetDirectoryName(location);
            this.filepath = path;
        }
        private void FormIntegrationTest_Load(object sender, EventArgs e)
        {
            Noms= ReadNom.ReadDoc(filepath);
            dataGridView1.DataSource = Noms;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTicket form = new FormTicket(Noms);
            form.ShowDialog();
        }
    }
}
