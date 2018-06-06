using System.Collections.Generic;
using System.Data;

using Dapper;

using MRRS.Shared.Entities;

namespace MRRS.Model
{
    internal static class ConnectionExtensions
    {
        /// <summary>
        /// 場所データを名称順に取得します。
        /// </summary>
        public static IEnumerable<Location> SelectLocations(this IDbConnection conn)
        {
            return conn.Query<Location>(@"
                    select
                     ID
                    ,NAME
                    from
                     LOCATION
                    order by
                     NAME
                    ");
        }
    }
}
