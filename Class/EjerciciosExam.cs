using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_de_estrurura_de_datos_unidad2.Class
{
    internal class EjerciciosExam
    {
        public void Vendedores()
        {
            double[,] ganacias = { { 500, 1000, 250, 400, 60 }, 
                                  { 3000, 150, 1800, 130, 20 },
                                  { 100, 200, 2900, 90, 4000 }, 
                                  { 400, 500, 300, 2400, 3600 } };
            double ganaciasTotalProduct = 0;
            double ganaciasTotalProduct2 = 0;
            double ganaciasTotalProduct3 = 0;
            double ganaciasTotalProduct4= 0;
            double ganaciasTotalProduct5 = 0;

            double ganaciasTotaLVeder = 0;
             double ganaciasTotaLVeder2 = 0;
            double ganaciasTotaLVeder3 = 0;
            double ganaciasTotaLVeder4 = 0;

            for(int j = 0; j < ganacias.GetLength(0); j++)
            {
                for (int k = 0; k < ganacias.GetLength(1); k++)
                {
                    Console.Write(" "+ ganacias[j,k]);
                }
                Console.WriteLine();
            }

            for(int j=0;j<5;j++)
                {
                    
                    ganaciasTotaLVeder += ganacias[0, j];
                    ganaciasTotaLVeder2+= ganacias[1, j];
                    ganaciasTotaLVeder3+= ganacias[2, j];
                    ganaciasTotaLVeder4+= ganacias[3, j];
            }
            
            for(int j = 0; j < 4; j++)
            {
                ganaciasTotalProduct += ganacias[j, 0];
                ganaciasTotalProduct2 += ganacias[j, 1];
                ganaciasTotalProduct3 += ganacias[j, 2];
                ganaciasTotalProduct4 += ganacias[j, 3];
                ganaciasTotalProduct5 += ganacias[j, 4];

            }


            Console.WriteLine($"El vendedor 1 obtuvo: {ganaciasTotaLVeder} de ganancia");
            Console.WriteLine($"El vendedor 2 obtuvo: {ganaciasTotaLVeder2} de ganancia");
            Console.WriteLine($"El vendedor 3 obtuvo: {ganaciasTotaLVeder3} de ganancia");
            Console.WriteLine($"El vendedor 4 obtuvo: {ganaciasTotaLVeder4} de ganancia");

            Console.WriteLine($"El Producto 1 genero: {ganaciasTotalProduct} de ganancias ");
            Console.WriteLine($"El Producto 2 genero: {ganaciasTotalProduct2} de ganancias ");
            Console.WriteLine($"El Producto 3 genero: {ganaciasTotalProduct3} de ganancias ");
            Console.WriteLine($"El Producto 4 genero: {ganaciasTotalProduct4} de ganancias ");
            Console.WriteLine($"El Producto 5 genero: {ganaciasTotalProduct5} de ganancias ");


        }
        public void CURP()
        {
          /*  string[] array = new string[18];
            string sexo=" ";

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Ingresar su CURP");
                array[i] = Console.ReadLine();
                if (array[10] == "H")
                {
                    sexo = "Hombre";
                }
                else
                {
                    sexo = "Mujer";
                }


                int año1 = int.Parse(array[5]);
                int año2 = int.Parse(array[6]);
                int mes1 = int.Parse(array[7]);
                int mes2 = int.Parse(array[8]);
                int dia1 = int.Parse(array[9]);
                int dia2 = int.Parse(array[10]);

                if (año1 >= 0 && año2 <= 49)
                {

                }
                Console.WriteLine($"Nacio en {dia1}{dia2}/{mes1}{mes2}/{año1}{año2}");
            }
            Console.WriteLine($"Su sexo es: {sexo}");*/
            
           

        }
        public void CalificacionesGrupar()
        {
            Random random = new Random();
            int[] array = new int [100];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            Console.WriteLine(string.Join(" ",array));
            for(int i=0; i < array.Length; i++)
            {
                for(int j = i+1; j < array.Length; j++)
                {
                    int aux;
                    if (array[i] > array[j])
                    {
                        aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine("Ingresa un numero a buscar");
            int valor=Convert.ToInt32(Console.ReadLine());
            int inicio = 0;
            int indice = -1;
            int fin = array.Length - 1;
            int medio;

            while(inicio<= fin)
            {
                medio = (inicio + fin + 1) / 2;
                if (array[medio] == valor)
                {
                    indice = medio;
                    break;
                }
                else if (array[medio] < valor)
                {
                    inicio = medio + 1;
                }
                else if (array[medio] > valor)
                {
                    fin = medio - 1;
                }
            }
            if (indice != -1)
                Console.WriteLine("El numero se encontró en la posición " + indice);
            else
                Console.WriteLine("El numero no se encontró " + indice);

        }


    }
}
