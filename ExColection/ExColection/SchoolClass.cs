namespace ExColection.App
{
    public class SchoolClass
    {
        // TODO: Erstelle ein Property Schuelers, welches alle Schüler der Klasse in einer
        //       Liste speichert.

        public List<Student> Schuelers = new();
        public string Name { get; set; } = string.Empty;
        public string KV { get; set; } = string.Empty;

       
        /// <summary>
        /// Fügt den Schüler zur Liste hinzu und setzt das Property KlasseNavigation
        /// des Schülers korrekt auf die aktuelle Instanz.
        /// </summary>
        /// <param name="s"></param>
        public void AddSchueler(Student s)
        {
            //Alt
            ////ist der schüler null
            //if(s is null)
            //{
            //    throw new ArgumentNullException("Schüler ist null");
            //}
            ////ist schüler bereits in liste 
            //if(Schuelers.Contains(s))
            //{
            //    throw new ArgumentException("Schüler ist schon ist schon vorhanden");
            //}
            //Schuelers.Add(s);
            //s.KlasseNavigation = this;
            //// HIER DEN CODE EINFÜGEN
            if (s != null && !Schuelers.Contains(s))
            {
                Schuelers.Add(s);
                s.KlasseNavigation = this;
            }
            else
            {
                return;
            }
        }

    }
}
