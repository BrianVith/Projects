namespace Fællessystem.Persistence
{
    public static class Connection
    {
        private static string connectionString = "Server=10.56.8.35;Database=B_EKSDB02_2021;User Id=B_EKS02;Password=B_OPENDB02;";
        public static string ConnectionString { get { return connectionString; } }
    }
}
