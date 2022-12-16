using System;
using System.Collections.Generic;
using System.Text;

namespace Voorbeeld_Debuggen_Console
{
    public class Persoon
    {
        private int _rijksregisternummer;
        private string _volledigeNaam;

        public string VolledigeNaam
        {
            get { return _volledigeNaam; }
            set { _volledigeNaam = value; }
        }

        public int  Rijksregisternummer
        {
            get { return _rijksregisternummer; }
            set { _rijksregisternummer = value; }
        }

    }
}
