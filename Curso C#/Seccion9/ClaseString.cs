using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_.Seccion9
{
    class ClaseString
    {
        public void HandlerClass()
        {
            // Metodos para buscar cadenas

            
            // Substring
            // ToLower
            // ToUpper

            // Split
            // Concat
            // Format
            // Join
            // PadLeft
            // PadRight
            // IsNullOrEmpty
            // IsNullOrWhiteSpace
            // Compare
            // CompareTo
            // Equals
            // EqualsIgnoreCase
            // Length
            // Clone
            // Copy
            // CopyTo
            // ToCharArray
            // ToCharArray


        }

        public void MethodString()
        {
            // Contains --> Devuelve un valor booleano si la cadena contiene la subcadena
            //string parrafo = "Hola, mi nombre es Juan Perez mas contenido Lorem ipsum dolor sit amet consectetur adipisicing elit. " +
            //                    "Fuga consequatur impedit a est accusantium facere voluptatibus quod quas voluptatem architecto. " +
            //                    "Fugit vero amet corporis quae porro voluptatem ea officiis maiores?";

            //Console.WriteLine(parrafo);

            //Console.Write("\nEscribe la subcadena a buscar: ");
            //string textobuscar = Console.ReadLine();

            //// Contains --> Sensible a mayusculas y minusculas
            //if (parrafo.Contains(textobuscar)) // Si la cadena contiene la subcadena devuelve true
            //{
            //    Console.WriteLine("La cadena contiene la subcadena");
            //}
            //else
            //{
            //    Console.WriteLine("La cadena no contiene la subcadena");
            //}



            // StartsWith --> Devuelve un valor booleano si la cadena empieza con la subcadena
            // EndsWith --> Devuelve un valor booleano si la cadena termina con la subcadena


            //________________________________________________________________________________________________________________________________

            // IndexOf --> Devuelve la posicion de la primera ocurrencia de la subcadena devuelve -1 si no la encuentra
            // LastIndexOf --> Devuelve la posicion de la ultima ocurrencia de la subcadena

            //string palabra = "Pantalla";
            //char caracterBuscado = 'P';

            //// Ambos retornan un -1 si no encuentran la subcadena
            //int index = palabra.IndexOf(caracterBuscado); // Sensibles a mayusculas y minusculas
            //int index2 = palabra.LastIndexOf(caracterBuscado); // Sensibles a mayusculas y minusculas
            //Console.WriteLine("La primera ocurrencia de la letra {0} es en la posicion {1}", caracterBuscado, index);
            //Console.WriteLine("La ultima ocurrencia de la letra {0} es en la posicion {1}", caracterBuscado, index2);


            //________________________________________________________________________________________________________________________________

            //Inmutabilidad de las cadenas
            // Las cadenas son inmutables, es decir, no se pueden modificar una vez creadas

            //string cadena = "Hola Mundo";
            //string cadena2 = cadena; // --> cadena2 apunta a la misma direccion de memoria que cadena

            ////cadena += cadena2; // Concatenamos la cadena2 a la cadena

            //Console.WriteLine(cadena);
            //Console.WriteLine(cadena2);

            //cadena += " desde C#"; // --> Se crea una nueva cadena con la concatenacion de la cadena original y la nueva cadena

            //Console.WriteLine("Despues de la concatenacion");

            //Console.WriteLine(cadena2); // --> cadena2 sigue apuntando a la cadena original
            //Console.WriteLine(cadena); // --> cadena apunta a la nueva cadena 


            //________________________________________________________________________________________________________________________________

            // Trim --> Elimina los espacios en blanco al inicio y al final de la cadena o los caracteres especificados
            // TrimStart --> Elimina los espacios en blanco al inicio de la cadena
            // TrimEnd --> Elimina los espacios en blanco al final de la cadena


            //string cadena1 = "-----Hola Mundo----";
            //string cadena2 = "    Hola Mundo    ";

            //Console.WriteLine("Texto sucio: ", cadena1);
            //Console.WriteLine("Texto con espacios: ", cadena2);

            //Console.WriteLine(cadena1.Trim('-'));
            //Console.WriteLine(cadena2.Trim());


            //________________________________________________________________________________________________________________________________

            // Replace --> Reemplaza una subcadena por otra subcadena

            //Ejemplo con Replace
            //string cadena = "Hola Mundo";
            //string cadenaReemplazada = cadena.Replace("Mundo", "C#");

            //Console.WriteLine(cadena);
            //Console.WriteLine(cadenaReemplazada);

            ////Especificar el rango desde donde se va a reemplazar
            //string cadena2 = "Hola Mundo";
            //string cadenaReemplazada2 = cadena2.Replace("Mundo", "C#", 5, 5); // Reemplaza la subcadena desde la posicion 5 y reemplaza 5 caracteres


            //________________________________________________________________________________________________________________________________


            //StringBuilder

            //StringBuilder es una clase que permite modificar cadenas de texto de manera eficiente
            //bufer de memoria que se puede modificar, a diferencia de las cadenas que son inmutables
            //mas informacion de bufer con StringBuilder 


            //string numeros = "";

            //for (int i = 1; i < 101; i++)
            //{
            //    numeros += i + ", ";
            //}

            //Console.WriteLine(numeros);


            //String y StringBuilder no son compatibles --> StringBuilder.ToString para CAST

            StringBuilder numeros = new StringBuilder();

            for (int i = 1; i < 101; i++)
            {
                numeros.Append(i + ", "); //Append() --> info
            }

            string cadenaString = numeros.ToString(); //

            Console.WriteLine(numeros);

        }
    }
}
