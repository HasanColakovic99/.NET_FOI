using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bankomat
{
    partial class Bankomat
    {
        public enum Stanje
        {
            Mirovanje,
            ProvjeraPina,
            OdabirIznosaZaIsplatu,
            IsplataGotovine,
            BlokiranRačun
        }

        public enum Dogadjaj
        {
            KARTICA_UMETNUTA,
            PIN_UNESEN,
            IZNOS_UNESEN,
            ISPLATA_GOTOVA,
            ODUSTANI
        }

        public Stanje TrenutnoStanje { get; set; }
        private Action[,] strojStanja;

        public void ObradiDogadjaj(Dogadjaj dogadaj)
        {
            this.strojStanja[(int)this.TrenutnoStanje, (int)dogadaj].Invoke();
        }

        private void DefinirajMatricuPrijelazaStanja()
        {
            TrenutnoStanje = Stanje.Mirovanje;

            //TODO - Dopuniti konačnu matricu prijelaza stanja s pozivom odgovarajućih metoda
            //Metode su već popisane ispod, te ih treba samo pozvati, a metoda IznosUnesen je 
            //već implementirana kako bi poslužila kao primjer
            strojStanja = new Action[4, 5]
            {
                //KARTICA_UMETNUTA  //PIN UNESEN    //IZNOS UNESEN  //ISPLATA_GOTOVA    //ODUSTANI
                {KarticaUmetnuta,   null,           null,           null,               null},      //Mirovanje
                {null,              PinUnesen,      null,           null,               Odustani},      //ProvjeraPina
                {null,              null,           IznosUnesen,    null,               Odustani},      //OdabirIznosaZaIsplatu
                {null,              null,           null,          IsplataGotova,      null},      //IsplataGotovine
            };
        }

        private void KarticaUmetnuta()
        {
            TrenutnoStanje = Stanje.ProvjeraPina;
        }

        private void PinUnesen()
        {
            if(Pogreske == 3)
            {
                TrenutnoStanje = Stanje.BlokiranRačun;
            }
            else if(Pogreske < 3 && Pin != IspravanPin)
            {
                TrenutnoStanje = Stanje.ProvjeraPina;
                Pogreske++;
            }
            else if(Pin == IspravanPin)
            {
                TrenutnoStanje = Stanje.OdabirIznosaZaIsplatu;
            }
        }

        private void IznosUnesen()
        {
            if (Iznos <= MaxIznos)
            {
                TrenutnoStanje = Stanje.IsplataGotovine;
            }
            else
            {
                MessageBox.Show("Nedovoljno sredstava!");
            }
        }

        private void IsplataGotova()
        {
            TrenutnoStanje = Stanje.Mirovanje;
        }

        private void Odustani()
        {
            TrenutnoStanje = Stanje.Mirovanje;
        }
    }
}
