using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapisivanjeuTekstualniDokument
{
    class Program
    {
        static void Main()
        {


            string[] lines = { "First line", "Second line", "Third line" };

            System.IO.File.WriteAllLines(@"C:\Users\korisnik\Desktop\Škola\progamiranje.txt", lines);


            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";

            System.IO.File.WriteAllText(@"C:\Users\korisnik\Desktop\Škola\progamiranje.txt", text);

            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\korisnik\\Desktop\Škola\programiranje2.txt"))
            {
                foreach (string line in lines)
                {
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
        }
    }
}