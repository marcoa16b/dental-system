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
    public partial class FormAdminDoctors : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public FormAdminDoctors()
        {
            InitializeComponent();

            DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnFLName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnSLName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnState = new DataGridViewTextBoxColumn();

            columnId.HeaderText = "ID";
            columnName.HeaderText = "Nombre";
            columnFLName.HeaderText = "Primer apellido";
            columnSLName.HeaderText = "Segundo apellido";
            columnState.HeaderText = "Estado";

            doctorDataViewer.Columns.Add(columnId);
            doctorDataViewer.Columns.Add(columnName);
            doctorDataViewer.Columns.Add(columnFLName);
            doctorDataViewer.Columns.Add(columnSLName);
            doctorDataViewer.Columns.Add(columnState);
        }

        public void UpdateData()
        {
            doctorDataViewer.Rows.Clear();

            foreach (Doctor doctor in HandleLists.DoctorsArray)
            {
                if (doctor != null)
                {
                    // Agrega una nueva fila al DataGridView con los datos de cada Doctor
                    string id = doctor.Id.ToString();
                    string name = doctor.Name;
                    string firstLastName = doctor.FirstLastName;
                    string secondLastName = doctor.SecondLastName;
                    string state = doctor.State == 'A' ? "Activo" : "Inactivo";

                    string[] row = { id, name, firstLastName, secondLastName, state };

                    doctorDataViewer.Rows.Add(row);
                }
            }
        }

        private void buttonNewDoctor_Click(object sender, EventArgs e)
        {
            if (HandleLists.DoctorsArray[19] != null)
            {
                MessageBox.Show("No se pueden agregar mas de 20 doctores", "Nuevo doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormNewDoctor formNewDoctor = new FormNewDoctor();
            formNewDoctor.Owner = this;
            formNewDoctor.ShowDialog();
        }
    }
}
