using Curso_C_.Seccion4;
using Curso_C_.Seccion5__Metodos_;
using Curso_C_.Seccion5;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso_C_.Seccion6;
using Curso_C_.Seccion7;
using Curso_C_.Seccion8;
using System.Xml.Linq;

namespace Curso_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Segundo_ejercicio_para_for factorial = new Segundo_ejercicio_para_for();
            //factorial.StartFactorial();

            //Uso_del_While uso_del_while = new Uso_del_While();
            //uso_del_while.StartClass();

            //Ejercicio_While ejercicio_while = new Ejercicio_While();
            //ejercicio_while.StartEjercicioWhile();

            //Uso_del_Do_While uso_del_do_while = new Uso_del_Do_While();
            //uso_del_do_while.StartClass();

            //Ejercicio_Do_While ejercicio_do_while = new Ejercicio_Do_While();
            //ejercicio_do_while.StartEjercicio_Do_While();
            //
            //IteracionAnidadas iteracionAnidadas = new IteracionAnidadas();
            //iteracionAnidadas.IteracionAnidada();


            //EjerciciosSeccion4 ejerciciosSeccion4 = new EjerciciosSeccion4();
            //ejerciciosSeccion4.CalcularPotencia();

            //EjerciciosSeccion4 ejerciciosSeccion4 = new EjerciciosSeccion4();
            //ejerciciosSeccion4.CalcularNumerosPrimos();

            //Metodos metodos = new Metodos();
            //metodos.StartMetodo();

            //EjercicioUnoMetodos ejercicioUnoMetodos = new EjercicioUnoMetodos();
            //ejercicioUnoMetodos.StartMetodo();

            //EjercicioDosMetodos ejercicioDosMetodos = new EjercicioDosMetodos();
            //ejercicioDosMetodos.StartMetodo();

            //Matrices matrices = new Matrices();
            //matrices.StartMethod();

            //EjercicioUnoMatriz ejercicioUnoMatriz = new EjercicioUnoMatriz();
            // ejercicioUnoMatriz.StartMethod();


            //********************************** Uso de la clase Random

            //Random random = new Random();

            // Tiene varios metodos para generar numeros aleatorios
            // Los 4 metodos mas comunes son:
            // Next() - Genera un numero aleatorio entre 0 y el valor que se le pase como parametro
            // Next(int min, int max) - Genera un numero aleatorio entre el rango que se le pase como parametro
            // NextDouble() - Genera un numero aleatorio entre 0 y 1
            // NextBytes(byte[] buffer) - Llena un arreglo de bytes con numeros aleatorios

            //Console.WriteLine(random.Next()); //Genera un numero aleatorio no negativo
            //Console.WriteLine(random.Next(10)); //Genera un numero aleatorio entre 0 y 10
            //Console.WriteLine(random.Next(1, 50)); //Genera un numero aleatorio entre 1 y 50


            //********************************** Fin de uso de la clase Random






            //********************************** Uso de la clase Automovil

            //Automovil automovil = new Automovil();
            //automovil.Marca = "Toyota"; //Se asigna atraves de la propiedad

            //Console.WriteLine(automovil.Marca); //Se accede atraves de la propiedad

            //automovil.Encender();

            //automovil.Modelo = "Corolla"; //Se asigna atraves de la propiedad
            //automovil.Anio = 2021; //Se asigna atraves de la propiedad

            //Console.WriteLine(automovil.Modelo); //Se accede atraves de la propiedad
            //Console.WriteLine(automovil.Anio); //Se accede atraves de la propiedad

            //Console.WriteLine(automovil.ToString()); //Se accede al metodo ToString


            //Automovil automovil2 = new Automovil("Nissan", "Sentra", 2021);
            //Console.WriteLine(automovil2.ToString());
            //automovil2.Encender();
            //automovil2.MetodoSobrecargado();
            //automovil2.MetodoSobrecargado(10);

            //********************************** Fin de uso de la clase Automovil




            //********************************** Uso de la clase Empleado



            //string name, lastName, nip;


            //Console.WriteLine("Bienvenidos\n");
            //Console.WriteLine("Ingrese los datos que se le solicitan\n");

            //Console.WriteLine("Ingrese el nombre:\n");
            //name = Console.ReadLine();

            //Console.WriteLine("Ingrese el apellido:\n");
            //lastName = Console.ReadLine();

            //Console.WriteLine("Ingrese el Dui:\n");
            //nip = Console.ReadLine();

            //Empleado empleado = new Empleado(name, lastName);
            //empleado.Nip = nip;



            //Console.WriteLine(empleado.ToString());







            //********************************** Fin de uso de la clase Empleado




            //********************************** Uso de la clase Banco




            //string name, lastName, direction, rfc;
            //int opcion;
            //double saldo, cantidad;
            //bool continuar = true;

            //Console.WriteLine("Bienvenidos\n");
            //Console.WriteLine("Ingrese los datos que se le solicitan\n");

            //Console.WriteLine("Ingrese el nombre:\n");
            //name = Console.ReadLine();

            //Console.WriteLine("Ingrese el apellido:\n");
            //lastName = Console.ReadLine();

            //Console.WriteLine("Ingrese la direccion:\n");
            //direction = Console.ReadLine();

            //Console.WriteLine("Ingrese el rfc:\n");
            //rfc = Console.ReadLine();

            //Console.WriteLine("Ingrese el saldo:\n");
            //saldo = Convert.ToDouble(Console.ReadLine());

            //Bank bank = new Bank(name, lastName, direction, rfc, saldo);

            //do
            //{

            //    Console.WriteLine("Que operacion desea realizar\n");
            //    Console.WriteLine("1. Depositar\n");
            //    Console.WriteLine("2. Retirar\n");
            //    Console.WriteLine("3. Consultar saldo\n");
            //    Console.WriteLine("4. Consultar informacio\n");
            //    Console.WriteLine("5. Salir\n");

            //    opcion = Convert.ToInt32(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            Console.WriteLine("Ingrese la cantidad a depositar\n");
            //            cantidad = Convert.ToDouble(Console.ReadLine());
            //            bank.Depositar(cantidad);
            //            Console.WriteLine("Deposito realizado con exito\n");
            //            Console.WriteLine("Saldo actual: " + bank.ConsultarSaldo());
            //            break;

            //        case 2:
            //            Console.WriteLine("Ingrese la cantidad a retirar\n");
            //            cantidad = Convert.ToDouble(Console.ReadLine());
            //            bank.Retirar(cantidad);
            //            Console.WriteLine("Saldo actual: " + bank.ConsultarSaldo());
            //            break;
            //        case 3:
            //            Console.WriteLine("Su saldo es: " + bank.ConsultarSaldo());
            //            break;
            //        case 4:
            //            Console.WriteLine(bank.ToString());
            //            break;
            //        case 5:
            //            Console.WriteLine("Gracias por usar nuestros servicios");
            //            continuar = false;
            //            break;
            //    }
            //} while (continuar);









            //********************************** Fin de uso de la clase Banco



            //********************************** Uso de la clase Colecciones


            //Alumno valorAlumno;

            //string valorString;

            //Colecciones<Alumno> colecciones = new Colecciones<Alumno>(5);

            //Colecciones<string> coleccionesString = new Colecciones<string>(5);

            //Alumno alumno1 = new Alumno(20);
            //Alumno alumno2 = new Alumno(21);
            //Alumno alumno3 = new Alumno(22);


            //coleccionesString.Agregar("Hola");
            //coleccionesString.Agregar("Mundo");

            //colecciones.Agregar(alumno1);
            //colecciones.Agregar(alumno2);
            //colecciones.Agregar(alumno3);

            //valorAlumno = colecciones.Obtener(2);


            //valorString = coleccionesString.Obtener(1);


            //Console.WriteLine(valorAlumno.Edad);
            //Console.WriteLine(valorString.ToString());




            //********************************** Fin de uso de la clase Colecciones





            //********************************** Uso de la clase ColeccionGenericaList

            string elemento;
            int opcion;

            Random random = new Random();

            ColeccionGenericaList coleccionGenericaList = new ColeccionGenericaList();

            //do
            //{
            //    Console.WriteLine("Ingrese el nombre de la persona: ");
            //    elemento = Console.ReadLine();
            //    coleccionGenericaList.Agregar(elemento);
            //    Console.WriteLine("Desea agregar otra persona? 1-Si 2-No");
            //    opcion = Convert.ToInt32(Console.ReadLine());
            //}
            //while (opcion == 1);


            //coleccionGenericaList.Mostrar();

            coleccionGenericaList.Insertar(1, "Juan");

            coleccionGenericaList.Mostrar();



            //****************************************** Fin de uso de la clase ColeccionGenericaList







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



            //Console.WriteLine("Ingrese el tiempo de permanencia en el estacionamiento en horas");
            //byte hora = Convert.ToByte(Console.ReadLine());

            //if (hora == 1)
            //{
            //    Console.WriteLine("Debes de pagar: $5");
            //}else if (hora > 1 && hora <= 2)
            //{
            //    Console.WriteLine("Debes de pagar: $15");
            //}else if(hora > 2)
            //{
            //    Console.WriteLine("Debes de pagar: $40");

            //}

        }
    }
}
