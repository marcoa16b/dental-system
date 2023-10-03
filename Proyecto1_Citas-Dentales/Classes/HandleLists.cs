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

        public static QueryType[] QueryTypesArray { get; } = new QueryType[10];
        public static Client[] ClientsArray { get; } = new Client[20];
        public static Doctor[] DoctorsArray { get; } = new Doctor[20];
        public static Appointment[] AppointmentsArray { get; } = new Appointment[20];
    }
}
