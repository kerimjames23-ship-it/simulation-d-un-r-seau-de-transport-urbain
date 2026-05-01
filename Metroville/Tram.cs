public class Tram : Vehicule
{
    private int numeroRail;

    public Tram(int numero, int capacite, int puissance, int rail)
        : base(numero, capacite, puissance)
    {
        numeroRail = rail;
    }

    public override void Demarrer()
    {
        moteur.Demarrer();
        Console.WriteLine($"Tram {Numero} sur rail {numeroRail} - prêt");
    }

    public override string GetTypeVehicule() => "Tram";
}