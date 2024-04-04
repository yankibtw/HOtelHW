using HotelHw.DB;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AppContext = HotelHw.DB.AppContext;

namespace HotelHw.Forms
{
    public partial class ReservedForm : Form
    {
        private bool isOpened = false;
        private int currentRowIndex = -1;
        public ReservedForm()
        {
            InitializeComponent();
        }

        private void ReservedForm_Load(object sender, EventArgs e)
        {
            Log.Information("Загрузка формы");
            LoadData();
        }
        private void LoadData()
        {
            using (var db = new AppContext())
            {
                Log.Information("Запрос с бд");
                var guests = db.Guests.Include(g => g.GuestDetails).ToList();
                foreach (var g in guests)
                {
                    if (g.Status == Status.Reserved)
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
            if (e.RowIndex != currentRowIndex)
            {
                if (!isOpened)
                {
                    Log.Information("Открытие панели данных о пользователе");
                    isOpened = true;
                    currentRowIndex = e.RowIndex;
                    mainGridView.MaximumSize = new Size(mainGridView.Width - userInfoPanel.Width - 10, 0);
                    userInfoPanel.Visible = true;
                    currentStausLabel.Text = "Зарезервировано";
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
                    fullNameLabel.Text = mainGridView.CurrentRow.Cells[1].Value.ToString() + " " + mainGridView.CurrentRow.Cells[2].Value.ToString();
                    currentDateInLabel.Text = mainGridView.CurrentRow.Cells[3].Value.ToString();
                    currentDateOutLabel.Text = mainGridView.CurrentRow.Cells[4].Value.ToString();
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
                Log.Information("Скрытие панели данных о пользователе");
                isOpened = false;
                mainGridView.MaximumSize = new Size(mainGridView.Width + userInfoPanel.Width + 10, 0);
                userInfoPanel.Visible = false;
            }
        }

        private void CheckMoreInfoBtn_Click(object sender, EventArgs e)
        {
            Log.Information("Получение ID о пользователе");
            CurrentUser user = new CurrentUser(int.Parse(userNumberLabel.Text.Split()[1]));
            Log.Information("Открытие подробной информации");
            user.Show();
        }
    }
}
