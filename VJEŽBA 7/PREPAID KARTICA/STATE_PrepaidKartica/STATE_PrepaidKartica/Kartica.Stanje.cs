using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PrepaidKartica
{
    partial class PrepaidKartica
    {
        public enum Stanje
        {
            NijeAktivna, 
            Aktivna,
            NemaSredstava
        }

        public enum Dogadjaj
        {
            ProdajaKartice,
            UplacenaSredstva,
            NemaSredstava,
            ImaSredstava
        }

        public Stanje TrenutnoStanje { get; set; }
        public Action[,] strojStanja;

        public void ObradiDogadjaj (Dogadjaj dogadjaj)
        {
            this.strojStanja[(int)this.TrenutnoStanje, (int)dogadjaj].Invoke();
        }

        public void DefinirajMatricuPrijelaza()
        {
            TrenutnoStanje = Stanje.NijeAktivna;

            strojStanja = new Action[3, 4]{
                // Prodaja kartice // Uplacena sredstva // Ima sredstava // Nema sredstava
                { ProdajaKartice, null, null, null}, // Aktivna
                { null, UplacenaSredstva, ImaSredstava, NemaSredstava}, // Nije aktivna
                { null, UplacenaSredstva, null, null}  // Nema sredstava
            };
        }

        private void ProdajaKartice()
        {
            TrenutnoStanje = Stanje.Aktivna;
        }

        private void UplacenaSredstva()
        {
            TrenutnoStanje = Stanje.Aktivna;
        }

        private void NemaSredstava()
        {
            if(Iznos < 0)
            {
                TrenutnoStanje = Stanje.NemaSredstava;
            }
            else
            {
                TrenutnoStanje = Stanje.Aktivna;
            }
        }

        private void ImaSredstava()
        {
            TrenutnoStanje = Stanje.Aktivna;

        }
    }
}
