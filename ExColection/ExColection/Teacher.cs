using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExColection.App
{
    public class Teacher : Person
    {
        public new string ArrivesAtSchoolWith()
        {
            return "Kommt mit den Fahrad an";
        }
        public override string GetArriveType
        {
            get { return "Kommt mit Boot"; }
        }
        public override int KatzenAnzahl()
        {
            return base.KatzenAnzahl() +2;
        }
    }


    
}
