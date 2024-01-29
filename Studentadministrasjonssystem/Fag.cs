using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;


public class Fag
{
    public string Fagkode { get; set; }
    public string Fagnavn { get; set; }
    public int AntallStudiepoeng { get; set; }

    public Fag(string fagkode, string fagnavn, int antallStudiepoeng)
    {
        Fagkode = fagkode;
        Fagnavn = fagnavn;
        AntallStudiepoeng = antallStudiepoeng;
    }

    public void SkrivUtInfo()
    {
        Console.WriteLine($"Fagkode: {Fagkode}");
        Console.WriteLine($"Fagnavn: {Fagnavn}");
        Console.WriteLine($"AntallStudiepoengkode: {AntallStudiepoeng}");
    }
}

