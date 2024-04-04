namespace HotelHw
{
    partial class HotelForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainDateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.searchImageButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.statusPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.freeLabel = new System.Windows.Forms.Label();
            this.freeRadioBtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.closedLabel = new System.Windows.Forms.Label();
            this.closedRadioBtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.progressLabel = new System.Windows.Forms.Label();
            this.progressRadioBtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.reservedLabel = new System.Windows.Forms.Label();
            this.reservedRaioBtn = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.statusLabel = new System.Windows.Forms.Label();
            this.listOfGuestsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.mainUsersPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.listGuestsLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.headerPanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.listOfGuestsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDateTime
            // 
            this.mainDateTime.BackColor = System.Drawing.SystemColors.Control;
            this.mainDateTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.mainDateTime.BorderRadius = 10;
            this.mainDateTime.BorderThickness = 1;
            this.mainDateTime.Checked = true;
            this.mainDateTime.Enabled = false;
            this.mainDateTime.FillColor = System.Drawing.Color.White;
            this.mainDateTime.FocusedColor = System.Drawing.Color.White;
            this.mainDateTime.Font = new System.Drawing.Font("Consolas", 18F);
            this.mainDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.mainDateTime.Location = new System.Drawing.Point(298, 39);
            this.mainDateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.mainDateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.mainDateTime.Name = "mainDateTime";
            this.mainDateTime.Size = new System.Drawing.Size(338, 70);
            this.mainDateTime.TabIndex = 0;
            this.mainDateTime.Value = new System.DateTime(2024, 3, 25, 21, 6, 37, 0);
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.searchImageButton);
            this.headerPanel.Controls.Add(this.searchTextBox);
            this.headerPanel.Controls.Add(this.mainDateTime);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1907, 147);
            this.headerPanel.TabIndex = 1;
            // 
            // searchImageButton
            // 
            this.searchImageButton.BackColor = System.Drawing.Color.White;
            this.searchImageButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.searchImageButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.searchImageButton.Image = global::HotelHw.Properties.Resources.searchIcon;
            this.searchImageButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.searchImageButton.ImageRotate = 0F;
            this.searchImageButton.Location = new System.Drawing.Point(1799, 47);
            this.searchImageButton.Name = "searchImageButton";
            this.searchImageButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.searchImageButton.Size = new System.Drawing.Size(58, 54);
            this.searchImageButton.TabIndex = 3;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderRadius = 10;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.DefaultText = "";
            this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.Location = new System.Drawing.Point(719, 39);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchTextBox.MaximumSize = new System.Drawing.Size(1162, 70);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PlaceholderText = "Поиск";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(1162, 70);
            this.searchTextBox.TabIndex = 1;
            // 
            // statusPanel
            // 
            this.statusPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.statusPanel.BorderRadius = 10;
            this.statusPanel.BorderThickness = 1;
            this.statusPanel.Controls.Add(this.freeLabel);
            this.statusPanel.Controls.Add(this.freeRadioBtn);
            this.statusPanel.Controls.Add(this.closedLabel);
            this.statusPanel.Controls.Add(this.closedRadioBtn);
            this.statusPanel.Controls.Add(this.progressLabel);
            this.statusPanel.Controls.Add(this.progressRadioBtn);
            this.statusPanel.Controls.Add(this.reservedLabel);
            this.statusPanel.Controls.Add(this.reservedRaioBtn);
            this.statusPanel.Controls.Add(this.statusLabel);
            this.statusPanel.Location = new System.Drawing.Point(32, 169);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(281, 834);
            this.statusPanel.TabIndex = 2;
            // 
            // freeLabel
            // 
            this.freeLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.freeLabel.AutoSize = true;
            this.freeLabel.Font = new System.Drawing.Font("Consolas", 16F);
            this.freeLabel.Location = new System.Drawing.Point(43, 162);
            this.freeLabel.Name = "freeLabel";
            this.freeLabel.Size = new System.Drawing.Size(108, 26);
            this.freeLabel.TabIndex = 8;
            this.freeLabel.Text = "Свободно";
            this.freeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.freeLabel.Click += new System.EventHandler(this.freeLabel_Click);
            // 
            // freeRadioBtn
            // 
            this.freeRadioBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.freeRadioBtn.CheckedState.BorderThickness = 0;
            this.freeRadioBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.freeRadioBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.freeRadioBtn.Location = new System.Drawing.Point(13, 162);
            this.freeRadioBtn.Name = "freeRadioBtn";
            this.freeRadioBtn.Size = new System.Drawing.Size(23, 23);
            this.freeRadioBtn.TabIndex = 7;
            this.freeRadioBtn.Text = "freeLabel";
            this.freeRadioBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.freeRadioBtn.UncheckedState.BorderThickness = 2;
            this.freeRadioBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.freeRadioBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.freeRadioBtn.CheckedChanged += new System.EventHandler(this.freeRadioBtn_CheckedChanged);
            // 
            // closedLabel
            // 
            this.closedLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.closedLabel.AutoSize = true;
            this.closedLabel.Font = new System.Drawing.Font("Consolas", 16F);
            this.closedLabel.Location = new System.Drawing.Point(43, 211);
            this.closedLabel.Name = "closedLabel";
            this.closedLabel.Size = new System.Drawing.Size(84, 26);
            this.closedLabel.TabIndex = 6;
            this.closedLabel.Text = "Заняты";
            this.closedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closedLabel.Click += new System.EventHandler(this.closedLabel_Click);
            // 
            // closedRadioBtn
            // 
            this.closedRadioBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.closedRadioBtn.CheckedState.BorderThickness = 0;
            this.closedRadioBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.closedRadioBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.closedRadioBtn.Location = new System.Drawing.Point(13, 211);
            this.closedRadioBtn.Name = "closedRadioBtn";
            this.closedRadioBtn.Size = new System.Drawing.Size(23, 23);
            this.closedRadioBtn.TabIndex = 5;
            this.closedRadioBtn.Text = "closedLabel";
            this.closedRadioBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.closedRadioBtn.UncheckedState.BorderThickness = 2;
            this.closedRadioBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.closedRadioBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.closedRadioBtn.CheckedChanged += new System.EventHandler(this.closedRadioBtn_CheckedChanged);
            // 
            // progressLabel
            // 
            this.progressLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Consolas", 16F);
            this.progressLabel.Location = new System.Drawing.Point(43, 260);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(156, 26);
            this.progressLabel.TabIndex = 4;
            this.progressLabel.Text = "Выписываются";
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressLabel.Click += new System.EventHandler(this.progressLabel_Click);
            // 
            // progressRadioBtn
            // 
            this.progressRadioBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.progressRadioBtn.CheckedState.BorderThickness = 0;
            this.progressRadioBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.progressRadioBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.progressRadioBtn.Location = new System.Drawing.Point(13, 260);
            this.progressRadioBtn.Name = "progressRadioBtn";
            this.progressRadioBtn.Size = new System.Drawing.Size(23, 23);
            this.progressRadioBtn.TabIndex = 3;
            this.progressRadioBtn.Text = "progressLabel";
            this.progressRadioBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.progressRadioBtn.UncheckedState.BorderThickness = 2;
            this.progressRadioBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.progressRadioBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.progressRadioBtn.CheckedChanged += new System.EventHandler(this.progressRadioBtn_CheckedChanged);
            // 
            // reservedLabel
            // 
            this.reservedLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.reservedLabel.AutoSize = true;
            this.reservedLabel.Font = new System.Drawing.Font("Consolas", 16F);
            this.reservedLabel.Location = new System.Drawing.Point(43, 112);
            this.reservedLabel.Name = "reservedLabel";
            this.reservedLabel.Size = new System.Drawing.Size(192, 26);
            this.reservedLabel.TabIndex = 2;
            this.reservedLabel.Text = "Зарезервировано";
            this.reservedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reservedLabel.Click += new System.EventHandler(this.reservedLabel_Click);
            // 
            // reservedRaioBtn
            // 
            this.reservedRaioBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reservedRaioBtn.CheckedState.BorderThickness = 0;
            this.reservedRaioBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reservedRaioBtn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.reservedRaioBtn.Location = new System.Drawing.Point(13, 113);
            this.reservedRaioBtn.Name = "reservedRaioBtn";
            this.reservedRaioBtn.Size = new System.Drawing.Size(23, 23);
            this.reservedRaioBtn.TabIndex = 1;
            this.reservedRaioBtn.Text = "reservedLabel";
            this.reservedRaioBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.reservedRaioBtn.UncheckedState.BorderThickness = 2;
            this.reservedRaioBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.reservedRaioBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.reservedRaioBtn.CheckedChanged += new System.EventHandler(this.reservedRaioBtn_CheckedChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Consolas", 30F);
            this.statusLabel.Location = new System.Drawing.Point(64, 20);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(152, 47);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Статус";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listOfGuestsPanel
            // 
            this.listOfGuestsPanel.AutoScroll = true;
            this.listOfGuestsPanel.AutoSize = true;
            this.listOfGuestsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.listOfGuestsPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.listOfGuestsPanel.BorderRadius = 10;
            this.listOfGuestsPanel.BorderThickness = 1;
            this.listOfGuestsPanel.Controls.Add(this.mainUsersPanel);
            this.listOfGuestsPanel.Controls.Add(this.listGuestsLabel);
            this.listOfGuestsPanel.Location = new System.Drawing.Point(373, 169);
            this.listOfGuestsPanel.MinimumSize = new System.Drawing.Size(0, 988);
            this.listOfGuestsPanel.Name = "listOfGuestsPanel";
            this.listOfGuestsPanel.Padding = new System.Windows.Forms.Padding(2);
            this.listOfGuestsPanel.Size = new System.Drawing.Size(1508, 1059);
            this.listOfGuestsPanel.TabIndex = 9;
            // 
            // mainUsersPanel
            // 
            this.mainUsersPanel.AutoScroll = true;
            this.mainUsersPanel.AutoSize = true;
            this.mainUsersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainUsersPanel.Location = new System.Drawing.Point(2, 69);
            this.mainUsersPanel.MinimumSize = new System.Drawing.Size(0, 988);
            this.mainUsersPanel.Name = "mainUsersPanel";
            this.mainUsersPanel.Size = new System.Drawing.Size(1504, 988);
            this.mainUsersPanel.TabIndex = 1;
            this.mainUsersPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainUsersPanel_Paint);
            // 
            // listGuestsLabel
            // 
            this.listGuestsLabel.AutoSize = true;
            this.listGuestsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.listGuestsLabel.Font = new System.Drawing.Font("Consolas", 30F);
            this.listGuestsLabel.Location = new System.Drawing.Point(2, 2);
            this.listGuestsLabel.Name = "listGuestsLabel";
            this.listGuestsLabel.Padding = new System.Windows.Forms.Padding(64, 20, 0, 0);
            this.listGuestsLabel.Size = new System.Drawing.Size(370, 67);
            this.listGuestsLabel.TabIndex = 0;
            this.listGuestsLabel.Text = "Список гостей";
            this.listGuestsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1041);
            this.Controls.Add(this.listOfGuestsPanel);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "HotelForm";
            this.Text = "Отель \"Название\"";
            this.headerPanel.ResumeLayout(false);
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.listOfGuestsPanel.ResumeLayout(false);
            this.listOfGuestsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker mainDateTime;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2ImageButton searchImageButton;
        private Guna.UI2.WinForms.Guna2Panel statusPanel;
        private System.Windows.Forms.Label statusLabel;
        private Guna.UI2.WinForms.Guna2CustomRadioButton reservedRaioBtn;
        private System.Windows.Forms.Label reservedLabel;
        private System.Windows.Forms.Label freeLabel;
        private Guna.UI2.WinForms.Guna2CustomRadioButton freeRadioBtn;
        private System.Windows.Forms.Label closedLabel;
        private Guna.UI2.WinForms.Guna2CustomRadioButton closedRadioBtn;
        private System.Windows.Forms.Label progressLabel;
        private Guna.UI2.WinForms.Guna2CustomRadioButton progressRadioBtn;
        private Guna.UI2.WinForms.Guna2Panel listOfGuestsPanel;
        private System.Windows.Forms.Label listGuestsLabel;
        private System.Windows.Forms.Timer timer1;
        public Guna.UI2.WinForms.Guna2Panel mainUsersPanel;
    }
}

