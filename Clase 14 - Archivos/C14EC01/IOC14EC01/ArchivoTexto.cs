using System;
using System.IO;

namespace IOC14EC01
{
    public static class ArchivoTexto
    {
        private static StreamWriter streamWriter;
        private static StreamReader streamReader;
        private static string carpeta = @"..\..\..\..\..\ArchivosGenerados"; //Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private static string nombreArchivo = $"{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}-{DateTime.Now.Hour}{DateTime.Now.Minute}";
        private static string ruta = carpeta + "\\" + nombreArchivo;

        public static string Guardar(string path, string contenido)
        {
            string rutaFinal = string.Empty;

            try
            {
                using(streamWriter = new StreamWriter(ruta + path))
                {
                    streamWriter.Write(contenido);
                    rutaFinal = ruta + path;
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error al escribir", ex);
            }

            return rutaFinal;
        }

        public string Leer(string ruta)
        {
            string retorno = String.Empty;
            try
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    retorno = streamReader.ReadToEnd();
                }

            }
            catch (Exception ex)
            {
                throw new FileNotFoundException("Error al leer una archivo", ex);
            }

            return retorno;
        }
    }
}
