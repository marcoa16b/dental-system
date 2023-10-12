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
 * Clase que representa un cliente
 */

namespace Entities
{
    public class Client : Person
    {
        public DateTime BirthDate { get; set; }
        public char Gender { get; set; }

        public Client(int id, string name, string lastName, string secondLastName, DateTime birthDate, char gender)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            SecondLastName = secondLastName;
            BirthDate = birthDate;
            Gender = gender;
        }

    }
}
