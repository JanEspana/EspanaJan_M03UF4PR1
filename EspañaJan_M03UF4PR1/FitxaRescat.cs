namespace JanEspaña_M03UF4_PR1
{
    public class FitxaRescat
    {
        public string NumRescat { get; set; }
        public string DataRescat { get; set; }
        public AAnimal Animal { get; set; }
        public string Localitzacio { get; set; }
        public bool CurarAlCentre { get; set; }
        public bool Curat { get; set; }
        public FitxaRescat(string numRescat, string dataRescat, string localitzacio)
        {
            NumRescat = numRescat;
            DataRescat = dataRescat;
            Localitzacio = localitzacio;
        }
        public static int NumRescatRandom()
        {
            Random rnd = new Random();
            return rnd.Next(1, 1000);
        }
        public static int AnimalRandom()
        {
            Random rnd = new Random();
            return rnd.Next(1, 4);
        }
        public void Curar(int x)
        {
            if (x == 1)
            {
                CurarAlCentre = false;

            }
            else if (x == 2)
            {
                CurarAlCentre = true;
            }
            else
            {
                Console.WriteLine("Opció no vàlida, torna-ho a intentar:");
                Curar(Convert.ToInt32(Console.ReadLine()));
            }
        }
        public void VeredicteFinal()
        {
            if (Animal.GA < 5)
            {
                Console.WriteLine("L'animal està llest per ser alliberat, el rescat ha sigut un èxit!.");
                Curat = true;
            }
            else
            {
                Console.WriteLine("L'animal no està llest per ser alliberat i haurà de ser enviat al CRAM.");
                Curat = false;
            }
        }
        public override string ToString()
        {
            return $"------Fitxa de rescat------\nNumero de rescat: {NumRescat}\n" +
                $"Data del rescat: {DataRescat}\nSuperfamília: {Animal.Superfamilia}\n" +
                $"Grau d'afectació: {Animal.GA}\nLocalització: {Localitzacio}";
        }
    }
}
