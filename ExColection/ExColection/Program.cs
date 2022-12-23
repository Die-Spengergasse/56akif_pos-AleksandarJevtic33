using System;
using System.Collections.Generic;
using System.Drawing;
using Newtonsoft.Json;

namespace ExColection.App
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SchoolClass> klassen = new Dictionary<string, SchoolClass>();
            klassen.Add("3AHIF", new SchoolClass() { Name = "3AHIF", KV = "KV1" });
            klassen.Add("3BHIF", new SchoolClass() { Name = "3BHIF", KV = "KV2" });
            klassen.Add("3CHIF", new SchoolClass() { Name = "3CHIF", KV = "KV3" });
            klassen["3AHIF"].AddSchueler(new Student() { Id = 1001, FirstName = "VN1", LastName = "ZN1", MaximaleStudiendauer = 5 });
            klassen["3AHIF"].AddSchueler(new Student() { Id = 1002, FirstName = "VN2", LastName = "ZN2", MaximaleStudiendauer = 2 });
            klassen["3AHIF"].AddSchueler(new Student() { Id = 1003, FirstName = "VN3", LastName = "ZN3", MaximaleStudiendauer = 3 });
            klassen["3BHIF"].AddSchueler(new Student() { Id = 1011, FirstName = "VN4", LastName = "ZN4", MaximaleStudiendauer = 1 });
            klassen["3BHIF"].AddSchueler(new Student() { Id = 1012, FirstName = "VN5", LastName = "ZN5", MaximaleStudiendauer = 7 });
            klassen["3BHIF"].AddSchueler(new Student() { Id = 1013, FirstName = "VN6", LastName = "ZN6", MaximaleStudiendauer = 2 });

            Student s = klassen["3AHIF"].Schuelers[0];
            Console.WriteLine($"s sitzt in der Klasse {s.KlasseNavigation.Name} mit dem KV {s.KlasseNavigation.KV}.");
            Console.WriteLine("3AHIF vor ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(klassen["3AHIF"].Schuelers));
            s.ChangeKlasse(klassen["3BHIF"]);
            Console.WriteLine("3AHIF nach ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(klassen["3AHIF"].Schuelers));
            Console.WriteLine("3BHIF nach ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(klassen["3BHIF"].Schuelers));
            Console.WriteLine($"s sitzt in der Klasse {s.KlasseNavigation.Name} mit dem KV {s.KlasseNavigation.KV}.");

            Console.WriteLine("___________________________________");

            KuerzesteStudiendauer(klassen["3BHIF"]);
            Student s1 = new Student();
            Console.WriteLine($"Hat {s1.KatzenAnzahl()} Katzen");
            Console.WriteLine(s1.ArrivesAtSchoolWith());
            Console.WriteLine(s1.GetArriveType);


        }

        private static void KuerzesteStudiendauer(SchoolClass k) //static weil in der Programm
        {
            //1. Initialiseren mit max wert 
            //2. Prüfen ob nächste dauer kleiner oder größer ist
            //2.1. Wenn größer: nichts zu tun
            //2.2 Wenn kleiner: überschreiben des neuen wert mit dem neuen minimum
            int minWert = 7;
            foreach (Student item in k.Schuelers)
            {
                if (item.MaximaleStudiendauer < minWert)
                {
                    minWert = item.MaximaleStudiendauer;
                }
            }
            Console.WriteLine($"Minimale Studiendauer in der {k?.Name ?? "unbekannt"} ist: {minWert}");
        }
    }
}
