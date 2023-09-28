using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPromedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los datos del estudiante:");
            Console.Write("Carnet: ");
            string carnet = Console.ReadLine();
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Quiz 1: ");
            double quiz1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quiz 2: ");
            double quiz2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quiz 3: ");
            double quiz3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tarea 1: ");
            double tarea1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tarea 2: ");
            double tarea2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tarea 3: ");
            double tarea3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Examen 1: ");
            double examen1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Examen 2: ");
            double examen2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Examen 3: ");
            double examen3 = Convert.ToDouble(Console.ReadLine());

            double porcentajeQuices = ((quiz1 + quiz2 + quiz3) / 3) * 0.25;
            double porcentajeTareas = ((tarea1 + tarea2 + tarea3) / 3 )* 0.30;
            double porcentajeExamenes = ((examen1 + examen2 + examen3) )/ 3 * 0.45;

            double promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;

            string condicion;
            if (promedioFinal >= 70)
            {
                condicion = "Aprobado";
            }
            else if (promedioFinal >= 50)
            {
                condicion = "Aplazado";
            }
            else
            {
                condicion = "Reprobado";
            }

            Console.WriteLine("\nResultados:");
            Console.WriteLine("Carnet: " + carnet);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Porcentaje de Quices: " + porcentajeQuices.ToString("P2"));
            Console.WriteLine("Porcentaje de Tareas: " + porcentajeTareas.ToString("P2"));
            Console.WriteLine("Porcentaje de Exámenes: " + porcentajeExamenes.ToString("P2"));
            Console.WriteLine("Promedio Final: " + promedioFinal.ToString("F2"));
            Console.WriteLine("Condición del Estudiante: " + condicion);

            Console.ReadLine(); 
        }
    }
}
        