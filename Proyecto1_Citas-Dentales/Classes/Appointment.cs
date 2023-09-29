using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Clase que representa una cita
 * 
 */

namespace Proyecto1_Citas_Dentales.Classes
{
    public class Appointment
    {
        // Fields
        private int _id;
        private DateTime _date;
        private QueryType _queryType;
        private Client _client;
        private Doctor _doctor;

        // Constructor
        public Appointment(int id, DateTime date, QueryType queryType, Client client, Doctor doctor)
        {
            _id = id;
            _date = date;
            _queryType = queryType;
            _client = client;
            _doctor = doctor;
        }

        // Propiedades para acceder a las variables
        public int Id
        {
            get => _id;
        }
        public DateTime Date
        {
            get => _date;
        }
        public QueryType QueryType
        {
            get => _queryType;
        }
        public Client Client
        {
            get => _client;
        }
        public Doctor Doctor
        {
            get => _doctor;
        }
    }
}
