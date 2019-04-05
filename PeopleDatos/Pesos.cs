namespace PeopleDatos
{
    /// <summary>
    /// Clase que contiene los pesos para la distribucion de las varibles
    /// </summary>
    public class Pesos
    {
        public Pesos()
        {
            this.ALto = 10;
            this.Medio = 7;
            this.Normal = 5;
            this.Bajo = 3;
            this.Sin = 0;
            this.PaisLaitno = 0.95m;
            this.PaisOtro = 0.05m;
        }

        public decimal ALto { get; set; }
        public decimal Medio { get; set; }
        public decimal Normal { get; set; }
        public decimal Bajo { get; set; }
        public decimal Sin { get; set; }

        public decimal PaisLaitno { get; set; }
        public decimal PaisOtro { get; set; }

        public decimal OptenerPeso (string peso)
        {
            decimal respueata;

            switch (peso)
            {
                case "ALto":
                    respueata = ALto;
                    break;
                case "Medio":
                    respueata = Medio;
                    break;
                case "Normal":
                    respueata = Normal;
                    break;
                case "Bajo":
                    respueata = Bajo;
                    break;
                default:
                    respueata = ALto;
                    break;
            }
            return respueata;
        }
    }
}
