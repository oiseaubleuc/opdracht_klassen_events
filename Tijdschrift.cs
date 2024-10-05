namespace Opdracht_Boekenwinkel;

public enum Verschijningsperiode
{
    Dagelijks,
    Wekelijks,
    Maandelijks
}


public class Tijdschrift : Boek
{
    
        public Verschijningsperiode Periode { get; set; }

        public Tijdschrift(string isbn, string naam, string uitgever, decimal prijs, Verschijningsperiode periode)
            : base(isbn, naam, uitgever, prijs)
        {
            Periode = periode;
        }

        public override string ToString()
        {
            return base.ToString() + $", Verschijningsperiode: {Periode}";
        }

        public new void Lees()
        {
            base.Lees();
            Console.WriteLine("Geef de verschijningsperiode (Dagelijks, Wekelijks, Maandelijks):");
            Periode = (Verschijningsperiode)Enum.Parse(typeof(Verschijningsperiode), Console.ReadLine(), true);
        }
    }

