using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Citas_Dentales.Classes
{
    public class Doctor
    {
        private int _id;
        private string _name;
        private string _firstLastName;
        private string _secondLastName;
        private char _state;

        // Constructor
        public Doctor(int id, string name, string firstLastName, string secondLastName, char state)
        {
            _id = id;
            _name = name;
            _firstLastName = firstLastName;
            _secondLastName = secondLastName;
            
            if (state == 'A' || state == 'I')
            {
                _state = state;
            }
            else
            {
                throw new ArgumentException("El estado debe ser 'A' o 'I'");
            }
        }

        // Propiedades para acceder a las variables
        public int Id
        {
            get => _id;
        }
        public string Name
        {
            get => _name;
        }
        public string FirstLastName
        {
            get => _firstLastName;
        }
        public string SecondLastName
        {
            get => _secondLastName;
        }
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
