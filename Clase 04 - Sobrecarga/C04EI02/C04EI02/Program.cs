/*
 *  Ejercicio I02 - Cotizador
 *  
 *  Crear un proyecto de tipo biblioteca de clases. Construir tres clases dentro de un namespace llamado Billetes: Pesos, Euro y Dolar.
 *  Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí con total normalidad como si fueran tipos numéricos, 
 *  teniendo presente que 1 Euro equivale a 1,17 Dólares y 1 Dólar equivale a 102,65 Pesos.
 *  
 *  TIP
 *  Para operar dos tipos de monedas distintos, primero se deberá convertir todo a una misma moneda y luego realizar la operación. 
 *  Por ejemplo, si quiero sumar Dolar y Euro, deberé convertir el Euro a Dólar y luego sumarlos.
 *  
 *  El atributo cotizRespectoDolar y el método GetCotizacion son estáticos.  
 *  Los constructores estáticos le darán a las clases una cotización por defecto respecto del dólar.
 *  Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los distintos tipos de datos.
 *  Los operadores de comparación == compararán cantidades.
 *  Reutilizar el código. Sólo realizar las conversiones dentro de los operadores para dicho uso.
 *  
 *  Crear un proyecto de consola y colocar dentro del método Main el código necesario para probar todas las funcionalidades.
 * 
 *  DOLAR                                                   EURO                                                    PESO
 *      Atributos:                                              Atributos:                                              Atributos:                                              
 *          (private) cantidad : double                             (private) cantidad : double                             (private) cantidad : double
 *          (private) cotizRespectoDolar : double                   (private) cotizRespectoDolar : double                   (private) cotizRespectoDolar : double
 *      Métodos:                                                Métodos:                                                Métodos:
 *          (static) Dolar()                                        (static) Euro()                                         (static) Pesos() 
 *          Dolar(double cantidad)                                  Euro(double cantidad)                                   Pesos(double cantidad)
 *          explicit operator Euro(Dolar d) : Euro                  Euro(double cantidad, double cotizacion)                Pesos(double cantidad, double cotizacion)
 *          explicit operator Pesos(Dolar d) : Pesos                explicit operator Dolar(Euro e) : Dolar                 explicit operator Dolar(Pesos p) : Dolar    
 *          GetCantidad() : double                                  explicit operator Pesos(Euro e) : Pesos                 explicit operator Euro(Pesos p) : Euro    
 *          GetCotizacion() : double                                GetCantidad() : double                                  GetCantidad() : double                    
 *          implicit operator Dolar(double d) : Dolar               GetCotizacion() : double                                GetCotizacion() : double        
 *          operator !=(Dolar d, Euro e) : bool                     implicit operator Euro(double d) : Euro                 implicit operator Pesos(double d) : Pesos    
 *          operator !=(Dolar d, Pesos p) : bool                    operator !=(Euro e, Dolar d) : bool                     operator !=(Pesos p, Dolar d) : bool    
 *          operator !=(Dolar d1, Dolar d2) : bool                  operator !=(Euro e, Pesos p) : bool                     operator !=(Pesos p, Euro e) : bool
 *          operator -(Dolar d, Euro e) : Dolar                     operator !=(Euro e1, Euro e2) : bool                    operator !=(Pesos p1, Pesos p2) : bool
 *          operator -(Dolar d, Pesos p) : Dolar                    operator -(Euro e, Dolar d) : Euro                      operator -(Pesos p, Dolar d) : Pesos    
 *          operator +(Dolar d, Euro e) : Dolar                     operator -(Euro e, Pesos p) : Euro                      operator -(Pesos p, Euro e) : Pesos
 *          operator +(Dolar d, Pesos p) : Dolar                    operator +(Euro e, Dolar d) : Euro                      operator +(Pesos p, Dolar d) : Pesos    
 *          operator ==(Dolar d, Euro e) : bool                     operator +(Euro e, Pesos p) : Euro                      operator +(Pesos p, Euro e) : Pesos        
 *          operator ==(Dolar d, Pesos p) : bool                    operator ==(Euro e, Dolar d) : bool                     operator ==(Pesos p, Dolar d) : bool            
 *          operator ==(Dolar d1, Dolar d2) : bool                  operator ==(Euro e, Pesos p) : bool                     operator ==(Pesos p, Euro e) : bool    
 *                                                                  operator ==(Euro e1, Euro e2) : bool                    operator ==(Pesos p1, Pesos p2) : bool            
 */
using System;
using System.Text;
using Billetes;

namespace C04EI02
{
    class Program
    {
        static void Main(string[] args)
        {
            //se instancian 3 Dolar
            Dolar dolar1 = new Dolar(1);
            Dolar dolar2 = new Dolar(100);
            Dolar dolar3 = new Dolar(125);
            //se instancian 3 Euro
            Euro euro1 = new Euro(1);
            Euro euro2 = new Euro(100);
            Euro euro3 = new Euro(125);
            //se instancian 3 Peso
            Peso peso1 = new Peso(1);
            Peso peso2 = new Peso(100);
            Peso peso3 = new Peso(125);

            //IMPLICITOS
            Dolar nuevoDolar = 200;
            Euro nuevoEuro = 200;
            Peso nuevoPeso = 200;

            Euro nuevoDolarAEuro = (Euro)nuevoDolar;
            Peso nuevoDolarAPeso = (Peso)nuevoDolar;
            Dolar nuevoEuroADolar = (Dolar)nuevoEuro;
            Peso nuevoEuroAPeso = (Peso)nuevoEuro;
            Dolar nuevoPesoADolar = (Dolar)nuevoPeso;
            Euro nuevoPesoAEuro = (Euro)nuevoPeso;

            //SUMAS
            //DOLAR + EURO
            Dolar dolarSumarEuro = dolar2.GetCantidad() + euro2.GetCantidad();
            //DOLAR + PESOS
            Dolar dolarSumarPesos = dolar2.GetCantidad() + peso2.GetCantidad();
            //EURO + DOLAR
            Euro euroSumaDolar = euro3.GetCantidad() + dolar3.GetCantidad();
            //EURO + PESOS
            Euro euroSumaPesos = euro1.GetCantidad() + peso2.GetCantidad();
            //PESOS + DOLAR
            Peso pesosSumaDolar = peso3.GetCantidad() + dolar1.GetCantidad();
            //PESOS + EURO
            Peso pesosSumaEuro = peso3.GetCantidad() + euro1.GetCantidad();

            //RESTAS
            //DOLAR - EURO
            Dolar dolarRestaEuro = dolar2.GetCantidad() - euro2.GetCantidad();
            //DOLAR - PESO
            Dolar dolarRestaPesos = dolar2.GetCantidad() - peso2.GetCantidad();
            //EURO - DOLAR
            Euro euroRestaDolar = euro2.GetCantidad() - dolar2.GetCantidad();
            //EURO - PESOS
            Euro euroRestaPesos = euro2.GetCantidad() - peso2.GetCantidad();
            //PESOS - DOLAR
            Peso pesosRestaDolar = peso2.GetCantidad() - dolar1.GetCantidad();
            //PESOS - EURO
            Peso pesosRestaEuro = peso2.GetCantidad() - euro1.GetCantidad();

            //COMPARACIONES
            //DOLAR IGUAL DOLAR
            bool dolarIgualDolar = dolar1.GetCantidad() == dolar2.GetCantidad();
            //DOLAR IGUAL EURO
            bool dolarIgualEuro = dolar1.GetCantidad() == euro1.GetCantidad();
            //DOLAR IGUAL PESOS
            bool dolarIgualPesos = dolar1.GetCantidad() == peso2.GetCantidad();
            //EURO IGUAL EURO
            bool euroIgualEuro = euro1.GetCantidad() == euro2.GetCantidad();
            //EURO IGUAL DOLAR
            bool euroIgualDolar = euro1.GetCantidad() == dolar2.GetCantidad();
            //EURO IGUAL PESOS
            bool euroIgualPesos = euro2.GetCantidad() == peso3.GetCantidad();
            //PESOS IGUAL PESOS
            bool pesosIgualPesos = peso2.GetCantidad() == peso3.GetCantidad();
            //PESOS IGUAL DOLAR
            bool pesosIgualDolar = peso2.GetCantidad() == dolar2.GetCantidad();
            //PESOS IGUAL EURO
            bool pesosIgualEuro = peso2.GetCantidad() == euro1.GetCantidad();

            //DOLAR DISTINTO DOLAR
            bool dolarDistintoDolar = dolar2.GetCantidad() != nuevoEuroADolar.GetCantidad();
            //DOLAR DISTINTO EURO
            bool dolarDistintoEuro = dolar2.GetCantidad() != nuevoDolarAEuro.GetCantidad();
            //DOLAR DISTINTO PESOS
            bool dolarDistintoPesos = dolar2.GetCantidad() != nuevoDolarAPeso.GetCantidad();
            //EURO DISTINTO EURO
            bool euroDistintoEuro = euro2.GetCantidad() != nuevoDolarAEuro.GetCantidad();
            //EURO DISTINTO DOLAR
            bool euroDistintoDolar = euro2.GetCantidad() != nuevoEuroADolar.GetCantidad();
            //EURO DISTINTO PESOS
            bool euroDistintoPesos = euro2.GetCantidad() != nuevoEuroAPeso.GetCantidad();
            //PESOS DISTINTO PESOS
            bool pesosDistintoPesos = peso2.GetCantidad() != nuevoDolarAPeso.GetCantidad();
            //PESOS DISTINTO DOLAR
            bool pesosDistintoDolar = peso2.GetCantidad() != nuevoPesoADolar.GetCantidad();
            //PESOS DISTINTO EURO
            bool pesosDistintoEuro = peso2.GetCantidad() != nuevoPesoAEuro.GetCantidad();

            //presentacion en pantalla
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Dolar 1: {dolar1.GetCantidad()}");
            sb.AppendLine($"Dolar 2: {dolar2.GetCantidad()}");
            sb.AppendLine($"Dolar 3: {dolar3.GetCantidad()}");
            sb.AppendLine($"Euro 1: {euro1.GetCantidad()}");
            sb.AppendLine($"Euro 2: {euro2.GetCantidad()}");
            sb.AppendLine($"Euro 3: {euro3.GetCantidad()}");
            sb.AppendLine($"Pesos 1: {peso1.GetCantidad()}");
            sb.AppendLine($"Pesos 2: {peso2.GetCantidad()}");
            sb.AppendLine($"Pesos 3: {peso3.GetCantidad()}");
            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine($"Nuevo Dolar: {nuevoDolar.GetCantidad()}");
            sb.AppendLine($"Nuevo Euro: {nuevoEuro.GetCantidad()}");
            sb.AppendLine($"Nuevo Pesos: {nuevoPeso.GetCantidad()}");
            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine($"Nuevo Dolar a Euro: {nuevoDolarAEuro.GetCantidad()}");
            sb.AppendLine($"Nuevo Dolar a Pesos: {nuevoDolarAPeso.GetCantidad()}");
            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine($"Nuevo Euro a Dolar: {nuevoEuroADolar.GetCantidad()}");
            sb.AppendLine($"Nuevo Euro a Pesos: {nuevoEuroAPeso.GetCantidad()}");
            sb.AppendLine("------------------------------------------------------------------------");
            sb.AppendLine($"Nuevo Pesos a Dolar: {nuevoPesoADolar.GetCantidad()}");
            sb.AppendLine($"Nuevo Pesos a Euro: {nuevoPesoAEuro.GetCantidad()}");
            sb.AppendLine("------------------------------------------------------------------------");

            Console.WriteLine(sb);
        }
    }
}
