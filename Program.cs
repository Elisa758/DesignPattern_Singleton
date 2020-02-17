using System;

namespace DesignPatterns_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 musique= new Class1();
            musique.Database = DatabaseSingleton.GetInstance();

            Class2 film = new Class2();
            film.Database = DatabaseSingleton.GetInstance();
        }
    }
}
