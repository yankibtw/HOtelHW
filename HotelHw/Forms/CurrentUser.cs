using Serilog;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HotelHw.Forms
{
    public partial class CurrentUser : Form
    {
        public readonly int UserID;
        private int userID;
        public CurrentUser(int userID)
        {
            this.userID = userID;
            InitializeComponent();
        }

        private void CurrentUser_Load(object sender, EventArgs e)
        {
            var db = new DB.AppContext();
            Log.Information("Заполнение информации о пользователе");
            try
            {
                Log.Information("Получение ID пользователя");
                var result = db.GuestDetails.FirstOrDefault(entity => entity.GuestID == userID);

                if (result != null)
                {
                    fullNameLabel.Text = result.FirstName + " " + result.LastName + " " + result.Patronymic;
                    birthLabel.Text = "День рождения: " + result.DateOfBirth.ToString().Split()[0];
                    paymentTypeLabel.Text = "Оплата:" + result.PaymentMethod.ToString();
                    paidDaysLabel.Text = "Количество дней:" + result.PaidDays.ToString();
                    if (result.TravellingWithPets)
                    {
                        withPetsCheckBox.Checked = true;
                    }
                    else
                    {
                        withPetsCheckBox.Checked = false;
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Log.Information("Ошибка" + ex.Message);
                Console.WriteLine("Ошибка при выполнении запроса: " + ex.Message);
            }
        }
    }
}
