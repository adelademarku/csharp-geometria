using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusGeometria
{
    public class BonusRettangolo
    {
        //// CARATTERISTICHE / PROPRIETA' che voglio tracciare (di un rettangolo)

        public int baseRettangolo;
        public int altezzaRettangolo;
        public int perimetroRettangolo;
        public int areaRettangolo;

        ////Metodi per calcolare perimetro e area 

        public int CalcolaPerimetro()
        {
            return (baseRettangolo + altezzaRettangolo) * 2;
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

        //Metodo per stampare la figura del rettangolo 
      
        public void StampaDisegnoRettangolo()
        {
            Console.Write(" ");

            for (int i = 1; i <= baseRettangolo; i++)
            {
                for (int j = 1; j <= altezzaRettangolo; j++)
                {
                    if (i == 1 || i == baseRettangolo)  
                    {
                        Console.Write("-");
                    } else if (j == 1 || j == altezzaRettangolo)
                    {
                        Console.WriteLine("|");
                    }else 
                    {
                        Console.Write("");
                    }
                }
                Console.Write("\n ");
            }
        }
    }

}





    
