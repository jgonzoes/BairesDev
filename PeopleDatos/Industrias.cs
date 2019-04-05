using System.Collections.Generic;

namespace PeopleDatos
{
    /// <summary>
    /// Listado de industrias con sus pesos para calcular el algoritmo
    /// </summary>
    public class Industrias
    {
        public Industrias()
        {
            ListaIndustrias = new List<Industria>();
            this.LlenarIndustras();
        }
        public List<Industria> ListaIndustrias { get; set; }

        /// <summary>
        /// Llena la clase con los datos que vienen en el archivo incial
        /// </summary>
        private void LlenarIndustras()
        {
            ListaIndustrias.Add(new Industria { Industry = "Accounting", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Airlines/Aviation", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Animation", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Apparel & Fashion", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Architecture & Planning", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Arts and Crafts", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Auctions", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Automobiles", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Automotive", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Aviation & Aerospace", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Banking", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Biotechnology", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Boats & Submarines", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Broadcast Media", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Brokerage", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Building Materials", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Business Services", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Business Supplies and Equipment", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Car & Truck Rental", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Chemicals", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Civic & Social Organization", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Civil Engineering", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Computer & Network Security", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Computer Games", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Computer Hardware", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Computer Networking", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Computer Software", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Construction", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Consumer Electronics", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Consumer Goods", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Consumer Services", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Cosmetics", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Cultural", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Dairy", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Defense & Space", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Design", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Education", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Education Management", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "E-Learning", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Electrical/Electronic Manufacturing", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Electronics", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Entertainment", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Environmental Services", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Events Services", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Executive Office", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Facilities Services", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Farming", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Financial Services", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Fine Art", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Food & Beverages", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Food Production", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Fund-Raising", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Furniture", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Glass, Ceramics & Concrete", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Government Administration", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Government Relations", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Graphic Design", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Health, Wellness and Fitness", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Higher Education", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Hospital & Health Care", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Hospitality", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Human Resources", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Import and Export", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Individual & Family Services", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Industrial Automation", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Information Services", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Information Technology and Services", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Insurance", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "International Affairs", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "International Trade and Development", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Internet", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Investment Banking", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Investment Management", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Judiciary", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Law Enforcement", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Law Practice", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Legal Services", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Legislative Office", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Leisure, Travel & Tourism", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Libraries", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Logistics and Supply Chain", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Luxury Goods & Jewelry", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Machinery", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Management Consulting", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Manufacturing", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Maritime", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Market Research", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Marketing and Advertising", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Mechanical or Industrial Engineering", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Media Production", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Medical Devices", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Medical Practice", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Mental Health Care", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Military", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Mining & Metals", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Motion Pictures and Film", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Motor Vehicle Dealers", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Museums and Institutions", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Music", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Newspapers", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Nonprofit Organization Management", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Office Products", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Oil & Energy", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Online Media", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Outsourcing/Offshoring", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Package/Freight Delivery", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Performing Arts", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Pharmaceuticals", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Philanthropy", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Photography", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Plastics", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Political Organization", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Primary/Secondary Education", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Printing", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Professional Training & Coaching", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Program Development", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Public Relations and Communications", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Public Safety", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Publishing", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Real Estate", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Religious Institutions", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Renewables & Environment", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Research", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Restaurants", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Retail", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Security and Investigations", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Security Products & Services", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Semiconductors", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Shipbuilding", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Sporting Goods", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Sports", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Staffing and Recruiting", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Supermarkets", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Telecommunications", Peso = "ALto" });
            ListaIndustrias.Add(new Industria { Industry = "Test & Measurement Equipment", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Textiles", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Think Tanks", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Tires & Rubber", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Tobacco", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Toys & Games", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Translation and Localization", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Transportation/Trucking/Railroad", Peso = "Medio" });
            ListaIndustrias.Add(new Industria { Industry = "Utilities", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Venture Capital & Private Equity", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Veterinary", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Warehousing", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Wholesale", Peso = "Bajo" });
            ListaIndustrias.Add(new Industria { Industry = "Wine and Spirits", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Wire & Cable", Peso = "Normal" });
            ListaIndustrias.Add(new Industria { Industry = "Writing and Editing", Peso = "Normal" });

        }
    }

    /// <summary>
    /// Clase de industria para generar un listado
    /// </summary>
    public class Industria
    {
        public string Industry { get; set; }
        public string Peso { get; set; }
    }

}
