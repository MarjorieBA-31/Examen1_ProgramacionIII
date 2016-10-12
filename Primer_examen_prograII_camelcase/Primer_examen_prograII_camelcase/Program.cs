using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_examen_prograII_camelcase
{//Alumna:Marjorie Blandon Aguilar
    class Program
    {
        //Dado un String en camelcase, retorne la cantidad de palabras que son representadas en el string
        //Solucion
        //    en primero lugar se necesita recorrer el string por el cual se hizo un arreglo para darle las pocisiones 
        //    luego se usa una condicion con un metodo que me diga si de primero ay una letra minuscula entra y en dado caso que no entra a la condicion falsa
        //    se  utilizo un for para recorrer el arreglo y dentro de el condiciodonde si habia minusculas o mayusculas fuera sumando y almacenando para al final obtener resultado

        public class CamelCase//Clase publica CamelCase
        {
            public int calculate(string numero)//Metodo que recibe un string palabra como parametro
            {     //declaración de variables de tipo int
                char letras = numero[0];//variable que toma un valor del arreglo o string                   
                int almacena = 0;//variable que va almacena un valor
                int almacenauno = 0;//variable que va almacena un valor
                int respuesta = 0;//variable que va almacena un valor
               

                if (char.IsLower(numero[0]))//esta condicion no entra si de primero hay una letra mayuscula
                                            //si no
                    for (int i = 0; i < numero.Length; i++)//ciclo que recorre el arreglo por letra.
                    {

                        if (char.IsUpper(numero[i]))//condicion la cual se cumple al encontrar una letra mayuscula
                        {
                            almacena++;//contador que va incrementando cada vez que se cumpla la condicion

                        }

                        if (char.IsLower(numero[0]))//Condicion la cual se cumlple al encontrar una letra minuscula
                        {
                            if (almacenauno <= 0)//entra si la  variable es menor
                            {
                                almacenauno++;//va incrementadon el contador 
                            }
                        }

                    }
                else//condicion false
                {
                    Console.WriteLine("No es un palabra camelCase");//imprime el mensaje
                }
                    respuesta = almacenauno + almacena;//suma de las dos variables
                
                Console.WriteLine("la cantidad de palabras es:" + respuesta);//imprime el total de las palabras

                Console.ReadKey();//la consola se detiene asta precionar enter
                return respuesta;//retorna la cantidad total de palabras

            }



            static void Main(string[] args)//main principal
            {
                CamelCase myCoint = new CamelCase();//crea una instancia de la clase
                string test = "save Changes  In The Editor";//vector que contiene los valores
                int val = myCoint.calculate(test); //obtiene los valores 
                Console.ReadLine();//detiene la consola
            }
        }

    }
}