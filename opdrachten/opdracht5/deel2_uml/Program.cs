using System;

namespace deel2_uml
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gebruiker user01 = new Gebruiker();
            //user01.Gebruikersnaam = "user";
            //Console.WriteLine(user01.Gebruikersnaam);

            // create instance of Persoon class
            Persoon persoon01 = new Persoon();
            Console.WriteLine(persoon01.GenereerWachtwoord(2018000001));
        }
    }
}