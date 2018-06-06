using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using MRRS.Shared.Entities;

namespace MRRS.View
{
    /// <summary>
    /// 会議室詳細画面の単体入力エラーチェックを行います。
    /// </summary>
    public class MeetingRoomDetailValidator : IDataErrorInfo
    {
        /// <summary>
        /// エラー情報ストア。
        /// </summary>
        private IDictionary<string, string> errors = new Dictionary<string, string>();

        /// <summary>
        /// チェック対象データを使ってMeetingRoomDetailValidatorクラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="locationSelectedIndex">場所（選択インデックス）。</param>
        /// <param name="name">名称。</param>
        public MeetingRoomDetailValidator(int locationSelectedIndex, string name)
        {
            if (locationSelectedIndex == -1)
            {
                errors[nameof(Location)] = "場所を選択してください。";
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                errors[nameof(MeetingRoom.Name)] = "名称を入力してください。";
            }
        }

        /// <summary>
        /// 指定した名前を持つプロパティのエラーメッセージを取得します。
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public string this[string columnName] =>
            errors.TryGetValue(columnName, out var message) ? message : null;

        /// <summary>
        /// インスタンス単位の単体入力エラーを返します。
        /// </summary>
        public string Error => "";

        /// <summary>
        /// 単体入力エラーがあるかどうか判定します。
        /// </summary>
        public bool HasError => errors.Any();
    }
}
