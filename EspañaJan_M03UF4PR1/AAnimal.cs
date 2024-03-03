namespace JanEspaña_M03UF4_PR1
{
    public abstract class AAnimal
    {
        public string Nom { get; set; }
        public string Especie { get; set; }
        public string Superfamilia { get; set; }
        public double PesAproximat { get; set; }
        public double GA { get; set; }
        public static double RandomGA()
        {
            Random rnd = new Random();
            return rnd.Next(1, 100);
        }
        public AAnimal(string nom, string especie, string superfamilia, double pesAproximat, double gA)
        {
            Nom = nom;
            Especie = especie;
            Superfamilia = superfamilia;
            PesAproximat = pesAproximat;
            GA = gA;
        }
    }
}
