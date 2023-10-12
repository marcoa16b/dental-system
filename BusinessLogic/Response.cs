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
 * Esta clase es utilizada para manejar una convencion en las respuestas
 * para la comunicacion entre la capa de presentacion y la capa de logica
 */

namespace BusinessLogic
{
    public class Response
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
    }
}
