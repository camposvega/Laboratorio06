using System;
using System.Collections.Generic;

namespace Laboratorio_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var evaluaciones = new List<IEvaluacion>()
            {
                new Laboratorio("Multiple", 5,"Laboratorio 1"),
                new Parcial(4,"Parcial 1", 20),
                new Tarea(new DateTime(2020,5,8), 5,"Tarea Ayuda" )
            };
            
            Console.WriteLine("1.- Agregar Evaluacion \n 2.- Mostrar evaluaciones almacenadas \n 3.-Eliminar evaluación" +
                              "4.- Terminar programa");
            
            String op = Console.ReadLine();
            do
            {
                switch (op)
                {
                    case "1":
                        
                        break;
                    case "2":
                        // code block
                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    default:
                        Console.WriteLine("Adios");
                        break;
                }
            } while (op != "4");

        }
    }
}