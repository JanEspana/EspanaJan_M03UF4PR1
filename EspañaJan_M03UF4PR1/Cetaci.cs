namespace JanEspaña_M03UF4_PR1
{
    public class Cetaci : AAnimal
    {
        public Cetaci(string nom, string especie, string superfamilia, double pesAproximat, double gA) : base(nom, especie, superfamilia, pesAproximat, gA)
        {
        }
        public double CalcularGA(bool centre)
        {
            double x = 0;
            if (!centre)
            {
                x = 25;
            }
            if (Math.Round(GA - (Math.Log10(GA)) - x) < 0)
            {
                return 0;
            }
            return Math.Round(GA - (Math.Log10(GA)) - x);
        }
        public override string ToString()
        {
            return $"-------- ANIMAL ---------\n" +
                $"Nom: {Nom}\nSuperfamília: {Superfamilia}\nEspècie: {Especie}\nPes aproximat: {PesAproximat}kg";
        }
    }
}