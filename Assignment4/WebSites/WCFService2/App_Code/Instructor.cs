using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Runtime.Serialization;

[Table(Name = "Instructors")] // Define the attribute
public class Instructor
{
    [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "instructor_id")]
    public int InstructorId { get; set; }

    [Column(Name = "first_name")]
    public string FirstName { get; set; }

    [Column(Name = "last_name")]
    public string LastName { get; set; }

    [Column(Name = "office_number")]
    public string OfficeNumber { get; set; }

    [Column(Name = "course_title")]
    public string CourseTitle { get; set; }
}
