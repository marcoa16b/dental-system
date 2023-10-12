using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* UNED: Proyecto III Cuatrimestre
 * Proyecto #1: Aplicacion para gestionar citas de una clinica dental
 * Estidiante: Marco Fernando Agüero Barboza
 * Fecha: 11/10/2023
 * 
 * Clase que representa una cita
 */

namespace Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public QueryType QueryType { get; set; }
        public Client Client { get; set; }
        public Doctor Doctor { get; set; }

        // Constructor
        public Appointment(int id, DateTime date, QueryType queryType, Client client, Doctor doctor)
        {
            Id = id;
            Date = date;
            QueryType = queryType;
            Client = client;
            Doctor = doctor;
        }
    }
}
