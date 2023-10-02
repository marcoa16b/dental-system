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

            // Asignar la lista de QueryTypes al BindingSource
            bindingSource.DataSource = HandleLists.DoctorsList;

            // Vincular el DataGridView al BindingSource
            doctorDataViewer.DataSource = bindingSource;
        }

        public void UpdateData()
        {
            bindingSource.ResetBindings(false);
        }

        private void buttonNewDoctor_Click(object sender, EventArgs e)
        {
            FormNewDoctor formNewDoctor = new FormNewDoctor();
            formNewDoctor.Owner = this;
            formNewDoctor.ShowDialog();
        }
    }
}
