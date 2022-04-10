using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public enum TipKlijenta
    {
        Privatni,
        Poslovni
    }

    public interface IKlijent
    {
        string Opis { get; }
        TipKlijenta Tip { get; }
        Osoba Osoba { get; }
    }
}
