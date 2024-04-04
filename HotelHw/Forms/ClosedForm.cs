using HotelHw.DB;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AppContext = HotelHw.DB.AppContext;

namespace HotelHw.Forms
{
    public partial class ClosedForm : Form
    {
        private bool isOpened = false;
        private int currentRowIndex = -1;

        public ClosedForm()
        {
            InitializeComponent();
        }

        private void ClosedForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            Log.Information("Загрузка Формы");
            using (var db = new AppContext())
            {
                Log.Information("Считывание БД");
                var guests = db.Guests.Include(g => g.GuestDetails).ToList();
                foreach (var g in guests)
                {
                    if (g.Status == Status.Close)
                    {
                        Log.Information("Заполнение mainGridView");
                        mainGridView.Rows.Add(
                            g.ID,
                            g.GuestDetails.FirstName,
                            g.GuestDetails.LastName,
                            g.CheckInDate.ToString().Split()[0],
                            g.CheckOutDate.ToString().Split()[0],
                            g.GuestDetails.UserHotelFlat
                        );
                    }
                }
            }
        }
        private void mainGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Log.Information("Открытие информации о пользователе");
            if (e.RowIndex != currentRowIndex)
            {
                if (!isOpened)
                {
                    isOpened = true;
                    currentRowIndex = e.RowIndex;
                    mainGridView.MaximumSize = new Size(mainGridView.Width - userInfoPanel.Width - 10, 0);
                    userInfoPanel.Visible = true;
                    currentStausLabel.Text = "Занял";
                    userNumberLabel.Text = "Номер " + mainGridView.CurrentRow.Cells[0].Value.ToString();
                    fullNameLabel.Text = mainGridView.CurrentRow.Cells[1].Value.ToString() + " " + mainGridView.CurrentRow.Cells[2].Value.ToString();
                    currentDateInLabel.Text = mainGridView.CurrentRow.Cells[3].Value.ToString();
                    currentDateOutLabel.Text = mainGridView.CurrentRow.Cells[4].Value.ToString();

                    Log.Information("Загрузка изображения");
                    using (var db = new AppContext())
                    {
                        byte[] imageData = db.GuestDetails.FirstOrDefault(u => u.GuestID == (int)mainGridView.CurrentRow.Cells[0].Value).ImageData;
                        if (imageData != null)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                userImageBox.BackgroundImage = Image.FromStream(ms);
                            }
                        }
                    }
                }
                else
                {
                    currentRowIndex = e.RowIndex;
                    userNumberLabel.Text = "Номер " + mainGridView.CurrentRow.Cells[0].Value.ToString();
                    currentStausLabel.Text = "Занял";
                    fullNameLabel.Text = mainGridView.CurrentRow.Cells[1].Value.ToString() + " " + mainGridView.CurrentRow.Cells[2].Value.ToString();
                    currentDateInLabel.Text = mainGridView.CurrentRow.Cells[3].Value.ToString();
                    currentDateOutLabel.Text = mainGridView.CurrentRow.Cells[4].Value.ToString();

                    Log.Information("Загрузка изображения");
                    using (var db = new AppContext())
                    {
                        byte[] imageData = db.GuestDetails.FirstOrDefault(u => u.GuestID == (int)mainGridView.CurrentRow.Cells[0].Value).ImageData;
                        if (imageData != null)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                userImageBox.BackgroundImage = Image.FromStream(ms);
                            }
                        }
                    }
                }
            }
            else
            {
                Log.Information("Закрытие панели с пользователем");
                isOpened = false;
                mainGridView.MaximumSize = new Size(mainGridView.Width + userInfoPanel.Width + 10, 0);
                userInfoPanel.Visible = false;
            }
        }

        private void CheckMoreInfoBtn_Click(object sender, EventArgs e)
        {
            Log.Information("Получение ID пользователя");
            CurrentUser user = new CurrentUser(int.Parse(userNumberLabel.Text.Split()[1]));
            Log.Information("Открытие подробной информации о пользователе");
            user.Show();
        }
    }
}
