using L3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L3.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}