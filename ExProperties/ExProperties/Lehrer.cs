using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExProperties
{
    public class Lehrer
    {
        //private string? _vorname;
        //private string _zuname;
        //private string _kuerzel;
        public string Vorname { get; set; } = ""; // oder string.Empty
        public string? Zuname { get; set; }

        public decimal? Bruttogehalt { get { return _bruttogehalt; }
            set
            {
                if (_bruttogehalt != null)
                {
                    _bruttogehalt = value;
                }
            }
        }
        private decimal? _bruttogehalt = null; // mit _fields damit fields bei dot zusammengefasst

        public string Kuerzel
        {
            get 
            {
                if (Zuname?.Length < 3)
                {
                    //return Zuname?.Substring(0, 3)?.ToUpper() ?? "";  // oder auch string.Empty
                    return Zuname?[..3]?.ToUpper() ?? ""; //der range parameter 
                }
                return "--";
            }
        }
        public decimal Nettogehalt
        {
            get { return _bruttogehalt * 0.8M ?? 0; }
        }
    }
}

        
    

