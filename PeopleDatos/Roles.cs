using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PeopleDatos
{
    public class Roles
    {
        public Roles()
        {
            Suma = new List<string>();
            Resta = new List<string>();
            this.Normal = 2;
            this.LlenaSuma();
            this.LlenaResta();
        }

        public decimal Normal { get; set; }
        public List<string> Suma { get; set; }
        public List<string> Resta{ get; set; }

        
        /// <summary>
        /// CAlcula el peso del rol que va a utilizar
        /// </summary>
        /// <param name="roleEntrada"></param>
        /// <returns></returns>
        public decimal calculaPesoRol(string roleEntrada)
        {
            long peso = 3;
            int count;
            
            //Calcula los pesos de las palabras que suman en el rol
            foreach (var cadena in Suma)
            {
                count = 0;
                foreach (Match match in Regex.Matches(roleEntrada, cadena, RegexOptions.IgnoreCase))
                    count++;
                peso += count * 3;
            }

            //Calcula los pesos de las palabras que restan en total
            foreach (var cadena in Resta)
            {
                count = 0;
                foreach (Match match in Regex.Matches(roleEntrada, cadena, RegexOptions.IgnoreCase))
                    count++;
                peso -= count * 3;
            }

            if (peso < 0)
                peso = 0;

            return peso;
        }


        /// <summary>
        /// Metodo que llena los roles que restan
        /// </summary>
        private void LlenaResta()
        {
            Resta.Add("assistant");
            Resta.Add("bar");
            Resta.Add("analyst");
            Resta.Add("freedom");
            Resta.Add("cafeteria");
            Resta.Add("management");
            Resta.Add("inspector");
            Resta.Add("child");
            Resta.Add("advisor");
            Resta.Add("customer service");
            Resta.Add("employee");
            Resta.Add("elementary");
            Resta.Add("secretary");
            Resta.Add("entertainer");
            Resta.Add("graduate");
            Resta.Add("installation");
        }

        private void LlenaSuma()
        {
            Suma.Add("director");
            Suma.Add("associate");
            Suma.Add("vice president");
            Suma.Add("human resources");
            Suma.Add("manager");
            Suma.Add("board");
            Suma.Add("business");
            Suma.Add("recruiter");
            Suma.Add("talent");
            Suma.Add("chairman");
            Suma.Add("chief");
            Suma.Add("owner");
            Suma.Add("president");
            Suma.Add("recruiter");
            Suma.Add("strategic");
        }
    }
}
