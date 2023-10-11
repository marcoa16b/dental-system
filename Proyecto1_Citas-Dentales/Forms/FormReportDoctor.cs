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
    public partial class FormReportDoctor : Form
    {
        public FormReportDoctor()
        {
            InitializeComponent();

            DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnDate = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnType = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnDoctor = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnClient = new DataGridViewTextBoxColumn();

            columnId.HeaderText = "ID";
            columnDate.HeaderText = "Fecha";
            columnType.HeaderText = "Tipo";
            columnDoctor.HeaderText = "Doctor";
            columnClient.HeaderText = "Cliente";

            resultsView.Columns.Add(columnId);
            resultsView.Columns.Add(columnDate);
            resultsView.Columns.Add(columnType);
            resultsView.Columns.Add(columnDoctor);
            resultsView.Columns.Add(columnClient);

            // Agregar los doctores al ComboBox
            for (int i = 0; i < Business.doctors.Length; i++)
            {
                if (Business.doctors[i] != null)
                {
                    Doctor doctor = Business.doctors[i];
                    string doctorData = doctor.Id.ToString() + " - " + doctor.Name + " " + doctor.LastName;
                    inputDoctors.Items.Add(doctorData);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Limpiar el DataGridView
            resultsView.Rows.Clear();

            string doctorInput = inputDoctors.Text;
            string[] doctorData = doctorInput.Split('-');
            int doctorId = int.Parse(doctorData[0]);

            // Buscar las citas que coincidan con el doctor
            for (int i = 0; i < Business.appointments.Length; i++)
            {
                if (Business.appointments[i] != null)
                {
                    Appointment appointment = Business.appointments[i];
                    if (appointment.Doctor.Id == doctorId)
                    {
                        string[] row = new string[]
                        {
                            appointment.Id.ToString(),
                            appointment.Date.ToString(),
                            appointment.QueryType.Description,
                            appointment.Doctor.Name + " " + appointment.Doctor.LastName,
                            appointment.Client.Name + " " + appointment.Client.LastName
                        };
                        resultsView.Rows.Add(row);
                    }
                }
            }
        }
    }
}
