class JeuVideo
{
    private string titre = string.Empty;
    private string studio = string.Empty;
    private double prix;

    // Getters 
    public string GetTitre()
    {
        return this.titre;
    }
    public string GetStudio()
    {
        return this.studio;
    }
    public double GetPrix()
    {
        return this.prix;
    }

    // Setters
    public void SetTitre(string titre)
    {
        this.titre = titre;
    }
    public void SetStudio(string studio)
    {
        this.studio = studio;
    }
    public void SetPrix(double prix)
    {
        this.prix = prix;
    }

    // Constructeur vide 
    public JeuVideo()
    {

    }

    // Constructeur Complet 
    public JeuVideo(string titre, string studio, double prix)
    {
        this.titre = titre;
        this.studio = studio;
        this.prix = prix;
    }


}