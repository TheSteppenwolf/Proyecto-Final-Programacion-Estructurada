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
            bool[][] aprobacionEstudiantes;
            // Variable que establece la cantidad de estudiantes ingresados.
            int index = 0;

            // Variable para gestionar menus.
            int opcion1 = 0;
            string opcionString1 = null;

            #endregion

            #region Constructores

            // Inicializa los jagged array para su uso.
            InicializarValores(out nombresEstudiantes, out notasEstudiantes, out asistenciasEstudiantes, out aprobacionEstudiantes);
            InicializarValores(ref index, ref nombresEstudiantes, ref notasEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);

            #endregion

            #region Menu de desplegue de información


            while (opcionString1 != "5")
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
                        // Se llama a la función para el ordenamiento según lo requerido.
                        PruebaAscendente(ref index, ref nombresEstudiantes, ref notasEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);
                        // Se llama a la función de impresión de los estudiantes.
                        GetEstudiantes(ref index, ref nombresEstudiantes, ref notasEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar..."); Console.ReadLine(); Console.Clear();
                        break;

                    #endregion

                    #region Por nota del examen de manera descendente

                    case "4":                        
                        // Se llama a la función para el ordenamiento según lo requerido.
                        ExamenDescendente(ref index, ref nombresEstudiantes, ref notasEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);
                        // Se llama a la función de impresión de los estudiantes.
                        GetEstudiantes(ref index, ref nombresEstudiantes, ref notasEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar..."); Console.ReadLine(); Console.Clear();
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
        static void InicializarValores(out string[][] p_nombresEstudiantes, out double[][] p_notasEstudiantes, out int[][] p_asistenciaEstudiantes, out bool[][] p_aprobacionEstudiantes)
        {
            p_nombresEstudiantes = new string[100][];
            p_notasEstudiantes = new double[100][];
            p_asistenciaEstudiantes = new int[100][];
            p_aprobacionEstudiantes = new bool[100][];
        }

        // Crea estudiantes para casos de prueba.
        static void InicializarValores(ref int p_index, ref string[][] p_nombresEstudiantes, ref double[][] p_notasEstudiantes, ref int[][] p_asistenciaEstudiantes, ref bool[][] p_aprobacionEstudiantes)
        {
            string tempNombre = "SBSNOM";
            string tempApellido = "SBSAPE";
            double tempPrueba = 8, tempExamen = 10;
            for(int i = 0; i < 6; i++)
            {
                p_nombresEstudiantes[p_index] = new string[] { tempNombre.Substring(0, i + 1), tempApellido.Substring(0, i + 1) };
                p_notasEstudiantes[p_index] = new double[] { ++tempPrueba, ++tempExamen };
                p_asistenciaEstudiantes[p_index] = new int[] { (int)tempPrueba + 2 };
                p_aprobacionEstudiantes[p_index] = new bool[] { true };
                p_index++;
            }
        }

        #endregion

        #region Ordenamiento de los datos del estudiante

        // Ordena de manera ascendente a los estudiantes considerando su nota de la prueba.
        static void PruebaAscendente(ref int p_index, ref string[][] p_nombresEstudiantes, ref double[][] p_notasEstudiantes, ref int[][] p_asistenciaEstudiantes, ref bool[][] p_aprobacionEstudiantes)
        {
            string tempNombre, tempApellido;
            double tempPrueba, tempExamen;
            int tempAsistencias;
            bool tempAprobacion;
            for(int i = 0; i < p_index; i++)
            {
                for(int j = 0; j < p_index - 1; j++)
                {
                    if(p_notasEstudiantes[j][0] > p_notasEstudiantes[j + 1][0])
                    {
                        // Inicializar variables temporales.
                        tempNombre = p_nombresEstudiantes[j][0];
                        tempApellido = p_nombresEstudiantes[j][1];
                        tempPrueba = p_notasEstudiantes[j][0];
                        tempExamen = p_notasEstudiantes[j][1];
                        tempAsistencias = p_asistenciaEstudiantes[j][0];
                        tempAprobacion = p_aprobacionEstudiantes[j][0];

                        // Renovar la posición del menor en la posición del mayor.                        
                        p_nombresEstudiantes[j][0] = p_nombresEstudiantes[j + 1][0];
                        p_nombresEstudiantes[j][1] = p_nombresEstudiantes[j + 1][1];
                        p_notasEstudiantes[j][0] = p_notasEstudiantes[j + 1][0];
                        p_notasEstudiantes[j][1] = p_notasEstudiantes[j + 1][1];
                        p_asistenciaEstudiantes[j][0] = p_asistenciaEstudiantes[j + 1][0];
                        p_aprobacionEstudiantes[j][0] = p_aprobacionEstudiantes[j + 1][0];

                        // Renovar la posición del mayor.
                        p_nombresEstudiantes[j + 1][0] = tempNombre;
                        p_nombresEstudiantes[j + 1][0] = tempApellido;
                        p_notasEstudiantes[j + 1][0] = tempPrueba;
                        p_notasEstudiantes[j + 1][1] = tempPrueba;
                        p_asistenciaEstudiantes[j + 1][0] = tempAsistencias;
                        p_aprobacionEstudiantes[j][0] = tempAprobacion;
                    }
                }
            }
        }

        // Ordena de manera descendente a los estudiantes considerando su nota de la prueba.
        static void ExamenDescendente(ref int p_index, ref string[][] p_nombresEstudiantes, ref double[][] p_notasEstudiantes, ref int[][] p_asistenciaEstudiantes, ref bool[][] p_aprobacionEstudiantes)
        {
            string tempNombre, tempApellido;
            double tempPrueba, tempExamen;
            int tempAsistencias;
            bool tempAprobacion;
            for (int i = 0; i < p_index; i++)
            {
                for (int j = 0; j < p_index - 1; j++)
                {
                    if (p_notasEstudiantes[j][0] < p_notasEstudiantes[j + 1][0])
                    {
                        // Inicializar variables temporales.
                        tempNombre = p_nombresEstudiantes[j][0];
                        tempApellido = p_nombresEstudiantes[j][1];
                        tempPrueba = p_notasEstudiantes[j][0];
                        tempExamen = p_notasEstudiantes[j][1];
                        tempAsistencias = p_asistenciaEstudiantes[j][0];
                        tempAprobacion = p_aprobacionEstudiantes[j][0];

                        // Renovar la posición del menor en la posición del mayor.                        
                        p_nombresEstudiantes[j][0] = p_nombresEstudiantes[j + 1][0];
                        p_nombresEstudiantes[j][1] = p_nombresEstudiantes[j + 1][1];
                        p_notasEstudiantes[j][0] = p_notasEstudiantes[j + 1][0];
                        p_notasEstudiantes[j][1] = p_notasEstudiantes[j + 1][1];
                        p_asistenciaEstudiantes[j][0] = p_asistenciaEstudiantes[j + 1][0];
                        p_aprobacionEstudiantes[j][0] = p_aprobacionEstudiantes[j + 1][0];

                        // Renovar la posición del mayor.
                        p_nombresEstudiantes[j + 1][0] = tempNombre;
                        p_nombresEstudiantes[j + 1][0] = tempApellido;
                        p_notasEstudiantes[j + 1][0] = tempPrueba;
                        p_notasEstudiantes[j + 1][1] = tempPrueba;
                        p_asistenciaEstudiantes[j + 1][0] = tempAsistencias;
                        p_aprobacionEstudiantes[j][0] = tempAprobacion;
                    }
                }
            }
        }

        #endregion

        #region Impresión de los estudiantes

        static void GetEstudiantes(ref int p_index, ref string[][] p_nombresEstudiantes, ref double[][] p_notasEstudiantes, ref int[][] p_asistenciaEstudiantes, ref bool[][] p_aprobacionEstudiantes)
        {
            Console.WriteLine("Nombre\t\tApellido\t\tPrueba\t\tExamen\t\tAsistencia\t\tResultado");
            for(int i = 0; i <= p_index - 1; i++)
            {
                if (i % 2 == 0) { Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black; }
                else { Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White; }
                Console.WriteLine($"{p_nombresEstudiantes[i][0]}\t\t{p_nombresEstudiantes[i][1]}\t\t\t{p_notasEstudiantes[i][0]}\t\t{p_notasEstudiantes[i][1]}\t\t{p_asistenciaEstudiantes[i][0]}\t\t\t{p_aprobacionEstudiantes[i][0]}");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
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
