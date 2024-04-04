using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelHw.DB
{
    enum Status
    {
        Reserved,
        Free,
        Close,
        InProcess
    }

    internal class Guests
    {
        public int ID { get; set; }

        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public Status Status { get; set; }

        [ForeignKey("GuestDetails")]
        public int GuestDetailsID { get; set; }
        public GuestDetails GuestDetails { get; set; }
        public Guests() { }

        public Guests(DateTime checkInDate, DateTime checkOutDate, Status status, int guestDetailsID)
        {
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Status = status;
            GuestDetailsID = guestDetailsID;
        }
    }
}
