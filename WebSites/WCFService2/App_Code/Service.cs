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
    public List<string> getAllCourses()
	{
        CustomDatabase db = new CustomDatabase();

        IEnumerable<Course> queryResult =
            from c in db.Courses
            where c.CourseNum > 0
     
            select c;
        return new List<string>{queryResult.ToList<Course>().ToString()};
	}
}
