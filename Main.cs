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
            int opcion1 = 0, opcion2 = 0, opcion3 = 0;
            string opcionString1 = null, opcionString2 = null;

            #endregion

            #region Constructores

            // Inicializa los jagged array para su uso.
            InicializarValores(out nombresEstudiantes, out notasEstudiantes, out asistenciasEstudiantes, out aprobacionEstudiantes);

            // Inicializa los jagged array con valores preestablecidos para casos de prueba.
            InicializarValores(ref index ,ref nombresEstudiantes, ref notasEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);

            #endregion

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
                                #region Ingresar nuevo estudiante

                                case (1):
                                    Console.WriteLine("Seccion: Ingresar nuevo estudiante");
                                    Console.WriteLine("Nota: Si desea cancelar la acción de ingreso de estudiantes presione \"Tab\"");
                                    
                                    break;

                                #endregion

                                #region Editar estudiante

                                case (2):
                                    break;

                                #endregion

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

                                            #region Busqueda por apellido

                                            case (2):
                                                break;

                                            #endregion

                                            #region Busqueda por nota

                                            case (3):
                                                break;

                                            #endregion

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
        
        // Inicializa los valores creando estudiantes para realizar pruebas de validación del programa.
        static void InicializarValores(ref int p_index, ref string[][] p_nombresEstudiantes, ref double[][] p_notasEstudiantes, ref int[][] p_asistenciaEstudiantes, ref string[][] p_aprobacionEstudiantes)
        {
            IngresoEstudiante(ref p_index, ref p_nombresEstudiantes, ref p_notasEstudiantes, ref p_asistenciaEstudiantes, ref p_aprobacionEstudiantes, "SEBASTIAN", "TAMAYO", 20, 19, 17, true);
            p_index++;
            IngresoEstudiante(ref p_index, ref p_nombresEstudiantes, ref p_notasEstudiantes, ref p_asistenciaEstudiantes, ref p_aprobacionEstudiantes, "BRYAN", "CUVI", 16, 20, 20, true);
            p_index++;
            IngresoEstudiante(ref p_index, ref p_nombresEstudiantes, ref p_notasEstudiantes, ref p_asistenciaEstudiantes, ref p_aprobacionEstudiantes, "SOFIA", "VILLACIS", 20, 20, 20, true);
            p_index++;
            IngresoEstudiante(ref p_index, ref p_nombresEstudiantes, ref p_notasEstudiantes, ref p_asistenciaEstudiantes, ref p_aprobacionEstudiantes, "ARIANA", "SOTOMAYOR", 10, 13, 7, false);
            p_index++;
            IngresoEstudiante(ref p_index, ref p_nombresEstudiantes, ref p_notasEstudiantes, ref p_asistenciaEstudiantes, ref p_aprobacionEstudiantes, "SEBASTIAN", "PROAÑO", 16, 3, 19, false);
            p_index++;
        }
        
        // Ingreso de estudiante nuevo.
        static void IngresoEstudiante(ref int p_index ,ref string[][] p_nombresEstudiantes, ref double[][] p_notasEstudiantes, ref int[][] p_asistenciaEstudiantes, ref string[][] p_aprobacionEstudiantes, string p_nombre, string p_apellido, double p_nota1, double p_nota2, int p_asistencia, bool p_aprobacion)
        {
            p_nombresEstudiantes[p_index][0] = p_nombre;
            p_nombresEstudiantes[p_index][1] = p_apellido;
            p_notasEstudiantes[p_index][0] = p_nota1;
            p_notasEstudiantes[p_index][1] = p_nota2;
            p_asistenciaEstudiantes[p_index][0] = p_asistencia;
            if (p_aprobacion) p_aprobacionEstudiantes[p_index][0] = "APROBADO";
            else p_aprobacionEstudiantes[p_index][0] = "REPROBADO";
            p_index++;
        }
    }
}
