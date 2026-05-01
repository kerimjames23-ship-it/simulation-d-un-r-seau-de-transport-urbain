public class Arret
{
    private string nom;
    private int passagersEnAttente;

    public string Nom => nom;

    public Arret(string nom)
    {
        this.nom = nom;
        passagersEnAttente = 0;
    }

    public void AjouterPassagers(int nb)
    {
        if (nb < 0) throw new ArgumentException("Nombre invalide");
        passagersEnAttente += nb;
    }

    public int FaireMonter(int nb)
    {
        int montes = Math.Min(nb, passagersEnAttente);
        passagersEnAttente -= montes;
        return montes;
    }

    public int GetPassagersEnAttente() => passagersEnAttente;
}