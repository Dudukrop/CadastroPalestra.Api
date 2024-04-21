using MySqlConnector;

namespace CadastroPalestra.Data
{
    public static class ProductionConnection
    {
        public static string BuildConnectionString(string databaseUrl)
        {
            var databaseUri = new Uri(databaseUrl);
            var userInfo = databaseUri.UserInfo.Split(':');
            var builder = new MySqlConnectionStringBuilder
            {
                Server = databaseUri.Host,
                Port = Convert.ToUInt32(databaseUri.Port),
                UserID = userInfo[0],
                Password = userInfo[1],
                Database = databaseUri.LocalPath.TrimStart('/'),
                SslMode = MySqlSslMode.Required
            };
            return builder.ToString();
        }
    }
}
