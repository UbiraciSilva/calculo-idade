using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnoMesNascimento
{
    internal class Idade
    {
        public Idade(int anos, int meses, int dias)
        {
            Anos = anos;
            Meses = meses;
            Dias = dias;
        }

        public int Anos { get; set; }
        public int Meses { get; set; }

        public int Dias { get; set; }
    }
}
