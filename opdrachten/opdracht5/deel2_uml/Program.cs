using System;

namespace deel2_uml
{
    class Program
    {
        static void Main(string[] args)
        {
            // create instance of Gebruiker class
            Gebruiker user01 = new Gebruiker();
            user01.Gebruikersnaam = "user";
            Console.WriteLine(user01.Gebruikersnaam);
        }
    }
}