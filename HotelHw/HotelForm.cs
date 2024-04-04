using HotelHw.Forms;
using Serilog;
using System;
using System.Windows.Forms;

namespace HotelHw
{
    public partial class HotelForm : Form
    {
        private Form currentChildForm;
        public HotelForm()
        {
            InitializeComponent();
            timer1.Start();
            Log.Information("Запуск таймера");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            mainDateTime.Value = DateTime.Now;
        }
        private void reservedLabel_Click(object sender, EventArgs e)
        {
            reservedRaioBtn.Checked = true;
            listGuestsLabel.Text = "Список зарезервированных номеров";
        }

        private void freeLabel_Click(object sender, EventArgs e)
        {
            freeRadioBtn.Checked = true;
            listGuestsLabel.Text = "Список свободных номеров";
        }

        private void closedLabel_Click(object sender, EventArgs e)
        {
            closedRadioBtn.Checked = true;
            listGuestsLabel.Text = "Список занятых номеров";
        }

        public void progressLabel_Click(object sender, EventArgs e)
        {
                progressRadioBtn.Checked = true;
                listGuestsLabel.Text = "Список освобождающихся номеров";
        }

        public void reservedRaioBtn_CheckedChanged(object sender, EventArgs e)
        {
            Log.Information("Проверка reservedRaioBtn");
            if (reservedRaioBtn.Checked)
            {
                ReservedForm childForm = new ReservedForm();
                OpenChildForm(childForm);
            }
        }
        public void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainUsersPanel.Controls.Add(childForm);
            mainUsersPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void freeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            Log.Information("Проверка freeRadioBtn");
            if (freeRadioBtn.Checked)
            {
                FreeForm childForm = new FreeForm();
                OpenChildForm(childForm);
            }
        }

        private void closedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            Log.Information("Проверка closedRadioBtn");
                if (closedRadioBtn.Checked)
                {
                    ClosedForm childForm = new ClosedForm();
                    OpenChildForm(childForm);
                }

        }

        private void progressRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            Log.Information("Проверка progressRadioBtn");
            if (progressRadioBtn.Checked)
            {
                InProcessForm childForm = new InProcessForm();
                OpenChildForm(childForm);
            }
        }

        private void mainUsersPanel_Paint(object sender, PaintEventArgs e)
        {
            Log.Information("Загрузка mainUsersPanel");
            DefaultForm childForm = new DefaultForm();
            OpenChildForm(childForm);
        }
    }
}
