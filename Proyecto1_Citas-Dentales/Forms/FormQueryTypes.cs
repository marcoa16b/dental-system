﻿using BusinessLogic;
using Entities;
// using Proyecto1_Citas_Dentales.Classes;
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

            UpdateData();
        }

        private void ButtonAddQueryType_Click(object sender, EventArgs e)
        {
            if (Business.queryTypes[9] != null)
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

            foreach (QueryType queryType in Business.queryTypes)
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
            if (e.RowIndex >= 0)
            {
                // Obtener el valor de la primera columna (columna 0)
                selectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            }
            else
            {
                selectedId = 0;
            }
        }

        private void ChangeState(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                Response res = Business.ChangeStatusQueryType(selectedId);

                if (res.Success)
                {
                    UpdateData();
                    selectedId = 0;
                    return;
                }
                else
                {
                    MessageBox.Show(res.Message, "Cambiar estado de tipo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea modificar", "Cambiar estado de tipo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteQueryType(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                Response res = Business.DeleteQueryType(selectedId);

                if (res.Success)
                {
                    UpdateData();
                    selectedId = 0;
                    return;
                }
                else
                {
                    MessageBox.Show(res.Message, "Eliminar tipo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila a eliminar", "Eliminar Tipo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
