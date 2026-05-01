public class MetroAutomatique : Vehicule
{
    private bool modeAutonome = true;

    public MetroAutomatique(int numero, int capacite, int puissance)
        : base(numero, capacite, puissance) { }

    public override void Demarrer()
    {
        Console.WriteLine($"Metro {Numero} - activation du pilote automatique");
    }

    public override string GetTypeVehicule() => "Metro Automatique";

    public void SignalerIncident(string description)
    {
        Console.WriteLine($"[INCIDENT Metro {Numero}] : {description}");
    }
}