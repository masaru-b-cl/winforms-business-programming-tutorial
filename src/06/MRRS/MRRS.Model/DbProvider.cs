using System.Configuration;
using System.Data;
using System.Data.Common;

namespace MRRS.Model
{
    /// <summary>
    /// DBに関する機能を提供します。
    /// </summary>
    internal static class DbProvider
    {
        /// <summary>
        /// DB接続を作成します。
        /// </summary>
        /// <returns>作成したDB接続。</returns>
        public static IDbConnection CreateConnection()
        {
            var connectionStringSettings = ConfigurationManager.ConnectionStrings["MRRS"];
            var factory = DbProviderFactories.GetFactory(connectionStringSettings.ProviderName);
            var conn = factory.CreateConnection();
            conn.ConnectionString = connectionStringSettings.ConnectionString;
            return conn;
        }
    }
}
