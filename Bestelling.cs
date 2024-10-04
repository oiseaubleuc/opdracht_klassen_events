namespace Opdracht_Boekenwinkel;

public class Bestelling<T>
{
    private static int _volgnummer = 0;
    public int Id { get; private set; }
    public T Item { get; set; }
    public DateTime Datum { get; set; }
    public int Aantal { get; set; }
    public Verschijningsperiode? AbonnementPeriode { get; set; }

    // Constructor
    public Bestelling(T item, int aantal, Verschijningsperiode? periode = null)
    {
        Id = ++_volgnummer;
        Item = item;
        Aantal = aantal;
        Datum = DateTime.Now;
        AbonnementPeriode = periode;
    }

    // Methode die een tuple retourneert
    public (string, int, decimal) Bestel()
    {
        if (Item is Boek boek)
        {
            decimal totalePrijs = boek.Prijs * Aantal;
            return (boek.Isbn, Aantal, totalePrijs);
        }
        throw new InvalidOperationException("Item is geen boek.");
    }

    // Event voor het plaatsen van een bestelling
    public event Action<string> BestellingGeplaatst;

    // Methode die een bestelling plaatst en het event triggert
    public void PlaatsBestelling()
    {
        var bestellingInfo = Bestel();
        BestellingGeplaatst?.Invoke($"Bestelling geplaatst voor ISBN: {bestellingInfo.Item1}, Aantal: {bestellingInfo.Item2}, Totale prijs: {bestellingInfo.Item3}€");
    }
    
}