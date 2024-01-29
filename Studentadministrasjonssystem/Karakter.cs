using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Karakter
    {
        public Student Student { get; set; }
        public Fag Fag { get; set; }
        public char Karakterverdi { get; set; }

        public Karakter(Student student, Fag fag, char karakterverdi)
    {
        Student = student;
        Fag = fag;
        Karakterverdi = karakterverdi;
    }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Student: {Student.Navn} ({Student.StudentID})");
            Console.WriteLine($"Fag: {Fag.Fagnavn} ({Fag.Fagkode})");
            Console.WriteLine($"Karakterverdi: {Karakterverdi}");
        }
}

