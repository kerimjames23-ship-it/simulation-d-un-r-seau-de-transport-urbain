public class Moteur
{
    private int puissance;
    private bool allume;
    private static int puissanceMax = 500;

    public Moteur(int puissance)
    {
        this.puissance = puissance;
        this.allume = false;
    }

    public void Demarrer() => allume = true;
    public void Arreter() => allume = false;
    public bool EstAllume() => allume;
    public int GetPuissance() => puissance;
    public static int GetPuissanceMax() => puissanceMax;

    public int Puissance => puissance;
}