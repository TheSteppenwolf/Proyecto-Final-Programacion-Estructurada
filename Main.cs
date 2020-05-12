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

            // Variables para operaciones con valores temporales.
            int[] index;

            // Variable para gestionar menus.
            int opcion1 = 0, opcion2 = 0, opcion3 = 0;
            string opcionString1 = null, opcionString2 = null;

            #endregion

            // Inicializa los jagged array para su uso.
            InicializarValores(out nombresEstudiantes, out notasEstudiantes, out asistenciasEstudiantes, out aprobacionEstudiantes);

            while (opcion1 != 3)
            {
                // Menu inicial de opciones.
                Console.WriteLine("SEFIAN: Controlador de notas");
                Console.Write("Escoja la opcion que desea:\n\t1.Gestionar estudiantes.\n\t2.Ver registro.\n\t3.Salir.\nOpcion: "); opcion1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcion1)
                {
                    #region Gestionar estudiantes

                    case (1):
                        while(opcion2 != 5)
                        {
                            Console.WriteLine("Seccion: Gestionar estudiantes");
                            Console.Write("Escoja la opcion que desea:\n\t1.Ingresar nuevo estudiante.\n\t2.Editar estudiante.\n\t3.Eliminar estudiante.\n\t4.Eliminar registro de estudiantes.\n\t5.Volver al menu principal.\nOpcion: ");
                            opcion2 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch(opcion2)
                            {
                                case (1):
                                    break;
                                case (2):
                                    break;

                                #region Eliminar estudiante

                                case (3):            
                                    while(opcion3 != 5)
                                    {
                                        Console.WriteLine("Seccion: Eliminar estudiante");
                                        Console.WriteLine("A que estudiante desea eliminar?");
                                        Console.Write("Seleccione el metodo de busqueda que desee:\n\t1.Por nombre.\n\t2.Por apellido.\n\t3.Por nota.\n\t4.Por aprobacion.\n\t5.Volver a gestionar estudiantes.\nOpcion: ");
                                        opcion3 = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        switch(opcion3)
                                        {
                                            #region Busqueda de estudiantes por nombre

                                            case (1):                                               
                                                break;

                                            #endregion

                                            case (2):
                                                break;
                                            case (3):
                                                break;

                                            #region Busqueda de estudiantes si aprobaron o no.

                                            case (4):
                                                break;

                                            #endregion

                                            // Regreso a Gestionar estudiantes.
                                            case (5):
                                                break;

                                            // En caso de que el usuario ingrese una opción no permitida.
                                            default:
                                                Console.WriteLine("Error: Opcion no valida, escoja de entre las opciones presentadas.");
                                                Console.WriteLine("Presione cualquier tecla para continuar...");
                                                Console.ReadKey(); Console.Clear();
                                                break;

                                        }
                                    }
                                    break;

                                #endregion

                                #region Eliminar registro de estudiantes

                                case (4):
                                    do
                                    {
                                        Console.Write("Esta seguro que desea eliminar todo el registro de estudiantes? (S/N)"); opcionString1 = Console.ReadLine().Trim().ToUpper();
                                        // Validación de ingreso de opciones válidas.
                                        if (opcionString1 != "S" & opcionString1 != "N")
                                        { 
                                            Console.WriteLine("Error: Opcion ingresada no valida."); 
                                            Console.WriteLine("Presione cualquier tecla para continuar...");
                                            Console.ReadKey(); Console.Clear();
                                        }
                                    } while (opcionString1 != "S" & opcionString1 != "N");
                                    if (opcionString1 == "S")
                                    {
                                        Console.Clear();
                                        InicializarValores(out nombresEstudiantes, out notasEstudiantes, out asistenciasEstudiantes, out aprobacionEstudiantes);
                                        Console.WriteLine("Eliminando registro de estudiantes...");
                                        for (int i = 0; i < 5; i++) { for (int j = 0; j < i + 1; j++) Console.Write("."); Console.WriteLine(); }
                                        Console.WriteLine("\nEl registro de estudiantes ha sido eliminado exitosamente!");
                                        Console.WriteLine("Presione cualquier tecla para continuar...");
                                        Console.ReadKey(); Console.Clear();
                                    }
                                    break;

                                #endregion

                                // Regreso a menu principal.
                                case (5):
                                    break;

                                // En caso de que el usuario ingrese una opción no permitida.
                                default:
                                    Console.WriteLine("Error: Opcion no valida, escoja de entre las opciones presentadas.");
                                    Console.WriteLine("Presione cualquier tecla para continuar...");
                                    Console.ReadKey(); Console.Clear();
                                    break;
                            }
                        }
                        break;

                    #endregion

                    #region Ver registro

                    case (2):
                        break;

                    #endregion

                    // Salida del programa.
                    case (3):
                        Console.WriteLine("Gracias por usar el programa!");
                        break;

                    // En caso de que el usuario ingrese una opción no permitida.
                    default:
                        Console.WriteLine("Error: opcion no valida, escoja de entre las opciones presentadas.");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey(); Console.Clear();
                        break;
                }
            }
            Console.WriteLine("Presione cualquier tecla para salir..."); Console.ReadKey();
        }

        // Inicializa los valores de que almacenan a todos los esutdiantes para su uso o para resetear el registro.
        static void InicializarValores(out string[][] p_nombresEstudiantes, out double[][] p_notasEstuadiantes, out int[][] p_asistenciaEstudiantes, out bool[][] p_aprobacionEstudiantes)
        {
            p_nombresEstudiantes = new string[100][];
            p_notasEstuadiantes = new double[100][];
            p_asistenciaEstudiantes = new int[100][];
            p_aprobacionEstudiantes = new bool[100][];
        }        
    }
}
