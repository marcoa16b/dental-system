using Proyecto1_Citas_Dentales.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_Citas_Dentales.States
{
    // Clase estatica para manejar y almacenar los tipos de consulta
    public static class HandleQueryTypes
    {
        // Lista observable de tipos de consulta
        public static BindingList<QueryType> queryTypes = new BindingList<QueryType>();

        // Metodo para agregar un tipo de consulta
        public static void AddQueryType(int id, string description, char state)
        {
            if (queryTypes.Count == 10)
            {
                throw new ArgumentException("No se pueden agregar mas tipos de consulta");
            }
            queryTypes.Add(new QueryType(id, description, state));
        }

        // Metodo para obtener todos los tipos de consulta
        public static BindingList<QueryType> GetQueryTypes()
        {
            return queryTypes;
        }

        public static int GetQueryTypesCount()
        {
            return queryTypes.Count;
        }

        public static bool QueryTypeExists(int id)
        {
            foreach (QueryType queryType in queryTypes)
            {
                if (queryType.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
