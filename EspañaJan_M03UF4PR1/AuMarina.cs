namespace JanEspaña_M03UF4_PR1
{
    public class AuMarina : AAnimal
    {
        public AuMarina(string nom, string especie, string superfamilia, double pesAproximat, double gA) : base(nom, especie, superfamilia, pesAproximat, gA)
        {
        }
        public double CalcularGA(bool centre)
        {
            double x = 0;
            if (!centre)
            {
                x = 5;
            }
            if (Math.Round((2 * Math.Pow(GA, 2) - 3 * Math.Pow(GA, 2)) / 250 - x) < 0)
            {
                return 0;
            }
            return Math.Round((2 * Math.Pow(GA, 2) - 3 * Math.Pow(GA, 2)) / 250 - x);
            //Igual que amb les tortugues, aquesta fórmula dona nombres molt estranys i la he reajustat.
        }
        public override string ToString()
        {
            return $"-------- ANIMAL ---------\n" +
                $"Nom: {Nom}\nSuperfamília: {Superfamilia}\nEspècie: {Especie}\nPes aproximat: {PesAproximat}kg";
        }
    }
}
