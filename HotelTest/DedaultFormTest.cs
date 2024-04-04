using HotelHw.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace HotelHw.Test
{
    [TestClass]
    public class DefaultFormTests
    {
        [TestMethod]
        public void TestDefaultFormInitialization()
        {
            HotelForm form = new HotelForm();
            Assert.IsNotNull(form);
        }

        [TestMethod]
        public void TestProgressLabelClick()
        {
            // Arrange
            HotelForm form = new HotelForm();
            var progressLabel = new Label();
            var progressRadioBtn = new RadioButton();
            var listGuestsLabel = new Label();

            // Act 
            form.progressLabel_Click(progressLabel, EventArgs.Empty);

            // Assert
            Assert.IsTrue(progressRadioBtn.Checked);
            Assert.AreEqual("Список освобождающихся номеров", listGuestsLabel.Text);
        }

        [TestMethod]
        public void TestReservedRadioBtnCheckedChanged()
        {
            // Arrange
            HotelForm form = new HotelForm();
            var reservedRaioBtn = new RadioButton();
            var childForm = new ReservedForm();

            // Act 
            reservedRaioBtn.Checked = true;
            form.reservedRaioBtn_CheckedChanged(reservedRaioBtn, EventArgs.Empty);

            // Assert 
            Assert.IsTrue(childForm.Visible);
        }

        [TestMethod]
        public void TestOpenChildForm()
        {
            // Arrange
            HotelForm form = new HotelForm();
            var childForm = new Form();

            // Act 
            form.OpenChildForm(childForm);

            // Assert 
            Assert.AreEqual(childForm, form.mainUsersPanel.Controls[0]);
            Assert.AreEqual(childForm, form.mainUsersPanel.Tag);
            Assert.IsTrue(childForm.Visible);
        }

        [TestMethod]
        public void TestCheckMoreInfoBtnClick()
        {
            // Arrange
            DefaultForm form = new DefaultForm();
            var userNumberLabel = new Label();
            userNumberLabel.Text = "User ID: 123";
            var user = new CurrentUser(123);

            // Act
            form.CheckMoreInfoBtn_Click(null, EventArgs.Empty);

            // Assert
            Assert.AreEqual(123, user.UserID);
            Assert.IsTrue(user.Visible);
        }
    }
}
