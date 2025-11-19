using System.Collections.ObjectModel;
using AlienUniverseDatabase.Models;

namespace AlienUniverseDatabase.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<FilmySpis> FilmySpisList { get; } = new()
    {
        new FilmySpis
        {
            TytulOrginalny = "Alien",
            TytulPolski = "Obcy – ósmy pasażer Nostromo",
            RokPremiery = 1979,
            Rezyser = "Ridley Scott",
            Scenariusz = "",
            Gatunek = "Sci-Fi / Horror",
            CzasTrwaniaMinuty = 117 ,
            IMDbOcenaOd1do10 = 8.5, 
            Postacie = ["Ellen Ripley", "Dallas", "Ash", "Lambert", "Kane"] , 
            Statek = "USCSS Nostromo",
            OpisFabuly = "Załoga statku handlowego Nostromo odbiera sygnał z nieznanej planety.\nPo lądowaniu odkrywają obcą formę życia, która zaczyna eliminować członków załogi jeden po drugim.",
            Ciekawostka = "Scena z „wyskakującym potworem” z klatki piersiowej aktora była niespodzianką dla obsady – ich reakcje są autentyczne." 
        },
        new FilmySpis
        {
            TytulOrginalny = "Aliens",
            TytulPolski = "Obcy – decydujące starcie",
            RokPremiery = 1986,
            Rezyser = "James Cameron",
            Scenariusz = "James Cameron, David Giler, Walter Hill",
            Gatunek = "Sci-Fi / Akcja / Horror",
            CzasTrwaniaMinuty = 137,
            IMDbOcenaOd1do10 = 8.4,
            Postacie = ["Ellen Ripley", "Hicks", "Newt", "Bishop", "Vasquez"],
            Statek = "USS Sulaco",
            OpisFabuly = "Ripley, jedyna ocalała z wcześniejszego ataku obcego, wraca z oddziałem kolonialnych marines\nna księżyc LV-426, by zbadać utratę kontaktu z kolonią. Wkrótce stają oko w oko z armią obcych.",
            Ciekawostka = "James Cameron napisał scenariusz podczas lotu do Londynu, tworząc tytuł, który jest liczbą mnogą słowa „Alien” – symbolicznie zapowiadając, że tym razem potworów będzie więcej."
        },

        new FilmySpis
        {
            TytulOrginalny = "Alien³",
            TytulPolski = "Obcy³",
            RokPremiery = 1992,
            Rezyser = "David Fincher",
            Scenariusz = "David Giler, Walter Hill, Larry Ferguson",
            Gatunek = "Sci-Fi / Horror",
            CzasTrwaniaMinuty = 114,
            IMDbOcenaOd1do10 = 6.5,
            Postacie = ["Ellen Ripley", "Dillon", "Clemens", "Morse", "Andrews"],
            Statek = "E.E.V. z USS Sulaco (katastrofa)",
            OpisFabuly = "Po katastrofie statku Sulaco Ripley trafia na więzienną planetę Fiorina 161,\ngdzie wkrótce pojawia się obcy. Pozbawiona broni i wsparcia, musi walczyć o życie\nwśród skazańców i odkrywa, że nosi w sobie embrion królowej obcych.",
            Ciekawostka = "David Fincher zadebiutował tym filmem jako reżyser, jednak miał ograniczoną kontrolę twórczą,\na produkcja była pełna konfliktów – reżyser później odciął się od tego projektu."
        },

        new FilmySpis
        {
            TytulOrginalny = "Alien: Resurrection",
            TytulPolski = "Obcy: Przebudzenie",
            RokPremiery = 1997,
            Rezyser = "Jean-Pierre Jeunet",
            Scenariusz = "Joss Whedon",
            Gatunek = "Sci-Fi / Horror",
            CzasTrwaniaMinuty = 109,
            IMDbOcenaOd1do10 = 6.2,
            Postacie = ["Ellen Ripley (klon)", "Call", "Johner", "Christie", "Dr. Gediman"],
            Statek = "USM Auriga",
            OpisFabuly = "Dwieście lat po śmierci Ripley naukowcy klonują ją, by wydobyć królową obcych z jej ciała.\nKlonowana Ripley zyskuje niezwykłe zdolności i wraz z grupą kosmicznych najemników\nmusi zapobiec katastrofie, gdy obcy wydostają się na wolność.",
            Ciekawostka = "Postać androidki Call gra Winona Ryder, a film miał początkowo być początkiem nowej trylogii,\nktóra jednak nigdy nie powstała."
        },

        new FilmySpis
        {
            TytulOrginalny = "Prometheus",
            TytulPolski = "Prometeusz",
            RokPremiery = 2012,
            Rezyser = "Ridley Scott",
            Scenariusz = "Jon Spaihts, Damon Lindelof",
            Gatunek = "Sci-Fi / Thriller",
            CzasTrwaniaMinuty = 124,
            IMDbOcenaOd1do10 = 7.0,
            Postacie = ["Elizabeth Shaw", "David", "Charlie Holloway", "Meredith Vickers"],
            Statek = "USCSS Prometheus",
            OpisFabuly = "Ekspedycja naukowa wyrusza na odległą planetę, by odkryć pochodzenie ludzkości.\nNa miejscu załoga Prometeusza odkrywa ruiny cywilizacji Inżynierów oraz coś,\nco nigdy nie powinno zostać obudzone.",
            Ciekawostka = "Ridley Scott planował, aby film stanowił zarówno prequel „Obcego”, jak i samodzielną opowieść\no powstaniu życia i człowieka – wiele elementów łączy się z mitologią obcych w sposób pośredni."
        },

        new FilmySpis
        {
            TytulOrginalny = "Alien: Covenant",
            TytulPolski = "Obcy: Przymierze",
            RokPremiery = 2017,
            Rezyser = "Ridley Scott",
            Scenariusz = "John Logan, Dante Harper",
            Gatunek = "Sci-Fi / Horror",
            CzasTrwaniaMinuty = 122,
            IMDbOcenaOd1do10 = 6.4,
            Postacie = ["Daniels", "David", "Walter", "Oram", "Tennessee"],
            Statek = "USCSS Covenant",
            OpisFabuly = "Załoga statku kolonizacyjnego Covenant odkrywa nieznaną planetę, idealną do osiedlenia.\nNa miejscu natrafiają jednak na Davida – syntetyka ocalałego z Prometeusza –\noraz nowe formy obcych stworzeń, które mogą zakończyć ludzką ekspansję w kosmosie.",
            Ciekawostka = "Film pierwotnie miał być zatytułowany „Paradise Lost”, a reżyser planował jeszcze jedną część\nłączącą fabułę z oryginalnym „Obcym” z 1979 roku."
        }
    };

    public ObservableCollection<PostacSpis> PostacSpisList { get; } = new()
    {
        new PostacSpis
        {
            ImieNazwisko = "Ellen Louise Ripley",
            Rola = "Oficer porządkowy, później specjalistka ds. bezpieczeństwa",
            Aktor = "Sigourney Weaver",
            Rasa = "Człowiek",
            RokUrodzenia = 2092,
            FunkcjaWZalodze = "Odpowiada za bezpieczeństwo załogi oraz przestrzeganie protokołów misji handlowych.",
            Charakterystyka = "Zdeterminowana, inteligentna, odporna psychicznie. Jej decyzje często ratują załogę kosztem własnego komfortu. Symbol siły i walki człowieka z nieznanym.",
            Los = "Ginęła w filmie „Alien³”, by uniemożliwić korporacji zdobycie królowej obcych. Później została sklonowana (film „Resurrection”).",
            Ciekawostka = "Sigourney Weaver była nominowana do Oscara za rolę w „Aliens” — to rzadkość w kinie sci-fi."
        },

        new PostacSpis
        {
            ImieNazwisko = "Arthur Koblenz Dallas",
            Rola = "Kapitan statku handlowego USCSS Nostromo",
            Aktor = "Tom Skerritt",
            Rasa = "Człowiek",
            RokUrodzenia = 2071,
            FunkcjaWZalodze = "Dowódca misji, odpowiedzialny za decyzje dotyczące lądowania i bezpieczeństwa załogi.",
            Charakterystyka = "Opanowany, odpowiedzialny, często stawia bezpieczeństwo załogi ponad własne emocje. Zmuszony do podjęcia trudnych decyzji w obliczu kontaktu z obcą formą życia.",
            Los = "Zginął podczas próby schwytania obcego w kanałach wentylacyjnych Nostromo.",
            Ciekawostka = "W scenariuszu oryginalnie rozważano alternatywne zakończenie, w którym Dallas zostaje odnaleziony żywy, uwięziony w kokonach obcego."
        },

        new PostacSpis
        { 
            ImieNazwisko = "Ash",
            Rola = "Oficer naukowy Nostromo",
            Aktor = "Ian Holm",
            Rasa = "Android (model Hyperdyne Systems 120-A/2)",
            RokUrodzenia = 0,
            FunkcjaWZalodze = "Odpowiada za analizę sygnałów i badania naukowe obiektów pozaziemskich.",
            Charakterystyka = "Zewnętrznie spokojny i profesjonalny, w rzeczywistości kierowany tajnymi rozkazami korporacji.",
            Los = "Zniszczony przez załogę po ujawnieniu, że jego misją było zachowanie obcego przy życiu.",
            Ciekawostka = "Ash jest pierwszym androidem w uniwersum Alien i początkiem całego wątku sztucznej inteligencji."
        },

        new PostacSpis
        {
            ImieNazwisko = "Bishop",
            Rola = "Oficer naukowy, android kolonialnych marines",
            Aktor = "Lance Henriksen",
            Rasa = "Android (model Hyperdyne 341-B)",
            RokUrodzenia = 0,
            FunkcjaWZalodze = "Zajmuje się systemami analizy danych i wspiera operacje bojowe.",
            Charakterystyka = "Empatyczny, lojalny, różni się od Asha — ma autentyczne poczucie etyki.",
            Los = "Ciężko uszkodzony przez królową obcych, później dezaktywowany.",
            Ciekawostka = "Bishop jest jednym z niewielu androidów w kinie, który naprawdę wzbudza zaufanie."
        },

        new PostacSpis
        {
            ImieNazwisko = "Jenette Vasquez",
            Rola = "Strzelec kolonialnych marines",
            Aktor = "Jenette Goldstein",
            Rasa = "Człowiek",
            RokUrodzenia = 2124,
            FunkcjaWZalodze = "Specjalistka od broni ciężkiej i operacji w ciasnych korytarzach kolonii.",
            Charakterystyka = "Odważna, twarda i zadziorna. Nie boi się śmierci i żartuje nawet w obliczu zagrożenia.",
            Los = "Poświęca życie, wysadzając korytarz pełen obcych, by uratować innych marines.",
            Ciekawostka = "Postać Vasquez była wzorem dla wielu późniejszych bohaterek gier i filmów sci-fi."
        },

        new PostacSpis
        {
            ImieNazwisko = "Rebecca \"Newt\" Jorden",
            Rola = "Jedyna ocalała z kolonii Hadley’s Hope",
            Aktor = "Carrie Henn",
            Rasa = "Człowiek",
            RokUrodzenia = 2172,
            FunkcjaWZalodze = "Nieformalna towarzyszka Ripley, dziecko, które przetrwało atak ksenomorfów.",
            Charakterystyka = "Sprytna, cicha, zaskakująco odporna psychicznie mimo wieku.",
            Los = "Ginęła w katastrofie statku Sulaco (początek „Alien³”).",
            Ciekawostka = "Carrie Henn po tym filmie nigdy więcej nie wystąpiła w żadnym filmie."
        },

        new PostacSpis
        {
            ImieNazwisko = "The Queen Alien",
            Rola = "Matka i królowa ksenomorfów",
            Aktor = "efekty praktyczne i animatronics",
            Rasa = "Obcy (Ksenomorf Królowa)",
            RokUrodzenia = 0,
            FunkcjaWZalodze = "Nie dotyczy — centralna postać hierarchii obcych, odpowiedzialna za składanie jaj.",
            Charakterystyka = "Niezwykle inteligentna, agresywna, pełna instynktu macierzyńskiego.",
            Los = "Zniszczona przez Ripley w ładowni statku Sulaco, ponownie klonowana w „Resurrection”.",
            Ciekawostka = "Do animacji Królowej Obcych użyto modelu o wysokości ponad 4 metrów."
        },

        new PostacSpis
        {
            ImieNazwisko = "Annalee Call",
            Rola = "Członkini załogi statku Betty",
            Aktor = "Winona Ryder",
            Rasa = "Android (model Auton – stworzony przez androidy)",
            RokUrodzenia = 2381,
            FunkcjaWZalodze = "Specjalistka ds. techniki i hakowania systemów wojskowych.",
            Charakterystyka = "Empatyczna, emocjonalna, wykazuje moralność bardziej ludzką niż większość ludzi.",
            Los = "Przeżywa i opuszcza Ziemię wraz z klonem Ripley.",
            Ciekawostka = "Call to pierwszy android w serii, który został stworzony przez inne androidy."
        },

        new PostacSpis
        {
            ImieNazwisko = "Ripley 8",
            Rola = "Klon Ellen Ripley z DNA królowej obcych",
            Aktor = "Sigourney Weaver",
            Rasa = "Hybryda (Człowiek / Obcy)",
            RokUrodzenia = 2381,
            FunkcjaWZalodze = "Pomaga załodze Betty w walce z obcymi na statku USM Auriga.",
            Charakterystyka = "Silna fizycznie i emocjonalnie, rozdarta między naturą człowieka i obcego.",
            Los = "Przeżywa wydarzenia filmu, ale nie ufa już ani ludziom, ani korporacjom.",
            Ciekawostka = "Ma kwaśną krew i zdolności nadludzkie, będąc symbolicznym połączeniem dwóch światów."
        },

        new PostacSpis
        {
            ImieNazwisko = "The Engineer",
            Rola = "Starożytna istota – stwórca ludzi",
            Aktor = "Ian Whyte",
            Rasa = "Inżynier",
            RokUrodzenia = 0,
            FunkcjaWZalodze = "Nie jest członkiem załogi – reprezentuje cywilizację twórców, którzy stworzyli życie na Ziemi.",
            Charakterystyka = "Milczący, majestatyczny, potężny. Symbol boskiej pychy.",
            Los = "Budzi się z hibernacji i morduje członków misji Prometeusza, po czym ginie.",
            Ciekawostka = "Postać Inżyniera łączy mit o stworzeniu człowieka z początkiem gatunku Obcych."
        },

        new PostacSpis
        {
            ImieNazwisko = "Neomorph",
            Rola = "Forma pośrednia między stworzeniem Davida a ksenomorfem",
            Aktor = "CGI / efekty komputerowe",
            Rasa = "Obcy (mutant)",
            RokUrodzenia = 0,
            FunkcjaWZalodze = "Nie dotyczy — stworzenie eksperymentalne Davida, symbol błędu ewolucji.",
            Charakterystyka = "Nieprzewidywalny, szybki i niestabilny biologicznie.",
            Los = "Zabity przez załogę Covenant.",
            Ciekawostka = "Neomorphy były inspirowane koncepcją „białego drapieżcy” z natury — połączeniem piękna i grozy."
        },

            new PostacSpis
        {
            ImieNazwisko = "Daniels Branson",
            Rola = "Oficer kolonizacyjny",
            Aktor = "Katherine Waterston",
            Rasa = "Człowiek",
            RokUrodzenia = 2100,
            FunkcjaWZalodze = "Projektantka kolonii, kieruje działaniami terraformacyjnymi.",
            Charakterystyka = "Pragmatyczna, ale odważna i zdeterminowana.",
            Los = "Zostaje uśpiona w kapsule przez Davida, który podszywa się pod androida Waltera.",
            Ciekawostka = "Scott chciał, by Daniels była symbolicznym „nowym początkiem” linii bohaterek."
        },
    };
}