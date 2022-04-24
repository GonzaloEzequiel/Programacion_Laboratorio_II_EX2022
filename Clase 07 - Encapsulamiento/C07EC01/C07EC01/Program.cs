/*
 *  Ejercicio C01 - Jugadores encapsulados
 * 
 *  Partir del ejercicio Estadística deportiva y realizar los siguientes cambios:
 *      1. Agregar propiedades de sólo lectura a los atributos partidosJugados, promedioGoles y totalGoles de Jugador, y de lectura/escritura a nombre y dni.
 *      2. Quitar el atributo promedioGoles de jugador. Calcular dicho promedio dentro de la propiedad de sólo lectura PromedioDeGoles.
 *      3. Quitar el método GetPromedioGoles, colocando dicha lógica en la respectiva propiedad.
 *      4. Realizar todos los cambios necesarios para que vuelva a funcionar como antes.
 * 
 */
using System;
using System.Text;
using BibliotecaC07EC01;

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