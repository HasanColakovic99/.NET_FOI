using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak6.Models
{
    public class Soba
    {
        public string Oznaka;
        public int Kapacitet;
        public enum StatusSobe {slobodna, rezervirana};
        public StatusSobe Status;

        public Soba(string oznaka, int kapacitet, StatusSobe status)
        {
            this.Oznaka = oznaka;
            this.Kapacitet = kapacitet;
            this.Status = status;
        }
    }
}
