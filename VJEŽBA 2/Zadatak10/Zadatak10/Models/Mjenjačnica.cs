using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak10.Models
{
    public class Mjenjačnica
    {
        public double Naknada = 0.05;
        public List<Potvrda> Potvrde = new List<Potvrda>();
        public Konverter konverter = new Konverter();
        public Potvrda PromijeniNovac(double iznos, string valuta)
        {
            double bruto = konverter.Konvertiraj(iznos, valuta);
            double razlika = bruto * Naknada;
            double neto = bruto - razlika;
            Potvrda potvrda = new Potvrda(iznos, iznos/bruto, bruto, razlika, neto);
            this.Potvrde.Add(potvrda);
            return potvrda;
        }

        public void IspisPotvrde (Potvrda potvrda)
        {
            Console.WriteLine($"Datum: {potvrda.Datum}\nIznos za promjenu: {potvrda.Kune} HRK\nPo tečaju: {potvrda.Tečaj}\nIznosi: {potvrda.Naknada}\nNaknada: {potvrda.Bruto}\n-------------------------------\nZa isplatiti: {potvrda.Isplata}");
        }
    }
}
