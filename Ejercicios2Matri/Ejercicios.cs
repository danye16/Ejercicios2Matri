using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicios2Matri
{
    internal class Ejercicios
    {
        public void Ejercicio1()
        {
            int tamaño;
            int numero;
            int total;
            Console.WriteLine("Ingrese El Tamaño de su arreglo");
            tamaño = Convert.ToInt32(Console.ReadLine());
            int[] arreglo1 = new int[tamaño];
            int[] arrelo2 = new int[tamaño];
            int[] arrelo3 = new int[tamaño];


            for (int c = 0; c < tamaño; c++)
            {
                Console.WriteLine("Ingrese los valores del primer arreglo");
                arreglo1[c] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese los valores del segundo arreglo");
                arrelo2[c] = Convert.ToInt32(Console.ReadLine());

                arrelo3[c] = arreglo1[c] + arrelo2[c];
                Console.WriteLine(arreglo1[c] +" + " + arrelo2[c]+ " = " + arrelo3[c]);
                { }

            }
           


        }
        public void Ejercicio2()
        {
            Console.WriteLine("dame un numero del 1 al 10");
            int numero = Convert.ToInt32(Console.ReadLine());
            
            
                int[] numeros = { 1, 2, 3, 3, 5, 6, 7, 4, 9, 10 };
                for (int i = 0; i < 10; i++)
                {
                    if (numeros[i] == numero)
                    {
                        Console.WriteLine($"{numero} esta en la posicion {i}");
                    }
                }
            
            //Buscar un elemento ingresado desde el teclado en un arreglo y guardar las posiciones en otro arreglo. Si hay más de una coincidencia, indicar igualmente la posición.


        }

        public void Ejercicio3()
        {
            Console.WriteLine("Indique el tamaño del arreglo");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            int[] algebra = new int[tamaño];
            int[] analisis = new int[tamaño];
            int[] alumnos = new int[tamaño];
            for (int c = 0; c < tamaño; c++)
            {
                Console.WriteLine("Ingrese los Id del alumno de algebra");
                algebra[c] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese los Id del alumno de analisis");
                analisis[c] = Convert.ToInt32(Console.ReadLine());

                if (algebra[c] == analisis[c])
                {
                    alumnos=
                }

            }


            //Solicitaremos los IDs(números) de los alumnos de dos clases y los guardaremos en dos arreglos con los nombres 'álgebra' y 'análisis'
            //.Queremos mostrar a todos los alumnos que están inscritos en ambas asignaturas.Estos alumnos se guardarán en un tercer arreglo, el cual se mostrará.También se indicará el número de alumnos que se repiten.

        }
    }
}
