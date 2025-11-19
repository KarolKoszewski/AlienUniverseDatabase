using System.Collections.Generic;

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
    public double IMDbOcenaOd1do10 { get; set; } = 0;
    public List<string> Postacie { get; set; } = new();
    public string Statek { get; set; } = "";
    
    public string OpisFabuly { get; set; } = "";
    public string Ciekawostka { get; set; } = "";


    
}