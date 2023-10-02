using Proyecto1_Citas_Dentales.Classes;
using Proyecto1_Citas_Dentales.States;
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
    public partial class FormNewQueryType : Form
    {

        public FormNewQueryType()
        {
            InitializeComponent();
        }

        private void ButtonAddQueryType_Click(object sender, EventArgs e)
        {
            if (idQueryType.Value != 0 && descriptionQueryType.Text != "" && stateQueryType.Text != "")
            {
                List<QueryType> queryTypes = HandleLists.QueryTypesList;
                if (queryTypes.Count == 10)
                {
                    MessageBox.Show("No se pueden agregar mas tipos de consulta", "Nuevo tipo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool exists = false;
                queryTypes.ForEach(value =>
                {
                    if (value.Id == (int)idQueryType.Value)
                    {
                        MessageBox.Show("El ID de consulta ya existe.", "Nuevo tipo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        exists = true;
                        return;
                    }
                });
                if (exists)
                {
                    return;
                }
                queryTypes.Add(new QueryType((int)idQueryType.Value, descriptionQueryType.Text, stateQueryType.Text[0]));

                // MessageBox.Show("Se ha agregado el nuevo tipo de consulta", "Nuevo tipo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar el DataGridView en FormQueryTypes
                if (Owner is FormQueryTypes formQueryTypes)
                {
                    formQueryTypes.UpdateData();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha podido agregar el nuevo tipo de consulta. Verifica los valores introducidos", "Nuevo tipo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
