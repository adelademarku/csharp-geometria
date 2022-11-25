// See https://aka.ms/new-console-template for more information
using BonusGeometria;


BonusRettangolo primoRettangolo = new BonusRettangolo();

///Chiedo le informazioni al utente 
Console.WriteLine("inserisci base del rettangolo");

primoRettangolo.baseRettangolo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserisci altezza del rettangolo");

primoRettangolo.altezzaRettangolo = Convert.ToInt32(Console.ReadLine());

primoRettangolo.perimetroRettangolo = primoRettangolo.CalcolaPerimetro();
primoRettangolo.areaRettangolo = primoRettangolo.CalcolaArea();

//Stampo tutte le informazioni del primo rettangolo

Console.WriteLine("Vediamo le informazione del primo rettangolo: ");
primoRettangolo.StampaRettangolo();
Console.WriteLine("Stampo il disegno");
primoRettangolo.StampaDisegnoRettangolo();