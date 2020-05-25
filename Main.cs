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
            int[] asistenciasEstudiantes;
            bool[] aprobacionEstudiantes;
            // Variable que establece la cantidad de estudiantes ingresados.
            int index = 0;

            // Variables que definen el ingreso de un estudiante individual.
            string nom, ape;
            double nota, exam;
            int asis;
            string res;
            bool val = false;

            // Variable para gestionar menus.            
            string opcionString1 = null;

            #endregion
           
            #region Constructores

            // Inicializa los jagged array para su uso.
            InicializarValores(out nombresEstudiantes, out apellidosEstudiantes, out pruebasEstudiantes, out examenesEstudiantes, out asistenciasEstudiantes, out aprobacionEstudiantes);
            // Creación de estudiantes para casos de prueba.
            InicializarValores(ref index, ref nombresEstudiantes, ref apellidosEstudiantes, ref pruebasEstudiantes, ref examenesEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);

            #endregion

            #region Ingreso Estudiantes

            Console.WriteLine("Lista de estudiantes: \n ");
            do
            {
                val = true;
                Console.Write("Nombre del Estudiante N*{0}: ", index); nom = Console.ReadLine().ToUpper();                
                Console.Write("Apellido del Estudiante N*{0}: ", index); ape = Console.ReadLine().ToUpper();

                // Validación de entrada correcta de información de la nota de la prueba.
                while (true)
                {
                    try
                    {                        
                        do
                        {
                            Console.Write("Nota de la prueba (/20) del Estudiante N*{0}:  ", index);
                            nota = Convert.ToDouble(Console.ReadLine());
                            if (nota > 20 || nota < 0)
                            {
                                Console.WriteLine("Error: Ingresar informacion dentro del regimen establecido");
                            }
                        }
                        while (nota > 20 || nota < 0);
                    }
                    catch
                    {
                        Console.WriteLine("Error: Valor ingresado no valido.");
                        continue;
                    }
                    break;
                }

                // Validación de entrada correcta de información de la nota del examen.
                while (true)
                {
                    try
                    {                        
                        do
                        {
                            Console.Write("Nota Examen (/20) del Estudiante N*{0}: ", index);
                            exam = Convert.ToDouble(Console.ReadLine());
                            if (exam > 20 || exam < 0)
                            {
                                Console.WriteLine("Error: Ingresar informacion dentro del regimen establecido");
                            }
                        }
                        while (exam > 20 || exam < 0);
                    }
                    catch
                    {
                        Console.WriteLine("Error: Valor ingresado no valido.");
                        continue;
                    }
                    break;
                }

                // Validación de entrada correcta de información de la asistencia.
                while (true)
                {
                    try
                    {
                        do
                        {
                            Console.Write("Asistencia del Estudiante N*{0}: (1-20)", index);
                            asis = int.Parse(Console.ReadLine());
                            if (asis > 20 || asis < 0)
                            {
                                Console.WriteLine("Error: Ingresar informacion dentro del regimen establecido");
                            }
                        }
                        while (asis > 20 || asis < 0);
                    }
                    catch
                    {
                        Console.WriteLine("Error: Valor ingresado no valido.");
                        continue;
                    }
                    break;
                }

                // Creación de nuevo estudiante en base a la información ingresada.
                InicializarValores(nom,ape,nota,exam,asis, ref nombresEstudiantes, ref apellidosEstudiantes, ref pruebasEstudiantes, ref examenesEstudiantes, ref asistenciasEstudiantes, ref index);

                Console.Write("Desea ingresar otro estudiante? (S/N): ");
                res = Console.ReadLine();
                if (res.ToUpper().Equals("N")) val = false;
                Console.WriteLine();
            }
            while (val);
            Console.WriteLine("\n\nPresione cualquier tecla para continuar..."); Console.ReadKey(); Console.Clear();

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
                        // Se llama a la función para el ordenamiento según lo requerido.
                        ascendenteNombre(index, ref nombresEstudiantes, ref apellidosEstudiantes, ref pruebasEstudiantes, ref examenesEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);
                        // Se llama a la función de impresión de los estudiantes.
                        GetEstudiantes(index, ref nombresEstudiantes, ref apellidosEstudiantes, ref pruebasEstudiantes, ref examenesEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar..."); Console.ReadLine(); Console.Clear();
                        break;

                    #endregion
                   
                    #region Por apellido de manera descendente

                    case "2":
                        // Se llama a la función para el ordenamiento según lo requerido.
                        descendenteApellido(index, ref nombresEstudiantes, ref apellidosEstudiantes, ref pruebasEstudiantes, ref examenesEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);
                        // Se llama a la función de impresión de los estudiantes.
                        GetEstudiantes(index, ref nombresEstudiantes, ref apellidosEstudiantes, ref pruebasEstudiantes, ref examenesEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar..."); Console.ReadLine(); Console.Clear();
                        break;

                    #endregion

                    #region Por nota de la prueba de manera ascendente

                    case "3":
                        // Se llama a la función para el ordenamiento según lo requerido.
                        PruebaAscendente(index, ref nombresEstudiantes, ref apellidosEstudiantes, ref pruebasEstudiantes, ref examenesEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);
                        // Se llama a la función de impresión de los estudiantes.
                        GetEstudiantes(index, ref nombresEstudiantes, ref apellidosEstudiantes, ref pruebasEstudiantes, ref examenesEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar..."); Console.ReadLine(); Console.Clear();
                        break;

                    #endregion

                    #region Por nota del examen de manera descendente

                    case "4":
                        // Se llama a la función para el ordenamiento según lo requerido.
                        ExamenDescendente(index, ref nombresEstudiantes, ref apellidosEstudiantes, ref pruebasEstudiantes, ref examenesEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);
                        // Se llama a la función de impresión de los estudiantes.
                        GetEstudiantes(index, ref nombresEstudiantes, ref apellidosEstudiantes, ref pruebasEstudiantes, ref examenesEstudiantes, ref asistenciasEstudiantes, ref aprobacionEstudiantes);
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
        static void InicializarValores(out string[] p_nombresEstudiantes, out string[] p_apellidosEstudiantes, out double[] p_pruebasEstudiantes, out double[] p_examenesEstudiantes, out int[] p_asistenciaEstudiantes, out bool[] p_aprobacionEstudiantes)
        {
            p_nombresEstudiantes = new string[100];
            p_apellidosEstudiantes = new string[100];
            p_pruebasEstudiantes = new double[100];
            p_examenesEstudiantes = new double[100];
            p_asistenciaEstudiantes = new int[100];
            p_aprobacionEstudiantes = new bool[100];
        }

        // Inicializa nuevos estudiantes.
        static void InicializarValores(string nom, string ape, double nota, double exam, int asis, ref string[] nombresEstudiantes, ref string[] apellidoEstudiantes, ref double[] notasEstudiantes, ref double[] examenEstudiantes, ref int[] asistenciaEstudiantes, ref int posEstu)
        {
            nombresEstudiantes[posEstu] = nom;
            apellidoEstudiantes[posEstu] = ape;
            notasEstudiantes[posEstu] = nota;
            examenEstudiantes[posEstu] = exam;
            asistenciaEstudiantes[posEstu] = asis;            
            posEstu++;
        }

        // Crea estudiantes para casos de prueba.
        static void InicializarValores(ref int p_index, ref string[] p_nombresEstudiantes, ref string[] p_apellidosEstudiantes, ref double[] p_pruebasEstudiantes, ref double[] p_examenesEstudiantes, ref int[] p_asistenciaEstudiantes, ref bool[] p_aprobacionEstudiantes)
        {
            p_nombresEstudiantes[p_index] = "SEBASTIAN";
            p_apellidosEstudiantes[p_index] = "TAMAYO";
            p_pruebasEstudiantes[p_index] = 19;
            p_examenesEstudiantes[p_index] = 20;
            p_asistenciaEstudiantes[p_index] = 18;
            p_aprobacionEstudiantes[p_index] = true;
            p_index++;
            p_nombresEstudiantes[p_index] = "BRYAN";
            p_apellidosEstudiantes[p_index] = "CUVI";
            p_pruebasEstudiantes[p_index] = 17;
            p_examenesEstudiantes[p_index] = 19;
            p_asistenciaEstudiantes[p_index] = 16;
            p_aprobacionEstudiantes[p_index] = true;
            p_index++;
            p_nombresEstudiantes[p_index] = "SOFIA";
            p_apellidosEstudiantes[p_index] = "VILLACIS";
            p_pruebasEstudiantes[p_index] = 20;
            p_examenesEstudiantes[p_index] = 20;
            p_asistenciaEstudiantes[p_index] = 20;
            p_aprobacionEstudiantes[p_index] = true;
            p_index++;
            p_nombresEstudiantes[p_index] = "VLADIMIR";
            p_apellidosEstudiantes[p_index] = "PUTIN";
            p_pruebasEstudiantes[p_index] = 12;
            p_examenesEstudiantes[p_index] = 13;
            p_asistenciaEstudiantes[p_index] = 10;
            p_aprobacionEstudiantes[p_index] = false;
            p_index++;
        }

        #endregion

        #region Ordenamiento de los datos del estudiante      

        // Ordena de manera ascendente a los estudiantes considerando su nombre.
        static void ascendenteNombre(int index, ref string[] nombresEstudiantes, ref string[] apellidoEstudiantes, ref double[] notasEstudiantes, ref double[] examenEstudiantes, ref int[] asistenciaEstudiantes, ref bool[] aprobacionEstudiantes)
        { 
            string itercambiarNombre,itercambiarApellio;
            double intercambiarNota, intercambioExamen;
            int intercambioAsistencia;
            bool intercambioAprobacion;
            for (int i = 1; i < index; i++)
            {
                for (int j = index - 1; j >= i; j--)
                {
                    if (nombresEstudiantes[j] == null || nombresEstudiantes[j - 1] == null)
                    {
                        continue;
                    }
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
        }

        // Ordena de manera descendente a los estudiantes considerando su apellido.
        static void descendenteApellido(int p_index, ref string[] nombresEstudiantes, ref string[] apellidoEstudiantes, ref double[] notasEstudiantes, ref double[] examenEstudiantes, ref int[] asistenciaEstudiantes, ref bool[] aprobacionEstudiantes)
        {
            string itercambiarNombre, itercambiarApellio;
            double intercambiarNota, intercambioExamen;
            int intercambioAsistencia;
            bool intercambioAprobacion;
            for (int i = 1; i < p_index; i++)
            {
                for (int j = p_index - 1; j >= i; j--)
                {
                    if (apellidoEstudiantes[j] == null || apellidoEstudiantes[j - 1] == null)
                    {
                        continue;
                    }
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
        }

        // Ordena de manera ascendente a los estudiantes considerando su nota de la prueba.
        static void PruebaAscendente(int p_index, ref string[] p_nombresEstudiantes, ref string[] p_apellidosEstudiantes, ref double[] p_pruebasEstudiantes, ref double[] p_examenesEstudiantes, ref int[] p_asistenciaEstudiantes, ref bool[] p_aprobacionEstudiantes)
        {
            string tempNombre, tempApellido;
            double tempPrueba, tempExamen;
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
                        tempAsistencias = p_asistenciaEstudiantes[j];
                        tempAprobacion = p_aprobacionEstudiantes[j];

                        // Renovar la posición del menor en la posición del mayor.                        
                        p_nombresEstudiantes[j] = p_nombresEstudiantes[j + 1];
                        p_apellidosEstudiantes[j] = p_apellidosEstudiantes[j + 1];
                        p_pruebasEstudiantes[j] = p_pruebasEstudiantes[j + 1];
                        p_examenesEstudiantes[j] = p_examenesEstudiantes[j + 1];
                        p_asistenciaEstudiantes[j] = p_asistenciaEstudiantes[j + 1];
                        p_aprobacionEstudiantes[j] = p_aprobacionEstudiantes[j + 1];

                        // Renovar la posición del mayor.
                        p_nombresEstudiantes[j + 1] = tempNombre;
                        p_apellidosEstudiantes[j + 1] = tempApellido;
                        p_pruebasEstudiantes[j + 1] = tempPrueba;
                        p_examenesEstudiantes[j + 1] = tempExamen;
                        p_asistenciaEstudiantes[j + 1] = tempAsistencias;
                        p_aprobacionEstudiantes[j + 1] = tempAprobacion;
                    }
                }
            }
        }

        // Ordena de manera descendente a los estudiantes considerando su nota de la prueba.
        static void ExamenDescendente(int p_index, ref string[] p_nombresEstudiantes, ref string[] p_apellidosEstudiantes, ref double[] p_pruebasEstudiantes, ref double[] p_examenesEstudiantes, ref int[] p_asistenciaEstudiantes, ref bool[] p_aprobacionEstudiantes)
        {
            string tempNombre, tempApellido;
            double tempPrueba, tempExamen;
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
                        tempAsistencias = p_asistenciaEstudiantes[j];
                        tempAprobacion = p_aprobacionEstudiantes[j];

                        // Renovar la posición del menor en la posición del mayor.                        
                        p_nombresEstudiantes[j] = p_nombresEstudiantes[j + 1];
                        p_apellidosEstudiantes[j] = p_apellidosEstudiantes[j + 1];
                        p_pruebasEstudiantes[j] = p_pruebasEstudiantes[j + 1];
                        p_examenesEstudiantes[j] = p_examenesEstudiantes[j + 1];
                        p_asistenciaEstudiantes[j] = p_asistenciaEstudiantes[j + 1];
                        p_aprobacionEstudiantes[j] = p_aprobacionEstudiantes[j + 1];

                        // Renovar la posición del mayor.
                        p_nombresEstudiantes[j + 1] = tempNombre;
                        p_apellidosEstudiantes[j + 1] = tempApellido;
                        p_pruebasEstudiantes[j + 1] = tempPrueba;
                        p_examenesEstudiantes[j + 1] = tempExamen;
                        p_asistenciaEstudiantes[j + 1] = tempAsistencias;
                        p_aprobacionEstudiantes[j + 1] = tempAprobacion;
                    }
                }
            }
        }

        #endregion

        #region Impresión de los estudiantes

        // Imprime a todos los estudiantes en un respectivo formato tipo tabla.
        static void GetEstudiantes(int p_index, ref string[] p_nombresEstudiantes, ref string[] p_apellidoEstudiantes, ref double[] p_pruebasEstudiantes, ref double[] p_examenEstudiantes, ref int[] p_asistenciaEstudiantes, ref bool[] p_aprobacionEstudiantes)
        {
            string temp;
            int counterX, counterY = 0;

            #region Impresión del formato de presentación de los estudiantes.

            // Impresión con formato amigable para el usuario.
            // Se evalua la tabulación dependiendo del string más largo, si no es del estudiante se toma de su identificador, puede ser "Nombre" como cualquier otro.
            if (MayorNombre(p_index, p_nombresEstudiantes) > "Nombre".Length) counterX = MayorNombre(p_index, p_nombresEstudiantes) + 8;
            else counterX = "Nombre".Length + 8;
            Console.Write("Nombre");
            // Se coloca en la posición deseada para respetar un mismo margen.
            Console.SetCursorPosition(counterX, counterY);
            if (MayorApellido(p_index, p_apellidoEstudiantes) > "Apellido".Length) counterX += MayorApellido(p_index, p_nombresEstudiantes) + 8;
            else counterX += "Apellido".Length + 8;
            Console.Write("Apellido");
            Console.SetCursorPosition(counterX, counterY);
            counterX += "Prueba".Length + 8;
            Console.Write("Prueba");
            Console.SetCursorPosition(counterX, counterY);
            counterX += "Examen".Length + 8;
            Console.Write("Examen");
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
                if (MayorNombre(p_index, p_nombresEstudiantes) > "Nombre".Length) counterX = MayorNombre(p_index, p_nombresEstudiantes) + 8;
                else counterX = "Nombre".Length + 8;
                Console.Write($"{p_nombresEstudiantes[i]}");
                // Se coloca en la posición deseada para respetar un mismo margen.
                Console.SetCursorPosition(counterX, counterY);
                if (MayorApellido(p_index, p_apellidoEstudiantes) > "Apellido".Length) counterX += MayorApellido(p_index, p_nombresEstudiantes) + 8;
                else counterX += "Apellido".Length + 8;
                Console.Write($"{p_apellidoEstudiantes[i]}");                
                Console.SetCursorPosition(counterX, counterY);
                counterX += "Prueba".Length + 8;
                Console.Write($"{p_pruebasEstudiantes[i]}");
                Console.SetCursorPosition(counterX, counterY);
                counterX += "Examen".Length + 8;
                Console.Write($"{p_examenEstudiantes[i]}");
                Console.SetCursorPosition(counterX, counterY);
                counterX += "Asistencias".Length + 7;
                Console.Write($"{p_asistenciaEstudiantes[i]}");
                Console.SetCursorPosition(counterX, counterY);                
                Console.WriteLine($"{temp}");
                // Se aumenta una linea al contador de lineas.
                counterY++;
            }

            #endregion

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

        // Devuelve el largo del nombre más largo de los estudiantes.
        static int MayorNombre(int p_index ,string[] p_nombresEstudiantes)
        {
            int temp = 0;
            for(int i = 0; i < p_index; i++)
            {
                if(p_nombresEstudiantes[i].Length > temp)
                {
                    temp = p_nombresEstudiantes[i].Length;
                }
            }
            return temp;
        }

        // Devuelve el largo del apellido más largo de los estudiantes.
        static int MayorApellido(int p_index, string[] p_apellidosEstudiantes)
        {
            int temp = 0;
            for (int i = 0; i < p_index; i++)
            {
                if (p_apellidosEstudiantes[i].Length > temp)
                {
                    temp = p_apellidosEstudiantes[i].Length;
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

        #endregion

        #endregion

    }
}
