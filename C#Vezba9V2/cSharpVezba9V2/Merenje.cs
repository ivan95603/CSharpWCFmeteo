using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpVezba9V2
{
    class Merenje
    {
        

        private string stanica;
        private int vrednost;
        private DateTime vreme;

        public Merenje(string stanica, int vrednost, DateTime vreme)
        {
            if (stanica == null) throw new ArgumentNullException(nameof(stanica));
            this.stanica = stanica;
            this.vrednost = vrednost;
            this.vreme = vreme;
        }

        public string Stanica
        {
            get { return stanica; }
            set { stanica = value; }
        }

        public int Vrednost
        {
            get { return vrednost; }
            set { vrednost = value; }
        }

        public DateTime Vreme
        {
            get { return vreme; }
            set { vreme = value; }
        }

        public override string ToString()
        {
            return string.Format("Uspesno dodato merenje sa stanice {0} vrednosti {1} datum {2}", this.Stanica, this.Vrednost, this.Vreme);
        }
    }
}
