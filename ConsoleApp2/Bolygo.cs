using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Bolygo
    {
        public string Nev { get; set; }
        public int HoldSzam { get; set; }
        public double Terfogat { get; set; }

        public Bolygo(string sorok)
        {
            string[] sor = sorok.Split(";");
            Nev = sor[0];
            HoldSzam = int.Parse(sor[1]);
            Terfogat = double.Parse(sor[2]);
        }
    }
}
