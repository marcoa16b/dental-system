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

            DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnDescription = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnState = new DataGridViewTextBoxColumn();

            columnId.HeaderText = "ID";
            columnDescription.HeaderText = "Descripción";
            columnState.HeaderText = "Estado";

            dataGridView1.Columns.Add(columnId);
            dataGridView1.Columns.Add(columnDescription);
            dataGridView1.Columns.Add(columnState);
        }

        private void ButtonAddQueryType_Click(object sender, EventArgs e)
        {
            if (HandleLists.QueryTypesArray[9] == null)
            {
                MessageBox.Show("No se pueden agregar mas tipos de consulta", "Nuevo tipo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormNewQueryType formNewQueryType = new FormNewQueryType();
            formNewQueryType.Owner = this;
            formNewQueryType.ShowDialog();

        }

        public void UpdateData()
        {
            dataGridView1.Rows.Clear();

            foreach (QueryType queryType in HandleLists.QueryTypesArray)
            {
                if (queryType != null)
                {
                    // Agrega una nueva fila al DataGridView con los datos de cada QueryType
                    string state = queryType.State == 'A' ? "Activo" : "Inactivo";
                    string id = queryType.Id.ToString();
                    string description = queryType.Description;
                    
                    string[] row = { id, description, state };

                    dataGridView1.Rows.Add(row);
                }
            }
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
