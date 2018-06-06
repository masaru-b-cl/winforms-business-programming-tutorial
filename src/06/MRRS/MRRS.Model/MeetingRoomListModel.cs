using System.Collections.Generic;
using System.Linq;

using Dapper;

using MRRS.Shared.Entities;

namespace MRRS.Model
{
    /// <summary>
    /// 会議室一覧画面のModelクラスです。
    /// </summary>
    public class MeetingRoomListModel
    {
        /// <summary>
        /// 場所コレクション。
        /// </summary>
        public IReadOnlyList<Location> Locations { get; private set; }

        /// <summary>
        /// 場所。
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// 会議室コレクション。
        /// </summary>
        public IReadOnlyList<MeetingRoom> MeetingRooms { get; private set; }

        /// <summary>
        /// 画面起動時の初期処理を行います。
        /// </summary>
        public void Initialize()
        {
            using (var conn = DbProvider.CreateConnection())
            {
                // 空の場所作成
                var emptyLocation = new Location();
                // 場所を名前順に取得
                var locations = conn.Query<Location>(@"
                    select
                     ID
                    ,NAME
                    from
                     LOCATION
                    order by
                     NAME
                    ");

                // 空の場所と取得した場所を連結する
                Locations = new[] { emptyLocation }
                    .Concat(locations)
                    .ToArray();

                // 初期値設定
                Location = emptyLocation;
            }
        }
    }
}
