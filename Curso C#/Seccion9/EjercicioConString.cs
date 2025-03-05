using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_.Seccion9
{
    class EjercicioConString
    {
        /*
         * De entre 8-20 caracteres
         * Van a contener al menos una letra minusculas
         * Una letra mayusculas
         * Un numero
         * Un caracter especial de entre seis posibles opciones
         */

        string numeros = "0123456789";
        string letrasMin = "abcdefghijklmnopqrstuvwxyz";
        string letrasMay = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string caracterEspecial = "$%#&!?";
        int numContiene=0, minContiene=0, mayContiene=0, espContienel=0;


        public string GenerarPassword()
        {
            //Variable que alamcenara la password
            string passwordGenerado = "";

            //Iniciamos a la clase Random()
            Random random = new Random();

            //variable longitud de la cadena entre 8 y 20
            int longitudPassword = random.Next(8, 21);

            double numTener = longitudPassword * .15;
            double minTener = longitudPassword * .35;
            double mayTener = longitudPassword * .35;
            double espTener = longitudPassword * .15;

            char caracterEscogido;

            while (passwordGenerado.Length < longitudPassword)
            {
                switch(random.Next(0, 4))
                {
                    case 0:
                        if (numContiene < numTener)
                        {
                            //string numeros = "0123456789"; --> la cadena tiene 10 caracteres 
                            //caracterEscogido = numeros[random.Next(10)]; --> me genera un numero entre 1 y 10
                            //caracterEscogido = numeros[3]; --> En el supuesto que me dio un 3
                            caracterEscogido = numeros[random.Next(numeros.Length)];
                            passwordGenerado += caracterEscogido;
                            numContiene++;
                        }
                        break;
                    case 1:
                        if (minContiene < numTener)
                        {
                            caracterEscogido = letrasMin[random.Next(letrasMin.Length)];
                            passwordGenerado += caracterEscogido;
                            minContiene++;
                        }
                        break;
                    case 2:
                        if (mayContiene < numTener)
                        {
                            caracterEscogido = letrasMay[random.Next(letrasMay.Length)];
                            passwordGenerado += caracterEscogido;
                            mayContiene++;
                        }
                        break;
                    case 3:
                        if (espContienel < numTener)
                        {
                            caracterEscogido = caracterEspecial[random.Next(caracterEspecial.Length)];
                            passwordGenerado += caracterEscogido;
                            espContienel++;
                        }
                        break;
                }
            }

            return passwordGenerado;

        }
    }
}
