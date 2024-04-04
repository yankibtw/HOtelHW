namespace HotelHw.Forms
{
    partial class CurrentUser
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.paidDaysLabel = new System.Windows.Forms.Label();
            this.withPetsCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(162, 62);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(299, 43);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Карточка гостя";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.Location = new System.Drawing.Point(77, 172);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(71, 37);
            this.fullNameLabel.TabIndex = 1;
            this.fullNameLabel.Text = "ФИО";
            this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthLabel.Location = new System.Drawing.Point(77, 255);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(287, 37);
            this.birthLabel.TabIndex = 2;
            this.birthLabel.Text = "День рождения: ";
            this.birthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paymentTypeLabel.Location = new System.Drawing.Point(77, 339);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(143, 37);
            this.paymentTypeLabel.TabIndex = 3;
            this.paymentTypeLabel.Text = "Оплата:";
            this.paymentTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paidDaysLabel
            // 
            this.paidDaysLabel.AutoSize = true;
            this.paidDaysLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paidDaysLabel.Location = new System.Drawing.Point(77, 420);
            this.paidDaysLabel.Name = "paidDaysLabel";
            this.paidDaysLabel.Size = new System.Drawing.Size(305, 37);
            this.paidDaysLabel.TabIndex = 4;
            this.paidDaysLabel.Text = "Количество дней:";
            this.paidDaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // withPetsCheckBox
            // 
            this.withPetsCheckBox.AutoSize = true;
            this.withPetsCheckBox.Enabled = false;
            this.withPetsCheckBox.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.withPetsCheckBox.Location = new System.Drawing.Point(83, 514);
            this.withPetsCheckBox.Name = "withPetsCheckBox";
            this.withPetsCheckBox.Size = new System.Drawing.Size(378, 36);
            this.withPetsCheckBox.TabIndex = 5;
            this.withPetsCheckBox.Text = "Путешествую с животными";
            this.withPetsCheckBox.UseVisualStyleBackColor = true;
            // 
            // CurrentUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 731);
            this.Controls.Add(this.withPetsCheckBox);
            this.Controls.Add(this.paidDaysLabel);
            this.Controls.Add(this.paymentTypeLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.headerLabel);
            this.MaximumSize = new System.Drawing.Size(658, 770);
            this.Name = "CurrentUser";
            this.Text = "CurrentUser";
            this.Load += new System.EventHandler(this.CurrentUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.Label paidDaysLabel;
        private System.Windows.Forms.CheckBox withPetsCheckBox;
    }
}