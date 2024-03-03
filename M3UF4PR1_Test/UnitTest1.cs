using JanEspaña_M03UF4_PR1;
namespace M03UF4PR1_Test
{
    [TestClass]
    public class TestFitxaRescat
    {
        [TestMethod]
        public void CurarTest1()
        {
            FitxaRescat fr = new FitxaRescat("RES" + FitxaRescat.NumRescatRandom(), "02-03-2024", "Andorra");
            fr.Curar(1);
            Assert.IsFalse(fr.CurarAlCentre);
        }
        [TestMethod]
        public void CurarTest2()
        {
            FitxaRescat fr = new FitxaRescat("RES" + FitxaRescat.NumRescatRandom(), "02-03-2024", "Andorra");
            fr.Curar(2);
            Assert.IsTrue(fr.CurarAlCentre);
        }
        [TestMethod]
        public void VeredicteFinalTest1()
        {
            TortugaMarina tortuga = new TortugaMarina("Toni", "Tortuga verd", "Tortuga marina", 40.5, AAnimal.RandomGA());
            FitxaRescat fr = new FitxaRescat("RES" + FitxaRescat.NumRescatRandom(), "02-03-2024", "Andorra");
            fr.Animal = tortuga;
            tortuga.GA = 40;
            fr.VeredicteFinal();
            Assert.IsFalse(fr.Curat);
        }
        [TestMethod]
        public void VeredicteFinalTest2()
        {
            TortugaMarina tortuga = new TortugaMarina("Toni", "Tortuga verd", "Tortuga marina", 40.5, AAnimal.RandomGA());
            FitxaRescat fr = new FitxaRescat("RES" + FitxaRescat.NumRescatRandom(), "02-03-2024", "Andorra");
            fr.Animal = tortuga;
            tortuga.GA = 3;
            fr.VeredicteFinal();
            Assert.IsTrue(fr.Curat);
        }
    }
    [TestClass]
    public class TestTortugaMarina
    {
        [TestMethod]
        public void CalcularGATest()
        {
            TortugaMarina tortuga = new TortugaMarina("Toni", "Tortuga verd", "Tortuga marina", 40.5, 40);
            Assert.AreEqual(32, tortuga.CalcularGA());
        }
        [TestMethod]
        public void ToStringTest1()
        {
            TortugaMarina tortuga = new TortugaMarina("Toni", "Tortuga verd", "Tortuga marina", 40.5, 3);
            string result = $"-------- ANIMAL ---------" +
                $"Nom: {tortuga.Nom}\nSuperfamília: {tortuga.Superfamilia}" +
                $"\nEspècie: {tortuga.Especie}\nPes aproximat: {tortuga.PesAproximat}kg";
            Assert.AreEqual(result, tortuga.ToString());
        }
    }
    [TestClass]
    public class TestAuMarina
    {
        [TestMethod]
        public void CalcularGATest()
        {
            AuMarina au = new AuMarina("Esteban", "Albatros", "Au marina", 8, 40);
            Assert.AreEqual(24, au.CalcularGA(false));
        }
        [TestMethod]
        public void CalcularGATest2()
        {
            AuMarina au = new AuMarina("Esteban", "Albatros", "Au marina", 8, 40);
            Assert.AreEqual(24, au.CalcularGA(true));
        }
        [TestMethod]
        public void ToStringTest1()
        {
            AuMarina au = new AuMarina("Esteban", "Albatros", "Au marina", 8, 40);
            string result = $"-------- ANIMAL ---------" +
                $"Nom: {au.Nom}\nSuperfamília: {au.Superfamilia}" +
                $"\nEspècie: {au.Especie}\nPes aproximat: {au.PesAproximat}kg";
            Assert.AreEqual(result, au.ToString());
        }
    }
    [TestClass]
    public class TestCetaci
    {
        [TestMethod]
        public void CalcularGATest()
        {
            Cetaci cetaci = new Cetaci("Alberto", "Orca", "Cetaci", 5000, 99);
            Assert.AreEqual(97, cetaci.CalcularGA(true));
        }
        [TestMethod]
        public void CalcularGATest2()
        {
            Cetaci cetaci = new Cetaci("Alberto", "Orca", "Cetaci", 5000, 99);
            Assert.AreEqual(72, cetaci.CalcularGA(false));
        }
        [TestMethod]
        public void ToStringTest1()
        {
            Cetaci cetaci = new Cetaci("Alberto", "Orca", "Cetaci", 5000, 90);
            string result = $"-------- ANIMAL ---------" +
                $"Nom: {cetaci.Nom}\nSuperfamília: {cetaci.Superfamilia}" +
                $"\nEspècie: {cetaci.Especie}\nPes aproximat: {cetaci.PesAproximat}kg";
            Assert.AreEqual(result, cetaci.ToString());
        }
    }
    [TestClass]
    public class TestJugador
    {
        [TestMethod]
        public void JugarTest1()
        {
            Jugador jugador = new Jugador("", "", 0);
            jugador.Jugar(1);
            Assert.IsTrue(jugador.Joc);
        }
        [TestMethod]
        public void JugarTest2()
        {
            Jugador jugador = new Jugador("", "", 0);
            jugador.Jugar(2);
            Assert.IsFalse(jugador.Joc);
        }
        [TestMethod]
        public void EscollirCarrecTest1()
        {
            Jugador jugador = new Jugador("", "", 0);
            jugador.EscollirCarrec(1);
            Assert.AreEqual("Tècnic", jugador.Carrec);
        }
        [TestMethod]
        public void EscollirCarrecTest2()
        {
            Jugador jugador = new Jugador("", "", 0);
            jugador.EscollirCarrec(2);
            Assert.AreEqual("Veterinari", jugador.Carrec);
        }
        [TestMethod]
        public void EscollirNomTest()
        {
            Jugador jugador = new Jugador("", "", 0);
            jugador.EscollirNom("Jan");
            Assert.AreEqual("Jan", jugador.Nom);
        }
        [TestMethod]
        public void ToStringTest1()
        {
            Jugador jugador = new Jugador("Jan", "Veterinari", 80);
            string result = $"----------- RESULTATS ------------\n" +
                $"Nom: {jugador.Nom}. Punts d'experiencia totals: {jugador.PtExp}XP.\n" +
                $"\nFins al proper rescat!";
            Assert.AreEqual(result, jugador.ToString());
        }
    }
}