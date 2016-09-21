namespace NBetting.EFMapping.Context
{
    public static class ConnectionStringProvider
    {
        public static string GetConnectionString()
        {
            return "Data Source=.\\DEV2012;Initial Catalog=NBetting;Integrated Security=True;pooling=true";
        }
    }
}
