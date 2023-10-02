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
    public partial class FormQueryTypes : Form
    {
        private BindingSource bindingSource = new BindingSource();

        private int selectedId;

        public FormQueryTypes()
        {
            InitializeComponent();

            // Asignar la lista de QueryTypes al BindingSource
            bindingSource.DataSource = HandleLists.QueryTypesList;

            // Vincular el DataGridView al BindingSource
            dataGridView1.DataSource = bindingSource;
        }

        private void ButtonAddQueryType_Click(object sender, EventArgs e)
        {
            FormNewQueryType formNewQueryType = new FormNewQueryType();
            formNewQueryType.Owner = this;
            formNewQueryType.ShowDialog();

        }

        public void UpdateData()
        {
            bindingSource.ResetBindings(false);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se hizo clic en la tercera columna y que haya al menos una fila seleccionada
            if (e.RowIndex >= 0 && e.ColumnIndex == 2) 
            {
                // Obtener el valor de la primera columna (columna 0)
                selectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                // Ahora, tienes el valor de la primera columna de la fila seleccionada en la variable selectedId
            }
            else
            {
                selectedId = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                List<QueryType> queryTypes = HandleLists.QueryTypesList;
                queryTypes.ForEach(value =>
                {
                    if (value.Id == selectedId)
                    {
                        if (value.State == 'I')
                        {
                            value.State = 'A';
                        }
                        else
                        {
                            value.State = 'I';
                        }
                        selectedId = 0;
                        UpdateData();
                        return;
                    }
                });
            }
            else
            {
                MessageBox.Show("Seleccione una columna de estado a modificar", "Cambiar estado de tipo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
