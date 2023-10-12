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
 * Clase que representa el tipo de consulta
 */

namespace Entities
{
    public class QueryType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public char State { get; set; }

        public QueryType(int id, string description, char state)
        {
            Id = id;
            Description = description;
            State = state;
        }
    }
}
