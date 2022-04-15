using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopisZadataka1
{
    public class RepozitorijZadataka
    {
        public List<Zadatak> Zadaci = new List<Zadatak>();

        public RepozitorijZadataka()
        {
            Zadaci.Add(new Zadatak("Zadatak 1", DateTime.Now));
            Zadaci.Add(new Zadatak("Zadatak 2", DateTime.Now));
        }
    }
}
