using WebApiProject.AppDbContext;

namespace WebApiProject.Repository
{
    public interface IBookingsRepository
    {
        List<Bookings> GetAllBookings();
        void AddBooking(Bookings booking);
        Bookings GetBookingById(int bookingId);
        void UpdateBooking(Bookings booking);
        void DeleteBooking(int bookingId);


    }
}
