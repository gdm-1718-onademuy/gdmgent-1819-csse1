using System;

namespace deel2_uml
{
    public class Student : Persoon
    {

        public string Emailadres
        {
            get;
            set;
        }

        public Opleiding Opleiding
        {
            get;
            set;
        }

        public override string GenereerWachtwoord()
        {
            return "Student - wachtwoord";
        }
    }
}