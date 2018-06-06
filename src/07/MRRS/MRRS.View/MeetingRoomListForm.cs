using System;
using System.Windows.Forms;

using MRRS.Model;

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
    }
}
