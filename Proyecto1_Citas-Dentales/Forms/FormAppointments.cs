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
    public partial class FormAppointments : Form
    {
        public FormAppointments()
        {
            InitializeComponent();
        }

        private void handleNewAppoiment(object sender, EventArgs e)
        {
            bool foundClient = false;
            bool foundDoctor = false;
            bool foundQueryType = false;
            foreach (Client client in HandleLists.ClientsArray)
            {
                if (client != null)
                {
                    foundClient = true;
                    break;
                }
            }
            foreach (Doctor doctor in HandleLists.DoctorsArray)
            {
                if (doctor != null && doctor.State == 'A')
                {
                    foundDoctor = true;
                    break;
                }
            }
            foreach (QueryType queryType in HandleLists.QueryTypesArray)
            {
                if (queryType != null && queryType.State == 'A')
                {
                    foundQueryType = true;
                    break;
                }
            }
            if (!foundClient)
            {
                MessageBox.Show("No hay clientes registrados");
                return;
            }
            if (!foundDoctor)
            {
                MessageBox.Show("No hay doctores registrados");
                return;
            }
            if (!foundQueryType)
            {
                MessageBox.Show("No hay tipos de consulta registrados");
                return;
            }
            FormNewAppointment formNewAppointment = new FormNewAppointment();
            formNewAppointment.Owner = this;
            formNewAppointment.ShowDialog();
        }
    }
}
