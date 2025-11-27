namespace TaskRunner.SQL
{
    internal class SqlConn
    {
        private static string server;
        private static string username = "sa";
        private static string password = "SA_0bjetiva";
        private static string database = "Empresario";
        public static void setServer(string serverName)
        {
            server = serverName;
        }

        public static string ConnString
        {

            get
            {
                return "Data Source=" + server +
                    "; Integrated Security = true" +
                    "; User ID=" + username +
                    "; Password=" + password +
                    "; Initial Catalog=" + database;
            }
        }
    }
}
