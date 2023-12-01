using Examen_de_estrurura_de_datos_unidad2.Class;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EjerciciosExam ejercicios = new EjerciciosExam();
            ejercicios.Vendedores();
            ejercicios.CURP();
            ejercicios.CalificacionesGrupar();
        }

    }
}