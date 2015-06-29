using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IService
{
    //Question 4
	[OperationContract]
	List<Course> getAllCourses();

    //Question 5 
    [OperationContract]
    List<Instructor> saveIntructors();

    // Question 6a
    [OperationContract]
    List<Course> getCourses300AndAbove();
}

