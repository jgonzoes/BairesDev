using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeopleDatos
{
    public class People
    {
        public long PersonId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CurrentRole { get; set; }
        public string Country { get; set; }
        public string Industry { get; set; }
        public int NumberOfRecommendations { get; set; }
        public int NumberOfConnections { get; set; }

        public decimal CurrentRolePeso { get; set; }
        public decimal CountryPeso { get; set; }
        public decimal IndustryPeso { get; set; }
        public decimal NumberOfRecommendationsPeso { get; set; }
        public decimal NumberOfConnectionsPeso { get; set; }
        public decimal PesoTotal { get; set; }

    }
}
