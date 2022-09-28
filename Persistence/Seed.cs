using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Courses.Any()) return;
            
            var activities = new List<Course>
            {
                new Course
                {
                    Title = "Ultimate Mountain Climbing",
                    Date = DateTime.Now.AddMonths(-2),
                    Creator = "Chris Og",
                    Description = "This course will teach you all you need to know about mountain climbing.",
                    Category = "Personal Development"
                },
                new Course
                {
                    Title = "Photoshop: Zero to Hero",
                    Date = DateTime.Now.AddMonths(-5),
                    Creator = "Mark Brown",
                    Description = "This course will teach you all about the amazing photo and video editor Photoshop.",
                    Category = "Photography and Video"
                },
                new Course
                {
                    Title = "Python: Beginner to Ninja",
                    Date = DateTime.Now.AddMonths(-3),
                    Creator = "Web Ninja",
                    Description = "The python course will make you a PYTHON NINJA!",
                    Category = "Programming and Web Development"
                }
            };

            await context.Courses.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}