namespace MRRS.View
{
    partial class MenuForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.locationButton = new System.Windows.Forms.Button();
            this.meetingRoomButton = new System.Windows.Forms.Button();
            this.reservationButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // locationButton
            // 
            this.locationButton.Location = new System.Drawing.Point(90, 12);
            this.locationButton.Name = "locationButton";
            this.locationButton.Size = new System.Drawing.Size(100, 40);
            this.locationButton.TabIndex = 0;
            this.locationButton.Text = "場所管理";
            this.locationButton.UseVisualStyleBackColor = true;
            // 
            // meetingRoomButton
            // 
            this.meetingRoomButton.Location = new System.Drawing.Point(90, 58);
            this.meetingRoomButton.Name = "meetingRoomButton";
            this.meetingRoomButton.Size = new System.Drawing.Size(100, 40);
            this.meetingRoomButton.TabIndex = 0;
            this.meetingRoomButton.Text = "会議室管理";
            this.meetingRoomButton.UseVisualStyleBackColor = true;
            this.meetingRoomButton.Click += new System.EventHandler(this.meetingRoomButton_Click);
            // 
            // reservationButton
            // 
            this.reservationButton.Location = new System.Drawing.Point(90, 104);
            this.reservationButton.Name = "reservationButton";
            this.reservationButton.Size = new System.Drawing.Size(100, 40);
            this.reservationButton.TabIndex = 0;
            this.reservationButton.Text = "予約管理";
            this.reservationButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(90, 169);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 40);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "終了";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 221);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.reservationButton);
            this.Controls.Add(this.meetingRoomButton);
            this.Controls.Add(this.locationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.Text = "会議室予約システム";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button locationButton;
        private System.Windows.Forms.Button meetingRoomButton;
        private System.Windows.Forms.Button reservationButton;
        private System.Windows.Forms.Button closeButton;
    }
}

