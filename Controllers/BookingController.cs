using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiProject.AppDbContext;
using WebApiProject.Model;
using WebApiProject.Repository;

namespace WebApiProject.Controllers
{
    

        [ApiController]
        [Route("api/[controller]")]
        public class BookingController : ControllerBase
        {
            private readonly IBookingsRepository _bookingRepository;
            readonly IMapper _mapper;
            public BookingController(IBookingsRepository bookingRepository, IMapper mapper)
            {
                _bookingRepository = bookingRepository;
                _mapper = mapper;
            }

            [HttpGet]
            public IActionResult GetAllBookings()
            {
                var bookings = _bookingRepository.GetAllBookings();
                return Ok(bookings);
            }

            [HttpGet("{id}")]
            public IActionResult GetBookingById(int id)
            {
                var booking = _bookingRepository.GetBookingById(id);
                /*if (booking == null)
                {
                    return NotFound();
                }*/

                var bookins = _mapper.Map<GetBookingDTO>(booking);
                return Ok(booking);
            }

            [HttpPost]
            public IActionResult CreateBooking(GetBookingDTO booking)
            {
                if (ModelState.IsValid)
                {
                    var addedBooking = _mapper.Map<Bookings>(booking);
                    _bookingRepository.AddBooking(addedBooking);
                    return CreatedAtAction(nameof(GetBookingById), new { id = booking.BookingId }, booking);
                }
                return BadRequest(ModelState);
            }

            [HttpPut("{id}")]
            public IActionResult UpdateBooking(int id, Bookings booking)
            {
                if (id != booking.BookingId)
                {
                    return BadRequest();
                }

                if (ModelState.IsValid)
                {
                    _bookingRepository.UpdateBooking(booking);
                    return NoContent();
                }
                return BadRequest(ModelState);
            }

            [HttpDelete("{id}")]
            public IActionResult DeleteBooking(int id)
            {
                _bookingRepository.DeleteBooking(id);
                return NoContent();
            }
        }

    
}
