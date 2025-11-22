using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_RECU
{
    internal class Program
    {
        public class Recursividad
        {
            public static long Factorial(int n)
            {
                if (n == 1)
                    return 1;
                return n * Factorial(n - 1);
            }
        }
        static void Main(string[] args)
        {
            
            string continuar=string.Empty;
            do
            {
            Console.WriteLine("EXAMEN FINAL - 008 ALGORITMOS");
            Console.WriteLine("UMG 2025");
            Console.WriteLine();

            Console.WriteLine("BIENVENIDOS AL SISTEMA. SELECCIONE UNA OPCIÓN");
            Console.WriteLine();

            Console.WriteLine("1. MOSTRAR NOMBRE COMPLETO");
            Console.WriteLine("2. MOSTRAR CARNÉ");
            Console.WriteLine("3. MOSTRAR DPI");
            Console.WriteLine("4. MOSTRAR FECHA DE NACIMIENTO");
            Console.WriteLine("5. CALCULAR FACTORIAL DE UN NÚMERO");
            Console.WriteLine("6. SALIR");
            Console.WriteLine();

            int opcion=int.Parse(Console.ReadLine());
            

            if (opcion == 1)
            {
                Console.WriteLine("JASON STEVE LÓPEZ GÓMEZ");
            }
            else if (opcion == 2)
            {
                Console.WriteLine("1790-25-26696");
            }
            else if (opcion == 3)
            {
                Console.WriteLine("3090-14999-0609");
            }
            else if (opcion == 4)
            {
                Console.WriteLine("14/02/2006");
            }
            else if (opcion == 5)
            {
                    Console.WriteLine("Introduce un número entero: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("EL FACTORIAL ES DE"+num);
                }
                else if (opcion == 6)
            {
                Console.WriteLine("SALIENDO DEL PROGRAMA");
                return;
            }
                Console.WriteLine("¿DESEA REALIZAR OTRA OPERACIÓN? S/N");
                
            } while (continuar == "S" && continuar == "s");
        }
    }
}

//int factorial (int n) {
// if (n==1 || n==0){
// return =1;
// }
// return n*factorial (n-1)
// }
