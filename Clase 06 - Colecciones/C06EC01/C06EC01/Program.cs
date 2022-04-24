/*
 *  Ejercicio C01 - Estadística deportiva
 * 
 *  Crear un proyecto de biblioteca de clases que contenga las clases Jugador y Equipo:
 *  
 *  Equipo                                              Jugador
 *      Fields                                              Fields
 *      (private) cantidadDeJugadores : short               (private) dni : int
 *      (private) jugadores : List<Jugador>                 (private) nombre : string
 *      (private) nombre : string                           (private) partidosJugados : int
 *                                                          (private) primedioGoles : float
 *      Methods                                             (private) totalGoles : int
 *      (private) Equipo()
 *      Equipo(shot cantidad, string nombre)                Methods
 *      operator +(Equipo e, Jugador j) : bool              GetPromedioGoles() : float
 *                                                          (private) Jugador()
 *                                                          Jugador(int dni, string nombre)
 *                                                          Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
 *                                                          MostrarDatos() : string
 *                                                          operator !=(Jugador j1, Jugador j2) : bool
 *                                                          operator !=(Jugador j1, Jugador j2) : bool
 *      
 *  
 *  Clase Jugador
 *  Todos los datos estadísticos del jugador se inicializarán en 0 dentro del constructor privado.
 *  El promedio de gol sólo se calculará cuando invoquen al método GetPromedioGoles.
 *  MostrarDatos retornará una cadena de string con todos los datos y estadísticas del jugador.
 *  Dos jugadores serán iguales si tienen el mismo DNI.
 *  
 *  Clase Equipo
 *  La lista de jugadores se inicializará sólo en el constructor privado de Equipo.
 *  La sobrecarga del operador + agregará jugadores a la lista siempre y cuando no exista aún en el equipo y la cantidad de jugadores no supere el límite establecido 
 *  por el atributo cantidadDeJugadores.
 *  
 *  Crear un proyecto de consola y generar las invocaciones necesarias en el método Main para probar el código.
 * 
 */

using System;
using System.Text;
using BibliotecaC06EC01;

namespace C06EC01
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo racingClub = new Equipo(30, "Racing Club");
            Equipo bocaJuniors = new Equipo(30, "Boca Juniors");

            Jugador gabrielAuche = new Jugador(37894531, "Gabriel Auche", 200, 300);
            Jugador enzoCopetti = new Jugador(40157953, "Enzo Copetti", 20, 100);
            Jugador gonzaloPerez = new Jugador(33111296, "Gonzalo Pérez");

            Jugador romanRiquelme = new Jugador(31256785, "Juan Román Riquelme", 400, 350);
            Jugador martinPalermo = new Jugador(305886799, "Martín \"El Loco\" Palermo", 500, 300);
            Jugador clementeCancela = new Jugador(40558713, "Clemente Cancela");
            Jugador copion = new Jugador(33111296, "Espía incubierto", 20, 100);

            StringBuilder muestroEnPantalla = new StringBuilder();
            muestroEnPantalla.AppendLine("MERCADO DE PASES 202X");
            muestroEnPantalla.AppendLine("----------------------------------------------------------------------------------------");
            muestroEnPantalla.AppendLine($"Racing incorpora a Gabriel Auche: {racingClub + gabrielAuche}");
            muestroEnPantalla.AppendLine($"Racing incorpora a Enzo Copetti: {racingClub + enzoCopetti}");
            muestroEnPantalla.AppendLine($"Racing incorpora a Gonzalo Pérez: {racingClub + gonzaloPerez}");
            muestroEnPantalla.AppendLine($"Boca incorpora a Román Riquelme: {bocaJuniors + romanRiquelme}");
            muestroEnPantalla.AppendLine($"Boca incorpora a Martín Palermo: {bocaJuniors + martinPalermo}");
            muestroEnPantalla.AppendLine($"Boca incorpora a Clemente Cancela: {bocaJuniors + clementeCancela}");
            muestroEnPantalla.AppendLine("----------------------------------------------------------------------------------------");
            muestroEnPantalla.AppendLine($"Racing incorpora a Gabriel Auche? {racingClub + gabrielAuche}");
            muestroEnPantalla.AppendLine("----------------------------------------------------------------------------------------");
            muestroEnPantalla.AppendLine($"Gonzalo y copion son el mismo jugador? (V) {gonzaloPerez == copion}");
            muestroEnPantalla.AppendLine($"Copetti y Riquelme son el mismo jugador? (F) {romanRiquelme == enzoCopetti}");
            muestroEnPantalla.AppendLine("----------------------------------------------------------------------------------------");
            muestroEnPantalla.AppendLine("----------------------------------------------------------------------------------------");
            muestroEnPantalla.AppendLine("RESUMEN:");
            muestroEnPantalla.AppendLine("Racing Club:");
            foreach (Jugador Jugador in racingClub.Jugadores)
            {
                muestroEnPantalla.AppendLine(Jugador.MostrarDatos());
            }
            muestroEnPantalla.AppendLine("Boca Juniors:");
            muestroEnPantalla.AppendLine("----------------------------------------------------------------------------------------");
            foreach (Jugador Jugador in bocaJuniors.Jugadores)
            {
                muestroEnPantalla.AppendLine(Jugador.MostrarDatos());
            }

            Console.WriteLine(muestroEnPantalla.ToString());
        }
    }
}
