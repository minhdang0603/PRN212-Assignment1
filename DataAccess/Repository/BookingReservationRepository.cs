using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookingReservationRepository : IBookingReservationRepository
    {
        public void AddBooking(BookingReservation bookingReservation) => BookingReservationDAO.Instance.Add(bookingReservation);

        public List<BookingReservation> GetAll() => BookingReservationDAO.Instance.GetBookingReservationsList().ToList();

        public BookingReservation GetByID(int id) => BookingReservationDAO.Instance.GetBookingReservationByID(id);

        public void RemoveBooking(BookingReservation bookingReservation) => BookingReservationDAO.Instance.Delete(bookingReservation);

        public void UpdateBooking(BookingReservation bookingReservation) => BookingReservationDAO.Instance.Update(bookingReservation);
    }
}
