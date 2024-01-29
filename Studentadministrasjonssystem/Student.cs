using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Student
    {
        public string Navn { get; set; }
        public int Alder { get; set; }
        public string Studieprogram { get; set; }
        public string StudentID { get; set; }

        public List<Fag> FagListe { get; set; } = new List<Fag>();
    public List<Karakter> KarakterListe { get; set; } = new List<Karakter>();

    public Student(string navn, int alder, string studieprogram, string studentID)
        {
            Navn = navn;
            Alder = alder;
            Studieprogram = studieprogram;
            StudentID = studentID;
        }
        

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Navn: {Navn}");
            Console.WriteLine($"Alder: {Alder}");
            Console.WriteLine($"Studieprogram: {Studieprogram}");
            Console.WriteLine($"StudentID: {StudentID}");
            Console.WriteLine("Fag");
            foreach (var fag in FagListe)
            {
            Console.WriteLine($"- {fag.Fagnavn} ({fag.Fagkode})");
            }
            Console.WriteLine("Fag og karakterer:");
            foreach (var karakter in KarakterListe)
            {
                Console.WriteLine($"- {karakter.Fag.Fagnavn} ({karakter.Fag.Fagkode}): {karakter.Karakterverdi}");
            }

        double gjennomsnittskarakter = BeregnGjennomsnittskarakter();
        Console.WriteLine($"Gjennomsnittskarakter: {gjennomsnittskarakter:F2}");
         }

    public int BeregnTotalStudiepoeng()
    {
        return FagListe.Sum(fag => fag.AntallStudiepoeng);
    }

        public double BeregnGjennomsnittskarakter()
    {
        if (KarakterListe.Count == 0)
        {
            Console.WriteLine("Ingen karakter tilgjengelig for gjennomsnittsberegning.");
            return 0.0;
        }

        var karakterverdier = KarakterListe.Select(karakter => KarakterTilNumeriskVerdi(karakter.Karakterverdi)).ToList();

        double gjennomsnitt = karakterverdier.Average();

        return gjennomsnitt;
    }

    private double KarakterTilNumeriskVerdi(char karakter)
    {
        switch (char.ToUpper(karakter))
        {
            case 'A':
                return 5.0;
            case 'B':
                return 4.0;
            case 'C':
                return 3.0;
            case 'D':
                return 2.0;
            case 'E':
                return 1.0;
            default:
                return 0.0;     
             }
         }

    }

