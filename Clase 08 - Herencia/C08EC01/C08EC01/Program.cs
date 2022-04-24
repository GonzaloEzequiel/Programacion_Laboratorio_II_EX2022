/*
 *  Ejercicio C01 - Herencia deportiva
 *  
 *  Partir del ejercicio Jugadores encapsulados y realizar los siguientes cambios:
 *      1. Crear una clase Persona.
 *      2. Generar una nueva clase DirectorTecnico
 *      3. DirectorTecnico y Jugador deberán heredar de Persona, quedando el siguiente formato:
 *      
 *          Personsa
 *            Fields
 *              (private) dni : long
 *              (private) nombre : string
 *            Properties
 *              Dni { get; set; } : long
 *              Nombre { get; set; } : string
 *            Methods
 *              MustrarDatos() : string
 *              Persona(long dni, string nombre)
 *              Persona(string nombre)
 *              
 *                          |
 *              --------------------------------------------------------------------------------
 *              |                                                                              |
 *              
 *          DirectorTecnico                                                                 Jugador
 *            Fields                                                                          Fields
 *              (private) fechaNacimiento : DateTime                                            (private) partidosJugados : int
 *            Methods                                                                           (private) totalGoles : int
 *              (private) DirectorTecnico(string nombre)                                      Properties
 *              DirectorTecnico(string nombre, DateTime fechaNacimiento)                        PartidosJugados { get; set; } : int
 *              MostrarDatos() : string                                                         PomedioDeGoles { get; } : float
 *              operator !=(DirectorTecnico dt1, DirectorTecnico dt2) : bool                    TotalGoles { get; set; } : int
 *              operator ==(DirectorTecnico dt1, DirectorTecnico dt2) : bool                  Methods
 *                                                                                              Jugador(long dni, string nombre)
 *                                                                                              Jugador(long dni, string nombre, int totalGoles, int totalPartidos)
 *                                                                                              MostrarDatos() : string
 *                                                                                              operator !=(Jugador j1, Jugador j2) : bool 
 *                                                                                              operator ==(Jugador j1, Jugador j2) : bool  
 *                                                                                              
 *              
 *  4. Dos directores técnicos serán iguales si tienen el mismo nombre y fecha de nacimiento.
 *  5. Realizar las modificaciones necesarias para reutilizar código según la nueva estructura (constructores, métodos de exposición de datos).
 *  6. Realizar las propiedades necesarias en Persona y DirectorTecnico.
 *  
 *  Realizar todos los cambios necesarios en el método Main para probar las clases.
 * 
 */

using System;
using System.Text;
using BibliotecaC08EC01;

namespace C08EC01
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
