using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class CoursesController : BaseApiController
    {
        private readonly DataContext _context;
        public CoursesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Course>>> GetCourses() {
            return await _context.Courses.ToListAsync();
        }

        [HttpGet("{id}")] //courses/id

        public async Task<ActionResult<Course>> GetCourse(Guid id) {
            return await _context.Courses.FindAsync(id);
        }
    }
}