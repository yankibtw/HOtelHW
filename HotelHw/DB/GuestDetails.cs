using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelHw.DB
{
    enum PaymentMethod
    {
        CreditCard,
        EWallet,
        PaymentSystem,
        Check,
        Cash,
        Cryptocurrency
    }
    internal class GuestDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GuestID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int PaidDays { get; set; }
        public bool TravellingWithPets { get; set; }
        public byte[] ImageData { get; set; }
        public int UserHotelFlat { get; set; }

        [ForeignKey("GuestDetailsID")]
        public ICollection<Guests> Guests { get; set; }

        public GuestDetails() { }

        public GuestDetails(int guestID, string firstName, string lastName, string patronymic, DateTime dateOfBirth, PaymentMethod paymentMethod, int paidDays, bool travellingWithPets)
        {
            GuestID = guestID;
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;
            PaymentMethod = paymentMethod;
            PaidDays = paidDays;
            TravellingWithPets = travellingWithPets;
        }
    }
}
