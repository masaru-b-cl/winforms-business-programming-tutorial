using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MRRS.Model;
using MRRS.Shared.Entities;

namespace MRRS.View
{
    public partial class MeetingRoomDetailForm : Form
    {
        public MeetingRoomDetailForm()
        {
            InitializeComponent();
        }

        private MeetingRoomDetailModel model;
        private readonly string editModeName;

        public MeetingRoomDetailForm(EditMode editMode) : this(editMode, null)
        {
        }

        public MeetingRoomDetailForm(EditMode editMode, MeetingRoom meetingRoom) : this()
        {
            model = new MeetingRoomDetailModel(editMode, meetingRoom);

            // ウィンドウタイトル設定
            editModeName =
                model.EditMode == EditMode.AddNew ? "登録" :
                model.EditMode == EditMode.Modify ? "変更" :
                                                    "削除";
        }

        private void MeetingRoomDetailForm_Load(object sender, EventArgs e)
        {
            // 初期処理
            model.Initialize();

            // 画面に反映
            locationBindingSource.DataSource = model.Locations;
            if (model.EditMode == EditMode.AddNew)
            {
                // 選択なし
                locationComboBox.SelectedIndex = -1;
            }
            else
            {
                locationComboBox.SelectedValue = model.Location.Id;
            }
            nameTextBox.Text = model.MeetingRoom.Name;

            // ウィンドウタイトル設定
            Text = $"会議室{editModeName}";

            if (model.EditMode == EditMode.Delete)
            {
                // 項目をブロック
                locationComboBox.Enabled = false;
                nameTextBox.ReadOnly = true;

                // 初期フォーカス設定
                ActiveControl = okButton;
            }
            else
            {
                // 初期フォーカス設定
                ActiveControl = locationComboBox;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // 画面の入力をModelに反映
            model.Location = locationBindingSource.Current as Location;
            model.MeetingRoom.Name = nameTextBox.Text;

            // 更新確認
            var dialogResult = MessageBox.Show(
                $"{editModeName}します。よろしいですか？",
                this.Text,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;

            // 更新処理
            model.Update();

            // 処理結果設定
            this.DialogResult = DialogResult.OK;
        }
    }
}
