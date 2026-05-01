public abstract class Vehicule
{
    private int numero;
    private int vitesse;
    private int capaciteMax;
    protected Moteur moteur;

    public int Numero => numero;

    public int Vitesse
    {
        get => vitesse;
        private set
        {
            if (value < 0 || value > 120)
                throw new ArgumentOutOfRangeException("Vitesse invalide");
            vitesse = value;
        }
    }

    public Vehicule(int numero, int capaciteMax, int puissanceMoteur)
    {
        this.numero = numero;
        this.capaciteMax = capaciteMax;
        moteur = new Moteur(puissanceMoteur);
        vitesse = 0;
    }

    public void Accelerer(int increment)
    {
        Vitesse = Math.Min(120, Vitesse + increment);
    }

    public void Freiner(int decrement)
    {
        Vitesse = Math.Max(0, Vitesse - decrement);
    }

    public abstract void Demarrer();
    public abstract string GetTypeVehicule();

    public void AfficherEtat()
    {
        Console.WriteLine($"Vehicule {numero} - {GetTypeVehicule()} - Vitesse: {Vitesse} km/h - Moteur: {(moteur.EstAllume() ? "Allumé" : "Éteint")}");
    }
}