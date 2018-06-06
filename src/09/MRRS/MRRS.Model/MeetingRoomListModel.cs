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
                var locations = conn.SelectLocations();

                // 空の場所と取得した場所を連結する
                Locations = new[] { emptyLocation }
                    .Concat(locations)
                    .ToArray();

                // 初期値設定
                Location = emptyLocation;
            }
        }

        /// <summary>
        /// 会議室を検索します。
        /// </summary>
        public void Search()
        {
            using (var conn = DbProvider.CreateConnection())
            {
                var sql = @"
                    select
                     *
                    from
                     MEETING_ROOM MR
                      inner join LOCATION LC on LC.ID = MR.LOCATION_ID
                    ";

                if (Location.Id.HasValue)
                {
                    // 場所が指定されていたら、絞り込み条件を追加する
                    sql += @"where MR.LOCATION_ID = :LocationId";
                }

                sql += @"
                    order by
                     LC.NAME
                    ,MR.NAME
                    ";

                // 問合せ実行
                // ※DapperのMulti mapping機能を使い、会議室と場所を取得する
                MeetingRooms = conn.Query<MeetingRoom, Location, MeetingRoom>(
                    sql,
                    (meetingRoom, location) =>
                    {
                        meetingRoom.Location = location;
                        return meetingRoom;
                    },
                    new { LocationId = Location.Id }
                    )
                    .ToArray();
            }
        }
    }
}
