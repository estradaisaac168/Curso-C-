using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_.Seccion10
{
    internal class EstructuraEnumeracion
    {
        /*Tipos de valor
         * 
         * struct
         * tuplas
         * enum
         * 
         */



        /*
         * Tipos de valor simples/ integrados
         * 
         * Tipos numericos integrales
         * 
         * - sbyte
         * - byte
         * - short
         * - ushort
         * - int
         * - unit
         * - long
         * - ulong
         * - nint
         * - nuint
         * 
         * 
         * Tipos numericos punto flotante
         * 
         * - float
         * - double
         * - decimal
         * 
         * bool
         * 
         * 
         * char
         * 
         */



        /* Tipos de referencias
         * 
         *  - class
         *  - interface
         *  - delegate
         *  - record
         * 
         */


        /*
         * Tipos de referencia integrados
         * 
         * dynamic
         * object
         * string
         * 
         */

        /*
         * 
         * Introduccion a las estructuras alamcenan grandes cantidades de datos y realizar operaciones simples
         * 
         * Organizar codigo
         * 
         * En C#, una estructura (struct) es un tipo de dato que permite agrupar múltiples variables bajo un mismo nombre, 
         * similar a una clase (class).
         * 
         */

        /*
         * Declaracion de una estructura
         * 
         */

    }

    struct EstructuraAlumno
    {
        //Campos
        string nombre;
        string apellido;
        double calificacion;
        bool alergias;
        string telefono;

        //Propiedades
        public string Nombre { get => nombre; set => nombre = value; }

    }

}
