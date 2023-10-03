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
using static System.Windows.Forms.AxHost;

namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormAdminClients : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public FormAdminClients()
        {
            InitializeComponent();

            DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnFLName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnSLName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnBirthday = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnGender = new DataGridViewTextBoxColumn();

            columnId.HeaderText = "ID";
            columnName.HeaderText = "Nombre";
            columnFLName.HeaderText = "Primer apellido";
            columnSLName.HeaderText = "Segundo apellido";
            columnBirthday.HeaderText = "Cumpleaños";
            columnGender.HeaderText = "Genero";

            clientDataViewer.Columns.Add(columnId);
            clientDataViewer.Columns.Add(columnName);
            clientDataViewer.Columns.Add(columnFLName);
            clientDataViewer.Columns.Add(columnSLName);
            clientDataViewer.Columns.Add(columnBirthday);
            clientDataViewer.Columns.Add(columnGender);
        }

        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            if (HandleLists.ClientsArray[19] != null)
            {
                MessageBox.Show("No se pueden agregar mas clientes", "Nuevo cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormNewClient formNewClient = new FormNewClient();
            formNewClient.Owner = this;
            formNewClient.ShowDialog();
        }

        public void UpdateData()
        {
            clientDataViewer.Rows.Clear();

            foreach (Client client in HandleLists.ClientsArray)
            {
                if (client != null)
                {
                    string id = client.Id.ToString();
                    string name = client.Name;
                    string firstLastName = client.FirstLastName;
                    string secondLastName = client.SecondLastName;
                    string birthday = client.BirthDate.ToString("dd/MM/yyyy");
                    string gender = client.Gender == 'F' ? "Femenino" : client.Gender == 'M' ? "Masculino" : "No especificado";
                    string[] row = { id,  name, firstLastName, secondLastName, birthday, gender };

                    clientDataViewer.Rows.Add(row);
                }
            }
        }
    }
}
