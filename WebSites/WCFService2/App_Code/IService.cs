﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IService
{
	[OperationContract]
	List<Course> getAllCourses();

    [OperationContract]
    List<Instructor> saveIntructors();

    [OperationContract]
    List<Course> getCourses300AndAbove();
}

