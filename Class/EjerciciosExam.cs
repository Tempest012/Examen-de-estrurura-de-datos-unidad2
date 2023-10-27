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
            double[,] ganacias = { { 500, 1000, 250, 400, 60 }, { 3000, 150, 1800, 130, 20 }, { 100, 200, 2900, 90, 4000 }, { 400, 500, 300, 2400, 3600 } };
            double ganaciasTotalProduct = 0;
            double ganaciasTotalProduct2 = 0;
            double ganaciasTotalProduct3 = 0;
            double ganaciasTotalProduct4= 0;
            double ganaciasTotalProduct5 = 0;

            double ganaciasTotaLVeder = 0;
             double ganaciasTotaLVeder2 = 0;
            double ganaciasTotaLVeder3 = 0;
            double ganaciasTotaLVeder4 = 0;



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
    }
}
