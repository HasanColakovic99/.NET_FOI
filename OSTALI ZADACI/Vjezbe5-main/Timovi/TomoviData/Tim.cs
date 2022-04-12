using System.Collections.Generic;

namespace TomoviData
{
    public class Tim
    {
        public List<Nogometas> NogometasiTima;
        public string NazivTima { get; set; }
        public int ID_Kluba { get; set; }
        public int ID { get; set; }
        public VrstaTaktike.Taktika Taktika { get; set; }
        public Tim(int id, VrstaTaktike.Taktika taktika, string naziv, int idTima)
        {
            ID = id;
            Taktika = taktika;
            NazivTima = naziv;
            ID_Kluba = idTima;
        }

        public void DodajIgracaTimu(Nogometas nogometas)
        {
            nogometas.ID_Tima = this.ID;
            NogometasiTima.Add(nogometas);
        }
    }
}