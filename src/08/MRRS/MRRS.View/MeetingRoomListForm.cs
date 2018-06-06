using System;
using System.Windows.Forms;

using MRRS.Model;
using MRRS.Shared.Entities;

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
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // 検索条件をModelに反映
            model.Location = locationBindingSource.Current as Location;

            // 検索処理
            model.Search();

            // 検索結果を画面に反映
            meetingRoomBindingSource.DataSource = model.MeetingRooms;

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
    }
}
