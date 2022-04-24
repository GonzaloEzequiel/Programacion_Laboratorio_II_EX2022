/*
 *  Ejercicio C01 - Conversor binario recargado
 *  
 *  Partiendo del ejercicio Conversor binario (C02EI03), se pide agregar las clases:
 *  
 *  NumeroBinario:
 *      Único atributo numero de tipo string.
 *      Único constructor privado (recibe un parámetro de tipo string).
 *      
 *  NumeroDecimal:
 *      Único atributo numero de tipo double.
 *      Único constructor privado (recibe un parámetro de tipo double).
 *  
 *  Utilizando los métodos de la clase Conversor donde corresponda, agregar las sobrecargas de operadores:
 *  
 *  NumeroBinario:
 *      string + (NumeroBinario, NumeroDecimal)
 *      string - (NumeroBinario, NumeroDecimal)
 *      bool == (NumeroBinario, NumeroDecimal)
 *      bool != (NumeroBinario, NumeroDecimal)
 *  
 *  NumeroDecimal:
 *      double + (NumeroDecimal, NumeroBinario)
 *      double - (NumeroDecimal, NumeroBinario)
 *      bool == (NumeroDecimal, NumeroBinario)
 *      bool != (NumeroDecimal, NumeroBinario)
 *  
 *  Agregar conversiones implícitas para poder ejecutar:
 *      NumeroBinario objBinario = "1001";
 *      NumeroDecimal objDecimal = 9;
 *      
 *  Agregar conversiones explícitas para poder ejecutar:
 *      string binario = (string)objBinario;
 *      double numeroDecimal = (double)objDecimal;
 *      
 *  Generar el código en el método Main para instanciar un objeto de cada tipo y operar entre ellos, imprimiendo cada resultado por pantalla.
 *  
 */

using System;
using System.Text;
using BilbiotecaC04EC01;

namespace C04EC01
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroDecimal = 141;
            int numeroBinario = 100110;

            Console.WriteLine("ESTO ES UNA PRUEBA");

            //Console.WriteLine($"Numero Decimal: {numeroDecimal} es {Conversor.ConvertirDecimalABinario(numeroDecimal)} en binario!");
            //Console.WriteLine($"Numero Binario: {numeroBinario} es {Conversor.ConvertirBinarioADecimal(numeroBinario)} en decimal!");

            //conversiones implícitas
            NumeroDecimal decimal1 = 145;
            NumeroDecimal decimal2 = 255;

            NumeroBinario binario1 = "10010001";
            NumeroBinario binario2 = "11111111";

            NumeroBinario binarioFalso = "1112";

            //conversiones explícitas
            string valorBinario = (string)binario1;
            double valorDecimal = (double)decimal2;

            double resultadoSumaD = decimal1 + binario1;
            double resultadoRestaD = decimal2 - binario1;
            string resultadoSumaB = binario1 + decimal2;
            string resultadoRestaB = binario2 - decimal1;

            double resultadoSumaDFalsa = decimal2 + binarioFalso; //esta debe dar como resultado decimal2 (255);
            string resultadoRestaBFalsa = binarioFalso - decimal1;

            bool igualdadDecimalConBinarioCorrecta = decimal1 == binario1;
            bool igualdadDecimalConBinarioIncorrecta = decimal2 == binario1;
            bool desigualdadDecimalConBinarioCorrecta = decimal1 != binario2;
            bool desigualdadDecimalConBinarioIncorrecta = decimal1 != binario1;

            bool igualdadBinarioConDecimalCorrecta = binario2 == decimal2;
            bool igualdadBinarioConDecimalIncorrecta = binario2 == decimal1;
            bool desigualdadBinarioConDecimalCorrecta = binario1 != decimal2;
            bool desigualdadBinarioConDecimalIncorrecta = binario2 != decimal2;


            //PRUEBAS Y MUESTRA EN PANTALLA
            StringBuilder muestraEnPantalla = new StringBuilder();
            muestraEnPantalla.AppendLine("VALORES:\n");
            muestraEnPantalla.AppendLine("(generados por conversion implícita)");
            muestraEnPantalla.AppendLine($"1°Decimal = {decimal1}");
            muestraEnPantalla.AppendLine($"2°Decimal = {decimal2}");
            muestraEnPantalla.AppendLine($"1°Binario = {binario1}");
            muestraEnPantalla.AppendLine($"2°Binario = {binario2}");
            muestraEnPantalla.AppendLine("(generados por conversion explícita)");
            muestraEnPantalla.AppendLine($"valorBinario = {valorBinario}");
            muestraEnPantalla.AppendLine($"2°valorDecimal = {valorDecimal}");
            muestraEnPantalla.AppendLine();
            muestraEnPantalla.AppendLine("RESULTADOS:\n");
            muestraEnPantalla.AppendLine("(sumas y restas)");
            muestraEnPantalla.AppendLine($"Resultado suma Decimal + Binario (debe dar 290): {resultadoSumaD}");
            muestraEnPantalla.AppendLine($"Resultado resta Decimal - Binario (debe dar 110): {resultadoRestaD}");
            muestraEnPantalla.AppendLine($"Resultado suma Binario + Decimal (debe dar 400): {resultadoSumaB}");
            muestraEnPantalla.AppendLine($"Resultado resta Binario - Decimal (debe dar 110): {resultadoRestaB}");
            muestraEnPantalla.AppendLine($"Resultado suma Decimal - StringNoBinario(0) (debe dar 255): {resultadoSumaDFalsa}");
            muestraEnPantalla.AppendLine($"Resultado suma StringNoBinario(0) - Decimal (debe dar -145): {resultadoRestaBFalsa}");
            muestraEnPantalla.AppendLine("(comparaciones)");
            muestraEnPantalla.AppendLine($"decimal1 == binario1(V): {igualdadDecimalConBinarioCorrecta}");
            muestraEnPantalla.AppendLine($"decimal2 == binario1(F): {igualdadDecimalConBinarioIncorrecta}");
            muestraEnPantalla.AppendLine($"decimal1 != binario2(V): {desigualdadDecimalConBinarioCorrecta}");
            muestraEnPantalla.AppendLine($"decimal1 != binario1(F): {desigualdadDecimalConBinarioIncorrecta}");
            muestraEnPantalla.AppendLine($"binario2 == decimal2(V): {igualdadBinarioConDecimalCorrecta}");
            muestraEnPantalla.AppendLine($"binario2 == decimal1(F): {igualdadBinarioConDecimalIncorrecta}");
            muestraEnPantalla.AppendLine($"binario1 != decimal2(V): {desigualdadBinarioConDecimalCorrecta}");
            muestraEnPantalla.AppendLine($"binario2 != decimal2(F): {desigualdadBinarioConDecimalIncorrecta}");

            Console.WriteLine(muestraEnPantalla.ToString());
        }
    }
}
