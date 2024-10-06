namespace Opdracht_Boekenwinkel
{
    public class Boek
    {
        public string Isbn { get; set; }
        public string Naam { get; set; }
        public string Uitgever { get; set; }
        private decimal prijs;

        public decimal Prijs
        {
            get { return prijs; }
            set
            {
                if (value < 5 || value > 50)
                    throw new ArgumentOutOfRangeException("Prijs moet tussen 5€ en 50€ liggen.");
                prijs = value;
            }
        }

        public Boek(string isbn, string naam, string uitgever, decimal prijs)
        {
            Isbn = isbn;
            Naam = naam;
            Uitgever = uitgever;
            Prijs = prijs;
        }

        public override string ToString()
        {
            return $"ISBN: {Isbn}, Naam: {Naam}, Uitgever: {Uitgever}, Prijs: {Prijs}€";
        }

        public void Lees()
        {
            Console.WriteLine("Geef ISBN:");
            Isbn = Console.ReadLine();
            Console.WriteLine("Geef Naam:");
            Naam = Console.ReadLine();
            Console.WriteLine("Geef Uitgever:");
            Uitgever = Console.ReadLine();
            Console.WriteLine("Geef Prijs (tussen 5 en 50):");
            Prijs = Convert.ToDecimal(Console.ReadLine());
        }
    }
}