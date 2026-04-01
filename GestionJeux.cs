class GestionJeux
{
    // Créatioon d'une liste privée de jeux vidéo
    private List<JeuVideo> jeux;

    public GestionJeux()
    {
        this.jeux = new List<JeuVideo>();
    }
    // Méthode pour ajouter un jeu à la liste
    public void AjouterJeu(JeuVideo jeu)
    {
        this.jeux.Add(jeu);
    }   

    public void AfficherJeux()
    {
        foreach (JeuVideo jeu in this.jeux)
        {
            Console.WriteLine($"Titre: {jeu.GetTitre()}, Studio: {jeu.GetStudio()}, Prix: {jeu.GetPrix()}");
        }
    }

}