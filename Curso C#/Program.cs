﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte mes = 0;

            //Console.WriteLine("Meses del anio: ");
            //Console.WriteLine("1 Enero: ");
            //Console.WriteLine("2 Febrero: ");
            //Console.WriteLine("3 Marzo: ");
            //Console.WriteLine("4 Abril: ");
            //Console.WriteLine("5 Mayo: ");
            //Console.WriteLine("6 Junio: ");
            //Console.WriteLine("7 Julio: ");
            //Console.WriteLine("8 Agosto: ");
            //Console.WriteLine("9 Septiembre: ");
            //Console.WriteLine("10 Octubre: ");
            //Console.WriteLine("11 Noviembre: ");
            //Console.WriteLine("12 Diciembre: ");

            //Console.WriteLine("Selecciona una de las opciones: ");
            //mes = Convert.ToByte(Console.ReadLine());


            //switch (mes)
            //{
            //    case 1:
            //        Console.WriteLine("Seleccionaste: Enero");
            //        break;

            //    case 2:
            //        Console.WriteLine("Seleccionaste: Febrero");
            //        break;

            //    case 3:
            //        Console.WriteLine("Seleccionaste: Marzo");
            //        break;

            //    case 4:
            //        Console.WriteLine("Seleccionaste: Abril");
            //        break;

            //    case 5:
            //        Console.WriteLine("Seleccionaste: Mayo");
            //        break;

            //    case 6:
            //        Console.WriteLine("Seleccionaste: Junio");
            //        break;

            //}

            //******************************** Ejercicio #2

            //Console.WriteLine("Ingrese un numero para evaluar si es par o impar");
            //byte numero = Convert.ToByte(Console.ReadLine());


            //if (numero % 2 == 0)
            //{
            //    Console.WriteLine("El numero es par");
            //}
            //else
            //{
            //    Console.WriteLine("El numero es inpar");
            //}


            //******************************** Ejercicio #3



            Console.WriteLine("Ingrese el tiempo de permanencia en el estacionamiento en horas");
            byte hora = Convert.ToByte(Console.ReadLine());

            if (hora == 1)
            {
                Console.WriteLine("Debes de pagar: $5");
            }else if (hora > 1 && hora <= 2)
            {
                Console.WriteLine("Debes de pagar: $15");
            }else if(hora > 2)
            {
                Console.WriteLine("Debes de pagar: $40");

            }

        }
    }
}
