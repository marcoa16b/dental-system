﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* UNED: Proyecto III Cuatrimestre
 * Proyecto #1: Aplicacion para gestionar citas de una clinica dental
 * Estidiante: Marco Fernando Agüero Barboza
 * Fecha: 11/10/2023
 * 
 * Clase que representa un doctor
 */

namespace Entities
{
    public class Doctor : Person
    {
        public char State { get; set; }

        public Doctor(int id, string name, string lastName, string secondLastName, char state)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            SecondLastName = secondLastName;
            State = state;
        }
    }
}
