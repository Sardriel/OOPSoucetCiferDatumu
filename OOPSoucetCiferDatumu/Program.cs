using System;
using System.Linq;
namespace OOPSoucetCiferDatumu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime datumCas = DateTime.Today;
            Console.WriteLine("Vypisuji součty cifer v datu pro následujících 7 dní");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("{0} - {1}", datumCas.AddDays(i).ToShortDateString(), datumCas.AddDays(i).Day + datumCas.Month + datumCas.Year);
            }


            
        }
    }
}
