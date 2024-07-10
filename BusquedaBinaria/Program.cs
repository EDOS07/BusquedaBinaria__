using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaBinaria
{
    public class Program
    {
        public static void Main(string[] cadenita)
        {


            Console.WriteLine("Ingresa una cadena de texto ");
            var cadena = Console.ReadLine();
            cadena = Ordenamiento(cadena);
            Console.WriteLine(cadena);
           
            Console.WriteLine("Ingrese el carater que quiere buscar");            
            var caracter = Console.ReadLine();
            var validacion = validaciones(cadena, caracter);
            if(validacion == "false")        
                throw new Exception("El caracter no se encuentra");
            
            var resutado = BusquedaBinaria(cadena, caracter);
            var busquedaordinaria = BusquedaOrdinaria(cadena, caracter);
            Console.WriteLine(resutado);
            Console.WriteLine(busquedaordinaria);
            BenchmarkRunner.Run<IntParseBenchmarks>();
            Console.ReadLine();
        }

        public static string validaciones(string cadena, string caracter)
        {
            var noExiste = "";
            foreach(var c in cadena)
            {
                if (Convert.ToString(c) == caracter)
                {
                    noExiste = "true";                    
                    break;
                }
                else
                {
                    noExiste = "false";
                }
            }
            return noExiste;
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
            var nuevacadena = new string(cadenarry);
            return nuevacadena.ToString();

        }


        public static string BusquedaBinaria(string cadenaOrdenada, string caracter)
        {            
            var inicio = 0;
            var mid = 0;
            var final = cadenaOrdenada.Length - 1;
            var resultado = "";
            var iteraciones = 0;
            while (inicio <= final)
            {
                mid = inicio + (final - inicio) / 2;
                if (cadenaOrdenada[mid] == Convert.ToChar(caracter))
                {
                    iteraciones++;
                    resultado = "Su carácter se encuentra en la posición " + (mid+1) + " y el numero de iteracione fue de " + iteraciones;
                    break;                    
                }
                else if (cadenaOrdenada[mid] < char.Parse(caracter))
                {
                    iteraciones++;
                    inicio = mid + 1;
                }
                else
                {
                    iteraciones++;
                    final = mid - 1;
                }

            }

            return resultado;
        }

        public static string BusquedaOrdinaria(string cadenaOrdenada, string caracter)
        {
            var resultadobusquedaordinaria = "";
            var iteracionesordinarias = 0;
            foreach (var c in cadenaOrdenada)
            {
                iteracionesordinarias++;
                if (Convert.ToString(c) == caracter)
                {
                    resultadobusquedaordinaria = "Tu caracter se encuentra y esta en la posicion " + iteracionesordinarias + " Y el numero de iteracines fue de " + iteracionesordinarias;
                    break;
                }
            }

            return resultadobusquedaordinaria;
        }

    }
}

