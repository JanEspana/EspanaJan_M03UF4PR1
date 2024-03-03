namespace JanEspaña_M03UF4_PR1
{
    public class TortugaMarina : AAnimal
    {
        public TortugaMarina(string nom, string especie, string superfamilia, double pesAproximat, double gA) : base(nom, especie, superfamilia, pesAproximat, gA)
        {
        }
        public double CalcularGA()
        {
            return Math.Round(GA - 3 * GA / 4 - 5);
            //He reajustat la fòrmula per a que funcioni bé.
        }
        public override string ToString()
        {
            return $"-------- ANIMAL ---------\n" +
                $"Nom: {Nom}\nSuperfamília: {Superfamilia}\nEspècie: {Especie}\nPes aproximat: {PesAproximat}kg";
        }
    }
}
