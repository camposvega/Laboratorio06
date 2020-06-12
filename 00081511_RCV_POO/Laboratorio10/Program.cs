using System;
using System.Collections.Generic;
using System.Globalization;

namespace Laboratorio10
{
    internal class Program
    {
        private delegate void verCuentas(List<CuentaBancaria> lista);
        static verCuentas delegado;
        public static void Main(string[] args)
        {
            
            var cuentas = new List<CuentaBancaria>();
            String opcion = "";
            delegado = verCuentasDelagate;
            delegado += verTotalCuentasDelagate;
            
            do
            {
                menu();
                try
                {
                    opcion = Console.ReadLine();
                    subMenus(opcion, cuentas);
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n ALGO SALIO MAL \n");
                }
            } while (!opcion.Equals("5"));
            

        }

        public static void menu()
        {
            Console.WriteLine("1. Agregar Cuenta \n 2. Ver cuentas almacenadas \n " +
                              "3. Ver cuentas almacenadas y el total de las cuentas " +
                              "\n 4. Ver cuentas almacenadas, el total de las cuentas, y las cuentas de las personas" +
                              " que su nombre inicie con una vocal" +
                              "\n 5. Salir");
        }

        public static void subMenus(String op, List<CuentaBancaria> lista)
        {
            switch (op)
            {
                case "1": 
                    Console.WriteLine("Nombre Propietario:");
                    String nombre = Console.ReadLine();
                    Console.WriteLine("Saldo de la cuenta:");
                    double saldo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture) ;
                    lista.Add(new CuentaBancaria(nombre, saldo));
                    break;
                case "3":
                    delegado.Invoke(lista);
                    break;
                case "4":
                    Action<List<CuentaBancaria>> actionCuenta = (c =>
                    {
                        c.ForEach(elem =>
                        {
                            Console.WriteLine($"Propietario: {elem._nombre}, Saldo: {elem._saldo}");
                        });
                    });
                    
                    actionCuenta += (c =>
                    {
                        double total = 0;
                        c.ForEach(elem =>
                        {
                            total += elem._saldo;
                        });
            
                        Console.WriteLine($"Total: {total}");
                    });
                    
                    actionCuenta += (c =>
                    {
                        Console.WriteLine("Escriba la Inicial que busca");
                        String inicial = Console.ReadLine();
                        c.ForEach(elem =>
                        {
                            if(elem._nombre.StartsWith(inicial))
                            Console.WriteLine($"Propietario: {elem._nombre}, Saldo: {elem._saldo}");
                        });
                    });
                    
                    actionCuenta.Invoke(lista);
                    break;
                case "2":
                    Func<List<CuentaBancaria>, String> funcCuentas = (li) =>
                        {
                            
                            return "Total cuentas: " + li.Count ;
                        }
                            ;
                    Console.WriteLine(funcCuentas.Invoke(lista));
                    break;
                default:
                    Console.WriteLine("no hay elemento para esta opcion");
                    break;
                    
            }
        }

        public static void verCuentasDelagate(List<CuentaBancaria> c)
        {
            c.ForEach(elem =>
            {
                Console.WriteLine($"Propietario: {elem._nombre}, Saldo: {elem._saldo}");
            });
        }
        
        public static void verTotalCuentasDelagate(List<CuentaBancaria> c)
        {
            double total = 0;
            c.ForEach(elem =>
            {
                total += elem._saldo;
            });
            
            Console.WriteLine($"Total: {total}");
        }
    }
}