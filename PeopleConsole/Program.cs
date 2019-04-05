using PeopleDatos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PeopleConsole
{
    /// <summary>
    /// Prueba de BairesDev 
    /// Abril 04-2018
    /// Elaborado por Joaquin Gonzalez E.
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            List<People> Personas = new List<People>();
            CargarArchivo(Personas);
            CalculaAlgoritmo(Personas);
            salida(Personas);
        }


        /// <summary>
        /// Metodo que asigna los pesos para el algoritmo en particular
        /// </summary>
        /// <param name="pesos"></param>
        static void IniciarPesos(Pesos pesos)
        {
            pesos.ALto = 10;
            pesos.Medio = 8;
            pesos.Normal = 5;
            pesos.Bajo = 2;
        }

        /// <summary>
        /// Metodo que lee el archivo de la ruata del compilacion bin/debug
        /// colocar el archivo en esta ruta
        /// </summary>
        static void CargarArchivo(List<People> Personas)
        {
            string linea;
            People Persona;

            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path.Remove(0, 6);
            path += @"\people.in";

            System.IO.StreamReader archivo =
                new System.IO.StreamReader(@path);
            while ((linea = archivo.ReadLine()) != null)
            {
                Persona = new People();
                var campos = linea.Split('|');

                Persona.PersonId = long.Parse(campos[0]);
                Persona.Name = campos[1];
                Persona.LastName = campos[2];
                Persona.CurrentRole = campos[3];
                Persona.Country = campos[4];
                Persona.Industry = campos[5];
                Persona.NumberOfRecommendations = int.Parse(campos[6]);
                Persona.NumberOfConnections = int.Parse(campos[7]);
                Persona.CountryPeso = 1;
                Persona.CurrentRolePeso = 1;
                Persona.IndustryPeso = 1;
                Persona.NumberOfConnectionsPeso = 1;
                Persona.NumberOfRecommendationsPeso = 1;
                Persona.PesoTotal = 1;
                Personas.Add(Persona);
            }
            archivo.Close();
        }

        static void CalculaAlgoritmo(List<People> Personas)
        {
            PaisesLatinos paisesLAtinos = new PaisesLatinos();
            Pesos pesos = new Pesos();
            Industrias industrias = new Industrias();
            Roles roles = new Roles();

            IniciarPesos(pesos);

            foreach (People persona in Personas)
            {
                persona.CurrentRolePeso = roles.calculaPesoRol(persona.CurrentRole);
                persona.IndustryPeso = pesos.OptenerPeso(industrias.ListaIndustrias.Where(ind => ind.Industry == persona.Industry).FirstOrDefault().Peso);
                persona.CountryPeso = paisesLAtinos.Paises.Any(pa => pa == persona.Country) ? pesos.PaisLaitno : pesos.PaisOtro;
                persona.NumberOfRecommendationsPeso = persona.NumberOfRecommendations;
                persona.NumberOfConnectionsPeso = persona.NumberOfConnections / 100;
                persona.PesoTotal = persona.CurrentRolePeso + persona.IndustryPeso + persona.CountryPeso + persona.NumberOfRecommendationsPeso + persona.NumberOfConnectionsPeso;
            }
        }

        static void salida(List<People> Personas)
        {
            List<People> PersonasSelecionadas = Personas.OrderByDescending(p => p.PesoTotal).Take(100).ToList();

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "people.out")))
            {
                foreach (var persona in PersonasSelecionadas)
                    outputFile.WriteLine(persona.PersonId);
            }

        }
    }
}
