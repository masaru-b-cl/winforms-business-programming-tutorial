namespace MRRS.View
{
    partial class MeetingRoomListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meetingRoomDataGridView = new System.Windows.Forms.DataGridView();
            this.locationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyDataGridViewButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteDataGridViewButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.meetingRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addNewButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingRoomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingRoomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(21, 26);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(29, 12);
            this.locationLabel.TabIndex = 0;
            this.locationLabel.Text = "場所";
            // 
            // locationComboBox
            // 
            this.locationComboBox.DataSource = this.locationBindingSource;
            this.locationComboBox.DisplayMember = "Name";
            this.locationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(56, 23);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(121, 20);
            this.locationComboBox.TabIndex = 0;
            this.locationComboBox.ValueMember = "Id";
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataSource = typeof(MRRS.Shared.Entities.Location);
            // 
            // meetingRoomDataGridView
            // 
            this.meetingRoomDataGridView.AllowUserToAddRows = false;
            this.meetingRoomDataGridView.AllowUserToDeleteRows = false;
            this.meetingRoomDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.meetingRoomDataGridView.AutoGenerateColumns = false;
            this.meetingRoomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meetingRoomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.modifyDataGridViewButtonColumn,
            this.deleteDataGridViewButtonColumn});
            this.meetingRoomDataGridView.DataSource = this.meetingRoomBindingSource;
            this.meetingRoomDataGridView.Location = new System.Drawing.Point(20, 70);
            this.meetingRoomDataGridView.Name = "meetingRoomDataGridView";
            this.meetingRoomDataGridView.ReadOnly = true;
            this.meetingRoomDataGridView.RowTemplate.Height = 21;
            this.meetingRoomDataGridView.Size = new System.Drawing.Size(460, 150);
            this.meetingRoomDataGridView.TabIndex = 2;
            this.meetingRoomDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.meetingRoomDataGridView_CellContentClick);
            // 
            // locationNameDataGridViewTextBoxColumn
            // 
            this.locationNameDataGridViewTextBoxColumn.DataPropertyName = "LocationName";
            this.locationNameDataGridViewTextBoxColumn.HeaderText = "場所";
            this.locationNameDataGridViewTextBoxColumn.Name = "locationNameDataGridViewTextBoxColumn";
            this.locationNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 180;
            // 
            // modifyDataGridViewButtonColumn
            // 
            this.modifyDataGridViewButtonColumn.HeaderText = "";
            this.modifyDataGridViewButtonColumn.Name = "modifyDataGridViewButtonColumn";
            this.modifyDataGridViewButtonColumn.ReadOnly = true;
            this.modifyDataGridViewButtonColumn.Text = "変更";
            this.modifyDataGridViewButtonColumn.UseColumnTextForButtonValue = true;
            this.modifyDataGridViewButtonColumn.Width = 60;
            // 
            // deleteDataGridViewButtonColumn
            // 
            this.deleteDataGridViewButtonColumn.HeaderText = "";
            this.deleteDataGridViewButtonColumn.Name = "deleteDataGridViewButtonColumn";
            this.deleteDataGridViewButtonColumn.ReadOnly = true;
            this.deleteDataGridViewButtonColumn.Text = "削除";
            this.deleteDataGridViewButtonColumn.UseColumnTextForButtonValue = true;
            this.deleteDataGridViewButtonColumn.Width = 60;
            // 
            // meetingRoomBindingSource
            // 
            this.meetingRoomBindingSource.DataSource = typeof(MRRS.Shared.Entities.MeetingRoom);
            // 
            // addNewButton
            // 
            this.addNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNewButton.Location = new System.Drawing.Point(20, 226);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(75, 23);
            this.addNewButton.TabIndex = 3;
            this.addNewButton.Text = "新規登録";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(405, 226);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(183, 21);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "検索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // MeetingRoomListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.meetingRoomDataGridView);
            this.Controls.Add(this.locationComboBox);
            this.Controls.Add(this.locationLabel);
            this.Name = "MeetingRoomListForm";
            this.Text = "会議室管理";
            this.Load += new System.EventHandler(this.MeetingRoomListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingRoomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingRoomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private System.Windows.Forms.DataGridView meetingRoomDataGridView;
        private System.Windows.Forms.BindingSource meetingRoomBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn modifyDataGridViewButtonColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteDataGridViewButtonColumn;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button searchButton;
    }
}