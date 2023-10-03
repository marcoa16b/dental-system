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
    public partial class FormNewAppointment : Form
    {

        public FormNewAppointment()
        {
            InitializeComponent();

            // string[] queryTypesInfo = getQueryTypes();

            foreach (QueryType qt in HandleLists.QueryTypesArray)
            {
                if (qt != null)
                {
                    string id = qt.Id.ToString();
                    string description = qt.Description;
                    string state = qt.State == 'A' ? "Activo" : "Inactivo";

                    string info = id + " - " + description + " - " + state;
                    inputType.Items.Add(info);
                }
            }

            foreach (Client client in HandleLists.ClientsArray)
            {
                if (client != null)
                {
                    string id = client.Id.ToString();
                    string name = client.Name;
                    string firstLastName = client.FirstLastName;
                    string secondLastName = client.SecondLastName;

                    string info = id + " - " + name + " " + firstLastName + " " + secondLastName;
                    inputClient.Items.Add(info);
                }
            }

            foreach (Doctor doctor in HandleLists.DoctorsArray)
            {
                if (doctor != null && doctor.State == 'A')
                {
                    string id = doctor.Id.ToString();
                    string name = doctor.Name;
                    string firstLastName = doctor.FirstLastName;
                    string secondLastName = doctor.SecondLastName;

                    string info = id + " - " + name + " " + firstLastName + " " + secondLastName;
                    inputDoctor.Items.Add(info);
                }
            }

        }
    }
}
