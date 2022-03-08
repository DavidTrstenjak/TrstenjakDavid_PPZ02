using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrstenjakDavid_PPZ02
{
    internal class klasa1
    {
        

        class Pica
        {
            string naziv, cijena, vrstaPakiranja, kolicina;

            public string Naziv { get => naziv; set => naziv = value; }
            public string Cijena { get => cijena; set => cijena = value; }
            public string VrstaPakiranja { get => vrstaPakiranja; set => vrstaPakiranja = value; }
            public string Kolicina { get => kolicina; set => kolicina = value; }

            public Pica(string naziv, string cijena, string vrstaPakiranja, string kolicina)
            {
                Naziv = naziv;
                Cijena = cijena;
                VrstaPakiranja= vrstaPakiranja;
                Kolicina = kolicina;
            }
        }

        class Gazirano : Pica
        {
            public Gazirano(string naziv, string cijena, string vrstaPakiranja, string kolicina) : base(naziv, cijena, vrstaPakiranja, kolicina)
            {
            }
            public override string ToString()
            {
                string ispis = "Naziv pića: " + this.Naziv + " Cijena pića: " + this.Cijena + " Vrsta pakiranja: " + this.VrstaPakiranja + " Količina: " + this.Kolicina + "\n";
                return ispis;
            }
        }

        class Negazirano : Pica
        {
            public Negazirano(string naziv, string cijena, string vrstaPakiranja, string kolicina) : base(naziv, cijena, vrstaPakiranja, kolicina)
            {
            }

            public override string ToString()
            {
                string ispis = "Naziv pića: " + this.Naziv + " Cijena pića: " + this.Cijena + " Vrsta pakiranja: " + this.VrstaPakiranja + " Količina: " + this.Kolicina + "\n";
                return ispis;
            }
        }

        class Alkoholno : Pica
        {
            int postotak;
            public Alkoholno(string naziv, string cijena, string vrstaPakiranja, string kolicina) : base(naziv, cijena, vrstaPakiranja, kolicina)
            {
            }

            public override string ToString()
            {
                string ispis = "Naziv pića: " + this.Naziv + " Cijena pića: " + this.Cijena + " Vrsta pakiranja: " + this.VrstaPakiranja + " Količina: " + this.Kolicina + " Postotak alkohola: " + this.postotak + "\n";
                return ispis;
            }
        }

        
    }

    

}
