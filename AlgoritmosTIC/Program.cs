using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosTIC
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("######### ALGORITMO 1 #########");
            List<int>[] ar = new List<int>[]
            {
                new List<int> {1, 2, 3},
                new List<int> { 4, 54, 6 },
                new List<int> { 97, 15, 15 },
                new List<int> { 197, 15, 15, 12},
                new List<int> { 19, 15, 15, 12, 42},
                new List<int> { 7, 15, 15, 12, 64, 76, 97}
            };
            NumeroMayor(ar);

            Console.Write("\n");

            Console.WriteLine("######### ALGORITMO 2 #########");
            foreach (var item in Fibonacci(5))
            {
                Console.WriteLine(item);
            }

            Console.Write("\n");

            Console.WriteLine("######### ALGORITMO 3 #########");
            foreach (var item in Billetes(17984))
            {
                Console.WriteLine(item);
            }

            


            Console.ReadKey();
        }



        /*Algoritmo 1: Crear una función que reciba un arreglo de listas de enteros y retorne
        tanto el número más alto que existe dentro de todas las listas como la lista
        que contiene mayor cantidad de números*/

        #region Algoritmo 1: NumeroMayor 
        public static void NumeroMayor(List<int>[] ar)
        {
            
            int count = ar.Count();
            for (int i = 0; i < count; i++)
            {
                var mayor = ar[i].Max();
                Console.WriteLine($"Lista #{i + 1} el numero mayor es: {mayor}");
            }
            Console.WriteLine("");
            var findlist = ar.LongCount();
            Console.WriteLine($"La lista mas larga es: #{findlist}");

        }

        #endregion



        /*Algoritmo 2: Crear una función que dado un numero retorne los siguientes 5 números
          utilizando el algoritmo Fibonacci (para el primer Fibonacci favor usar el
          número dado menos 1 como numero anterior). */

        #region Algoritmo 2: Fibonacci
        public static int[] Fibonacci(int num1)
        {
            int[] numeros = new int[5];
            int aux;
            int limite = 5;
            int num2 = num1 - 1;
            for (int i = 0; i < limite; i++)
            {
                aux = num2;
                num2 = num1;
                num1 = aux + num2;
                numeros[i] = num2;

            }

            return numeros;
        }
        #endregion



        /*Algoritmo 3: Cree una función que reciba un entero. El entero es un monto que debe
        ser desglosado en billetes, donde las monedas más grandes tienen
        prioridad. El desglose se trata de identificar cual sería la cantidad
        necesaria de cada billete para igualar el monto del número ingresado, la
        función debe retornar una lista de String donde cada elemento es igual al
        siguiente mensaje: [Cantidad de billetes] x [Billete] = [Total] la moneda
        para usar son las de Republica Dominicana, donde tenemos las siguientes
        denominaciones [2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1]. Nota: no se
        deben imprimir los elementos donde [cantidad de billetes] es igual a cero.
        */

        #region Algoritmo 3: Billetes DOP
        public static List<string> Billetes(int monto)
        {
            int[] billetes = new int[] {2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1}; 

            billetes[9] = monto;

            billetes[0] = (billetes[9] - billetes[9] % 2000) / 2000;
            billetes[9] = billetes[9] % 2000;

            billetes[1] = (billetes[9] - billetes[9] % 1000) / 1000;
            billetes[9] = billetes[9] % 1000;

            billetes[2] = (billetes[9] - billetes[9] % 500) / 500;
            billetes[9] = billetes[9] % 500;

            billetes[3] = (billetes[9] - billetes[9] % 200) / 200;
            billetes[9]=billetes[9] % 200;

            billetes[4] = (billetes[9] - billetes[9] % 100) / 100;
            billetes[9] = billetes[9] % 100;

            billetes[5] = (billetes[9] - billetes[9] % 50) / 50;
            billetes[9] = billetes[9] % 50;

            billetes[6]= (billetes[9] - billetes[9] % 25) / 25;
            billetes[9] = billetes[9] % 25;

            billetes[7]= (billetes[9] - billetes[9] % 10) / 10;
            billetes[9] = billetes[9] % 10;

            billetes[8] = (billetes[9] - billetes[9] % 5) / 5;
            billetes[9] = billetes[9] % 5;

            List<string> result = new List<string>();
            if (monto <= 0)
            {
               result.Add("Monto invalido"); 
            }
            else
            {
                if (billetes[0] != 0)
                    result.Add($"{billetes[0]} x 2000 = {billetes[0] * 2000}");

                if (billetes[1] != 0)
                    result.Add($"{billetes[1]} x 1000 = {billetes[1] * 1000}");

                if (billetes[2] != 0)
                    result.Add($"{billetes[2]} x 500 = {billetes[2] * 500}");

                if (billetes[3] != 0)
                    result.Add($"{billetes[3]} x 200 = {billetes[3] * 200}");

                if (billetes[4] != 0)
                    result.Add($"{billetes[4]} x 100 = {billetes[4] * 100}");

                if (billetes[5] != 0)
                    result.Add($"{billetes[5]} x 50 = {billetes[5] * 50}");

                if (billetes[6] != 0)
                    result.Add($"{billetes[6]} x 25 = {billetes[6] * 25}");
                
                if (billetes[7] != 0)
                    result.Add($"{billetes[7]} x 10 = {billetes[7] * 10}");

                if (billetes[8] != 0)
                    result.Add($"{billetes[8]} x 5 = {billetes[8] * 5}");

                if (billetes[9] != 0)
                    result.Add($"{billetes[9]} x 1 = {billetes[9] * 1}");
            }
            
            return result;
        }
        #endregion
        






        
    }



   
}

