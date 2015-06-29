using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

public class Service : IService
{
    // Question 4
    public List<Course> getAllCourses()
	{
        CustomDatabase db = new CustomDatabase();

        IEnumerable<Course> queryResult =
            from c in db.Courses
            select c;
        return queryResult.ToList<Course>();
	}

    //Question 5
    public List<Instructor> saveIntructors() {
        using(CustomDatabase db = new CustomDatabase())
        {
            db.ExecuteCommand("DELETE FROM Instructors"); // Allows the method to be called multiple times without creating duplicate data
            List<Instructor> instructors = new List<Instructor>{
                new Instructor { FirstName = "Debra" , LastName = "Callis", OfficeNumber = "BYAC 001", CourseTitle = "Prin of Programming with Java" },
                new Instructor { FirstName = "Staff" , LastName = "Staff", OfficeNumber = "BYAC 002", CourseTitle = "Digital Design Fundamentals" },
                new Instructor { FirstName = "Farideh" , LastName = "Tadayon-Navabi", OfficeNumber = "BYAC 003", CourseTitle = "Programming for Computer Engr" },
                new Instructor { FirstName = "Violet" , LastName = "Syrotiuk", OfficeNumber = "BYAC 004", CourseTitle = "Data Structures and Algorithms" },
                new Instructor { FirstName = "Kasim" , LastName = "Candan", OfficeNumber = "BYAC 005", CourseTitle = "Multimedia Information Systems" },
                new Instructor { FirstName = "Kanika" , LastName = "Grover", OfficeNumber = "BYAC 006", CourseTitle = "Object-Oriented Program & Data" },
                new Instructor { FirstName = "Xuerong" , LastName = "Feng", OfficeNumber = "BYAC 007", CourseTitle = "Computer Literacy" },
                new Instructor { FirstName = "Yinong" , LastName = "Chen", OfficeNumber = "BYAC 008", CourseTitle = "Distributed Software Development" }
            };
            db.Instructors.InsertAllOnSubmit(instructors);
            db.SubmitChanges();

            IEnumerable<Instructor> queryResult = 
            from i in db.Instructors
            select i;
            return queryResult.ToList<Instructor>();
        }
    }
}
