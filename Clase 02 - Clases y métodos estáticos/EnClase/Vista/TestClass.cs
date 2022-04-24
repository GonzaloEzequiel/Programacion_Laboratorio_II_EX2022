using System;
using LogicaNegocio;

namespace Vista
{
    class TestClass
    {
        static float temperaturaCelcius;
        static float temperaturaKelvin;

        static void Main(string[] args)
        {
            temperaturaCelcius = 30;
            temperaturaKelvin = ConversorDeTemperatura.ConvertirCelciusAKelvin(temperaturaCelcius);

            MostrarTemperaturas();
        }

        static void MostrarTemperaturas()
        {
            Console.WriteLine($"La Temperatura Celcius es {temperaturaCelcius}°C");
            Console.WriteLine($"La Temperatura Kelvin es {temperaturaKelvin}°K");
        }
    }
}

