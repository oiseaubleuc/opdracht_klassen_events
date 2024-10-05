namespace Opdracht_Boekenwinkel;

public class Program
{
   
        static void Main(string[] args)
        {
            Boek boek1 = new Boek("123-456", "Boek A", "Uitgever A", 20m);
            Tijdschrift tijdschrift1 = new Tijdschrift("789-101", "Tijdschrift A", "Uitgever B", 10m, Verschijningsperiode.Wekelijks);

            Bestelling<Boek> bestellingBoek = new Bestelling<Boek>(boek1, 3);
            bestellingBoek.BestellingGeplaatst += Bericht => Console.WriteLine(Bericht);
            bestellingBoek.PlaatsBestelling();

            Bestelling<Tijdschrift> bestellingTijdschrift = new Bestelling<Tijdschrift>(tijdschrift1, 1, Verschijningsperiode.Wekelijks);
            bestellingTijdschrift.BestellingGeplaatst += Bericht => Console.WriteLine(Bericht);
            bestellingTijdschrift.PlaatsBestelling();
        }
}

