class Program
{
    static void Main()
    {
        // 1. Véhicules
        Bus b1 = new Bus(1, 60, 300, true);
        Bus b2 = new Bus(2, 60, 300, false);
        Tram t1 = new Tram(3, 120, 450, 2);
        MetroAutomatique m1 = new MetroAutomatique(4, 200, 500);

        Vehicule[] flotte = { b1, b2, t1, m1 };

        // 2. Arrêts
        Arret a1 = new Arret("Gare Centrale");
        Arret a2 = new Arret("Université");
        Arret a3 = new Arret("Marché");

        a1.AjouterPassagers(10);
        a2.AjouterPassagers(6);
        a3.AjouterPassagers(8);

        Arret[] arrets = { a1, a2, a3 };

        // 3. Ligne
        Ligne ligne = new Ligne(42, arrets, flotte);

        // 4. Puissance max
        Console.WriteLine(Moteur.GetPuissanceMax());

        // 5. Démarrage
        ligne.LancerService();

        // 6. Simulation
        ligne.SimulerTour();

        // 7. Exception vitesse
        try
        {
            b1.Accelerer(40);
            b1.Freiner(1000); // provoque exception indirecte si hors limites
        }
        catch (Exception e)
        {
            Console.WriteLine("Erreur vitesse : " + e.Message);
        }

        // 8. GPS
        b1.ActualiserPosition(50.85, 4.35);
        Console.WriteLine($"Position Bus 1 : {b1.Latitude}, {b1.Longitude}");

        // 9. Type véhicules
        foreach (var v in flotte)
            Console.WriteLine(v.GetTypeVehicule());

        // 10. Incident métro
        foreach (var v in flotte)
        {
            if (v is MetroAutomatique metro)
                metro.SignalerIncident("Porte bloquée");
        }
    }
}