using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaBinaria
{
    public class Program
    {

        

        private static void Main(string cadenita )
        {
            

            Console.WriteLine("Ingresa una cadena de texto ");
            var cadena = Console.ReadLine();            
            Ordenamiento(cadena);
            Console.WriteLine();
            Binario(cadena);
            Console.WriteLine();
            Console.ReadLine();
        }

        public static string Ordenamiento(string cadenarray)
        {

            char[] cadenarry = cadenarray.ToCharArray();

            for (int i = 0; i < cadenarry.Length; i++)
            {                
                // Console.WriteLine("El numero de iteraciones del primer for 'i' es de " + i);
                for (int j = 0; j < cadenarry.Length - 1 - i; j++)
                {
                    if (cadenarry[j] > cadenarry[j + 1])
                    {
                        //  Console.WriteLine("El numero de iteraciones del primer for 'j' es de " + j);
                        char aux = cadenarry[j];
                        cadenarry[j] = cadenarry[j + 1];
                        cadenarry[j + 1] = aux;
                    }
                }

            }
            return Convert.ToString(cadenarry);
            
        }


        public string string Binario(string cadena)
        {

        }

    }
}
