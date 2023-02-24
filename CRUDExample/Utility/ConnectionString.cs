namespace CRUDExample.Utility
{
    public static class ConnectionString
    {

        private static string cName = "data source=DHIRAJ;initial catalog=StudentManagement;trusted_connection=true";

        public static string CName { get => cName; }
    }
}
