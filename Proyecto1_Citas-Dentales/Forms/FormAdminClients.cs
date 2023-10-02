using Proyecto1_Citas_Dentales.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormAdminClients : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public FormAdminClients()
        {
            InitializeComponent();

            // Asignar la lista de QueryTypes al BindingSource
            bindingSource.DataSource = HandleLists.ClientsList;

            // Vincular el DataGridView al BindingSource
            clientDataViewer.DataSource = bindingSource;
        }

        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            FormNewClient formNewClient = new FormNewClient();
            formNewClient.Owner = this;
            formNewClient.ShowDialog();
        }

        public void UpdateData()
        {
            bindingSource.ResetBindings(false);
        }
    }
}
