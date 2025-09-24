using System.ComponentModel;
using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Mutuu jad, Metemaatilised tehted, IF ja ELSE;


            //1. tuvasta  sisu vörduluses tühja stringiga, string andmetüüp
            Console.WriteLine("Tere Kasutaja, mis on sinu nimi");
            string nimi = Console.ReadLine();

            if (nimi == "")
            {
                Console.WriteLine("Kasutaja ei sisestanud oma nime ");
            }


            else if (nimi != "") 
            {
                Console.WriteLine("Tere " + nimi + "!");

            }
            else
            {
                Console.WriteLine("Kasutaja ei sisestanud oma nime);

            }
            //2. tuvasta arvuvahemik, võrdluses piirväärtustega, int/double/float andmetüüp
            Console.WriteLine(nimi + ", miś on sinu nimi?:  ");
            int kasutajavanus = int.Parse(Console.ReadLine());

            //2.1 mitu tingimust pesastatud if- ide adil
            // if (Kasutajavanus > 0)
            //{
            //   if ( kasatujavanus < 10)
            //    {
            //      Console.Witeline("kahjuks eneergiajooki sulle ei müüda, oleb Monsterist ilma 🍌
            //      
            // 
            //
            //
            //


















































            //4 parool, if string  andmetüüp
            Console.WriteLine("Proogrami edasiseks tõõks sisesta palun parool:");
            string paasword = Console.ReadLine();

            if (paasword == "simsaladin")
            { 
                Console.WriteLine("parool on ö")









































































