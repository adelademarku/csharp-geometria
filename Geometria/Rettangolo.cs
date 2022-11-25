using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    //definisco la mia classe rettangoli
    public class Rettangolo

    {
        //// CARATTERISTICHE / PROPRIETA' che voglio tracciare (di un rettangolo)

        public int baseRettangolo;
        public int altezzaRettangolo;
        public int perimetroRettangolo;
        public int areaRettangolo;

        ////Metodi per calcolare perimetro e area 

        public int CalcolaPerimetro()
        {
            return (baseRettangolo + altezzaRettangolo)*2;
        }


        public int CalcolaArea()
        {
            return baseRettangolo * altezzaRettangolo;
        }

        //Metodo per stampare un rettangolo
        public void StampaRettangolo()
        {
            Console.WriteLine("Base:\t" + baseRettangolo + " cm");
            Console.WriteLine("Altezza:\t" + altezzaRettangolo + " cm");
            Console.WriteLine("Perimetro:\t" + perimetroRettangolo + " cm");
            Console.WriteLine("Area:\t" + areaRettangolo + " cm2");

        }

    }
}
