using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Programación_Estructurada
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables 

            // Variables que almacenan a todos los estudiantes y determinan los parametros para serlo.
            string[][] nombresEstudiantes;
            double[][] notasEstudiantes;
            int[][] asistenciasEstudiantes;
            string[][] aprobacionEstudiantes;
            // Variable que establece la cantidad de estudiantes ingresados.
            int index = 0;

            // Variable para gestionar menus.
            int opcion1 = 0;
            string opcionString1 = null;

            #endregion

            #region Constructores

            // Inicializa los jagged array para su uso.
            InicializarValores(out nombresEstudiantes, out notasEstudiantes, out asistenciasEstudiantes, out aprobacionEstudiantes);

            #endregion

            #region Menu de desplegue de información
            

            while(opcionString1 != "5")
            {
                Console.WriteLine("SEFIAN: Controlador de notas.");
                Console.WriteLine("Escoja la opción que desea para la visualizacion del registro:");
                Console.WriteLine("\t1.Por Nombre en forma ascendente.\n\t2.Por apellido en forma descendente.\n\t3.Por nota de la prueba en forma ascendente.\n\t4.Por nota del examen de forma descendente.\n\t5.Salir.");
                Console.Write("Opcion: "); opcionString1 = Console.ReadLine();
                Console.Clear();
                switch(opcionString1)
                {
                    #region Por nombre de manera ascendente

                    case "1":
                        break;

                    #endregion

                    #region Por apellido de manera descendente

                    case "2":
                        break;

                    #endregion

                    #region Por nota de la prueba de manera ascendente

                    case "3":
                        break;

                    #endregion

                    #region Por nota del examen de manera descendente

                    case "4":
                        break;

                    #endregion                  

                    // Salida del programa. 
                    case "5":
                        Console.WriteLine("Cerrando el programa...");
                        Procesando();
                        Console.WriteLine("Gracias por utilizar nuestro programa!");
                        break;

                    // En caso de seleccionar opción no válida.
                    default:
                        Console.WriteLine("Error: Opcion no valida.");
                        Console.WriteLine("\nPresione cualquier tecla para continuar..."); Console.ReadKey(); Console.Clear();
                        break;                   
                }
            }

            #endregion

            Console.WriteLine("\nPresione cualquier tecla para salir..."); Console.ReadKey();
        }

        #region Métodos

        #region Inicialización de valores inciales para casos de prueba y para su uso.

        // Inicializa los valores de que almacenan a todos los esutdiantes para su uso o para resetear el registro.
        static void InicializarValores(out string[][] p_nombresEstudiantes, out double[][] p_notasEstudiantes, out int[][] p_asistenciaEstudiantes, out string[][] p_aprobacionEstudiantes)
        {
            p_nombresEstudiantes = new string[100][];
            p_notasEstudiantes = new double[100][];
            p_asistenciaEstudiantes = new int[100][];
            p_aprobacionEstudiantes = new string[100][];
        }

        #endregion

        #region Funciones para ambiente amigable con el usuario.

        // Despliega puntos a la consola simulando que el programa esta procesando información.
        static void Procesando()
        {
            for(int i = 0; i < 6; i++)
            {
                for (int j = 0; j < i + 1; j++) Console.Write(".");
                Console.WriteLine();
            }           
        }

        #endregion

        #endregion

    }
}
