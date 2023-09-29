using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Citas_Dentales.Classes
{
    public static class HandleLists
    {
        public static List<QueryType> QueryTypesList { get; } = new List<QueryType>();
        public static List<Client> ClientsList { get; } = new List<Client>();
        public static List<Doctor> DoctorsList { get; } = new List<Doctor>();
        public static List<Appointment> AppointmentsList { get; } = new List<Appointment>();
    }
}
