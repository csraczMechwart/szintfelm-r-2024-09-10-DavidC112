using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foca
{
    internal class Beolvas
    {
        public Beolvas(int fordulo, int hgol, int vgol, int elsoFel, int masodikFel, string hazaiCs, string vengedCs)
        {
            this.fordulo = fordulo;
            this.hgol = hgol;
            this.vgol = vgol;
            this.elsoFel = elsoFel;
            this.masodikFel = masodikFel;
            this.hazaiCs = hazaiCs;
            this.vengedCs = vengedCs;
        }

        public int fordulo { get; set; }
        public int hgol {  get; set; }
        public int vgol { get; set; }
        public int elsoFel { get; set; }
        public int masodikFel { get; set; }
        public string hazaiCs { get; set; }
        public string vengedCs {  get; set; }

         

    }
}
