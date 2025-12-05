using System.Runtime.CompilerServices;

namespace TaskRunner.SQL
{
    internal class SqlConn
    {
        private static string server;
        private static string username = "sa";
        private static string password = "SA_0bjetiva";
        //private static string database = "Empresario";
        private static string database;
        public static void setServer(string serverName)
        {
            server = serverName;
        }

        public static void setDataBase(string dataBase)
        {
            database = dataBase;
        }

        public static string getDataBase()
        {
            return database;
        }

        public static string ConnString
        {

            get
            {
                return "Data Source=" + server +
                    "; User ID=" + username +
                    "; Password=" + password +
                    "; Initial Catalog=" + database;
            }
        }
    }
}
