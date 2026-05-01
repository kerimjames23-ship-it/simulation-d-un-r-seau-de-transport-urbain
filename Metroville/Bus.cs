public class Bus : Vehicule, ILocalisable
{
    private bool estEnZonePayante;
    private double latitude;
    private double longitude;

    public double Latitude => latitude;
    public double Longitude => longitude;

    public Bus(int numero, int capacite, int puissance, bool zonePayante)
        : base(numero, capacite, puissance)
    {
        estEnZonePayante = zonePayante;
    }

    public override void Demarrer()
    {
        moteur.Demarrer();
        Console.WriteLine($"Bus {Numero} prêt - zone {(estEnZonePayante ? "payante" : "gratuite")}");
    }

    public override string GetTypeVehicule() => "Bus";

    public void ActualiserPosition(double lat, double lon)
    {
        latitude = lat;
        longitude = lon;
    }
}