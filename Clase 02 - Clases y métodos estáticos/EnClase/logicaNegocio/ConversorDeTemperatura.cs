using System;

namespace LogicaNegocio
{
    public static class ConversorDeTemperatura
    {
        private const float ceroAblsoluto = 273.15f;

        public static float ConvertirCelciusAKelvin(float temperaturaCelcius)
        {
            return temperaturaCelcius + ConversorDeTemperatura.ceroAblsoluto;
        }

        public static float ConvertirKelvinACelcius(float temperaturaKelvin)
        {
            return temperaturaKelvin - ConversorDeTemperatura.ceroAblsoluto;
        }
    }
}
