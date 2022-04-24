/*
 *   Ejercicio I05 - Prueba de geometría
 *   
 *   En un proyecto de biblioteca de clases, crear las clases modeladas en el siguiente diagrama:
 *   
 *   Punto
 *      Fields
 *      (private) x : int
 *      (private) y : int
 *      Methods
 *      GetX() : int
 *      GetY() : int
 *      Punto(int x, int y)
 *      
 *  Rectangulo
 *      Fields
 *      (private) area : float
 *      (private) perimetro : float
 *      (private) vertice1 : Punto
 *      (private) vertice2 : Punto
 *      (private) vertice3 : Punto
 *      (private) vertice4 : Punto
 *      Methods
 *      Area() : float
 *      Perimetro() : float
 *      Rectaangulo(Punto vertice1, vertice3)
 *      
 *  Ambas clases deberán encontrarse dentro de un espacio de nombres (namespace) llamado Geometria.
 *  La clase Punto debe tener:
 *  Dos atributos privados con acceso de sólo lectura (sólo con getters), que serán las coordenadas del punto.
 *  Un constructor que reciba los parámetros x e y.
 *  
 *  La clase Rectangulo:
 *  Tiene los atributos de tipo Punto: vertice1, vertice2, vertice3 y vertice4 (que corresponden a los cuatro vértices del rectángulo).
 *  La base de todos los rectángulos de esta clase será siempre horizontal. El constructor para calculará los vértices 2 y 4 del rectángulo a partir de los vértices 1 y 3.
 *  Utilizar el método Abs de la clase Math que retorna el valor absoluto de un número y será necesario para obtener la distancia entre puntos.
 *  Realizar los métodos getters para los atributos privados area y perimetro.
 *  El área (base * altura) y el perímetro ((base + altura) / 2) se deberán calcular sólo una vez cuando se llame por primera vez a su correspondiente método getter. 
 *  En las siguientes invocaciones de dichos métodos se deberá retornar siempre el valor calculado anteriormente.
 *  
 *  Crear un proyecto de consola.
 *  En la clase Program, desarrollar un método de clase (estático) que muestre todos los datos de una instancia de Rectangulo que reciba como parámetro.
 *  En el método Main probar las funcionalidades de las clases Punto y Rectángulo.
 *  Instanciar un nuevo Rectangulo.
 *  Imprimir por pantalla los valores de área y perímetro.
 *   
 */
using System;
using System.Text;
using Geometria;

namespace C03EI05
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto esquina1 = new Punto(0, 15);
            Punto esquina3 = new Punto(60, 40);

            Rectangulo rectangulo1 = new Rectangulo(esquina1, esquina3);

            Program.MostrarDatos(rectangulo1);
        }

        /// <summary>
        /// Imprime en pantalla todos los datos de un rectángulo
        /// </summary>
        /// <param name="rectangulo">el rectangulo a mostrar</param>
        private static void MostrarDatos(Rectangulo rectangulo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Vértice 1: ({rectangulo.Vertice1.GetX()}, {rectangulo.Vertice1.GetY()})");
            sb.AppendLine($"Vértice 2: ({rectangulo.Vertice2.GetX()}, {rectangulo.Vertice2.GetY()})");
            sb.AppendLine($"Vértice 3: ({rectangulo.Vertice3.GetX()}, {rectangulo.Vertice3.GetY()})");
            sb.AppendLine($"Vértice 4: ({rectangulo.Vertice4.GetX()}, {rectangulo.Vertice4.GetY()})");
            sb.AppendLine($"Área: {rectangulo.GetArea()}");
            sb.AppendLine($"Perímetro: {rectangulo.GetPerimetro()}");

            Console.WriteLine(sb);
        }
    }
}
