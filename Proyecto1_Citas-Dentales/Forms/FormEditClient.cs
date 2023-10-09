using BusinessLogic;
using Entities;
// using Proyecto1_Citas_Dentales.Classes;
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
    public partial class FormEditClient : Form
    {

        public FormEditClient()
        {
            InitializeComponent();

            for (int i = 0; i < Business.clients.Length; i++)
            {
                // verifica que el cliente exista
                if (Business.clients[i] != null && Business.clients[i].Id == Business.selectedClientId)
                {
                    inputId.Text = Business.clients[i].Id.ToString();
                    inputName.Text = Business.clients[i].Name;
                    inputFirstLastName.Text = Business.clients[i].LastName;
                    inputSecondLastName.Text = Business.clients[i].SecondLastName;
                    inputBirthday.Text = Business.clients[i].BirthDate.ToString();
                    if (Business.clients[i].Gender == 'M')
                    {
                        inputGender.Text = "Masculino";
                    }
                    else if (Business.clients[i].Gender == 'F')
                    {
                        inputGender.Text = "Femenino";
                    }
                    else
                    {
                        inputGender.Text = "No especificado";
                    }
                }
            }
        }

        private void buttonSaveClient_Click(object sender, EventArgs e)
        {
            Response res = Business.UpdateClientData(inputBirthday.Value, inputGender.Text[0]);

            if (res.Success)
            {
                if (Owner is FormAdminClients formAdminClients)
                {
                    formAdminClients.UpdateData();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show(res.Message, "Editar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
