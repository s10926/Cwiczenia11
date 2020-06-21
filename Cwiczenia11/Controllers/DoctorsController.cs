using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia11.DTOs.Requests;
using Cwiczenia11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly DoctorsDbContext _db;

        public DoctorsController(DoctorsDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult getDoctors()
        {
            return Ok(_db.Doctors.ToList());
        }

        [HttpPost]
        public IActionResult addDoctor(CreateDoctorDtoRequest doctor)
        {
            if (string.IsNullOrEmpty(doctor.FirstName) || string.IsNullOrEmpty(doctor.LastName) || string.IsNullOrEmpty(doctor.Email))
            {
                return BadRequest("Jedna z przekazanych wartości jest pusta.");
            }

            Doctor d = new Doctor
            {
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Email = doctor.Email
            };

            _db.Add(d);
            _db.SaveChanges();

            return Ok(d);
        }

        [HttpPut("{id}")]
        public IActionResult updateDoctor(int id, CreateDoctorDtoRequest doctor)
        {
            if (!_db.Doctors.Any(d => d.IdDoctor == id))
            {
                return NotFound("Doktor o podanym numerze id nie istnieje.");
            }

            if (string.IsNullOrEmpty(doctor.FirstName) || string.IsNullOrEmpty(doctor.LastName) || string.IsNullOrEmpty(doctor.Email))
            {
                return BadRequest("Jedna z przekazanych wartości jest pusta.");
            }

            Doctor d = new Doctor
            {
                IdDoctor = id,
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Email = doctor.Email
            };

            _db.Attach(d);
            _db.Entry(d).Property("FirstName").IsModified = true;
            _db.Entry(d).Property("LastName").IsModified = true;
            _db.Entry(d).Property("Email").IsModified = true;
            _db.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult removeDoctor(int id)
        {
            if (!_db.Doctors.Any(d => d.IdDoctor == id))
            {
                return NotFound("Doktor o podanym numerze id nie istnieje.");
            }

            var doctor = new Doctor
            {
                IdDoctor = id
            };

            _db.Attach(doctor);
            _db.Remove(doctor);
            _db.SaveChanges();

            return Ok();
        }
    }
}
