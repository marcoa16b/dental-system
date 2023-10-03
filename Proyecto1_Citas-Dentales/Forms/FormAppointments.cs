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
            if (HandleLists.ClientsList.Count == 0)
            {
                MessageBox.Show("No hay clientes registrados");
                return;
            }
            if (HandleLists.DoctorsList.Count == 0)
            {
                MessageBox.Show("No hay doctores registrados");
                return;
            }
            if (HandleLists.QueryTypesList.Count == 0)
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
