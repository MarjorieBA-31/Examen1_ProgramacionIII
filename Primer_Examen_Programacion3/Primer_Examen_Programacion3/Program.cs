using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Alunma: Marjorie Blandon Aguilar


//Dada una Matriz de tamaño NXN, calcule la diferencia de las sumas de las diagonales
namespace Primer_Examen_Programacion3
//{En la solucion del programa lo que se me Ocurrio fue separa el arreglo de string con el split,este me srive para saber
//    la cantidad y darle tamaño a mi matriz,luego sustituir los espacios y las rayas para ingresarle comas,introduciendolos en otro arreglo,
//       al obtener ese arreglo los convierto a numero y lgo los paso a la matriz ya estando en la matriz saco las diagonales segun su posicion y
//        uso if para poder restar segun los valores obtenidos de las sumas de las diagonales


//    class Program
{
    public class DiagonalDifference//Clase
    {

        public int matrix(string numeroEntrada)//Metodo entrada
        {


            int coinCoint = 0;//variable almacena valor

            string[] separaRayas = numeroEntrada.Split('|');//toma los valores del string  y los separa
            int cantidad = separaRayas.Length;//Cuenta la cantidada de split que se dieron en el arreglo
            int[,] arreglo = new int[cantidad, cantidad];//arreglo que va dar el tamayo a la matriz
            numeroEntrada = numeroEntrada.Replace(' ', ',');//Aqui sustituye los espacios que esten en el string con comas
            numeroEntrada = numeroEntrada.Replace('|', ',');//aqui sustituye los palitos que hay en el arreglo y  por comas
            String[] substrings = numeroEntrada.Split(',');//crea un string nuevo y separa los valores por la coma
            int contador = 0;//variable que almacena un valor
            for (int i = 0; i < cantidad; i++)//for que crea la matriz esta son las filas,no se sale asta que i sea iguial a la cantidad
            {
                for (int y = 0; y < cantidad; y++)//for que crea la matriz esta son las columnas, no se sale asta que i sea iguial a la cantidad
                {

                    arreglo[i, y] = Convert.ToInt32(substrings[contador]);//Convierte los valores para que puedan entrar al arreglo
                    contador++;//contador que aumenta
                }

            }
            Console.WriteLine("\tMATRIZ\n");//linea de espacio y imprime el tutulo en pantalla
            for (int i = 0; i < cantidad; i++)//Imprime la matriz con valorfor que crea la matriz esta son las filas,no se sale asta que i sea igial a la cantidad,
            {
                for (int j = 0; j < cantidad; j++)//Imprime la matriz con valor,for que crea la matriz esta son las Columnas, no se sale asta que i sea igial a la cantidad,

                    Console.Write(" " + arreglo[i, j] + "\t");//imprime los valores en el arreglo y le da espacio entre ellos

                Console.WriteLine();//linea de espacio

            }
            int Diafginalprimaria = 0;//variable que almacena el valor de la primera diagonal
            int Diagonalsecundaria = 0;//variable que almacenas los valores de la segunda diagonal
                                       //averigia la primera diagonal
            for (int i = 0; i < cantidad; i++)//for donde nos muestra las filas 
            {
                Diafginalprimaria = Diafginalprimaria + arreglo[i, i];//suma la primera diagonal segun las posiciones
            }
            //averigua la segunda diagonal

            for (int i = 0; i < cantidad; i++)//recorre las filas
            {
                for (int y = 0; y < cantidad; y++)//rrecorre las columnas
                {

                    if ((cantidad + 1) == (i + y + 2))//
                    {
                        Diagonalsecundaria += arreglo[i, y];//almacena los valores de la segunda diagonal
                    }
                }

            }


            if (Diafginalprimaria > Diagonalsecundaria)//entra a esta condicion si la suma de la diagonal menor es menor a la segunada diagonal
            {
                coinCoint = Diafginalprimaria - Diagonalsecundaria;//hace la la resta y la alamcela

            }
            else//entra a esta condicon si la primera no se cumple
            {
                coinCoint = Diagonalsecundaria - Diafginalprimaria;///hace la la resta y la alamcela
            }
            Console.WriteLine(" \n\nSuma es diagonal1= " + Diafginalprimaria);//imprime por pantalla el mensaje con la respuesta
            Console.WriteLine("suma es diagonal2= " + Diagonalsecundaria);// imprime por pantalla el mensaje con la respuest


            return coinCoint;//va aretorna esta variable con el valor especifico
        }

    


        static void Main(string[] args)//main principal
        {
            DiagonalDifference myCoint = new DiagonalDifference();//crea una instancia de la clase
            string test = "11 2 4|4 5 6|10 8 -12";//vector que contiene los valores
            int val = myCoint.matrix(test); //obtiene los valores 
            Console.WriteLine(" La diferencia de las Diagonales es= " + val);//imprime por pantalla el mensaje con la respuesta
            Console.ReadLine();//detiene la consola
        }
    }
 

}
    


