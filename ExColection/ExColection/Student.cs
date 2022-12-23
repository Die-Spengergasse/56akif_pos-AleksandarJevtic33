using Newtonsoft.Json;
using System.Xml.Linq;

namespace ExColection.App
{
    public class Student :Person
    {
        // TODO: Erstelle ein Proeprty KlasseNavigation vom Typ Klasse, welches auf
        //       die Klasse des Schülers zeigt.
        // Füge dann über das Proeprty die Zeile
        // [JsonIgnore]
        // ein, damit der JSON Serializer das Objekt ausgeben kann.
        [JsonIgnore] //damit nicht eine endliche rekursion passiert
        public SchoolClass KlasseNavigation { get; set; } = new();
        public int Id { get; set; }
        
        //ausgabe voller name mit Property
        

        public override string GetArriveType
        {
            get { return "Kommt mit Zug"; }
        }

        public new string ArrivesAtSchoolWith()
        {
            return "Kommt mit Bagger";
        }

        public override int KatzenAnzahl()
        {
            return base.KatzenAnzahl() +1;
        }

        //Bedingung Studiendauer muss mind 1 Jahr max 7 Jahre betragen
        public int MaximaleStudiendauer
        {
            get { return _maximaleStudiendauer; }
            set
            {
                if(value >= 1 && value <= 7)
                {
                    _maximaleStudiendauer = value;
                }
                else
                {
                    throw new ArgumentException("Nicht im gültigen bereich");
                }
            }
        }
        private int _maximaleStudiendauer;
        /// <summary>
        /// Ändert die Klassenzugehörigkeit, indem der Schüler
        /// aus der alten Klasse, die in KlasseNavigation gespeichert ist, entfernt wird.
        /// Danach wird der Schüler in die neue Klasse mit der korrekten Navigation eingefügt.
        /// </summary>
        /// <param name="k"></param>
        public void ChangeKlasse(SchoolClass k)
        {
            // HIER DEN CODE EINFÜGEN
                KlasseNavigation.Schuelers.Remove(this);
                //KlasseNavigation = k; //der Schüler wird schon gesetzt
                //k.Schuelers.Add(this);
                k.AddSchueler(this); // mit der scxhon geschriebenen methode
           
        }
    }
}
