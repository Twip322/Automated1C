using ITworks.Brom;
using Logic.IntegrationLogic;
using Logic.Settings;
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

namespace AppNetCore
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        }

        private void btnAutorisation_Click(object sender, EventArgs e)
        {
            AuthLogic authLogic = new AuthLogic();
            dynamic auth = authLogic.Auth(textBoxLogin.Text, textBoxPassword.Text);
            Client.bromClient = auth;
            bool flag=true;
            try
            {
                flag = true;
                Client.bromClient.Ping();
            }
            catch(Exception ex)
            {
                flag = false;
                MessageBox.Show(ex.Message);
            }
            if(flag)
            {
                FormMain formMain = new FormMain();
                this.Visible = false;
                formMain.ShowDialog();
                if(formMain.DialogResult == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
    }
}
