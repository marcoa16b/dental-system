// using Proyecto1_Citas_Dentales.Classes;
using BusinessLogic;
using Entities;
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
    public partial class FormNewAppointment : Form
    {

        public FormNewAppointment()
        {
            InitializeComponent();

            foreach (QueryType qt in Business.queryTypes)
            {
                if (qt != null && qt.State == 'A')
                {
                    string id = qt.Id.ToString();
                    string description = qt.Description;

                    string info = id + " - " + description;
                    inputType.Items.Add(info);
                }
            }

            foreach (Client client in Business.clients)
            {
                if (client != null)
                {
                    string id = client.Id.ToString();
                    string name = client.Name;
                    string firstLastName = client.LastName;
                    string secondLastName = client.SecondLastName;

                    string info = id + " - " + name + " " + firstLastName + " " + secondLastName;
                    inputClient.Items.Add(info);
                }
            }

            foreach (Doctor doctor in Business.doctors)
            {
                if (doctor != null && doctor.State == 'A')
                {
                    string id = doctor.Id.ToString();
                    string name = doctor.Name;
                    string firstLastName = doctor.LastName;
                    string secondLastName = doctor.SecondLastName;

                    string info = id + " - " + name + " " + firstLastName + " " + secondLastName;
                    inputDoctor.Items.Add(info);
                }
            }

        }

        private void buttonSaveAppointment_Click(object sender, EventArgs e)
        {
            Response response = Business.SaveAppointment(inputID.Text, inputDate.Value, inputType.Text, inputClient.Text, inputDoctor.Text);

            if (response.Success)
            {
                if (Owner is FormAppointments formAppointments)
                {
                    formAppointments.UpdateData();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show(response.Message, "Nueva cita", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
