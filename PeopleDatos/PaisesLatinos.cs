using System.Collections.Generic;

namespace PeopleDatos
{
    /// <summary>
    /// Clase que contiene una lista de paises de latinoAmerica
    /// </summary>
    public class PaisesLatinos
    {
        public PaisesLatinos()
        {
            Paises = new List<string>();
            this.LlenarPais();
        }
        public List<string> Paises { get; set; }

        /// <summary>
        /// Metodo que llena el listado de los paises de LatinoAmerica
        /// </summary>
        private void LlenarPais()
        {
            Paises.Add("PaisLatino");
            Paises.Add("Argentina ");
            Paises.Add("Bolivia ");
            Paises.Add("Brasil ");
            Paises.Add("Chile ");
            Paises.Add("Colombia ");
            Paises.Add("Costa Rica ");
            Paises.Add("Cuba ");
            Paises.Add("Ecuador ");
            Paises.Add("El Salvador ");
            Paises.Add("Guayana Francesa");
            Paises.Add("Granada ");
            Paises.Add("Guatemala ");
            Paises.Add("Guayana");
            Paises.Add("Haití");
            Paises.Add("Honduras ");
            Paises.Add("Jamaica ");
            Paises.Add("México ");
            Paises.Add("Nicaragua ");
            Paises.Add("Paraguay ");
            Paises.Add("Panamá");
            Paises.Add("Perú");
            Paises.Add("Puerto Rico");
            Paises.Add("República Dominicana");
            Paises.Add("Surinam");
            Paises.Add("Uruguay ");
            Paises.Add("Venezuela");
        }
    }
}
