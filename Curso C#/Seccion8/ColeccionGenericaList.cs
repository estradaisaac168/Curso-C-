using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Curso_C_.Seccion8
{
    class ColeccionGenericaList
    {

        //List<T> es una clase genérica que se encuentra en el espacio de nombres System.Collections.Generic
        //List<T> es una colección de elementos de tipo T
        //List<T> es una clase genérica, por lo que se puede crear una lista de cualquier tipo de datos

        List<string> personas = new List<string>();


        //Métodos de la clase List<T>
        //Add(T) -> Agrega un elemento al final de la lista
        public void Agregar(string nombre)
        {
            personas.Add(nombre);
        }

        //Agregar elementos a la lista en una posición específica
        //Insert(int, T) -> Inserta un elemento en la posición especificada
        public void Insertar(int posicion, string nombre)
        {
            personas.Insert(posicion, nombre);
        }

        public void Mostrar()
        {
            foreach (string persona in personas)
            {
                Console.WriteLine(persona);
            }
        }
    }
}
