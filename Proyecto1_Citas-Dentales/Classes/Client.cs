using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Citas_Dentales.Classes
{
    internal class Client
    {
        private int _id;
        private string _name;
        private string _firstLastName;
        private string _secondLastName;
        private DateTime _birthDate;
        private string _gender;

        // Constructor
        public Client(int id, string name, string firstLastName, string secondLastName, DateTime birthdate, string gender)
        {
            _id = id;
            _name = name;
            _firstLastName = firstLastName;
            _secondLastName = secondLastName;
            _birthDate = birthdate;

            if (gender == "F" || gender == "M" || gender == "N")
            {
                _gender = gender;
            }
            else
            {
                throw new ArgumentException("El género debe ser 'F' (Femenino), 'M' (Masculino) o 'N' (No especificado).");
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
        public DateTime BirthDate
        {
            get => _birthDate;
            set => _birthDate = value;
        }
        public string Gender
        {
            get => _gender;
            set
            {
                if (value == "F" || value == "M" || value == "N")
                {
                    _gender = value;
                }
                else
                {
                    throw new ArgumentException("El género debe ser 'F' (Femenino), 'M' (Masculino) o 'N' (No especificado).");
                }
            }
        }
    }
}
