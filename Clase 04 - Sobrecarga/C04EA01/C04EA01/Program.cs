/*
 *  Ejercicio A01 - Fahrenheit 451
 *  
 *  Crear un proyecto de consola y un proyecto de biblioteca de clases. Agregar al último tres clases Fahrenheit, Celsius y Kelvin.
 *  Realizar la implementación necesaria para poder convertir una temperatura en sus distintas unidades de medida (Fahrenheit, Celsius y Kelvin).
 *  Utilizar sobrecargas de métodos, operadores y/o conversiones.
 *  
 *      TIP
 *      F = C * (9/5) + 32
 *      C = (F-32) * 5/9
 *      F = K * 9/5 – 459.67
 *      K = (F + 459.67) * 5/9
 *        
 */

using System;
using System.Text;
using BibliotecaC04EA01;

namespace C04EA01
{
    class Program
    {
        static void Main(string[] args)
        {
            //celsius1 instanciado con constructor
            Celsius celsius1 = new Celsius(40);
            //celsius2 creado con sobrecarga implícita
            Celsius celsius2 = 50;
            //celsius3 creado con sobrecarga de operador unario con double
            Celsius celsius3 = celsius1 + 20;

            //fahrenheit1 instanciado con constructor
            Fahrenheit fahrenheit1 = new Fahrenheit(100);
            //fahrenheit2 creado con sobrecarga implícita
            Fahrenheit fahrenheit2 = 150;
            //fahrenheit3 creado con sobrecarga de operador unario con objeto del mismo tipo
            Fahrenheit fahrenheit3 = fahrenheit2 - fahrenheit1;

            //kelvin1 instanciado con sobrecarga explícita
            Kelvin kelvin1 = (Kelvin)celsius1;
            //kelvin2 instanciado con sobrecarga explícita resultado de la suma de las temperatura de dos objetos distintos
            Kelvin kelvin2 = (Kelvin)celsius1+fahrenheit2;



            StringBuilder muestroEnPantalla = new StringBuilder();

            muestroEnPantalla.AppendLine($"Celsius 1: {celsius1.GetCantidad()}");
            muestroEnPantalla.AppendLine($"Celsius 2: {celsius2.GetCantidad()}");
            muestroEnPantalla.AppendLine($"Celsius 3: {celsius3.GetCantidad()}");
            muestroEnPantalla.AppendLine($"C1 + C2: {(celsius1+celsius2).GetCantidad()}");
            muestroEnPantalla.AppendLine($"C1 - C2: {(celsius1-celsius2).GetCantidad()}");
            muestroEnPantalla.AppendLine();
            muestroEnPantalla.AppendLine($"Fahrenheit 1: {fahrenheit1.GetCantidad()}");
            muestroEnPantalla.AppendLine($"Fahrenheit 2: {fahrenheit2.GetCantidad()}");
            muestroEnPantalla.AppendLine($"Fahrenheit 3: {fahrenheit3.GetCantidad()}");
            muestroEnPantalla.AppendLine($"F1 + C2: {(fahrenheit1 + celsius2).GetCantidad()}");
            muestroEnPantalla.AppendLine($"F1 - K2: {(fahrenheit2 - kelvin2).GetCantidad()}");
            muestroEnPantalla.AppendLine();
            muestroEnPantalla.AppendLine($"Kelvin 1: {kelvin1.GetCantidad()}");
            muestroEnPantalla.AppendLine($"Kelvin 2: {kelvin2.GetCantidad()}");
            muestroEnPantalla.AppendLine($"Comparo K1 = C1: {kelvin1 == celsius1}");
            muestroEnPantalla.AppendLine($"Comparo K1 != K2: {kelvin1 != kelvin2}");

            Console.WriteLine(muestroEnPantalla.ToString());
        }
    }
}
