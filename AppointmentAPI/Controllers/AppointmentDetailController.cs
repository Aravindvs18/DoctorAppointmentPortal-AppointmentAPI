using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppointmentAPI.Models;

namespace AppointmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentDetailController : ControllerBase
    {
        private readonly AppointmentDetailContext _context;

        public AppointmentDetailController(AppointmentDetailContext context)
        {
            _context = context;
        }

        // GET: api/AppointmentDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppointmentDetail>>> GetAppointmentDetails()
        {
            return await _context.AppointmentDetails.ToListAsync();
        }

        // GET: api/AppointmentDetail/5
        [HttpGet("{id}")]
        public IEnumerable<AppointmentDetail> GetAppointmentDetail([FromRoute]string id)
        {
        

            var appointmentDetail = _context.AppointmentDetails.Where(m=> m.UserId == id);

           /* if (appointmentDetail == null)
            {

                return BadRequest(appointmentDetail);
                    }*/

            return appointmentDetail;
        }

        // PUT: api/AppointmentDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppointmentDetail(int id, AppointmentDetail appointmentDetail)
        {
            if (id != appointmentDetail.AppointmentId)
            {
                return BadRequest();
            }

            _context.Entry(appointmentDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppointmentDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AppointmentDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AppointmentDetail>> PostAppointmentDetail(AppointmentDetail appointmentDetail)
        {
            _context.AppointmentDetails.Add(appointmentDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppointmentDetail", new { id = appointmentDetail.AppointmentId }, appointmentDetail);
        }

        // DELETE: api/AppointmentDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppointmentDetail(int id)
        {
            var appointmentDetail = await _context.AppointmentDetails.FindAsync(id);
            if (appointmentDetail == null)
            {
                return NotFound();
            }

            _context.AppointmentDetails.Remove(appointmentDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppointmentDetailExists(int id)
        {
            return _context.AppointmentDetails.Any(e => e.AppointmentId == id);
        }
    }
}
