using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R1Estructura
{
    class Metodos
    {
        int[] matriz = new int[10];
          
        public  void LlenarMatrizDesdeConsola(int[] matriz)
        {
            for (int i = 0; i < matriz.Length; i++)
            {
                Console.Write($"Ingrese el elemento en la posición {i}: ");
                matriz[i] = int.Parse(Console.ReadLine());
            }
        }

        public void ImprimirMatriz(int[] matriz)
        {
            for (int i = 0; i < matriz.Length; i++)
            {
                Console.Write(matriz[i] + " ");
                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        public void InsertarElemento(int[] matriz)
        {
            Console.Write("Ingrese la posición para insertar el elemento: ");
            int posicion = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor a insertar: ");
            int valor = int.Parse(Console.ReadLine());

            if (EsPosicionValida(matriz, posicion))
            {
                matriz[posicion] = valor;
            }
            else
            {
                Console.WriteLine("Posición inválida. No se pudo insertar el elemento.");
            }
        }
        public void ModificarElemento(int[] matriz)
        {
            Console.Write("Ingrese la posición del elemento a modificar: ");
            int posicion = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nuevo valor: ");
            int nuevoValor = int.Parse(Console.ReadLine());

            if (EsPosicionValida(matriz, posicion))
            {
                matriz[posicion] = nuevoValor;
            }
            else
            {
                Console.WriteLine("Posición inválida. No se pudo modificar el elemento.");
            }
        }

        public void EliminarElemento(int[] matriz)
        {
            // Eliminar un elemento en una posición dada
            Console.Write("Ingrese la posición del elemento a eliminar: ");
            int posicion = int.Parse(Console.ReadLine());

            if (EsPosicionValida(matriz, posicion))
            {
                matriz[posicion] = 0; // Puedes cambiar esto según tu lógica de eliminación
            }
            else
            {
                Console.WriteLine("Posición inválida. No se pudo eliminar el elemento.");
            }
        }
        public bool EsPosicionValida(int[] matriz, int posicion)
        {
            return posicion >= 0 && posicion < matriz.Length;
        }

    }
}
