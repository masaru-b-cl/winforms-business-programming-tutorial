using System;

namespace MRRS.Shared.Entities
{
    /// <summary>
    /// 予約のEntityクラスです。
    /// </summary>
    public class Reservation
    {
        /// <summary>
        /// ID。
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// 会議室。
        /// </summary>
        public MeetingRoom MeetingRoom { get; set; }

        /// <summary>
        /// 予約開始日時。
        /// </summary>
        public DateTime? ReservationStartDate{ get; set; }

        /// <summary>
        /// 予約終了日時。
        /// </summary>
        public DateTime? ReservationEndDate { get; set; }

        /// <summary>
        /// 利用者。
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 場所ID。
        /// </summary>
        public int? LocationId => MeetingRoom?.Location?.Id;

        /// <summary>
        /// 場所名称。
        /// </summary>
        public string LocationName => MeetingRoom?.Location?.Name;

        /// <summary>
        /// 会議室ID。
        /// </summary>
        public int? MeetingRoomId => MeetingRoom?.Id;

        /// <summary>
        /// 会議室名称。
        /// </summary>
        public string MeetingRoomName => MeetingRoom?.Name;
    }
}
