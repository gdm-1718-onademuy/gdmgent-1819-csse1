using System;

namespace deel1_uml
{
    public class Author
    {
        // define member variables
        private string name;
        private string email;
        private char gender;

        // constructor
        public Author(string name, string email, char gender)
        {
            this.name = name;
            // TODO - Add email validation
            this.email = email;
            // gender can be male, female or none
            if (gender == 'm' || gender == 'f' || gender == 'n')
            {
                this.gender = gender;
            }
            else
            {
                Console.WriteLine("Please use a valid gender ('m' for male or 'f' for female)");
                this.gender = 'n'; // none
            }
        }

        public string getName()
        {
            return name;
        }

        public string getEmail()
        {
            return email;
        }

        public char getGender()
        {
            return gender;
        }

        public void print()
        {
            Console.WriteLine("author name: {0}, author email: {1}, author gender: {2}", name, email, gender);
        }
    }
}
