using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

[Table(Name = "Courses")] // Define the attribute
public partial class Course
{
    [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "course_id")]
    public int CourseId { get; set; }

    [Column(Name = "course_num")]
    public int CourseNum { get; set; }

    [Column(Name = "course_title")]
    public string CourseTitle { get; set; }

    [Column(Name = "instructor")]
    public string Instructor { get; set; }

    [Column(Name = "cap")]
    public int Cap { get; set; }
}