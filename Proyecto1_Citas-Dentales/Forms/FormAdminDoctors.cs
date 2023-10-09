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
    public partial class FormAdminDoctors : Form
    {
        private int selectedId;

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

            UpdateData();
        }

        public void UpdateData()
        {
            doctorDataViewer.Rows.Clear();

            foreach (Doctor doctor in Business.doctors)
            {
                if (doctor != null)
                {
                    // Agrega una nueva fila al DataGridView con los datos de cada Doctor
                    string id = doctor.Id.ToString();
                    string name = doctor.Name;
                    string firstLastName = doctor.LastName;
                    string secondLastName = doctor.SecondLastName;
                    string state = doctor.State == 'A' ? "Activo" : "Inactivo";

                    string[] row = { id, name, firstLastName, secondLastName, state };

                    doctorDataViewer.Rows.Add(row);
                }
            }
        }

        private void buttonNewDoctor_Click(object sender, EventArgs e)
        {
            if (Business.doctors[19] != null)
            {
                MessageBox.Show("No se pueden agregar mas de 20 doctores", "Nuevo doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormNewDoctor formNewDoctor = new FormNewDoctor();
            formNewDoctor.Owner = this;
            formNewDoctor.ShowDialog();
        }
        private void HandleCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(doctorDataViewer.Rows[e.RowIndex].Cells[0].Value);
            }
            else
            {
                selectedId = 0;
            }
        }

        private void buttonChangeState_Click(object sender, EventArgs e)
        {
            Response response = Business.ChangeStatusDoctor(selectedId);
            if (response.Success)
            {
                UpdateData();
            }
            else
            {
                MessageBox.Show(response.Message, "Cambiar estado de Doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteDoctor_Click(object sender, EventArgs e)
        {
            Response response = Business.DeleteDoctor(selectedId);
            if (response.Success)
            {
                UpdateData();
            }
            else
            {
                MessageBox.Show(response.Message, "Eliminar Doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
