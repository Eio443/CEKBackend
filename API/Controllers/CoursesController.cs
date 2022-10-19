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
            var result  = await _context.Courses.ToListAsync();
            return result;
        }

       //[HttpGet("{id}")] //courses/id

       [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourse(Guid id) {
            var result = await _context.Courses.FindAsync(id);
            return result;

        }
    }
}