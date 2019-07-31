using System;
namespace ContosoUniversity.Models
{
    public class Course
    {
        public int CourseId{get; set;}
        public string Title { get; set; }
        public string Credits { get; set; }

        public Course()
        {
        }
    }
}
