using System;
using System.Windows.Forms;

using MRRS.Model;
using MRRS.Shared.Entities;
using System.Linq;

namespace MRRS.View
{
    public partial class MeetingRoomListForm : Form
    {
        private MeetingRoomListModel model = new MeetingRoomListModel();

        public MeetingRoomListForm()
        {
            InitializeComponent();
        }

        private void MeetingRoomListForm_Load(object sender, EventArgs e)
        {
            // 初期処理
            model.Initialize();

            // 画面に反映
            locationBindingSource.DataSource = model.Locations;

            // 初期フォーカス設定
            ActiveControl = locationComboBox;
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            using (var form = new MeetingRoomDetailForm(EditMode.AddNew))
            {
                var dialogResult = form.ShowDialog();

                if (
                   dialogResult == DialogResult.OK &&
                   model.MeetingRooms.Any()
                   )
                {
                    // 検索データがあれば再検索
                    Search();
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search();

            if (model.MeetingRooms.Count == 0)
            {
                // 検索結果：データなし
                MessageBox.Show(
                    "選択した場所に会議室がありません。",
                    this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 検索処理を行います。
        /// </summary>
        private void Search()
        {
            // 検索条件をModelに反映
            model.Location = locationBindingSource.Current as Location;

            // 検索処理
            model.Search();

            // 検索結果を画面に反映
            meetingRoomBindingSource.DataSource = model.MeetingRooms;
        }

        private void meetingRoomDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // データがなければ中断
            if (e.RowIndex < 0) return;

            // クリックした列が［変更］ボタンでなければ中断
            if (e.ColumnIndex != 2 && e.ColumnIndex != 3) return;

            // 対象会議室データを取得
            var meetingRoom = meetingRoomBindingSource.Current as MeetingRoom;

            var editMode = e.ColumnIndex == 2 ? EditMode.Modify :
                                                EditMode.Delete;

            using (var form = new MeetingRoomDetailForm(editMode, meetingRoom))
            {
                var dialogResult = form.ShowDialog();

                if (
                    dialogResult == DialogResult.OK &&
                    model.MeetingRooms.Any()
                    )
                {
                    // 検索データがあれば再検索
                    Search();
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
