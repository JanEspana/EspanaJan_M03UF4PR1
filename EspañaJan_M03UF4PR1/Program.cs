using System;
namespace JanEspaña_M03UF4_PR1
{
    public class Program
    {
        public static void Main()
        {
            Jugador jugador = new Jugador("", "", 0);
            TortugaMarina tortuga = new TortugaMarina("Toni", "Tortuga verd", "Tortuga marina", 40.5, AAnimal.RandomGA());
            Cetaci orca = new Cetaci("Alberto", "Orca", "Cetaci", 5000, AAnimal.RandomGA());
            AuMarina albatros = new AuMarina("Esteban", "Albatros", "Au marina", 8, AAnimal.RandomGA());
            FitxaRescat fitxa = new FitxaRescat("RES" + FitxaRescat.NumRescatRandom(), "02-03-2024", "Andorra");

            Console.WriteLine("SAVE THE OCEAN\nQuè vols fer?\n1. Jugar\n2. Sortir");
            jugador.Jugar(Convert.ToInt32(Console.ReadLine()));
            if (jugador.Joc)
            {
                Console.WriteLine("Perfecte! Quin carrec vols?\n1. Tècnic (45XP)\n2. Veterinari (80XP)");
                jugador.EscollirCarrec(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Genial! I el teu nom?");
                jugador.EscollirNom(Console.ReadLine());

                Console.WriteLine("Benvingut/da " + jugador.Nom + ", ets un " + jugador.Carrec + " amb " + jugador.PtExp + " punts d'experiència.");
                Console.WriteLine("El 112 ha rebut una trucada d’avís d’un exemplar a rescatar." +
                    "\nLes dades que ens han donat són les següents:\n");

                if (FitxaRescat.AnimalRandom() == 1)
                {
                    fitxa.Animal = tortuga;
                }
                else if (FitxaRescat.AnimalRandom() == 2)
                {
                    fitxa.Animal = orca;
                }
                else
                {
                    fitxa.Animal = albatros;
                }
                Console.WriteLine(fitxa.ToString());
                Console.WriteLine("\nTambé tens la fitxa de l'animal:\n");
                if (fitxa.Animal == tortuga)
                {
                    Console.WriteLine(tortuga.ToString());

                    Console.WriteLine("La tortuga té un grau d'afectació de "
                    + orca.GA + "%. Vols curarla (1) o traslladar-la al centre (2)?");
                    fitxa.Curar(Convert.ToInt32(Console.ReadLine()));
                    if (fitxa.CurarAlCentre)
                    {
                        Console.WriteLine("L'animal ha estat traslladat al centre.");
                    }
                    else
                    {
                        Console.WriteLine(".");
                    }
                    tortuga.GA = tortuga.CalcularGA();
                    Console.WriteLine($"La tortuga té un grau d'afectació de {tortuga.GA}%.");
                }
                else if (fitxa.Animal == orca)
                {
                    Console.WriteLine(orca.ToString());

                    Console.WriteLine("La orca té un grau d'afectació de "
                    + orca.GA + "%. Vols curarla (1) o traslladar-la al centre (2)?");
                    fitxa.Curar(Convert.ToInt32(Console.ReadLine()));
                    if (fitxa.CurarAlCentre)
                    {
                        Console.WriteLine("L'animal ha estat traslladat al centre.");
                    }
                    else
                    {
                        Console.WriteLine("La has curat al lloc.");
                    }
                    orca.GA = orca.CalcularGA(fitxa.CurarAlCentre);
                    Console.WriteLine($"La orca té un grau d'afectació de {orca.GA}%.");
                }
                else
                {
                    Console.WriteLine(albatros.ToString());

                    Console.WriteLine("L'albatros té un grau d'afectació de " +
                        albatros.GA + "%. Vols curar-lo (1) o traslladar-lo al centre (2)?");
                    fitxa.Curar(Convert.ToInt32(Console.ReadLine()));
                    if (fitxa.CurarAlCentre)
                    {
                        Console.WriteLine("L'animal ha estat traslladat al centre.");
                    }
                    else
                    {
                        Console.WriteLine("L'has curat al lloc.");
                    }
                    albatros.GA = albatros.CalcularGA(fitxa.CurarAlCentre);
                    Console.WriteLine($"L'albatros té un grau d'afectació de {albatros.GA}%.");
                }
                fitxa.VeredicteFinal();
                if (fitxa.Curat)
                {
                    Console.Write("Has guanyat 50XP!");
                    jugador.PtExp += 50;
                }
                else
                {
                    Console.WriteLine("Has perdut 20XP...");
                    jugador.PtExp -= 20;
                }
                Console.WriteLine(jugador.ToString());
            }
        }
    }
}