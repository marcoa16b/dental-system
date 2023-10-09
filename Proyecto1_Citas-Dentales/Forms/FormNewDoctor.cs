// using Proyecto1_Citas_Dentales.Classes;
using BusinessLogic;
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
            char state = inputState.Text[0];
            Response res = Business.SaveDoctor(inputId.Text, inputName.Text, inputFirstLastName.Text, inputSecondLastName.Text, state);
            if (res.Success)
            {
                if (MessageBox.Show("Doctor agregado. ¿desea agregar otro?", "Nuevo doctor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    inputId.Text = "";
                    inputName.Text = "";
                    inputFirstLastName.Text = "";
                    inputSecondLastName.Text = "";
                    inputState.Text = "Inactivo";
                }
                else
                {
                    if (Owner is FormAdminDoctors formDoctors)
                    {
                        formDoctors.UpdateData();
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(res.Message, "Nuevo doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
