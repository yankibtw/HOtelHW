using HotelHw.DB;
using Serilog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelHw.Forms
{
    public partial class FreeForm : Form
    {
        public FreeForm()
        {
            InitializeComponent();
        }

        private void FreeForm_Load(object sender, System.EventArgs e)
        {
            Log.Information("Загрузка формы");
            try
            {
                using (var db = new DB.AppContext())
                {
                    Log.Information("Загрузка свободных номеров");
                    var hotel = db.HotelsRoom;
                    foreach (var g in hotel)
                    {
                        if (g.UserID == null)
                        {
                            mainGridView.Rows.Add(
                                g.ID,
                                g.Room
                            );
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                while (ex != null)
                {
                    Log.Information("Ошибка" + ex.Message);
                    MessageBox.Show(ex.Message);
                    ex = ex.InnerException;
                }
            }
        }
    }
}
