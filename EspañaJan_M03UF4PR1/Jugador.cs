namespace JanEspaña_M03UF4_PR1
{
    public class Jugador
    {
        public string Nom { get; set; }
        public bool Joc { get; set; }
        public string Carrec { get; set; }
        public int PtExp { get; set; }
        public Jugador(string nom, string carrec, int ptExp)
        {
            Nom = nom;
            Carrec = carrec;
            PtExp = ptExp;
        }
        public void Jugar(int x)
        {
            if (x == 1)
            {
                Joc = true;

            }
            else if (x == 2)
            {
                Joc = false;
                Console.WriteLine("Adeu!");
            }
            else
            {
                Console.WriteLine("Opció no vàlida, torna-ho a intentar:");
                Jugar(Convert.ToInt32(Console.ReadLine()));
            }
        }
        public void EscollirCarrec(int x)
        {
            if (x == 1)
            {
                this.Carrec = "Tècnic";
                this.PtExp = 45;
            }
            else if (x == 2)
            {
                this.Carrec = "Veterinari";
                this.PtExp = 80;
            }
            else
            {
                Console.WriteLine("Opció no vàlida, torna-ho a intentar:");
                EscollirCarrec(Convert.ToInt32(Console.ReadLine()));
            }
        }
        public void EscollirNom(string nom)
        {
            this.Nom = nom;
        }
        public override string ToString()
        {
            return $"----------- RESULTATS ------------\n" +
                $"Nom: {Nom}. Punts d'experiencia totals: {PtExp}XP.\n" +
                $"\nFins al proper rescat!";
        }
    }
}
