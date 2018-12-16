using System;

namespace deel3_singletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonDbConnect dbConnection = SingletonDbConnect.instance;
            Console.WriteLine(dbConnection);
        }
    }
}
