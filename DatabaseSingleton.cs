using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace DesignPatterns_Singleton
{
    class DatabaseSingleton
    {
        private static DatabaseSingleton instance = null;
        private DatabaseSingleton()
        {
            Console.WriteLine("Création objet");
        }
        public static DatabaseSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseSingleton();
            }
            return instance;
        }
    }
}
