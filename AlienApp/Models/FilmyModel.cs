using System.Collections.Generic;

namespace AlienApp.Models;

public class FilmyModel
{
    public string TytulOrginalny { get; set; }
    public string TytulPolski { get; set; }
    public int RokPremiery { get; set; }
    public string Rezyser { get; set;}
    public string Scenariusz { get; set; } 
    public string Gatunek { get; set; }
    public int CzasTrwaniaMinuty { get; set; } 
    public double IMDbOcenaOd1do10 { get; set; } 
    public List<string> Postacie { get; set; }
    public string Statek { get; set; } 
    public string OpisFabuly { get; set; } 
    public string Ciekawostka { get; set; } 
}