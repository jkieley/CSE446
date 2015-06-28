using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

[Table(Name = "Courses")] // Define the attribute
public class Course
{
    [Column(IsPrimaryKey = true, IsDbGenerated = true)]
    public int courseId { get; set; }

    [Column]
    public int CourseNum { get; set; }

    [Column]
    public string CourseTitle { get; set; }
    
    [Column]
    public string Instructor { get; set; }

    [Column]
    public int Cap { get; set; }
}