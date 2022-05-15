using Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automated1C
{
    public partial class FormTicket : Form
    {
        private readonly List<NomModel> Noms = new List<NomModel>();
        public FormTicket(List<NomModel> Noms)
        {
            InitializeComponent();
            this.Noms = Noms;
        }

        private void FormTicket_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Noms;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
            dataGridView1.Columns.Add("Name","Name");
            dataGridView1.Columns.Add("Count", "Count");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(new object[]{ comboBox1.SelectedValue,Int32.Parse(textBox1.Text)});
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
