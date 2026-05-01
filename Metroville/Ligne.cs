public class Ligne
{
    private int numeroLigne;
    private Arret[] arrets;
    private Vehicule[] vehicules;

    public Ligne(int num, Arret[] arrets, Vehicule[] vehicules)
    {
        numeroLigne = num;
        this.arrets = arrets;
        this.vehicules = vehicules;
    }

    public void LancerService()
    {
        foreach (var v in vehicules)
            v.Demarrer();
    }

    public void SimulerTour()
    {
        foreach (var v in vehicules)
        {
            foreach (var a in arrets)
            {
                int montes = a.FaireMonter(5);
                Console.WriteLine($"{montes} passagers montent à {a.Nom}");
                v.AfficherEtat();
            }
        }
    }
}