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
    public partial class FormNewClient : Form
    {
        public FormNewClient()
        {
            InitializeComponent();
        }

        private void buttonSaveClient_Click(object sender, EventArgs e)
        {
            if (inputId.Text != "" && inputName.Text != "" && inputFirstLastName.Text != "" && inputSecondLastName.Text != "")
            {
                int id;
                if (!int.TryParse(inputId.Text, out id))
                {
                    MessageBox.Show("El ID debe ser un numero entero", "Nuevo cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (IsClientInList(id))
                {
                    MessageBox.Show("Ya existe un cliente con ese ID", "Nuevo cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string name = inputName.Text;
                string firstLastName = inputFirstLastName.Text;
                string secondLastName = inputSecondLastName.Text;
                DateTime date = inputBirthday.Value.Date; // Fecha de nacimiento sin el tiempo
                char gender = inputGender.Text[0];
                Client client = new Client(id, name, firstLastName, secondLastName, date, gender);
                HandleLists.ClientsList.Add(client);

                if (Owner is FormAdminClients formClients)
                {
                    formClients.UpdateData();
                }

                DialogResult res = MessageBox.Show("Cliente agregado. ¿desea agregar otro?", "Nuevo cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    inputId.Text = "";
                    inputName.Text = "";
                    inputFirstLastName.Text = "";
                    inputSecondLastName.Text = "";
                    inputBirthday.Value = DateTime.Parse("01/01/2000");
                    inputGender.Text = "N - No especificado";
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public bool IsClientInList(int id)
        {
            foreach (Client client in HandleLists.ClientsList)
            {
                if (client.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
