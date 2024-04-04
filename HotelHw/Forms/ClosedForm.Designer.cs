namespace HotelHw.Forms
{
    partial class ClosedForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkMoreInfoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.currentDateOutLabel = new System.Windows.Forms.Label();
            this.dateOutLabel = new System.Windows.Forms.Label();
            this.currentDateInLabel = new System.Windows.Forms.Label();
            this.dateInLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.currentStausLabel = new System.Windows.Forms.Label();
            this.userNumberLabel = new System.Windows.Forms.Label();
            this.userInfoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.userStatusLabel = new System.Windows.Forms.Label();
            this.userImageBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.hotelRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.userInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // checkMoreInfoBtn
            // 
            this.checkMoreInfoBtn.BorderRadius = 10;
            this.checkMoreInfoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checkMoreInfoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checkMoreInfoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkMoreInfoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checkMoreInfoBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkMoreInfoBtn.ForeColor = System.Drawing.Color.White;
            this.checkMoreInfoBtn.Location = new System.Drawing.Point(144, 743);
            this.checkMoreInfoBtn.Name = "checkMoreInfoBtn";
            this.checkMoreInfoBtn.Size = new System.Drawing.Size(221, 59);
            this.checkMoreInfoBtn.TabIndex = 9;
            this.checkMoreInfoBtn.Text = "Просмотр карточки";
            this.checkMoreInfoBtn.Click += new System.EventHandler(this.CheckMoreInfoBtn_Click);
            // 
            // currentDateOutLabel
            // 
            this.currentDateOutLabel.AutoSize = true;
            this.currentDateOutLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentDateOutLabel.Location = new System.Drawing.Point(260, 629);
            this.currentDateOutLabel.Name = "currentDateOutLabel";
            this.currentDateOutLabel.Size = new System.Drawing.Size(90, 28);
            this.currentDateOutLabel.TabIndex = 8;
            this.currentDateOutLabel.Text = "Статус";
            // 
            // dateOutLabel
            // 
            this.dateOutLabel.AutoSize = true;
            this.dateOutLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOutLabel.Location = new System.Drawing.Point(51, 629);
            this.dateOutLabel.Name = "dateOutLabel";
            this.dateOutLabel.Size = new System.Drawing.Size(168, 28);
            this.dateOutLabel.TabIndex = 7;
            this.dateOutLabel.Text = "Дата выезда:";
            // 
            // currentDateInLabel
            // 
            this.currentDateInLabel.AutoSize = true;
            this.currentDateInLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentDateInLabel.Location = new System.Drawing.Point(260, 559);
            this.currentDateInLabel.Name = "currentDateInLabel";
            this.currentDateInLabel.Size = new System.Drawing.Size(90, 28);
            this.currentDateInLabel.TabIndex = 6;
            this.currentDateInLabel.Text = "Статус";
            // 
            // dateInLabel
            // 
            this.dateInLabel.AutoSize = true;
            this.dateInLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateInLabel.Location = new System.Drawing.Point(51, 559);
            this.dateInLabel.Name = "dateInLabel";
            this.dateInLabel.Size = new System.Drawing.Size(168, 28);
            this.dateInLabel.TabIndex = 5;
            this.dateInLabel.Text = "Дата заезда:";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.Location = new System.Drawing.Point(192, 489);
            this.fullNameLabel.MaximumSize = new System.Drawing.Size(420, 0);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(51, 28);
            this.fullNameLabel.TabIndex = 4;
            this.fullNameLabel.Text = "ФИО";
            this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentStausLabel
            // 
            this.currentStausLabel.AutoSize = true;
            this.currentStausLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentStausLabel.Location = new System.Drawing.Point(192, 419);
            this.currentStausLabel.Name = "currentStausLabel";
            this.currentStausLabel.Size = new System.Drawing.Size(90, 28);
            this.currentStausLabel.TabIndex = 3;
            this.currentStausLabel.Text = "Статус";
            // 
            // userNumberLabel
            // 
            this.userNumberLabel.AutoSize = true;
            this.userNumberLabel.Font = new System.Drawing.Font("Consolas", 30F);
            this.userNumberLabel.Location = new System.Drawing.Point(48, 35);
            this.userNumberLabel.Name = "userNumberLabel";
            this.userNumberLabel.Size = new System.Drawing.Size(152, 47);
            this.userNumberLabel.TabIndex = 1;
            this.userNumberLabel.Text = "Номер ";
            // 
            // userInfoPanel
            // 
            this.userInfoPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.userInfoPanel.BorderRadius = 5;
            this.userInfoPanel.BorderThickness = 1;
            this.userInfoPanel.Controls.Add(this.checkMoreInfoBtn);
            this.userInfoPanel.Controls.Add(this.currentDateOutLabel);
            this.userInfoPanel.Controls.Add(this.dateOutLabel);
            this.userInfoPanel.Controls.Add(this.currentDateInLabel);
            this.userInfoPanel.Controls.Add(this.dateInLabel);
            this.userInfoPanel.Controls.Add(this.fullNameLabel);
            this.userInfoPanel.Controls.Add(this.currentStausLabel);
            this.userInfoPanel.Controls.Add(this.userStatusLabel);
            this.userInfoPanel.Controls.Add(this.userNumberLabel);
            this.userInfoPanel.Controls.Add(this.userImageBox);
            this.userInfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.userInfoPanel.Location = new System.Drawing.Point(1363, 42);
            this.userInfoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.userInfoPanel.Name = "userInfoPanel";
            this.userInfoPanel.Size = new System.Drawing.Size(480, 966);
            this.userInfoPanel.TabIndex = 7;
            this.userInfoPanel.Visible = false;
            // 
            // userStatusLabel
            // 
            this.userStatusLabel.AutoSize = true;
            this.userStatusLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userStatusLabel.Location = new System.Drawing.Point(51, 419);
            this.userStatusLabel.Name = "userStatusLabel";
            this.userStatusLabel.Size = new System.Drawing.Size(103, 28);
            this.userStatusLabel.TabIndex = 2;
            this.userStatusLabel.Text = "Статус:";
            // 
            // userImageBox
            // 
            this.userImageBox.BackColor = System.Drawing.Color.Transparent;
            this.userImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userImageBox.FillColor = System.Drawing.Color.Transparent;
            this.userImageBox.ImageRotate = 0F;
            this.userImageBox.Location = new System.Drawing.Point(115, 122);
            this.userImageBox.Margin = new System.Windows.Forms.Padding(0);
            this.userImageBox.Name = "userImageBox";
            this.userImageBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userImageBox.Size = new System.Drawing.Size(250, 250);
            this.userImageBox.TabIndex = 0;
            this.userImageBox.TabStop = false;
            // 
            // hotelRoom
            // 
            this.hotelRoom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hotelRoom.HeaderText = "Номер отеля";
            this.hotelRoom.Name = "hotelRoom";
            this.hotelRoom.ReadOnly = true;
            // 
            // DateOut
            // 
            this.DateOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateOut.HeaderText = "Дата выезда";
            this.DateOut.Name = "DateOut";
            this.DateOut.ReadOnly = true;
            // 
            // DateIn
            // 
            this.DateIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateIn.HeaderText = "Дата заезда";
            this.DateIn.Name = "DateIn";
            this.DateIn.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.HeaderText = "Имя";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // userLastName
            // 
            this.userLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userLastName.HeaderText = "Фамилия";
            this.userLastName.Name = "userLastName";
            this.userLastName.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // mainGridView
            // 
            this.mainGridView.AllowUserToAddRows = false;
            this.mainGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.mainGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.mainGridView.ColumnHeadersHeight = 50;
            this.mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.mainGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.userLastName,
            this.Username,
            this.DateIn,
            this.DateOut,
            this.hotelRoom});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.mainGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.mainGridView.Location = new System.Drawing.Point(39, 42);
            this.mainGridView.MinimumSize = new System.Drawing.Size(0, 966);
            this.mainGridView.Name = "mainGridView";
            this.mainGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mainGridView.RowHeadersVisible = false;
            this.mainGridView.RowHeadersWidth = 50;
            this.mainGridView.RowTemplate.Height = 50;
            this.mainGridView.Size = new System.Drawing.Size(1804, 966);
            this.mainGridView.TabIndex = 6;
            this.mainGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.mainGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.mainGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.mainGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.mainGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.mainGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.mainGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.mainGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.mainGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.mainGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.mainGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.mainGridView.ThemeStyle.HeaderStyle.Height = 50;
            this.mainGridView.ThemeStyle.ReadOnly = true;
            this.mainGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.mainGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.mainGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.mainGridView.ThemeStyle.RowsStyle.Height = 50;
            this.mainGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.mainGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.mainGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainGridView_CellDoubleClick);
            // 
            // ClosedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.userInfoPanel);
            this.Controls.Add(this.mainGridView);
            this.Name = "ClosedForm";
            this.Padding = new System.Windows.Forms.Padding(39, 42, 61, 33);
            this.Text = "ClosedForm";
            this.Load += new System.EventHandler(this.ClosedForm_Load);
            this.userInfoPanel.ResumeLayout(false);
            this.userInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button checkMoreInfoBtn;
        private System.Windows.Forms.Label currentDateOutLabel;
        private System.Windows.Forms.Label dateOutLabel;
        private System.Windows.Forms.Label currentDateInLabel;
        private System.Windows.Forms.Label dateInLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label currentStausLabel;
        private System.Windows.Forms.Label userNumberLabel;
        private Guna.UI2.WinForms.Guna2Panel userInfoPanel;
        private System.Windows.Forms.Label userStatusLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userImageBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private Guna.UI2.WinForms.Guna2DataGridView mainGridView;
    }
}