using WebApiProject.AppDbContext;

namespace WebApiProject.Repository
{
    public class BookingsRepository : IBookingsRepository
    {
        private readonly AppsDbContext _appsDbContext;

        public BookingsRepository(AppsDbContext appsDbContext)
        {
            _appsDbContext = appsDbContext;
        }


        public List<Bookings> GetAllBookings()
        {
            return _appsDbContext.Bookings.ToList();
        }

        public void AddBooking(Bookings booking)
        {
            _appsDbContext.Bookings.Add(booking);
            _appsDbContext.SaveChanges();
           
        }


        public Bookings GetBookingById(int bookingId)
        {
            return _appsDbContext.Bookings.FirstOrDefault(b => b.BookingId == bookingId);
        }

        public void UpdateBooking(Bookings booking)
        {
            _appsDbContext.Bookings.Update(booking);
            _appsDbContext.SaveChanges();
        }


        public void DeleteBooking(int bookingId)
        {
            var booking = GetBookingById(bookingId);
            if (booking != null)
            {
                _appsDbContext.Bookings.Remove(booking);
                _appsDbContext.SaveChanges();
            }
        }

       
    }
}
