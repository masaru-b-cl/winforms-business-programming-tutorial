using System;
using System.Collections.Generic;
using System.Linq;

using Dapper;

using MRRS.Shared.Entities;

namespace MRRS.Model
{
    /// <summary>
    /// 会議室詳細画面のModelクラスです。
    /// </summary>
    public class MeetingRoomDetailModel
    {
        public MeetingRoomDetailModel(EditMode editMode) : this(editMode, null)
        {
        }

        public MeetingRoomDetailModel(EditMode editMode, MeetingRoom meetingRoom)
        {
            EditMode = editMode;
            MeetingRoom = meetingRoom;
        }

        /// <summary>
        /// 場所コレクション。
        /// </summary>
        public IReadOnlyList<Location> Locations { get; private set; }

        /// <summary>
        /// 場所。
        /// </summary>
        public Location Location
        {
            get
            {
                return MeetingRoom.Location;
            }
            set
            {
                MeetingRoom.Location = value;
            }
        }

        /// <summary>
        /// 会議室。
        /// </summary>
        public MeetingRoom MeetingRoom { get; private set; }

        /// <summary>
        /// 編集モード。
        /// </summary>
        public EditMode EditMode { get; private set; }

        /// <summary>
        /// 画面起動時の初期処理を行います。
        /// </summary>
        public void Initialize()
        {
            using (var conn = DbProvider.CreateConnection())
            {
                // 場所を名前順に取得
                Locations = conn.SelectLocations().ToArray();

                // 初期値設定
                if (EditMode == EditMode.AddNew)
                {
                    MeetingRoom = new MeetingRoom();
                }
                else
                {
                    // 会議室の最新データを読み込む
                    MeetingRoom = conn.Query<MeetingRoom, Location, MeetingRoom>(@"
                        select
                         *
                        from
                         MEETING_ROOM MR
                          inner join LOCATION LC on LC.ID = MR.LOCATION_ID
                        where
                         MR.ID = :ID
                        ",
                        (mr, loc) => { mr.Location = loc; return mr; },
                        new { ID = MeetingRoom.Id }
                        )
                        .Single();
                }
            }
        }

        /// <summary>
        /// 会議室データを更新します。
        /// </summary>
        public void Update()
        {
            using (var conn = DbProvider.CreateConnection())
            {
                switch (EditMode)
                {
                    case EditMode.AddNew:
                        conn.Execute(@"
                            insert into MEETING_ROOM
                            (
                               ID
                              ,NAME
                              ,LOCATION_ID
                            )
                            values
                            (
                               SEQ_MEETING_ROOM_ID.NEXTVAL
                              ,:Name
                              ,:LocationId
                            )
                            ",
                            MeetingRoom);
                        break;

                    case EditMode.Modify:
                        conn.Execute(@"
                            update MEETING_ROOM
                            set
                             NAME = :Name
                            ,LOCATION_ID = :LocationId
                            where
                             ID = :Id
                            ",
                            MeetingRoom);
                        break;

                    case EditMode.Delete:
                        conn.Execute(@"
                            delete from MEETING_ROOM
                            where
                             ID = :Id
                            ",
                            MeetingRoom);
                        break;
                }
            }
        }
    }
}
