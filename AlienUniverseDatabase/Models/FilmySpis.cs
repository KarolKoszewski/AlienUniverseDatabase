namespace AlienUniverseDatabase.Models;

public class FilmySpis
{
    public string TytulOrginalny { get; set; } = "";
    public string TytulPolski { get; set; } = "";
    public int RokPremiery { get; set; } = 0;
    public string Rezyser { get; set; } = "";
    public string Scenariusz { get; set; } = "";
    public string Gatunek { get; set; } = "";
    public int CzasTrwaniaMinuty { get; set; } = 0;
    public int IMDbOcenaOd1do10 { get; set; } = 0;
    public string GlownePostacie { get; set; } = "";
    public string Statek { get; set; } = "";
}