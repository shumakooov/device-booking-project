﻿using booking.DTO;
using booking.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace booking.Controllers
{
    [Route("api/department")]
    [ApiController]
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    [EnableCors("CorsPolicy")]
    public class DepartmentConroller : ControllerBase
    {
        private readonly DeviceBookingContext _context;

        public DepartmentConroller(DeviceBookingContext context)
        {
            _context = context;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<DepartmentDTO>>> GetTags()
        {
            var list = await _context.Departments.Select(d => new DepartmentDTO { Id = d.Id, Name = d.Name}).ToListAsync();

            if (list.Count == 0)
                return NotFound(new { error = true, message = "Departments are not found" });

            return Ok(list);
        }
    }
}
