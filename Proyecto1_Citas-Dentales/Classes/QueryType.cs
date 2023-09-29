using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Citas_Dentales.Classes
{
    public class QueryType
    {
        // Fields
        private int _id;
        private string _description;
        private char _state;

        // Constructor
        public QueryType(int id, string description, char state)
        {
            _id = id;
            _description = description;

            if (state == 'A' || state == 'I')
            {
                _state = state;
            }
            else
            {
                throw new ArgumentException("El estado debe ser 'A' o 'I'");
            }
        }

        // Propiedades para acceder al ID y a la descripcion
        public int Id
        {
            get => _id;
        }
        public string Description
        {
            get => _description;
        }

        // Propiedad para acceder y cambiar el estado
        public char State
        {
            get => _state;
            set 
            { 
                if (value == 'A' || value == 'I')
                {
                    _state = value;
                }
                else
                {
                    throw new ArgumentException("El estado debe ser 'A' o 'I'");
                }
            }
        }
    }
}
