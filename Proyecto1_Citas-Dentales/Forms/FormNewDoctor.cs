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
    public partial class FormNewDoctor : Form
    {
        public FormNewDoctor()
        {
            InitializeComponent();
        }

        private void buttonSaveDoctor_Click(object sender, EventArgs e)
        {
            if (inputId.Text != "" && inputName.Text != "" && inputFirstLastName.Text != "" && inputSecondLastName.Text != "")
            {
                int id;
                if (!int.TryParse(inputId.Text, out id))
                {
                    MessageBox.Show("El ID debe ser un numero entero", "Nuevo doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (IsDoctorInList(id))
                {
                    MessageBox.Show("Ya existe un doctor con ese ID", "Nuevo doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string name = inputName.Text;
                string firstLastName = inputFirstLastName.Text;
                string secondLastName = inputSecondLastName.Text;
                char state = inputState.Text[0];
                Doctor doctor = new Doctor(id, name, firstLastName, secondLastName, state);
                HandleLists.DoctorsList.Add(doctor);

                if (Owner is FormAdminDoctors formDoctors)
                {
                    formDoctors.UpdateData();
                }

                DialogResult res = MessageBox.Show("Doctor agregado. ¿Desea agregar otro?", "Nuevo doctor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    inputId.Text = "";
                    inputName.Text = "";
                    inputFirstLastName.Text = "";
                    inputSecondLastName.Text = "";
                    inputState.Text = "I - Inactivo";
                }
                else
                {
                    this.Close();
                }
            }
        }

        public bool IsDoctorInList(int id)
        {
            foreach (Doctor doctor in HandleLists.DoctorsList)
            {
                if (doctor.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
