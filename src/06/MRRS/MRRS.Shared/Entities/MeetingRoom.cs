namespace MRRS.Shared.Entities
{
    /// <summary>
    /// 会議室のEntityクラスです。
    /// </summary>
    public class MeetingRoom
    {
        /// <summary>
        /// ID。
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// 場所。
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// 名称。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 場所ID。
        /// </summary>
        public int? LocationId => Location?.Id;

        /// <summary>
        /// 場所名称。
        /// </summary>
        public string LocationName => Location?.Name;
    }
}
