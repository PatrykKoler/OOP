using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class Adres
    {
        public Adres()
        {

        }
        public Adres(int adresid)
        {
            this.adresId = adresId;
        }
        public int adresId { get; private set; }
        public int adresTyp { get; set; }
        public string Ulica { get; set; }
        public string Miasto { get; set; }
        public string kodPodcztowy { get; set; }
        public string Kraj { get; set; }
    }
}
