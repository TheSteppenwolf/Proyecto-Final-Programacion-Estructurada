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
            string[] nombresEstudiantes;
            string[] apellidosEstudiantes;
            double[] pruebasEstudiantes;
            double[] examenesEstudiantes;
            double[] promedioEstudiantes;
            int[] asistenciasEstudiantes;
            bool[] aprobacionEstudiantes;
            // Variable que establece la cantidad de estudiantes ingresados.
            int index = 0;

            // Variables que definen el ingreso de un estudiante individual.
            string nom, ape;
            double nota, exam;
            int asis;
            string res;

            // Variable para gestionar menus.            
            string opcionString1 = null;

            #endregion
           
            #region Constructores

            // Inicializa los jagged array para su uso con el maximo de estudiantes que se desea.
            InicializarValores(out nombresEstudiantes, out apellidosEstudiantes, out pruebasEstudiantes, out examenesEstudiantes, out promedioEstudiantes, out asistenciasEstudiantes, out aprobacionEstudiantes, 1000);            

            #endregion

            #region Ingreso Estudiantes

            Console.WriteLine("Lista de estudiantes: \n ");
            do
            {
                Console.Write("Nombre del Estudiante N*{0}: ", index + 1); nom = Console.ReadLine().ToUpper();                
                Console.Write("Apellido del Estudiante N*{0}: ", index + 1); ape = Console.ReadLine().ToUpper();

                // Validación de entrada correcta de información de la nota de la prueba.
                while (true)
                {
                    try
                    {                        
                        do
                        {
                            Console.Write("Nota de la prueba (/20) del Estudiante N*{0}:  ", index + 1); nota = Convert.ToDouble(Console.ReadLine());
                            if (nota > 20 || nota < 0) Console.WriteLine("Error: Ingresar informacion dentro del regimen establecido");
                        } while (nota > 20 || nota < 0);
                    }
                    catch { Console.WriteLine("Error: Valor ingresado no valido."); continue; }
                    break;
                }

                // Validación de entrada correcta de información de la nota del examen.
                while (true)
                {
                    try
                    {                        
                        do
                        {
                            Console.Write("Nota Examen (/20) del Estudiante N*{0}: ", index + 1); exam = Convert.ToDouble(Console.ReadLine());
                            if (exam > 20 || exam < 0) Console.WriteLine("Error: Ingresar informacion dentro del regimen establecido");
                        } while (exam > 20 || exam < 0);
                    }
                    catch { Console.WriteLine("Error: Valor ingresado no valido."); continue; }
                    break;
                }

                // Validación de entrada correcta de información de la asistencia.
                while (true)
                {
                    try
                    {
                        do
                        {
                            Console.Write("Asistencia del Estudiante N*{0}: (1-20): ", index + 1); asis = int.Parse(Console.ReadLine());
                            if (asis > 20 || asis < 1) Console.WriteLine("Error: Ingresar informacion dentro del regimen establecido");                            
                        } while (asis > 20 || asis < 1);
                    }
                    catch { Console.WriteLine("Error: Valor ingresado no valido."); continue; }
                    break;
                }

                // Creación de nuevo estudiante en base a la información ingresada.
                InicializarValores(nom,ape,nota,exam,asis, ref nombresEstudiantes, ref apellidosEstudiantes, ref pruebasEstudiantes, ref examenesEstudiantes, ref promedioEstudiantes, ref asistenciasEstudiantes, ref index);

                // Validación e ingreso de opciones para ingresar nuevos estudiantes.
                do
                {
                    Console.Write("Desea ingresar otro estudiante? (S/N): "); res = Console.ReadLine().ToUpper();
                    if (res != "S" & res != "N") Console.WriteLine("Error: Opcion ingresada no valida.");
                } while (res != "S" & res != "N");

                // Salida del loop.
                if (res.Equals("N")) break; 

                // Cambio de colores aleatorios.
                PantallaPintada(); Console.Clear();
            } while (true);

            // Evaluación de reprobados y aprobados.
            resultado(index, ref aprobacionEstudiantes,promedioEstudiantes, asistenciasEstudiantes);

            // Vuelta a la normalidad para una mejor presentación de la información del programa.
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White; Console.Clear();

            #endregion

            #region Menu de desplegue de información

            while (opcionString1 != "5")
            {
                Console.WriteLine("SEFIAN: Controlador de notas.");
                Console.WriteLine("Escoja la opción que desea para la visualizacion del registro:"); 
                Console.WriteLine("\t1.Por Nombre en forma ascendente.\n\t2.Por apellido en forma descendente.\n\t3.Por prueba de manera ascendente.\n\t4.Por examen de manera descendente.\n\t5.Salir."); 
                Console.Write("Opcion: "); opcionString1 = Console.ReadLine(); Console.Clear();
                switch(opcionString1)
                {                    
                    #region Por nombre de manera ascendente

                    case "1":
                        // Se llama a la función para el ordenamiento según lo requerido.
                        ascendenteNombre(index, ref nombresEstudiantes, ref apellidosEstudiantes, ref pruebasEstudiantes, ref examenesEstudiantes, ref promedioEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);
                        // Se llama a la función de impresión de los estudiantes.
                        GetEstudiantes(index, nombresEstudiantes, apellidosEstudiantes, pruebasEstudiantes, examenesEstudiantes, promedioEstudiantes, asistenciasEstudiantes, aprobacionEstudiantes);
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar..."); Console.ReadLine(); Console.Clear();
                        break;

                    #endregion
                   
                    #region Por apellido de manera descendente

                    case "2":
                        // Se llama a la función para el ordenamiento según lo requerido.
                        descendenteApellido(index, ref nombresEstudiantes, ref apellidosEstudiantes, ref pruebasEstudiantes, ref examenesEstudiantes, ref promedioEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);
                        // Se llama a la función de impresión de los estudiantes.
                        GetEstudiantes(index, nombresEstudiantes, apellidosEstudiantes, pruebasEstudiantes, examenesEstudiantes, promedioEstudiantes, asistenciasEstudiantes, aprobacionEstudiantes);
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar..."); Console.ReadLine(); Console.Clear();
                        break;

                    #endregion

                    #region Por prueba de manera ascendente.

                    case "3":
                        // Se llama a la función de ordenamiento según lo requerido.
                        NotasAscendente(index, ref nombresEstudiantes, ref apellidosEstudiantes, ref pruebasEstudiantes, ref examenesEstudiantes, ref promedioEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);
                        // Se llama a la función de impresión de los estudiantes.
                        GetEstudiantes(index, nombresEstudiantes, apellidosEstudiantes, pruebasEstudiantes, examenesEstudiantes, promedioEstudiantes, asistenciasEstudiantes, aprobacionEstudiantes);
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar..."); Console.ReadLine(); Console.Clear();
                        break;

                    #endregion

                    #region Por examen de manera descendente.

                    case "4":
                        // Se llama a la función de ordenamiento según lo requerido.
                        NotasDescendente(index, ref nombresEstudiantes, ref apellidosEstudiantes, ref pruebasEstudiantes, ref examenesEstudiantes, ref promedioEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);
                        // Se llama a la función de impresión de los estudiantes.
                        GetEstudiantes(index, nombresEstudiantes, apellidosEstudiantes, pruebasEstudiantes, examenesEstudiantes, promedioEstudiantes, asistenciasEstudiantes, aprobacionEstudiantes);
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
                        Procesando();
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
        static void InicializarValores(out string[] p_nombresEstudiantes, out string[] p_apellidosEstudiantes, out double[] p_pruebasEstudiantes, out double[] p_examenesEstudiantes, out double[] p_promedioEstudiantes, out int[] p_asistenciaEstudiantes, out bool[] p_aprobacionEstudiantes, int maxEstudiantes)
        {
            p_nombresEstudiantes = new string[maxEstudiantes];
            p_apellidosEstudiantes = new string[maxEstudiantes];
            p_pruebasEstudiantes = new double[maxEstudiantes];
            p_examenesEstudiantes = new double[maxEstudiantes];
            p_promedioEstudiantes = new double[maxEstudiantes];
            p_asistenciaEstudiantes = new int[maxEstudiantes];
            p_aprobacionEstudiantes = new bool[maxEstudiantes];
        }

        // Inicializa nuevos estudiantes.
        static void InicializarValores(string nom, string ape, double nota, double exam, int asis, ref string[] nombresEstudiantes, ref string[] apellidoEstudiantes, ref double[] notasEstudiantes, ref double[] examenEstudiantes, ref double[] promedioEstudiantes, ref int[] asistenciaEstudiantes, ref int posEstu)
        {
            nombresEstudiantes[posEstu] = nom;
            apellidoEstudiantes[posEstu] = ape;
            notasEstudiantes[posEstu] = nota;
            examenEstudiantes[posEstu] = exam;
            promedioEstudiantes[posEstu] = (notasEstudiantes[posEstu] + examenEstudiantes[posEstu]) / 2;
            asistenciaEstudiantes[posEstu] = asis;
            posEstu++;
        }

        #endregion

        #region Funciones avanzadas

        // condicion para ver si el estudiante aprobo o no
        static void resultado(int p_index, ref bool[] aprobacionEstudiantes, double[] promedioEstudiantes, int[] asistenciasEstudiantes)
        {
            //se pasa por ref debido a que todos estan declarados en falso y si cumple la condicion solo se cambian los que cumplan las condiciones.
            for (int i = 0; i < p_index; i++)
            {
                if (promedioEstudiantes[i] > 15 && asistenciasEstudiantes[i] >= 10)
                {
                    aprobacionEstudiantes[i] = true;
                }
                else aprobacionEstudiantes[i] = false;
            }
        }

        // Función que devuelve el promedio general del curso.
        static double promediogeneral(int index, double[] promediogeneral)
        {
            double suma = 0;
            foreach (double calificacion in promediogeneral)
            {
                suma += calificacion;
            }
            return suma / index;
        }

        // Función que devuelve la desviación estandar del curso.
        static double desviacionstandar(int index, double[] promedio)
        {
            double total = 0;
            double result = 0;
            double tit;
            double cuadra;
            double[] sum = new double[100];
            for (int i = 0; i < promedio.Length; i++)
            {
                double nume = (promedio[i] - promediogeneral(index, promedio));
                double[] tito = { nume };
                for (int j = 0; j < tito.Length; j++)
                {
                    cuadra = (tito[j] * tito[j]);
                    sum[j] = cuadra;
                    for (int q = 0; q < sum.Length; q++)
                    {
                        total += sum[q];
                        tit = (total / i);
                        result = Math.Sqrt(tit);
                    }
                }
            }
            return result - 10.49;
        }

        #endregion

        #region Ordenamiento de los datos del estudiante      

        // Ordena de manera ascendente a los estudiantes considerando su nombre.
        static void ascendenteNombre(int index, ref string[] nombresEstudiantes, ref string[] apellidoEstudiantes, ref double[] notasEstudiantes, ref double[] examenEstudiantes, ref double[] promedioEstudiantes, ref int[] asistenciaEstudiantes, ref bool[] aprobacionEstudiantes)
        { 
            string itercambiarNombre,itercambiarApellio;
            double intercambiarNota, intercambioExamen, intercambioPromedio;
            int intercambioAsistencia;
            bool intercambioAprobacion;
            for (int i = 1; i < index; i++)            
                for (int j = index - 1; j >= i; j--)
                {
                    if (nombresEstudiantes[j] == null || nombresEstudiantes[j - 1] == null) continue;                   
                    else if (nombresEstudiantes[j - 1].CompareTo(nombresEstudiantes[j]) > 0)
                    {
                        //intercambia nombres
                        itercambiarNombre = nombresEstudiantes[j - 1];
                        nombresEstudiantes[j - 1] = nombresEstudiantes[j];
                        nombresEstudiantes[j] = itercambiarNombre;                       

                        //intercambia apellidos
                        itercambiarApellio = apellidoEstudiantes[j - 1];
                        apellidoEstudiantes[j - 1] = apellidoEstudiantes[j];
                        apellidoEstudiantes[j] = itercambiarApellio;

                        //intercambia nota
                        intercambiarNota = notasEstudiantes[j - 1];
                        notasEstudiantes[j - 1] = notasEstudiantes[j];
                        notasEstudiantes[j] = intercambiarNota;

                        //intercambia examen
                        intercambioExamen = examenEstudiantes[j - 1];
                        examenEstudiantes[j - 1] = examenEstudiantes[j];
                        examenEstudiantes[j] = intercambioExamen;

                        //intercambio promedio
                        intercambioPromedio = promedioEstudiantes[j - 1];
                        promedioEstudiantes[j - 1] = promedioEstudiantes[j];
                        promedioEstudiantes[j] = intercambioPromedio;

                        //intercambia asistencia
                        intercambioAsistencia = asistenciaEstudiantes[j - 1];
                        asistenciaEstudiantes[j - 1] = asistenciaEstudiantes[j];
                        asistenciaEstudiantes[j] = intercambioAsistencia;

                        // Intercambiar aprobación
                        intercambioAprobacion = aprobacionEstudiantes[j - 1];
                        aprobacionEstudiantes[j - 1] = aprobacionEstudiantes[j];
                        aprobacionEstudiantes[j] = intercambioAprobacion;
                    }

                }            
        }

        // Ordena de manera descendente a los estudiantes considerando su apellido.
        static void descendenteApellido(int p_index, ref string[] nombresEstudiantes, ref string[] apellidoEstudiantes, ref double[] notasEstudiantes, ref double[] examenEstudiantes, ref double[] promedioEstudiantes, ref int[] asistenciaEstudiantes, ref bool[] aprobacionEstudiantes)
        {
            string itercambiarNombre, itercambiarApellio;
            double intercambiarNota, intercambioExamen, intercambioPromedio;
            int intercambioAsistencia;
            bool intercambioAprobacion;
            for (int i = 1; i < p_index; i++)            
                for (int j = p_index - 1; j >= i; j--)
                {
                    if (apellidoEstudiantes[j] == null || apellidoEstudiantes[j - 1] == null) continue;                    
                    else if (apellidoEstudiantes[j - 1].CompareTo(apellidoEstudiantes[j]) < 0)
                    {
                        //intercambia nombres
                        itercambiarNombre = nombresEstudiantes[j - 1];
                        nombresEstudiantes[j - 1] = nombresEstudiantes[j];
                        nombresEstudiantes[j] = itercambiarNombre;

                        //intercambia apellidos
                        itercambiarApellio = apellidoEstudiantes[j - 1];
                        apellidoEstudiantes[j - 1] = apellidoEstudiantes[j];
                        apellidoEstudiantes[j] = itercambiarApellio;

                        //intercambia nota
                        intercambiarNota = notasEstudiantes[j - 1];
                        notasEstudiantes[j - 1] = notasEstudiantes[j];
                        notasEstudiantes[j] = intercambiarNota;

                        //intercambia examen
                        intercambioExamen = examenEstudiantes[j - 1];
                        examenEstudiantes[j - 1] = examenEstudiantes[j];
                        examenEstudiantes[j] = intercambioExamen;

                        //intercambio promedio
                        intercambioPromedio = promedioEstudiantes[j - 1];
                        promedioEstudiantes[j - 1] = promedioEstudiantes[j];
                        promedioEstudiantes[j] = intercambioPromedio;

                        //intercambia asistencia
                        intercambioAsistencia = asistenciaEstudiantes[j - 1];
                        asistenciaEstudiantes[j - 1] = asistenciaEstudiantes[j];
                        asistenciaEstudiantes[j] = intercambioAsistencia;

                        // Intercambiar aprobación
                        intercambioAprobacion = aprobacionEstudiantes[j - 1];
                        aprobacionEstudiantes[j - 1] = aprobacionEstudiantes[j];
                        aprobacionEstudiantes[j] = intercambioAprobacion;
                    }

                }            
        }

        // Ordena de manera ascendente a los estudiantes considerando su nota en base a lo que desee el usuario.
        static void NotasAscendente(int p_index, ref string[] p_nombresEstudiantes, ref string[] p_apellidosEstudiantes, ref double[] p_pruebasEstudiantes, ref double[] p_examenesEstudiantes, ref double[] p_promedioEstudiantes, ref int[] p_asistenciaEstudiantes, ref bool[] p_aprobacionEstudiantes)
        {
            string tempNombre, tempApellido;
            double tempPrueba, tempExamen, tempPromedio;
            int tempAsistencias;
            bool tempAprobacion;
            for(int i = 0; i < p_index; i++)
            {
                for(int j = 0; j < p_index - 1; j++)
                {
                    if(p_pruebasEstudiantes[j] > p_pruebasEstudiantes[j + 1])
                    {
                        // Inicializar variables temporales.
                        tempNombre = p_nombresEstudiantes[j];
                        tempApellido = p_apellidosEstudiantes[j];
                        tempPrueba = p_pruebasEstudiantes[j];
                        tempExamen = p_examenesEstudiantes[j];
                        tempPromedio = p_promedioEstudiantes[j];
                        tempAsistencias = p_asistenciaEstudiantes[j];
                        tempAprobacion = p_aprobacionEstudiantes[j];

                        // Renovar la posición del menor en la posición del mayor.                        
                        p_nombresEstudiantes[j] = p_nombresEstudiantes[j + 1];
                        p_apellidosEstudiantes[j] = p_apellidosEstudiantes[j + 1];
                        p_pruebasEstudiantes[j] = p_pruebasEstudiantes[j + 1];
                        p_examenesEstudiantes[j] = p_examenesEstudiantes[j + 1];
                        p_promedioEstudiantes[j] = p_promedioEstudiantes[j + 1];
                        p_asistenciaEstudiantes[j] = p_asistenciaEstudiantes[j + 1];
                        p_aprobacionEstudiantes[j] = p_aprobacionEstudiantes[j + 1];

                        // Renovar la posición del mayor.
                        p_nombresEstudiantes[j + 1] = tempNombre;
                        p_apellidosEstudiantes[j + 1] = tempApellido;
                        p_pruebasEstudiantes[j + 1] = tempPrueba;
                        p_examenesEstudiantes[j + 1] = tempExamen;
                        p_promedioEstudiantes[j + 1] = tempPromedio;
                        p_asistenciaEstudiantes[j + 1] = tempAsistencias;
                        p_aprobacionEstudiantes[j + 1] = tempAprobacion;
                    }
                }
            }
        }

        // Ordena de manera descendente a los estudiantes considerando su nota en base a lo que desee el usuario.
        static void NotasDescendente(int p_index, ref string[] p_nombresEstudiantes, ref string[] p_apellidosEstudiantes, ref double[] p_pruebasEstudiantes, ref double[] p_examenesEstudiantes, ref double[] p_promedioEstudiantes, ref int[] p_asistenciaEstudiantes, ref bool[] p_aprobacionEstudiantes)
        {
            string tempNombre, tempApellido;
            double tempPrueba, tempExamen, tempPromedio;
            int tempAsistencias;
            bool tempAprobacion;
            for (int i = 0; i < p_index; i++)
            {
                for (int j = 0; j < p_index - 1; j++)
                {
                    if (p_examenesEstudiantes[j] < p_examenesEstudiantes[j + 1])
                    {
                        // Inicializar variables temporales.
                        tempNombre = p_nombresEstudiantes[j];
                        tempApellido = p_apellidosEstudiantes[j];
                        tempPrueba = p_pruebasEstudiantes[j];
                        tempExamen = p_examenesEstudiantes[j];
                        tempPromedio = p_promedioEstudiantes[j];
                        tempAsistencias = p_asistenciaEstudiantes[j];
                        tempAprobacion = p_aprobacionEstudiantes[j];

                        // Renovar la posición del menor en la posición del mayor.                        
                        p_nombresEstudiantes[j] = p_nombresEstudiantes[j + 1];
                        p_apellidosEstudiantes[j] = p_apellidosEstudiantes[j + 1];
                        p_pruebasEstudiantes[j] = p_pruebasEstudiantes[j + 1];
                        p_examenesEstudiantes[j] = p_examenesEstudiantes[j + 1];
                        p_promedioEstudiantes[j] = p_promedioEstudiantes[j + 1];
                        p_asistenciaEstudiantes[j] = p_asistenciaEstudiantes[j + 1];
                        p_aprobacionEstudiantes[j] = p_aprobacionEstudiantes[j + 1];

                        // Renovar la posición del mayor.
                        p_nombresEstudiantes[j + 1] = tempNombre;
                        p_apellidosEstudiantes[j + 1] = tempApellido;
                        p_pruebasEstudiantes[j + 1] = tempPrueba;
                        p_examenesEstudiantes[j + 1] = tempExamen;
                        p_promedioEstudiantes[j + 1] = tempPromedio;
                        p_asistenciaEstudiantes[j + 1] = tempAsistencias;
                        p_aprobacionEstudiantes[j + 1] = tempAprobacion;
                    }
                }
            }
        }

        #endregion

        #region Impresión de los estudiantes

        // Imprime a todos los estudiantes en un respectivo formato tipo tabla con tabulación definida y colores para mejor visualización.
        static void GetEstudiantes(int p_index, string[] p_nombresEstudiantes, string[] p_apellidoEstudiantes, double[] p_pruebasEstudiantes, double[] p_examenEstudiantes, double[] p_promedioEstudiantes, int[] p_asistenciaEstudiantes, bool[] p_aprobacionEstudiantes)
        {
            string temp;
            int counterX, counterY = 0;

            #region Impresión del formato de presentación de los estudiantes.

            // Impresión con formato amigable para el usuario.
            // Se evalua la tabulación dependiendo del string más largo, si no es del estudiante se toma de su identificador, puede ser "Nombre" como cualquier otro.
            if (Mayor(p_index, p_nombresEstudiantes) > "Nombre".Length) counterX = Mayor(p_index, p_nombresEstudiantes) + 8;
            else counterX = "Nombre".Length + 8;
            Console.Write("Nombre");
            // Se coloca en la posición deseada para respetar un mismo margen.
            Console.SetCursorPosition(counterX, counterY);
            if (Mayor(p_index, p_apellidoEstudiantes) > "Apellido".Length) counterX += Mayor(p_index, p_nombresEstudiantes) + 8;
            else counterX += "Apellido".Length + 8;
            Console.Write("Apellido");
            Console.SetCursorPosition(counterX, counterY);
            counterX += "Prueba".Length + 8;
            Console.Write("Prueba");
            Console.SetCursorPosition(counterX, counterY);
            counterX += "Examen".Length + 8;
            Console.Write("Examen");
            Console.SetCursorPosition(counterX, counterY);
            counterX += "Promedio".Length + 8;
            Console.Write("Promedio");
            Console.SetCursorPosition(counterX, counterY);
            counterX += "Asistencia".Length + 8;
            Console.Write("Asistencia");
            Console.SetCursorPosition(counterX, counterY);
            Console.WriteLine("Resultado");
            // Se aumenta una linea al contador de lineas.
            counterY++;

            #endregion

            #region Impresión los estudiantes

            // Impresión de cada estudiante.
            for (int i = 0; i <= p_index - 1; i++)
            {
                LineaPintada(i, counterY);
                if (p_aprobacionEstudiantes[i] == true) temp = "APROBADO";
                else temp = "REPROBADO";

                // Impresión con formato amigable para el usuario.
                // Se evalua la tabulación dependiendo del string más largo, si no es del estudiante se toma de su identificador, puede ser "Nombre" como cualquier otro.
                if (Mayor(p_index, p_nombresEstudiantes) > "Nombre".Length) counterX = Mayor(p_index, p_nombresEstudiantes) + 8;
                else counterX = "Nombre".Length + 8;
                Console.Write($"{p_nombresEstudiantes[i]}");
                // Se coloca en la posición deseada para respetar un mismo margen.
                Console.SetCursorPosition(counterX, counterY);
                if (Mayor(p_index, p_apellidoEstudiantes) > "Apellido".Length) counterX += Mayor(p_index, p_nombresEstudiantes) + 8;
                else counterX += "Apellido".Length + 8;
                Console.Write($"{p_apellidoEstudiantes[i]}");                
                Console.SetCursorPosition(counterX, counterY);
                counterX += "Prueba".Length + 8;
                Console.Write($"{p_pruebasEstudiantes[i]}");
                Console.SetCursorPosition(counterX, counterY);
                counterX += "Examen".Length + 8;
                Console.Write($"{p_examenEstudiantes[i]}");
                Console.SetCursorPosition(counterX, counterY);
                counterX += "Promedio".Length + 8;
                Console.Write($"{p_promedioEstudiantes[i]}");
                Console.SetCursorPosition(counterX, counterY);
                counterX += "Asistencias".Length + 7;
                Console.Write($"{p_asistenciaEstudiantes[i]}");
                Console.SetCursorPosition(counterX, counterY);                
                Console.WriteLine($"{temp}");
                // Se aumenta una linea al contador de lineas.
                counterY++;
            }

            #endregion          

            // Vuelta de colores a la normalidad para mejor visualización.
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            // Impresión del promedio y desviación estandar del curso.
            Console.WriteLine($"El promedio general del curso fue: {promediogeneral(p_index, p_promedioEstudiantes):#.##}");
            Console.WriteLine($"La desviación estandar del curso fue: {desviacionstandar(p_index, p_promedioEstudiantes):#.##}");
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

        // Devuelve el largo del nombre o apellido más largo de los estudiantes.
        static int Mayor(int p_index ,string[] p_stringEstudiantes)
        {
            int temp = 0;
            for(int i = 0; i < p_index; i++)
            {
                if(p_stringEstudiantes[i].Length > temp)
                {
                    temp = p_stringEstudiantes[i].Length;
                }
            }
            return temp;
        }

        // Pinta una linea de 110 caracteres y devuelve el cursor al inicio de la misma.
        static void LineaPintada(int p_index, int p_pointY)
        {
            if (p_index % 2 == 0) { Console.BackgroundColor = ConsoleColor.Gray; Console.ForegroundColor = ConsoleColor.Black; }
            else { Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White; }
            for (int i = 0; i < 110; i++) Console.Write(" ");
            Console.SetCursorPosition(0, p_pointY);
        }

        // Cambia el color de la pantalla de forma aleatoria.
        static void PantallaPintada()
        {
            // Declaración de objetos tipo random.
            Random rand = new Random();           
            
            // Inicialización de un arreglo de objetos tipo color con todos sus valores.
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            
            // Variable que almacenará un número aleatorio para designar un color aleatorio.
            int bgColor = rand.Next(0, 15);            

            // Contado que permitirá recuperar el color aleatorio.
            int counter = 0;

            // Recuperar un colo aleatorio en base al número aleatorio que se recupero.
            foreach(var iter in colors) { if (counter == bgColor) Console.BackgroundColor = iter; counter++; }

            // En base al color de la pantalla se determina el color de la letra.
            if (bgColor < 7) Console.ForegroundColor = ConsoleColor.White;
            else Console.ForegroundColor = ConsoleColor.Black;
        }

        #endregion

        #endregion

    }
}
