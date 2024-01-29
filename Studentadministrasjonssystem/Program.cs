class Program
{
    static void Main()
    {
        Student student1 = new Student("Arne Bjarne", 23, "Kokk", "ABC123");
        Student student2 = new Student("Karl Dhal", 25, "Bygg og Anlegg", "DEF456");

        Fag fag1 = new Fag("KOK101", "Sushimaester", 9);
        Fag fag2 = new Fag("BOA201", "Snekker", 10);
        Fag fag3 = new Fag("MAT301", "Mattematikk", 7);
        Fag fag4 = new Fag("SER401", "Service", 5);
        Fag fag5 = new Fag("ELE501", "Elektrikker", 8);

        List<Fag> fagListe = new List<Fag> { fag1, fag2, fag3, fag4, fag5 };

        student1.FagListe.AddRange(fagListe);
        student2.FagListe.AddRange(fagListe);

        Karakter karakter1 = new Karakter(student1, fag1, 'A');
        Karakter karakter2 = new Karakter(student1, fag2, 'B');
        Karakter karakter3 = new Karakter(student1, fag3, 'A');
        Karakter karakter4 = new Karakter(student1, fag4, 'A');
        Karakter karakter5 = new Karakter(student1, fag5, 'A');

        Karakter karakter6 = new Karakter(student2, fag1, 'C');
        Karakter karakter7 = new Karakter(student2, fag2, 'A');
        Karakter karakter8 = new Karakter(student2, fag3, 'B');
        Karakter karakter9 = new Karakter(student2, fag4, 'A');
        Karakter karakter10 = new Karakter(student2, fag5, 'A');

        student1.KarakterListe.AddRange(new List<Karakter> { karakter1, karakter2, karakter3, karakter4, karakter5 });
        student2.KarakterListe.AddRange(new List<Karakter> { karakter6, karakter7, karakter8, karakter9, karakter10 });

        Console.WriteLine("Informasjon om Student 1:");
        student1.SkrivUtInfo();

        Console.WriteLine("\nInformasjon om Student 2:");
        student2.SkrivUtInfo();

        Console.WriteLine("\nInformasjon om Fag 1:");
        fag1.SkrivUtInfo();

        Console.WriteLine("\nInformasjon om Fag 2:");
        fag2.SkrivUtInfo();

        Console.WriteLine("\nInformasjon om Fag 3:");
        fag3.SkrivUtInfo();

        Console.WriteLine("\nInformasjon om Fag 4:");
        fag4.SkrivUtInfo();

        Console.WriteLine("\nInformasjon om Fag 5:");
        fag5.SkrivUtInfo();

        Console.WriteLine("\nInformasjon om  Karakter 1:");
        karakter1.SkrivUtInfo();

        Console.WriteLine("\nInformasjon om Karakter 2:");
        karakter2.SkrivUtInfo();

        Console.WriteLine("\nInformasjon om  Karakter 3:");
        karakter3.SkrivUtInfo();

        Console.WriteLine("\nInformasjon om Karakter 4:");
        karakter4.SkrivUtInfo();

        Console.WriteLine("\nInformasjon om  Karakter 5:");
        karakter5.SkrivUtInfo();

        Console.WriteLine("\nInformasjon om Karakter 6:");
        karakter6.SkrivUtInfo();

        Console.WriteLine("\nInformasjon om  Karakter 7:");
        karakter7.SkrivUtInfo();

        Console.WriteLine("\nInformasjon om Karakter 8:");
        karakter8.SkrivUtInfo();

        Console.WriteLine("\nInformasjon om  Karakter 9:");
        karakter9.SkrivUtInfo();

        Console.WriteLine("\nInformasjon om Karakter 10:");
        karakter10.SkrivUtInfo();
    }
}