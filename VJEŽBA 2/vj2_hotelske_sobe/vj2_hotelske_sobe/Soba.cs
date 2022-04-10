using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vj2_hotelske_sobe
{
    public class Soba
    {
        public enum StatusSobe { slobodno, rezervirano };

        public string oznaka;
        public int kapacitet;
        public StatusSobe status;

        public Soba(string o, int k, StatusSobe s)
        {
            this.oznaka = o;
            this.kapacitet = k;
            this.status = s;
        }
    }
}
