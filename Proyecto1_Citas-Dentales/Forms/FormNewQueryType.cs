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
                bool exists = false;
                for (int i = 0; i < HandleLists.QueryTypesArray.Length; i++)
                {
                    QueryType qt = HandleLists.QueryTypesArray[i];
                    if (qt != null && qt.Id == (int)idQueryType.Value)
                    {
                        MessageBox.Show("El ID de consulta ya existe.", "Nuevo tipo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        exists = true;
                        return;
                    }
                }
                if (exists)
                {
                    return;
                }
                for (int i = 0; i < HandleLists.QueryTypesArray.Length; i++)
                {
                    if (HandleLists.QueryTypesArray[i] == null)
                    {
                        int id = (int)idQueryType.Value;
                        string description = descriptionQueryType.Text;
                        char stateQt = stateQueryType.Text[0];

                        HandleLists.QueryTypesArray[i] = new QueryType(id, description, stateQt);
                        break;
                    }
                }
                if (Owner is FormQueryTypes formQueryTypes)
                {
                    formQueryTypes.UpdateData();
                }
                if (MessageBox.Show("Se ha agregado el nuevo tipo de consulta. ¿Desea agregar otro?", "Nuevo tipo de consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    idQueryType.Value = 0;
                    descriptionQueryType.Text = "";
                    stateQueryType.Text = "";
                    return;
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
