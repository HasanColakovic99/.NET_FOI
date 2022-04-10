using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak13.Models
{
    public class Kuća
    {
        public List<Brojilo> Brojila = new List<Brojilo>();

        public Kuća()
        {
            Brojila.Add(new Brojilo("HEP_101", Brojilo.TipBrojila.Struja, 34235, 32150));
            Brojila.Add(new Brojilo("TP_222", Brojilo.TipBrojila.Plin, 11500, 10400));
            Brojila.Add(new Brojilo("VAR_123", Brojilo.TipBrojila.Voda, 16225, 16100));
        }


        private double DohvatiCijenuEnergenta (Brojilo.TipBrojila tipBrojila)
        {
            double cijena = 0;
            if(tipBrojila == Brojilo.TipBrojila.Plin)
            {
                cijena = 0.20;
            }
            else if(tipBrojila == Brojilo.TipBrojila.Struja)
            {
                cijena = 0.10;
            } 
            else 
            {
                cijena = 3.5;
            }
            return cijena;
        }

        public double IzracunajIznosZaBrojilo (Brojilo.TipBrojila tipbrojila)
        {
            double iznos = 0;
            foreach(Brojilo item in Brojila)
            {
                if (item.Tip == tipbrojila)
                    iznos = item.OcitajPotrosnju() * DohvatiCijenuEnergenta(tipbrojila);
            }
            return iznos;
        }


        public double IzracunajIznosUkupno()
        {
            double ukupno = 0;
            foreach (Brojilo item in Brojila)
            {
                ukupno += item.OcitajPotrosnju() * DohvatiCijenuEnergenta(item.Tip);
            }
            return ukupno;
        }

        public void Ispis()
        {
            Console.WriteLine($"Brojilo HEP_101 (Struja) = {IzracunajIznosZaBrojilo(Brojilo.TipBrojila.Struja)} kn\nBrojilo TP_222 (Plin) = {IzracunajIznosZaBrojilo(Brojilo.TipBrojila.Plin)} kn\nBrojilo VAR_123 (Voda) = {IzracunajIznosZaBrojilo(Brojilo.TipBrojila.Voda)} kn\n--------------------------------------------\nUKUPNO: {IzracunajIznosUkupno()} kn");
        }

    }
}
