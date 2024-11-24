using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Ornek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kimlik kml = new Kimlik();
            kml.AD = "Elyasa";
            kml.SOYAD = "Kapucu";
            kml.MEMLEKET = "Ordu";
            kml.YAŞ = 22;
            kml.CINSIYET = 'E';
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAŞ);
            Console.WriteLine(kml.CINSIYET);
            Console.Read();
        }
    }
}
